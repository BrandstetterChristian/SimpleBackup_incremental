using BackupProgram.Backup.Template;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace BackupProgram.Backup
{
    /// <summary>
    /// contains paths that should be saved, paths to exclude and name of the backup
    /// </summary>
    public class BackupTemplate : IEquatable<BackupTemplate>
    {
        /// <summary>
        /// folder paths to save
        /// </summary>
        public List<string> PathsBackup;

        public List<string> PathsSingleFiles;

        /// <summary>
        /// paths to exclude from a backup
        /// </summary>
        public List<string> PathsExclude;

        // name must be unique
        public string BackupName { get; set; }

        public List<string> TypeFilter;
        // Invert = copy everything except this
        // else = copy only types in this list
        public bool TypeInverted { get; set; }

        // the last time this template was used for a backup
        public DateTime LastUsed { get; set; }

        public BackupTemplate() : this("XML", "", "", "", false)
        {
            // empty constructor required for serialization
        }


        public BackupTemplate(string backupName, string pathsToSave, string pathsToExclude, string typeFilter, bool typeInvert)
        {
            SplitFileAndFolderPaths(pathsToSave);
            //PathsBackup = ListConverter.StringToList(pathsToSave);
            PathsExclude = ListConverter.StringToList(pathsToExclude);
            BackupName = backupName;
            TypeFilter = ListConverter.StringToList(typeFilter);
            TypeInverted = typeInvert;
                       
        }

        private void SplitFileAndFolderPaths(string src)
        {
            List<string> allPaths = ListConverter.StringToList(src);
            PathsBackup = new List<string>();
            PathsSingleFiles = new List<string>();

            foreach (string path in allPaths)
            {
                // file else folder
                if (File.Exists(path))
                {
                    PathsSingleFiles.Add(path);
                } else
                {
                    PathsBackup.Add(path);
                }
            }
        }

        #region paths
        public string GetBackupPathsString()
        {
            return ListConverter.ListToString(PathsBackup);
        }

        public string GetExcludePathsString()
        {
            return ListConverter.ListToString(PathsExclude);
        }
        public string GetTypeFilterString()
        {
            return ListConverter.ListToString(TypeFilter);
        }

        // TODO...
        /*public string GetFilterForDirectory()
        {
            return ListConverter.ListToString(TypeFilter, "|.*");
        }*/



        #endregion

        
        /// <summary>
        /// defines if a path of the template will be copied
        /// checks excluded directories and excluded file types
        /// </summary>
        /// <param name="path">path of file or folder</param>
        /// <returns>true if it should be copied</returns>
        public bool ShouldBeCopied(string path, bool isFile, bool checkDate)
        {
            // 1. check if path is excluded:
            foreach (string s in PathsExclude)
            {
                // if (path.Contains(s))
                if (path.StartsWith(s))
                {
                    return false;
                }
            }

            // 2. check last used date, default datetime is sth like 1.1
            if (checkDate && LastUsed != default(DateTime))
            {
                bool copyFile;
                try
                {
                    DateTime lastEdited = File.GetLastWriteTime(path);
                    copyFile = lastEdited > LastUsed;

                }
                catch
                {

                    copyFile = true;
                }
                if (!copyFile)
                {
                    return false;
                }
            }

            // 3. check type filter for files
            if (isFile)
            {
                // if no filters exist true
                if (TypeFilter.Count <= 0)
                {
                    return true;
                }
                // cant contain files with no extensions
                if (!path.Contains("."))
                {
                    return TypeInverted;
                }

                // get only extension (without ".")
                string extension = path.Substring(path.LastIndexOf('.') + 1);
                if (TypeFilter.Contains(extension))
                {
                    return !TypeInverted;
                }
                else
                {
                    return TypeInverted;
                }
            }
            return true;
        }
    


        /// <summary>
        /// get the xml text from this template
        /// starts with \n<SplitTemplate/>\n to define start of a template
        /// </summary>
        public string ToXML()
        {
            using (StringWriter writer = new StringWriter())
            {
                XmlSerializer xml = new XmlSerializer(typeof(BackupTemplate));

                xml.Serialize(writer, this);
                return TemplateHandler.SplitExport + writer.ToString();
            }
        }

        /// <summary>
        /// gets a template from xml text
        /// </summary>
        /// <param name="tempText">text of the template</param>
        /// <returns>template or null if error</returns>
        public static BackupTemplate FromXML(string tempText)
        {
            if (string.IsNullOrEmpty(tempText))
            {
                return null;
            }
            // remove identifier
            if (tempText.Contains(TemplateHandler.SplitExport))
            {
                tempText = tempText.Replace(TemplateHandler.SplitExport, "");
            }

            try
            {
                using (StringReader reader = new StringReader(tempText))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(BackupTemplate));

                    return (BackupTemplate)xml.Deserialize(reader);
                }
            }
            catch
            {
                return null;
            }
        }

        public bool Equals(BackupTemplate other)
        {
            return other != null && other.BackupName == BackupName;
        }


    }
}
