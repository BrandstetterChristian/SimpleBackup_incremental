namespace BackupProgram
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.txtEditPaths = new System.Windows.Forms.TextBox();
            this.cmdImportTemplates = new System.Windows.Forms.Button();
            this.txtDestinationPath = new System.Windows.Forms.TextBox();
            this.cmdBrowseDestination = new System.Windows.Forms.Button();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.txtEditPathsExclude = new System.Windows.Forms.TextBox();
            this.cmdEditBrowse = new System.Windows.Forms.Button();
            this.cmdBrowseExclude = new System.Windows.Forms.Button();
            this.cmdEditDelete = new System.Windows.Forms.Button();
            this.cmdBrowseRestoreSource = new System.Windows.Forms.Button();
            this.txtRestoreSource = new System.Windows.Forms.TextBox();
            this.cmdExportTemplates = new System.Windows.Forms.Button();
            this.lblBackupStatus = new System.Windows.Forms.Label();
            this.lblRestoreStatus = new System.Windows.Forms.Label();
            this.txtTypeFilter = new System.Windows.Forms.TextBox();
            this.chbInvertType = new System.Windows.Forms.CheckBox();
            this.chbOnlyChanged = new System.Windows.Forms.CheckBox();
            this.cmdResetSettings = new System.Windows.Forms.Button();
            this.tabTools = new System.Windows.Forms.TabPage();
            this.tabTemplates = new System.Windows.Forms.TabPage();
            this.tblTemplates = new System.Windows.Forms.TableLayoutPanel();
            this.cmdSave = new System.Windows.Forms.Button();
            this.lblEditName = new System.Windows.Forms.Label();
            this.lblExclude = new System.Windows.Forms.Label();
            this.lblEditPaths = new System.Windows.Forms.Label();
            this.cmbTemplatesEdit = new System.Windows.Forms.ComboBox();
            this.lblEditTemplates = new System.Windows.Forms.Label();
            this.lblLastUsed = new System.Windows.Forms.Label();
            this.lblTypFilter = new System.Windows.Forms.Label();
            this.tabBackup = new System.Windows.Forms.TabPage();
            this.tblStart = new System.Windows.Forms.TableLayoutPanel();
            this.cmdBackupStart = new System.Windows.Forms.Button();
            this.lblDestinationPath = new System.Windows.Forms.Label();
            this.cmbTemplatesStart = new System.Windows.Forms.ComboBox();
            this.lblBackupConcept = new System.Windows.Forms.Label();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabRestore = new System.Windows.Forms.TabPage();
            this.tblRestore = new System.Windows.Forms.TableLayoutPanel();
            this.cmdRestoreBackup = new System.Windows.Forms.Button();
            this.lblSourcePath = new System.Windows.Forms.Label();
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.cmsListBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copySelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabTools.SuspendLayout();
            this.tabTemplates.SuspendLayout();
            this.tblTemplates.SuspendLayout();
            this.tabBackup.SuspendLayout();
            this.tblStart.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabRestore.SuspendLayout();
            this.tblRestore.SuspendLayout();
            this.cmsListBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tipInfo
            // 
            this.tipInfo.AutomaticDelay = 340;
            this.tipInfo.BackColor = System.Drawing.Color.White;
            this.tipInfo.ForeColor = System.Drawing.Color.Black;
            // 
            // txtEditPaths
            // 
            this.txtEditPaths.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEditPaths.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEditPaths.Font = new System.Drawing.Font("Century Gothic", 14.14286F);
            this.txtEditPaths.Location = new System.Drawing.Point(166, 117);
            this.txtEditPaths.Name = "txtEditPaths";
            this.txtEditPaths.Size = new System.Drawing.Size(352, 42);
            this.txtEditPaths.TabIndex = 8;
            this.tipInfo.SetToolTip(this.txtEditPaths, "Input example: C:\\folder1, C:\\folder2");
            // 
            // cmdImportTemplates
            // 
            this.cmdImportTemplates.AutoSize = true;
            this.cmdImportTemplates.BackColor = System.Drawing.Color.White;
            this.cmdImportTemplates.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdImportTemplates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdImportTemplates.Font = new System.Drawing.Font("Century Gothic", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdImportTemplates.Location = new System.Drawing.Point(3, 86);
            this.cmdImportTemplates.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.cmdImportTemplates.Name = "cmdImportTemplates";
            this.cmdImportTemplates.Size = new System.Drawing.Size(685, 83);
            this.cmdImportTemplates.TabIndex = 14;
            this.cmdImportTemplates.Text = "Import templates";
            this.tipInfo.SetToolTip(this.cmdImportTemplates, "Import templates from a text file");
            this.cmdImportTemplates.UseVisualStyleBackColor = false;
            this.cmdImportTemplates.Click += new System.EventHandler(this.ImportTemplatesClick);
            // 
            // txtDestinationPath
            // 
            this.txtDestinationPath.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDestinationPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDestinationPath.Font = new System.Drawing.Font("Century Gothic", 14.14286F);
            this.txtDestinationPath.Location = new System.Drawing.Point(3, 166);
            this.txtDestinationPath.Name = "txtDestinationPath";
            this.txtDestinationPath.Size = new System.Drawing.Size(422, 42);
            this.txtDestinationPath.TabIndex = 3;
            this.tipInfo.SetToolTip(this.txtDestinationPath, "Path where backup will be saved");
            // 
            // cmdBrowseDestination
            // 
            this.cmdBrowseDestination.BackColor = System.Drawing.Color.White;
            this.cmdBrowseDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdBrowseDestination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBrowseDestination.Font = new System.Drawing.Font("Wingdings", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cmdBrowseDestination.Location = new System.Drawing.Point(431, 166);
            this.cmdBrowseDestination.Name = "cmdBrowseDestination";
            this.cmdBrowseDestination.Size = new System.Drawing.Size(251, 59);
            this.cmdBrowseDestination.TabIndex = 4;
            this.cmdBrowseDestination.Text = "1";
            this.tipInfo.SetToolTip(this.cmdBrowseDestination, "Browse destination path");
            this.cmdBrowseDestination.UseVisualStyleBackColor = false;
            this.cmdBrowseDestination.Click += new System.EventHandler(this.BrowseDestinationClick);
            // 
            // txtEditName
            // 
            this.txtEditName.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEditName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEditName.Font = new System.Drawing.Font("Century Gothic", 14.14286F);
            this.txtEditName.Location = new System.Drawing.Point(166, 288);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(352, 42);
            this.txtEditName.TabIndex = 10;
            this.tipInfo.SetToolTip(this.txtEditName, "Unique name");
            // 
            // txtEditPathsExclude
            // 
            this.txtEditPathsExclude.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEditPathsExclude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEditPathsExclude.Font = new System.Drawing.Font("Century Gothic", 14.14286F);
            this.txtEditPathsExclude.ForeColor = System.Drawing.Color.Black;
            this.txtEditPathsExclude.Location = new System.Drawing.Point(166, 174);
            this.txtEditPathsExclude.Name = "txtEditPathsExclude";
            this.txtEditPathsExclude.Size = new System.Drawing.Size(352, 42);
            this.txtEditPathsExclude.TabIndex = 15;
            this.tipInfo.SetToolTip(this.txtEditPathsExclude, "(Optional) exclude certain paths");
            // 
            // cmdEditBrowse
            // 
            this.cmdEditBrowse.BackColor = System.Drawing.Color.White;
            this.cmdEditBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdEditBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEditBrowse.Font = new System.Drawing.Font("Wingdings", 13.875F);
            this.cmdEditBrowse.Location = new System.Drawing.Point(524, 117);
            this.cmdEditBrowse.Name = "cmdEditBrowse";
            this.cmdEditBrowse.Size = new System.Drawing.Size(158, 51);
            this.cmdEditBrowse.TabIndex = 12;
            this.cmdEditBrowse.Text = "1";
            this.tipInfo.SetToolTip(this.cmdEditBrowse, "Browse paths");
            this.cmdEditBrowse.UseVisualStyleBackColor = false;
            this.cmdEditBrowse.Click += new System.EventHandler(this.BrowsePathsClick);
            // 
            // cmdBrowseExclude
            // 
            this.cmdBrowseExclude.BackColor = System.Drawing.Color.White;
            this.cmdBrowseExclude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdBrowseExclude.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBrowseExclude.Font = new System.Drawing.Font("Wingdings", 13.875F);
            this.cmdBrowseExclude.ForeColor = System.Drawing.Color.Black;
            this.cmdBrowseExclude.Location = new System.Drawing.Point(524, 174);
            this.cmdBrowseExclude.Name = "cmdBrowseExclude";
            this.cmdBrowseExclude.Size = new System.Drawing.Size(158, 51);
            this.cmdBrowseExclude.TabIndex = 16;
            this.cmdBrowseExclude.Text = "1";
            this.tipInfo.SetToolTip(this.cmdBrowseExclude, "Browse excluded paths");
            this.cmdBrowseExclude.UseVisualStyleBackColor = false;
            this.cmdBrowseExclude.Click += new System.EventHandler(this.BrowseExcludeClick);
            // 
            // cmdEditDelete
            // 
            this.cmdEditDelete.BackColor = System.Drawing.Color.LightGray;
            this.cmdEditDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdEditDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEditDelete.Location = new System.Drawing.Point(524, 345);
            this.cmdEditDelete.Name = "cmdEditDelete";
            this.cmdEditDelete.Size = new System.Drawing.Size(158, 54);
            this.cmdEditDelete.TabIndex = 13;
            this.cmdEditDelete.Text = "Delete";
            this.tipInfo.SetToolTip(this.cmdEditDelete, "Delete the selected template");
            this.cmdEditDelete.UseVisualStyleBackColor = false;
            this.cmdEditDelete.Click += new System.EventHandler(this.DeleteTemplateClick);
            // 
            // cmdBrowseRestoreSource
            // 
            this.cmdBrowseRestoreSource.BackColor = System.Drawing.Color.White;
            this.cmdBrowseRestoreSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdBrowseRestoreSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBrowseRestoreSource.Font = new System.Drawing.Font("Wingdings", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cmdBrowseRestoreSource.Location = new System.Drawing.Point(431, 84);
            this.cmdBrowseRestoreSource.Name = "cmdBrowseRestoreSource";
            this.cmdBrowseRestoreSource.Size = new System.Drawing.Size(251, 100);
            this.cmdBrowseRestoreSource.TabIndex = 4;
            this.cmdBrowseRestoreSource.Text = "1";
            this.tipInfo.SetToolTip(this.cmdBrowseRestoreSource, "Browse source path");
            this.cmdBrowseRestoreSource.UseVisualStyleBackColor = false;
            this.cmdBrowseRestoreSource.Click += new System.EventHandler(this.BrowseRestoreClick);
            // 
            // txtRestoreSource
            // 
            this.txtRestoreSource.BackColor = System.Drawing.Color.Gainsboro;
            this.txtRestoreSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRestoreSource.Font = new System.Drawing.Font("Century Gothic", 14.14286F);
            this.txtRestoreSource.Location = new System.Drawing.Point(3, 84);
            this.txtRestoreSource.Name = "txtRestoreSource";
            this.txtRestoreSource.Size = new System.Drawing.Size(422, 42);
            this.txtRestoreSource.TabIndex = 3;
            this.tipInfo.SetToolTip(this.txtRestoreSource, "Path to be restored, should contain template.txt");
            // 
            // cmdExportTemplates
            // 
            this.cmdExportTemplates.AutoSize = true;
            this.cmdExportTemplates.BackColor = System.Drawing.Color.White;
            this.cmdExportTemplates.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdExportTemplates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdExportTemplates.Font = new System.Drawing.Font("Century Gothic", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExportTemplates.Location = new System.Drawing.Point(3, 3);
            this.cmdExportTemplates.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.cmdExportTemplates.Name = "cmdExportTemplates";
            this.cmdExportTemplates.Size = new System.Drawing.Size(685, 83);
            this.cmdExportTemplates.TabIndex = 12;
            this.cmdExportTemplates.Text = "Export templates";
            this.tipInfo.SetToolTip(this.cmdExportTemplates, "Export current templates to a text file");
            this.cmdExportTemplates.UseVisualStyleBackColor = false;
            this.cmdExportTemplates.Click += new System.EventHandler(this.ExportTemplatesClick);
            // 
            // lblBackupStatus
            // 
            this.lblBackupStatus.AutoEllipsis = true;
            this.lblBackupStatus.AutoSize = true;
            this.lblBackupStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBackupStatus.Location = new System.Drawing.Point(3, 358);
            this.lblBackupStatus.Name = "lblBackupStatus";
            this.lblBackupStatus.Size = new System.Drawing.Size(422, 69);
            this.lblBackupStatus.TabIndex = 7;
            this.lblBackupStatus.Text = "_";
            this.tipInfo.SetToolTip(this.lblBackupStatus, "Backup progress");
            // 
            // lblRestoreStatus
            // 
            this.lblRestoreStatus.AutoEllipsis = true;
            this.lblRestoreStatus.AutoSize = true;
            this.lblRestoreStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRestoreStatus.Location = new System.Drawing.Point(3, 293);
            this.lblRestoreStatus.Name = "lblRestoreStatus";
            this.lblRestoreStatus.Size = new System.Drawing.Size(422, 109);
            this.lblRestoreStatus.TabIndex = 7;
            this.lblRestoreStatus.Text = "_";
            this.tipInfo.SetToolTip(this.lblRestoreStatus, "Restore progress");
            // 
            // txtTypeFilter
            // 
            this.txtTypeFilter.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTypeFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTypeFilter.Font = new System.Drawing.Font("Century Gothic", 14.14286F);
            this.txtTypeFilter.Location = new System.Drawing.Point(166, 231);
            this.txtTypeFilter.Name = "txtTypeFilter";
            this.txtTypeFilter.Size = new System.Drawing.Size(352, 42);
            this.txtTypeFilter.TabIndex = 18;
            this.tipInfo.SetToolTip(this.txtTypeFilter, "File types that will be copied, input example: txt, pdf");
            // 
            // chbInvertType
            // 
            this.chbInvertType.AutoSize = true;
            this.chbInvertType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbInvertType.Location = new System.Drawing.Point(524, 231);
            this.chbInvertType.Name = "chbInvertType";
            this.chbInvertType.Size = new System.Drawing.Size(158, 51);
            this.chbInvertType.TabIndex = 19;
            this.chbInvertType.Text = "Invert";
            this.tipInfo.SetToolTip(this.chbInvertType, "Invert = copy everything except these files");
            this.chbInvertType.UseVisualStyleBackColor = true;
            // 
            // chbOnlyChanged
            // 
            this.chbOnlyChanged.AutoSize = true;
            this.chbOnlyChanged.Location = new System.Drawing.Point(3, 231);
            this.chbOnlyChanged.Name = "chbOnlyChanged";
            this.chbOnlyChanged.Size = new System.Drawing.Size(307, 40);
            this.chbOnlyChanged.TabIndex = 8;
            this.chbOnlyChanged.Text = "Only changed files";
            this.tipInfo.SetToolTip(this.chbOnlyChanged, "Copy only the files that have changed since the last backup");
            this.chbOnlyChanged.UseVisualStyleBackColor = true;
            // 
            // cmdResetSettings
            // 
            this.cmdResetSettings.AutoSize = true;
            this.cmdResetSettings.BackColor = System.Drawing.Color.LightGray;
            this.cmdResetSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdResetSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdResetSettings.Font = new System.Drawing.Font("Century Gothic", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdResetSettings.Location = new System.Drawing.Point(3, 169);
            this.cmdResetSettings.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.cmdResetSettings.Name = "cmdResetSettings";
            this.cmdResetSettings.Size = new System.Drawing.Size(685, 83);
            this.cmdResetSettings.TabIndex = 15;
            this.cmdResetSettings.Text = "Reset everything";
            this.tipInfo.SetToolTip(this.cmdResetSettings, "Removes all templates and resets settings");
            this.cmdResetSettings.UseVisualStyleBackColor = false;
            this.cmdResetSettings.Click += new System.EventHandler(this.ResetSettingsClick);
            // 
            // tabTools
            // 
            this.tabTools.BackColor = System.Drawing.Color.DarkGray;
            this.tabTools.Controls.Add(this.cmdResetSettings);
            this.tabTools.Controls.Add(this.cmdImportTemplates);
            this.tabTools.Controls.Add(this.cmdExportTemplates);
            this.tabTools.Location = new System.Drawing.Point(4, 43);
            this.tabTools.Name = "tabTools";
            this.tabTools.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabTools.Size = new System.Drawing.Size(691, 408);
            this.tabTools.TabIndex = 4;
            this.tabTools.Text = "Tools";
            // 
            // tabTemplates
            // 
            this.tabTemplates.BackColor = System.Drawing.Color.DimGray;
            this.tabTemplates.Controls.Add(this.tblTemplates);
            this.tabTemplates.Location = new System.Drawing.Point(4, 43);
            this.tabTemplates.Name = "tabTemplates";
            this.tabTemplates.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabTemplates.Size = new System.Drawing.Size(691, 408);
            this.tabTemplates.TabIndex = 3;
            this.tabTemplates.Text = "Templates";
            // 
            // tblTemplates
            // 
            this.tblTemplates.BackColor = System.Drawing.Color.DarkGray;
            this.tblTemplates.ColumnCount = 3;
            this.tblTemplates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.tblTemplates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.38095F));
            this.tblTemplates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.tblTemplates.Controls.Add(this.cmdEditDelete, 2, 6);
            this.tblTemplates.Controls.Add(this.cmdSave, 0, 6);
            this.tblTemplates.Controls.Add(this.txtEditName, 1, 5);
            this.tblTemplates.Controls.Add(this.lblEditName, 0, 5);
            this.tblTemplates.Controls.Add(this.cmdBrowseExclude, 2, 3);
            this.tblTemplates.Controls.Add(this.txtEditPathsExclude, 1, 3);
            this.tblTemplates.Controls.Add(this.lblExclude, 0, 3);
            this.tblTemplates.Controls.Add(this.cmdEditBrowse, 2, 2);
            this.tblTemplates.Controls.Add(this.txtEditPaths, 1, 2);
            this.tblTemplates.Controls.Add(this.lblEditPaths, 0, 2);
            this.tblTemplates.Controls.Add(this.cmbTemplatesEdit, 0, 1);
            this.tblTemplates.Controls.Add(this.lblEditTemplates, 0, 0);
            this.tblTemplates.Controls.Add(this.lblLastUsed, 2, 5);
            this.tblTemplates.Controls.Add(this.lblTypFilter, 0, 4);
            this.tblTemplates.Controls.Add(this.txtTypeFilter, 1, 4);
            this.tblTemplates.Controls.Add(this.chbInvertType, 2, 4);
            this.tblTemplates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblTemplates.Location = new System.Drawing.Point(3, 3);
            this.tblTemplates.Name = "tblTemplates";
            this.tblTemplates.RowCount = 7;
            this.tblTemplates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28507F));
            this.tblTemplates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28505F));
            this.tblTemplates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28505F));
            this.tblTemplates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28505F));
            this.tblTemplates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28965F));
            this.tblTemplates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28505F));
            this.tblTemplates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28506F));
            this.tblTemplates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tblTemplates.Size = new System.Drawing.Size(685, 402);
            this.tblTemplates.TabIndex = 8;
            // 
            // cmdSave
            // 
            this.cmdSave.BackColor = System.Drawing.Color.White;
            this.tblTemplates.SetColumnSpan(this.cmdSave, 2);
            this.cmdSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSave.Location = new System.Drawing.Point(3, 345);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(515, 54);
            this.cmdSave.TabIndex = 11;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = false;
            this.cmdSave.Click += new System.EventHandler(this.SaveTemplateClick);
            // 
            // lblEditName
            // 
            this.lblEditName.AutoSize = true;
            this.lblEditName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEditName.Location = new System.Drawing.Point(3, 285);
            this.lblEditName.Name = "lblEditName";
            this.lblEditName.Size = new System.Drawing.Size(157, 57);
            this.lblEditName.TabIndex = 9;
            this.lblEditName.Text = "Name*";
            // 
            // lblExclude
            // 
            this.lblExclude.AutoSize = true;
            this.lblExclude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblExclude.ForeColor = System.Drawing.Color.Black;
            this.lblExclude.Location = new System.Drawing.Point(3, 171);
            this.lblExclude.Name = "lblExclude";
            this.lblExclude.Size = new System.Drawing.Size(157, 57);
            this.lblExclude.TabIndex = 14;
            this.lblExclude.Text = "Exclude";
            // 
            // lblEditPaths
            // 
            this.lblEditPaths.AutoSize = true;
            this.lblEditPaths.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEditPaths.Location = new System.Drawing.Point(3, 114);
            this.lblEditPaths.Name = "lblEditPaths";
            this.lblEditPaths.Size = new System.Drawing.Size(157, 57);
            this.lblEditPaths.TabIndex = 7;
            this.lblEditPaths.Text = "Paths*";
            // 
            // cmbTemplatesEdit
            // 
            this.cmbTemplatesEdit.BackColor = System.Drawing.Color.Gainsboro;
            this.tblTemplates.SetColumnSpan(this.cmbTemplatesEdit, 3);
            this.cmbTemplatesEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbTemplatesEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTemplatesEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTemplatesEdit.Font = new System.Drawing.Font("Century Gothic", 14.14286F);
            this.cmbTemplatesEdit.FormattingEnabled = true;
            this.cmbTemplatesEdit.Location = new System.Drawing.Point(3, 60);
            this.cmbTemplatesEdit.Name = "cmbTemplatesEdit";
            this.cmbTemplatesEdit.Size = new System.Drawing.Size(679, 42);
            this.cmbTemplatesEdit.TabIndex = 1;
            this.cmbTemplatesEdit.SelectedValueChanged += new System.EventHandler(this.OnEditValueChanged);
            // 
            // lblEditTemplates
            // 
            this.lblEditTemplates.AutoSize = true;
            this.lblEditTemplates.BackColor = System.Drawing.Color.Transparent;
            this.tblTemplates.SetColumnSpan(this.lblEditTemplates, 3);
            this.lblEditTemplates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEditTemplates.Location = new System.Drawing.Point(3, 0);
            this.lblEditTemplates.Name = "lblEditTemplates";
            this.lblEditTemplates.Size = new System.Drawing.Size(679, 57);
            this.lblEditTemplates.TabIndex = 6;
            this.lblEditTemplates.Text = "Add or edit templates";
            // 
            // lblLastUsed
            // 
            this.lblLastUsed.AutoEllipsis = true;
            this.lblLastUsed.AutoSize = true;
            this.lblLastUsed.Location = new System.Drawing.Point(524, 285);
            this.lblLastUsed.Name = "lblLastUsed";
            this.lblLastUsed.Size = new System.Drawing.Size(30, 36);
            this.lblLastUsed.TabIndex = 20;
            this.lblLastUsed.Text = "_";
            // 
            // lblTypFilter
            // 
            this.lblTypFilter.AutoSize = true;
            this.lblTypFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTypFilter.Location = new System.Drawing.Point(3, 228);
            this.lblTypFilter.Name = "lblTypFilter";
            this.lblTypFilter.Size = new System.Drawing.Size(157, 57);
            this.lblTypFilter.TabIndex = 17;
            this.lblTypFilter.Text = "Type filter";
            // 
            // tabBackup
            // 
            this.tabBackup.BackColor = System.Drawing.Color.DimGray;
            this.tabBackup.Controls.Add(this.tblStart);
            this.tabBackup.Location = new System.Drawing.Point(4, 43);
            this.tabBackup.Name = "tabBackup";
            this.tabBackup.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabBackup.Size = new System.Drawing.Size(691, 433);
            this.tabBackup.TabIndex = 0;
            this.tabBackup.Text = "Backup";
            // 
            // tblStart
            // 
            this.tblStart.BackColor = System.Drawing.Color.DarkGray;
            this.tblStart.ColumnCount = 2;
            this.tblStart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tblStart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tblStart.Controls.Add(this.cmdBackupStart, 0, 5);
            this.tblStart.Controls.Add(this.cmdBrowseDestination, 1, 3);
            this.tblStart.Controls.Add(this.txtDestinationPath, 0, 3);
            this.tblStart.Controls.Add(this.lblDestinationPath, 0, 2);
            this.tblStart.Controls.Add(this.cmbTemplatesStart, 0, 1);
            this.tblStart.Controls.Add(this.lblBackupConcept, 0, 0);
            this.tblStart.Controls.Add(this.lblBackupStatus, 0, 6);
            this.tblStart.Controls.Add(this.chbOnlyChanged, 0, 4);
            this.tblStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblStart.Location = new System.Drawing.Point(3, 3);
            this.tblStart.Name = "tblStart";
            this.tblStart.RowCount = 7;
            this.tblStart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.65899F));
            this.tblStart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.33737F));
            this.tblStart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.65899F));
            this.tblStart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.33737F));
            this.tblStart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.33637F));
            this.tblStart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.33737F));
            this.tblStart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.33354F));
            this.tblStart.Size = new System.Drawing.Size(685, 427);
            this.tblStart.TabIndex = 7;
            // 
            // cmdBackupStart
            // 
            this.cmdBackupStart.BackColor = System.Drawing.Color.White;
            this.tblStart.SetColumnSpan(this.cmdBackupStart, 2);
            this.cmdBackupStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdBackupStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBackupStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBackupStart.Location = new System.Drawing.Point(3, 296);
            this.cmdBackupStart.Name = "cmdBackupStart";
            this.cmdBackupStart.Size = new System.Drawing.Size(679, 59);
            this.cmdBackupStart.TabIndex = 1;
            this.cmdBackupStart.Text = "Start backup";
            this.cmdBackupStart.UseVisualStyleBackColor = false;
            this.cmdBackupStart.Click += new System.EventHandler(this.StartBackupClick);
            // 
            // lblDestinationPath
            // 
            this.lblDestinationPath.AutoSize = true;
            this.tblStart.SetColumnSpan(this.lblDestinationPath, 2);
            this.lblDestinationPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDestinationPath.Location = new System.Drawing.Point(3, 114);
            this.lblDestinationPath.Name = "lblDestinationPath";
            this.lblDestinationPath.Size = new System.Drawing.Size(679, 49);
            this.lblDestinationPath.TabIndex = 2;
            this.lblDestinationPath.Text = "Destination path";
            // 
            // cmbTemplatesStart
            // 
            this.cmbTemplatesStart.BackColor = System.Drawing.Color.Gainsboro;
            this.tblStart.SetColumnSpan(this.cmbTemplatesStart, 2);
            this.cmbTemplatesStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbTemplatesStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTemplatesStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTemplatesStart.Font = new System.Drawing.Font("Century Gothic", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTemplatesStart.FormattingEnabled = true;
            this.cmbTemplatesStart.Location = new System.Drawing.Point(3, 52);
            this.cmbTemplatesStart.Name = "cmbTemplatesStart";
            this.cmbTemplatesStart.Size = new System.Drawing.Size(679, 42);
            this.cmbTemplatesStart.TabIndex = 0;
            // 
            // lblBackupConcept
            // 
            this.lblBackupConcept.AutoSize = true;
            this.lblBackupConcept.BackColor = System.Drawing.Color.Transparent;
            this.tblStart.SetColumnSpan(this.lblBackupConcept, 2);
            this.lblBackupConcept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBackupConcept.Location = new System.Drawing.Point(3, 0);
            this.lblBackupConcept.Name = "lblBackupConcept";
            this.lblBackupConcept.Size = new System.Drawing.Size(679, 49);
            this.lblBackupConcept.TabIndex = 5;
            this.lblBackupConcept.Text = "Select backup template";
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabBackup);
            this.tabMain.Controls.Add(this.tabRestore);
            this.tabMain.Controls.Add(this.tabTemplates);
            this.tabMain.Controls.Add(this.tabTools);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("Century Gothic", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Multiline = true;
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(699, 480);
            this.tabMain.TabIndex = 0;
            // 
            // tabRestore
            // 
            this.tabRestore.BackColor = System.Drawing.Color.DimGray;
            this.tabRestore.Controls.Add(this.tblRestore);
            this.tabRestore.Location = new System.Drawing.Point(4, 43);
            this.tabRestore.Name = "tabRestore";
            this.tabRestore.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabRestore.Size = new System.Drawing.Size(691, 408);
            this.tabRestore.TabIndex = 6;
            this.tabRestore.Text = "Restore";
            // 
            // tblRestore
            // 
            this.tblRestore.BackColor = System.Drawing.Color.DarkGray;
            this.tblRestore.ColumnCount = 2;
            this.tblRestore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tblRestore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tblRestore.Controls.Add(this.cmdRestoreBackup, 0, 2);
            this.tblRestore.Controls.Add(this.cmdBrowseRestoreSource, 1, 1);
            this.tblRestore.Controls.Add(this.txtRestoreSource, 0, 1);
            this.tblRestore.Controls.Add(this.lblSourcePath, 0, 0);
            this.tblRestore.Controls.Add(this.lblRestoreStatus, 0, 3);
            this.tblRestore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblRestore.Location = new System.Drawing.Point(3, 3);
            this.tblRestore.Name = "tblRestore";
            this.tblRestore.RowCount = 4;
            this.tblRestore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.21768F));
            this.tblRestore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.59632F));
            this.tblRestore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.59632F));
            this.tblRestore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.58967F));
            this.tblRestore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tblRestore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tblRestore.Size = new System.Drawing.Size(685, 402);
            this.tblRestore.TabIndex = 8;
            // 
            // cmdRestoreBackup
            // 
            this.cmdRestoreBackup.BackColor = System.Drawing.Color.White;
            this.tblRestore.SetColumnSpan(this.cmdRestoreBackup, 2);
            this.cmdRestoreBackup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdRestoreBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRestoreBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRestoreBackup.Location = new System.Drawing.Point(3, 190);
            this.cmdRestoreBackup.Name = "cmdRestoreBackup";
            this.cmdRestoreBackup.Size = new System.Drawing.Size(679, 100);
            this.cmdRestoreBackup.TabIndex = 1;
            this.cmdRestoreBackup.Text = "Restore backup";
            this.cmdRestoreBackup.UseVisualStyleBackColor = false;
            this.cmdRestoreBackup.Click += new System.EventHandler(this.RestoreBackupClick);
            // 
            // lblSourcePath
            // 
            this.lblSourcePath.AutoSize = true;
            this.tblRestore.SetColumnSpan(this.lblSourcePath, 2);
            this.lblSourcePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSourcePath.Location = new System.Drawing.Point(3, 0);
            this.lblSourcePath.Name = "lblSourcePath";
            this.lblSourcePath.Size = new System.Drawing.Size(679, 81);
            this.lblSourcePath.TabIndex = 2;
            this.lblSourcePath.Text = "Source path";
            // 
            // lbOutput
            // 
            this.lbOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lbOutput.ContextMenuStrip = this.cmsListBox;
            this.lbOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbOutput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOutput.ForeColor = System.Drawing.Color.White;
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.HorizontalScrollbar = true;
            this.lbOutput.ItemHeight = 27;
            this.lbOutput.Location = new System.Drawing.Point(0, 480);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.ScrollAlwaysVisible = true;
            this.lbOutput.Size = new System.Drawing.Size(699, 112);
            this.lbOutput.TabIndex = 1;
            // 
            // cmsListBox
            // 
            this.cmsListBox.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.cmsListBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copySelectedToolStripMenuItem,
            this.copyAllToolStripMenuItem});
            this.cmsListBox.Name = "cmsListBox";
            this.cmsListBox.Size = new System.Drawing.Size(297, 88);
            // 
            // copySelectedToolStripMenuItem
            // 
            this.copySelectedToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copySelectedToolStripMenuItem.Name = "copySelectedToolStripMenuItem";
            this.copySelectedToolStripMenuItem.Size = new System.Drawing.Size(296, 42);
            this.copySelectedToolStripMenuItem.Text = "Copy selected";
            this.copySelectedToolStripMenuItem.Click += new System.EventHandler(this.CopySelectedLbClick);
            // 
            // copyAllToolStripMenuItem
            // 
            this.copyAllToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyAllToolStripMenuItem.Name = "copyAllToolStripMenuItem";
            this.copyAllToolStripMenuItem.Size = new System.Drawing.Size(296, 42);
            this.copyAllToolStripMenuItem.Text = "Copy all";
            this.copyAllToolStripMenuItem.Click += new System.EventHandler(this.CopyAllLbClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 592);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.lbOutput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Backup program";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            this.Load += new System.EventHandler(this.FormMainLoad);
            this.Resize += new System.EventHandler(this.OnFormResize);
            this.tabTools.ResumeLayout(false);
            this.tabTools.PerformLayout();
            this.tabTemplates.ResumeLayout(false);
            this.tblTemplates.ResumeLayout(false);
            this.tblTemplates.PerformLayout();
            this.tabBackup.ResumeLayout(false);
            this.tblStart.ResumeLayout(false);
            this.tblStart.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tabRestore.ResumeLayout(false);
            this.tblRestore.ResumeLayout(false);
            this.tblRestore.PerformLayout();
            this.cmsListBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip tipInfo;
        private System.Windows.Forms.TabPage tabTools;
        private System.Windows.Forms.TabPage tabTemplates;
        private System.Windows.Forms.Label lblEditTemplates;
        private System.Windows.Forms.ComboBox cmbTemplatesEdit;
        private System.Windows.Forms.Label lblEditPaths;
        private System.Windows.Forms.TextBox txtEditPaths;
        private System.Windows.Forms.Button cmdEditBrowse;
        private System.Windows.Forms.Label lblEditName;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdEditDelete;
        private System.Windows.Forms.TabPage tabBackup;
        private System.Windows.Forms.Label lblBackupConcept;
        private System.Windows.Forms.ComboBox cmbTemplatesStart;
        private System.Windows.Forms.Label lblDestinationPath;
        private System.Windows.Forms.TextBox txtDestinationPath;
        private System.Windows.Forms.Button cmdBrowseDestination;
        private System.Windows.Forms.Button cmdBackupStart;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.Button cmdImportTemplates;
        private System.Windows.Forms.Label lblExclude;
        private System.Windows.Forms.TextBox txtEditPathsExclude;
        private System.Windows.Forms.Button cmdBrowseExclude;
        private System.Windows.Forms.TableLayoutPanel tblStart;
        private System.Windows.Forms.Label lblBackupStatus;
        private System.Windows.Forms.TableLayoutPanel tblTemplates;
        private System.Windows.Forms.TabPage tabRestore;
        private System.Windows.Forms.TableLayoutPanel tblRestore;
        private System.Windows.Forms.Button cmdRestoreBackup;
        private System.Windows.Forms.Button cmdBrowseRestoreSource;
        private System.Windows.Forms.TextBox txtRestoreSource;
        private System.Windows.Forms.Label lblSourcePath;
        private System.Windows.Forms.Label lblRestoreStatus;
        private System.Windows.Forms.Button cmdExportTemplates;
        private System.Windows.Forms.ListBox lbOutput;
        private System.Windows.Forms.Label lblTypFilter;
        private System.Windows.Forms.TextBox txtTypeFilter;
        private System.Windows.Forms.CheckBox chbInvertType;
        private System.Windows.Forms.CheckBox chbOnlyChanged;
        private System.Windows.Forms.Label lblLastUsed;
        private System.Windows.Forms.Button cmdResetSettings;
        private System.Windows.Forms.ContextMenuStrip cmsListBox;
        private System.Windows.Forms.ToolStripMenuItem copySelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyAllToolStripMenuItem;
    }
}

