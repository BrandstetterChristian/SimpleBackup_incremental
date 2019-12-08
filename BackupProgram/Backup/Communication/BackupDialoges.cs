using Microsoft.WindowsAPICodePack.Dialogs;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BackupProgram.Backup
{

    /// <summary>
    /// dialoges to save, select etc.
    /// </summary>
    #region tutorial_commonDialog
    // nuGet: Microsoft.WindowsAPICodePack-Shell
    // using Microsoft.WindowsAPICodePack.Dialogs;
    // fix size bug: app.manifest (new item, app manifest)
    // https://stackoverflow.com/questions/42975285/commonopenfiledialog-cause-windows-form-to-shrink
    /* uncomment:   <application xmlns="urn:schemas-microsoft-com:asm.v3">
        < windowsSettings >
        < dpiAware xmlns = "http://schemas.microsoft.com/SMI/2005/WindowsSettings" > true </ dpiAware >
        </ windowsSettings >
    </ application > */
    #endregion
    public class BackupDialoges
    {
        public string BrowseFileOrFolderString()
        {
            List<string> paths = BrowseFileOrFolder();
            if (paths == null)
            {
                return null;
            }
            string result = "";
            foreach (string s in paths)
            {
                result += s + ",";
            }

            return result;
        }

        private List<string> BrowseFileOrFolder()
        {
            using (CommonOpenFileDialog cfd = new CommonOpenFileDialog())
            {
                cfd.Title = "Open files or folders (Ctrl + click for multi selection)";

                cfd.IsFolderPicker = true;
                cfd.EnsureValidNames = false;
                cfd.EnsureFileExists = false;
                cfd.EnsurePathExists = false;

                cfd.Multiselect = true;

                if (cfd.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    return cfd.FileNames.ToList();
                }
            }

            return null;
        }

        /// <summary>
        /// browse multiple folders as string
        /// </summary>
        /// <returns>example folder1, folder2, folder3 or null</returns>
        public string BrowseFolderString()
        {
            List<string> paths = BrowseFolders();
            if (paths == null)
            {
                return null;
            }
            string result = "";
            foreach (string s in paths)
            {
                result += s + ",";
            }

            return result;
        }

        /// <summary>
        /// browse multiple folders as list
        /// </summary>
        /// <returns>list of paths or null</returns>
        private List<string> BrowseFolders()
        {
            using (CommonOpenFileDialog cfd = new CommonOpenFileDialog())
            {
                cfd.Title = "Open folders (Ctrl + click for multi selection)";
                cfd.IsFolderPicker = true;
                cfd.Multiselect = true;

                if (cfd.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    return cfd.FileNames.ToList();
                }
            }

            return null;
        }

        /// <summary>
        /// browse a single folder path
        /// </summary>
        /// <returns>path or null</returns>
        public string BrowseFolder()
        {
            using (CommonOpenFileDialog cfd = new CommonOpenFileDialog())
            {
                cfd.Title = "Open folder";
                cfd.IsFolderPicker = true;
                cfd.Multiselect = false;

                if (cfd.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    return cfd.FileName;
                }
            }

            return null;
        }

        /// <summary>
        /// save a file
        /// </summary>
        public bool SaveFile(string name, string text, string title = "Export", string filter = "Text File | *.txt")
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.FileName = name;
                sfd.Filter = filter;
                sfd.Title = title;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter writer = new StreamWriter(sfd.OpenFile()))
                        {
                            writer.Write(text ?? "");
                            return true;
                        }
                    }
                    catch
                    {
                        // return false;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// browse a file, return full text of the file or null
        /// </summary>
        public string BrowseFileText(string title = "Open file", string filter = "Text File | *.txt")
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = title;
                ofd.Filter = filter;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamReader reader = new StreamReader(ofd.OpenFile()))
                        {
                            return reader.ReadToEnd();
                        }
                    }
                    catch
                    {
                        //return null;
                    }
                }
            }

            return null;
        }

    }
}
