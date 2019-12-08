using DarkDialog;
using BackupProgram.Backup;
using System;
using System.IO;
using System.Windows.Forms;

namespace BackupProgram
{
    public partial class FormMain : Form, ICommunication
    {
        protected BackupMain backup;
        /// <summary>
        /// place holder for editing templates to add a new template
        /// </summary>
        protected const string placeHolderNew = "*Add new*";

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMainLoad(object sender, EventArgs e)
        {
            backup = new BackupMain(this);
            // load settings:
            RefreshBackupList();
            txtDestinationPath.Text = CSettings.Default.DestinationPath ?? "";
            txtRestoreSource.Text = CSettings.Default.RestorePath ?? "";
            chbOnlyChanged.Checked = CSettings.Default.OnlyChanged;
            // select last used item
            if (cmbTemplatesStart.Items.Count - 1 >= CSettings.Default.LastUsedTemplate
                && CSettings.Default.LastUsedTemplate >= 0)
            {
                cmbTemplatesStart.SelectedIndex = CSettings.Default.LastUsedTemplate;
            }
        }

        /// <summary>
        /// if any processes are running ask if they should be cancelled
        /// </summary>
        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (backup.Backup.IsWorkerBusy())
            {
                if (DialogBoxDark.ShowDialog("Backup is still running, do you want to cancel it?",
                    "Cancel backup") != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
            if (backup.Restore.IsWorkerBusy())
            {
                if (DialogBoxDark.ShowDialog("Restoring is still running, do you want to cancel it?",
                    "Cancel restore") != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// on close: cancel running processes, save settings
        /// </summary>
        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            backup.Backup.CancelBackup();
            backup.Restore.CancelBackup();
            CSettings.Default.Save();
        }

        /// <summary>
        /// output height = 30% of window height
        /// </summary>
        private void OnFormResize(object sender, EventArgs e)
        {
            lbOutput.Height = (int)(Height * 0.3);
        }

        // functions that need to be inside the form class
        #region functions
        /// <summary>
        /// display templates from settings in both combo boxes, + add new in edit
        /// </summary>
        protected void RefreshBackupList()
        {
            if (CSettings.Default.SavedTemplates != null)
            {
                cmbTemplatesStart.Items.Clear();
                cmbTemplatesEdit.Items.Clear();

                // edit empty for creating new
                cmbTemplatesEdit.Items.Add(placeHolderNew);

                foreach (BackupTemplate selecttemplate in CSettings.Default.SavedTemplates)
                {
                    cmbTemplatesStart.Items.Add(selecttemplate.BackupName);
                    cmbTemplatesEdit.Items.Add(selecttemplate.BackupName);
                }
                DisplayDeleteButton();
            }
        }


        /// <summary>
        /// shows needed buttons in templates tab:
        /// edit/delete existing or create new
        /// </summary>
        protected void DisplayDeleteButton()
        {
            cmdEditDelete.Visible = !SelectedAddOrEdit();
        }

        /// <summary>
        /// decide what button will be displayed
        /// </summary>
        /// <returns> true = add new, false = edit existing</returns>
        protected bool SelectedAddOrEdit()
        {
            return (string.IsNullOrEmpty(cmbTemplatesEdit.Text) ||
                cmbTemplatesEdit.Text == placeHolderNew);
        }

        /// <summary>
        /// when the selected template to edit changes
        /// </summary>
        protected void OnEditChanged()
        {
            if (SelectedAddOrEdit())
            {
                // selected new = clear inputs
                txtEditName.Text = txtEditPathsExclude.Text = txtEditPaths.Text = 
                    txtTypeFilter.Text = lblLastUsed.Text = "";
                chbInvertType.Checked = false;
            }
            else
            {
                // selected existing = show values of this template
                BackupTemplate template = TemplateHandler.GetTemplateByName(cmbTemplatesEdit.Text);
                if (template == null)
                {
                    SendOutput("[Templates] Selected template doesn't exist", true);
                    return;
                }

                txtEditName.Text = template.BackupName;
                // append "," for adding new values
                txtEditPaths.Text = template.GetBackupPathsString() + ",";
                txtEditPathsExclude.Text = template.GetExcludePathsString() + ",";
                txtTypeFilter.Text = template.GetTypeFilterString() + ",";
                chbInvertType.Checked = template.TypeInverted;
                lblLastUsed.Text = template.LastUsed.ToString();
            }
            // show buttons
            DisplayDeleteButton();
        }
        #endregion

        // communication interface
        #region iCommunication

        /// <summary>
        /// TODO: implement isError for different text color
        /// writes output to listbox, save for multi threading
        /// </summary>
        public void SendOutput(string message, bool isError = false)
        {
            if (lbOutput.InvokeRequired)
            {
                // https://stackoverflow.com/questions/14703698/invokedelegate
                lbOutput.Invoke((MethodInvoker)delegate { LogText(message); });
                // lbOutput.Invoke(new MethodInvoker(() => LogText(message)));
            }
            else
            {
                LogText(message);
            }
        }

        /// <summary>
        /// write each line of a string to the listbox
        /// </summary>
        private void LogText(string text)
        {
            using (StringReader reader = new StringReader(text))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lbOutput.Items.Add(line);
                }
            }
            // select last to scroll down
            lbOutput.SelectedIndex = lbOutput.Items.Count - 1;
        }

        public void OnBackupProgressChanged(string progress)
        {
            if (lblBackupStatus.InvokeRequired)
            {
                lblBackupStatus.Invoke((MethodInvoker)delegate { lblBackupStatus.Text = progress; });
            }
            else
            {
                lblBackupStatus.Text = progress;
            }
        }
 

        public void OnRestoreProgressChanged(string progress)
        {
            if (lblRestoreStatus.InvokeRequired)
            {
                lblRestoreStatus.Invoke((MethodInvoker)delegate { lblRestoreStatus.Text = progress; });
            }
            else
            {
                lblRestoreStatus.Text = progress;
            }
        }

        #endregion

        // Tab pages, buttons
        #region tabBackup
        private void StartBackupClick(object sender, EventArgs e)
        {

            if (backup.Backup.Start(txtDestinationPath.Text, cmbTemplatesStart.Text, chbOnlyChanged.Checked))
            {
                if (!string.IsNullOrEmpty(cmbTemplatesStart.Text))
                {
                    //success
                    CSettings.Default.DestinationPath = txtDestinationPath.Text;
                    CSettings.Default.LastUsedTemplate = cmbTemplatesStart.Items.IndexOf(cmbTemplatesStart.SelectedItem);
                    CSettings.Default.OnlyChanged = chbOnlyChanged.Checked;
                }
            }

        }


        private void BrowseDestinationClick(object sender, EventArgs e)
        {
            string path = backup.Dialoges.BrowseFolder();
            if (path != null)
            {
                txtDestinationPath.Text = path;
            }
        }

        #endregion

        #region tabRestore
        private void BrowseRestoreClick(object sender, EventArgs e)
        {
            string path = backup.Dialoges.BrowseFolder();
            if (path != null)
            {
                txtRestoreSource.Text = path;
            }
        }

        private void RestoreBackupClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRestoreSource.Text))
            {
                SendOutput("[Restore] Select path to restore from first", true);
                return;
            }

            if (backup.Restore.Start(txtRestoreSource.Text))
            {
                //success
                CSettings.Default.RestorePath = txtRestoreSource.Text;
            }
        }
        #endregion

        #region tabEdit
        private void OnEditValueChanged(object sender, EventArgs e)
        {
            OnEditChanged();
        }

        private void BrowsePathsClick(object sender, EventArgs e)
        {
            string add = backup.Dialoges.BrowseFileOrFolderString();
            //string add = backup.Dialoges.BrowseFolderString();
            if (add != null)
            {
                txtEditPaths.Text += add;
                SendOutput("[Templates] Added: " + add);
            }
        }

        private void BrowseExcludeClick(object sender, EventArgs e)
        {
            string add = backup.Dialoges.BrowseFolderString();
            if (add != null)
            {
                txtEditPathsExclude.Text += add;
                SendOutput("[Templates] Added exclude: " + add);
            }
        }

        // add or change template
        private void SaveTemplateClick(object sender, EventArgs e)
        {
            bool flag;
            if (SelectedAddOrEdit())
            {
                flag = backup.Templates.AddTemplate(txtEditName.Text, 
                    txtEditPaths.Text, txtEditPathsExclude.Text, txtTypeFilter.Text, chbInvertType.Checked);
            }
            else
            {
                flag = backup.Templates.ReplaceTemplate(cmbTemplatesEdit.Text, 
                    txtEditName.Text, txtEditPaths.Text, txtEditPathsExclude.Text
                    , txtTypeFilter.Text, chbInvertType.Checked);
            }
            if (flag)
            {
                RefreshBackupList();
                txtEditName.Text = "";
            }

        }

        private void DeleteTemplateClick(object sender, EventArgs e)
        {
            if (!SelectedAddOrEdit() && backup.Templates.RemoveTemplate(cmbTemplatesEdit.Text))
            {
                RefreshBackupList();
            }
        }


        #endregion

        #region tabExport

        private void ExportTemplatesClick(object sender, EventArgs e)
        {
            backup.Dialoges.SaveFile("BackupTemplates_" + DateTime.Now.ToString("dd_MM_yyyy"),
                backup.Templates.AllTemplatesToXML(), "Export templates");
        }

        private void ImportTemplatesClick(object sender, EventArgs e)
        {
            string ftext = backup.Dialoges.BrowseFileText();
            if (ftext != null && backup.Templates.ImportFromXML(ftext))
            {
                RefreshBackupList();
            }
        }

        private void ResetSettingsClick(object sender, EventArgs e)
        {
            if (CriticalDialog.ShowDialog("Reset settings and delete " +
                "templates?\nYou can't undo this action!\nThe program will restart.",
                "Reset")
                == DialogResult.Yes)
            {
                CSettings.Default.Reset();
                Application.Restart();
            }
        }


        #endregion

        private void CopySelectedLbClick(object sender, EventArgs e)
        {
            try
            {
                if (lbOutput.SelectedItem != null)
                {
                    Clipboard.SetText(lbOutput.SelectedItem.ToString());
                }
            }
            catch (Exception ex)
            {
                SendOutput("Could not copy contents: " + ex);
            }
        }

        private void CopyAllLbClick(object sender, EventArgs e)
        {
            try
            {
                string content = "";
                foreach (var item in lbOutput.Items)
                {
                    content += item + "\n";
                }
                if (!string.IsNullOrWhiteSpace(content))
                {
                    Clipboard.SetText(content);
                }
            }
            catch (Exception ex)
            {
                SendOutput("Could not copy contents: " + ex);
            }
        }
    }
}
