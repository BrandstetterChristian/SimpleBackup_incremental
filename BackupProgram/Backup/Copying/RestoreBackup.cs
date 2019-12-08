using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace BackupProgram.Backup.Copying
{
    /// <summary>
    /// restore a previous backup
    /// </summary>
    public class RestoreBackup : BackgroundCopyBase
    {

        public RestoreBackup(ICommunication communication_)
            : base(communication_, true)
        {

        }

        /// <summary>
        /// start background worker, only checks if worker is available and send start message
        /// </summary>
        public bool Start(string pathToRestore)
        {
            if (bgrWorker.IsBusy)
            {
                communication.SendOutput("[Restore] Can't start while other restore process is running", true);
                return false;
            }

            communication.SendOutput("[Restore] Started copying, " + DateTime.Now);

            ResetCounters();
            // send path to background worker
            bgrWorker.RunWorkerAsync(argument: pathToRestore);

            return true;
        }

        protected override void WorkerDoWork(object sender, DoWorkEventArgs e)
        {
            ExecuteRestore((string)e.Argument);
            DisplayCopyErrors("[Restore]");
            communication.SendOutput("[Restore] Restored "
                + totalFilesCopied + " / " + totalFilesToCopy + " files, " + DateTime.Now);
        }

        protected override void OnWorkerProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            communication.OnRestoreProgressChanged(CopyPercentage());
        }

        protected override void OnBackupCancelled()
        {
            communication.OnRestoreProgressChanged("_");
        }

        private bool ExecuteRestore(string pathToRestore)
        {
            // get paths that will be restored and the template for the destination paths
            if (string.IsNullOrEmpty(pathToRestore))
            {
                communication.SendOutput("[Restore] invalid path for restoring");
                return false;
            }

            // paths from the folder to restore
            string[] pathsToRestore;

            try
            {
                pathsToRestore = Directory.GetDirectories(pathToRestore);
            }
            catch
            {
                communication.SendOutput("[Restore] could not get folders to restore", true);
                return false;
            }

            // template for destination paths
            BackupTemplate restoreTemplate = GetTemplateToRestore(pathToRestore);
            if (restoreTemplate == null)
            {
                return false; // output already in get template method
            }

            communication.OnBackupProgressChanged("Started " + restoreTemplate.BackupName);

            // check if anything will be overwritten, if yes backup first
            bool needBackup = false;
            foreach (string pathExists in restoreTemplate.PathsBackup)
            {
                if (Directory.Exists(pathExists))
                {
                    needBackup = true;
                    break;
                }
            }

            if (needBackup)
            {
                communication.SendOutput("[Restore] Creating backup of current files before overriding them");
                //throw new NotImplementedException();
                string targetPath = pathToRestore + "\\before_restore_" + DateTime.Now.ToString("dd_MM_yyyy__HH_mm");
                CopyDirectories(restoreTemplate, targetPath, false);

                if (!DisplayCopyErrors("[Backup before restore]"))
                {
                    // errors at copy before restore: ask if continue
                    if (DarkDialog.DialogBoxDark.ShowDialog("Some files could not be saved before restoring." +
                        "\nDo you want to overwrite them and restore anyway?", "Current files will be lost")
                        != DialogResult.Yes)
                    {
                        return false;
                    }
                }
            }

            // name of template path
            string tempName = "";

            // need to search target path for all paths from template, can't use copyDirectory
            foreach (string tempPath in restoreTemplate.PathsBackup)
            {
                tempName = GetNameOfPath(tempPath);

                foldersToCopy = pathsToRestore.Length + 1;
                foldersCopied = 0;

                foreach (string restore in pathsToRestore)
                {
                    if (GetNameOfPath(restore) == tempName)
                    {
                        foldersCopied++;
                        CopyDirectory(restore, tempPath, restoreTemplate, false);
                        break;
                    }
                }

            }
            return true;
        }



        /// <summary>
        /// get the used template from a folder, returns null if not found
        /// </summary>
        private BackupTemplate GetTemplateToRestore(string path)
        {
            string templateSourceText = null;
            try
            {
                templateSourceText = File.ReadAllText(path + ExportTemplatePath);
            }
            catch
            {
                communication.SendOutput("[Restore] Could not find " + ExportTemplatePath + " in " + path);
                return null;
            }

            BackupTemplate template = BackupTemplate.FromXML(templateSourceText);

            if (template == null)
            {
                communication.SendOutput("[Restore] could not read template from " + ExportTemplatePath + " file", true);
            }
            return template;
        }



    }


}
