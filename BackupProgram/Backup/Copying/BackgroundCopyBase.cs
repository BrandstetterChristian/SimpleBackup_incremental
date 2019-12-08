using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BackupProgram.Backup.Copying
{
    public abstract class BackgroundCopyBase : BackgroundWorkerBase
    {
        /// <summary>
        /// if files that already exist will be overriden on copy (File.Copy parameter)
        /// </summary>
        private readonly bool overrideFiles;

        /// <summary>
        /// errors while copying, "" if success
        /// </summary>
        private string copyErrors;

        // current file counter of folder
        private int filesCopied;
        private int filesToCopy;
        // total folders to copy
        protected int foldersToCopy;
        protected int foldersCopied;

        // counter of files to copy
        protected int totalFilesCopied;
        protected int totalFilesToCopy;

        protected ICommunication communication;

        /// <summary>
        /// template.txt path
        /// </summary>
        protected const string ExportTemplatePath = "\\template.txt";

        public BackgroundCopyBase(ICommunication communication_, bool overrideF) : base()
        {
            communication = communication_;
            copyErrors = "";
            overrideFiles = overrideF;
        }

        /// <summary>
        /// copy list of folders, sets counters for output
        /// </summary>
        protected void CopyDirectories(BackupTemplate template, string targetPath, bool checkDate)
        {
            foldersToCopy = template.PathsBackup.Count;
            foldersCopied = 0;
            foreach (string source in template.PathsBackup)
            {
                if (source.Contains("\\"))
                {
                    foldersCopied++;
                    CopyDirectory(source, targetPath
                       + source.Substring(source.LastIndexOf('\\')) + @"\",
                       template, checkDate);
                }
            }
        }

        /// <summary>
        /// copying function without recursion: 
        /// "*", SearchOption.AllDirectories
        /// </summary>
        protected void CopyDirectory(string sourceDirName, string destDirName, BackupTemplate template, bool checkDate)
        {
            try
            {
                Directory.CreateDirectory(destDirName);
            }
            catch
            {
                communication.SendOutput("[Copying] Can't copy to " + destDirName ?? "NULL");
                return;
            }


            // get files + folders to copy
            string destination = "";
            List<string> copyDirectories;
            List<string> copyFiles;
            try
            {
                // excluding: after changing to none recursive some problems, solution: ShouldBeCopied

                copyDirectories = Directory.GetDirectories(sourceDirName, "*",
                    SearchOption.AllDirectories).ToList();


                copyFiles = Directory.GetFiles(sourceDirName, "*",
                    SearchOption.AllDirectories).ToList();

                // single files
                copyFiles.AddRange(template.PathsSingleFiles);

                filesCopied = 0;
                filesToCopy = copyFiles.Count;
            }
            catch
            {
                communication.SendOutput("[Copying] Could not get files to copy, make sure "
                    + (sourceDirName ?? "NULL") + " is accessable", true);
                return;
            }

            // 1. create target directories
            foreach (string copyDir in copyDirectories)
            {
                try
                {
                    // destination = target directory + path without source folder
                    destination = Path.Combine(destDirName, copyDir.Substring(sourceDirName.Length + 1));
                    if (template.ShouldBeCopied(copyDir, false, checkDate))
                    {
                        Directory.CreateDirectory(destination);
                    }
                }
                catch (Exception ex)
                {
                    AddCopyError(copyDir, ex);
                    continue;
                }
            }

            // 2. copy files
            foreach (string copyFile in copyFiles)
            {
                try
                {
                    destination = Path.Combine(destDirName, copyFile.Substring(sourceDirName.Length + 1));
                    if (template.ShouldBeCopied(copyFile, true, checkDate))
                    {
                        File.Copy(copyFile, destination, overrideFiles);
                        filesCopied++;
                    }


                    bgrWorker.ReportProgress(1);
                }
                catch (Exception ex)
                {
                    AddCopyError(copyFile, ex);
                    continue;
                }
            }
            // counters:
            totalFilesCopied += filesCopied;
            totalFilesToCopy += filesToCopy;

        }


        protected void AddCopyError(string path, Exception ex)
        {
            copyErrors += (path ?? "NULL") + ", " + ex.GetType() + "\n";
        }

        /// <summary>
        /// display errors at copying if there were any
        /// </summary>
        /// <returns>true = no errors, false = errors</returns>
        protected bool DisplayCopyErrors(string source)
        {
            if (copyErrors == "")
            {
                return true;
            }
            communication.SendOutput(source + " Errors while copying, these file were not copied:\n"
                + copyErrors, true);
            copyErrors = ""; // reset errors here
            return false;
        }

        /// <summary>
        /// get only the name of a path
        /// </summary>
        protected string GetNameOfPath(string path)
        {
            int index = path.LastIndexOf("\\");
            // from last \ to end, if in range (lastindex can return -1)
            return path.Substring(index < path.Length && index > 0 ?
                index : 0, path.Length - index);
        }


        protected string CopyPercentage()
        {
            // calculating would be based on the guess that every folder takes the same time to copy
            return "Part " + foldersCopied + "/" + foldersToCopy + ", file " + filesCopied + "/" + filesToCopy;
        }

        protected void ResetCounters()
        {
            filesCopied = filesToCopy = foldersToCopy =
            foldersCopied = totalFilesCopied = 
            totalFilesToCopy = 0;
        }

    }
}
