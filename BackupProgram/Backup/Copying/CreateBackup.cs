using System;
using System.ComponentModel;
using System.IO;

namespace BackupProgram.Backup.Copying
{
    /// <summary>
    /// copy files
    /// </summary>
    public class ExecuteBackup : BackgroundCopyBase
    {


        public ExecuteBackup(ICommunication communication_)
            : base(communication_, false)
        {

        }

        /// <summary>
        /// start background worker, only checks if worker is available and send start message
        /// </summary>
        public bool Start(string sourceDir, string templateName, bool onlyChanged)
        {
            if (bgrWorker.IsBusy)
            {
                communication.SendOutput("[Backup] Can not start while other backup process is running", true);
                return false;
            }

            communication.SendOutput("[Backup] Started copying, " + DateTime.Now);

            ResetCounters();
            bgrWorker.RunWorkerAsync(argument: new CreateWorkerParameter(sourceDir, templateName, onlyChanged));

            return true;
        }

        /// <summary>
        /// call function to copy, call function to display errors
        /// </summary>
        protected override void WorkerDoWork(object sender, DoWorkEventArgs e)
        {
            CreateWorkerParameter par = (CreateWorkerParameter)e.Argument;
            MakeBackup(par.SourceDir, par.TemplateName, par.OnlyChanged);
            DisplayCopyErrors("[Backup]");

            communication.SendOutput("[Backup] Created backup of "
                + totalFilesCopied + " / " + totalFilesToCopy + ", files " + DateTime.Now);
        }

        protected override void OnWorkerProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            communication.OnBackupProgressChanged(CopyPercentage());
        }

        protected override void OnBackupCancelled()
        {
            communication.OnBackupProgressChanged("_");
        }

        private bool MakeBackup(string targetPath, string backupname, bool onlyChanged)
        {
            BackupTemplate template = TemplateHandler.GetTemplateByName(backupname);

            if (template == null)
            {
                communication.SendOutput("[Backup] " + (backupname ?? "NULL") + " template does not exist", true);
                return false;
            }
            if (string.IsNullOrEmpty(targetPath))
            {
                communication.SendOutput("[Backup] Destination folder does not exist: ", true);
                return false;
            }

            try
            {
                // create destination, for sorting in explorer format year, month, day
                targetPath += "\\" + template.BackupName + "_" + DateTime.Now.ToString("yyyy_MM_dd");
                if (onlyChanged)
                {
                    targetPath += "_INC";
                }
                // if backup does already exist add hour + minute
                if (Directory.Exists(targetPath))
                {
                    targetPath += "_" + DateTime.Now.ToString("HH_mm");
                }
                Directory.CreateDirectory(targetPath);
            }
            catch
            {
                communication.SendOutput("[Backup] Could not create destination folder at " + targetPath, true);
                return false;
            }

            communication.OnBackupProgressChanged("Started " + backupname);
            // copy files and folders
            CopyDirectories(template, targetPath, onlyChanged);
            AddUsedTemplate(targetPath, template);
            communication.SendOutput("[Backup] Saved at: " + targetPath);

            return true;
        }

        /// <summary>
        /// copy the template that was used for the backup
        /// used to restore later
        /// </summary>
        private void AddUsedTemplate(string path, BackupTemplate template)
        {
            try
            {
                template.LastUsed = DateTime.Now;
                File.WriteAllText(path + ExportTemplatePath, template.ToXML());
            }
            catch (Exception ex)
            {
                communication.SendOutput("[Backup] Could not add used template at" + path + ex.Message);
            }
        }




    }
}
