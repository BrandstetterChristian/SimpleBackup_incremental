using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace BackupProgram.Backup
{
    /// <summary>
    /// class for editing, exporting and importing templates
    /// xml serialization from:
    /// https://www.youtube.com/watch?v=zAn-ZbJqS90
    /// </summary>
    public class TemplateHandler
    {

        protected ICommunication communication;

        /// <summary>
        /// string for splitting templates when exporting
        /// </summary>
        public static readonly string SplitExport = "\n<SplitTemplate/>\n";

        public TemplateHandler(ICommunication communication_)
        {
            communication = communication_;

            // xml editor, settings
            //Type="System.Collections.Generic.List&lt;BackupProgram.Backup.BackupTemplate&gt;
            if (CSettings.Default.SavedTemplates == null)
            {
                CSettings.Default.SavedTemplates = new List<BackupTemplate>();
            }
        }

        /// <summary>
        /// get template from settings by its name
        /// null if template doesn't exist or settings null
        /// </summary>
        public static BackupTemplate GetTemplateByName(string name)
        {
            if (string.IsNullOrEmpty(name) || CSettings.Default.SavedTemplates == null)
            {
                return null;
            }
            foreach (BackupTemplate template in CSettings.Default.SavedTemplates)
            {
                if (template.BackupName == name)
                {
                    return template;
                }
            }
            return null;
        }


        /// <summary>
        /// add template to settings + check name of it
        /// </summary>
        public bool AddTemplate(BackupTemplate template)
        {
            //check if name is valid
            foreach (BackupTemplate checkName in CSettings.Default.SavedTemplates)
            {
                if (checkName.Equals(template))
                {
                    communication.SendOutput("[Templates] Backup name already exists: " + template.BackupName + ", try a different name");
                    return false;
                }
            }

            // save settings here
            CSettings.Default.SavedTemplates.Add(template);
            CSettings.Default.Save();

            return true;
        }

        /// <summary>
        /// create template by input
        /// </summary>
        public bool AddTemplate(string name, string addpaths, string excludepaths, string typeFilter, bool invertType)
        {
            // check that inputs are not empty
            if (string.IsNullOrWhiteSpace(name))
            {
                communication.SendOutput("[Templates] Enter a template name", true);
                return false;
            }
            if (string.IsNullOrWhiteSpace(addpaths))
            {
                communication.SendOutput("[Templates] Select at least one path", true);
                return false;
            }

            // make sure the name has no special characters (will be used for creating folder)
            name = System.Text.RegularExpressions.Regex.Replace(name, "[^a-zA-Z0-9]", "_");

            // create + save template
            BackupTemplate template = new BackupTemplate(name, addpaths, excludepaths, typeFilter, invertType);

            if (!AddTemplate(template))
            {
                return false;
            }

            communication.SendOutput("[Templates] Created backup template " + template.BackupName);
            return true;
        }

        /// <summary>
        /// remove + add template
        /// </summary>
        public bool ReplaceTemplate(string previousTemplateName, string name, string addpaths, string excludepaths, string typeFilter, bool invertType)
        {
            RemoveTemplate(previousTemplateName);

            if (AddTemplate(name, addpaths, excludepaths, typeFilter, invertType))
            {
                communication.SendOutput("[Templates] Successfully replaced template");
                return true;
            }
            else
            {
                communication.SendOutput("[Templates] Could not replace template");
                return false;
            }
        }

        /// <summary>
        /// remove templates from settings
        /// </summary>
        public bool RemoveTemplate(string templateName)
        {
            BackupTemplate remove = GetTemplateByName(templateName);
            if (remove == null)
            {
                communication.SendOutput("[Templates] Can't remove template that does not exist", true);
                return false;
            }
            if (CSettings.Default.SavedTemplates.Remove(remove))
            {
                communication.SendOutput("[Templates] Removed template " + remove.BackupName);
                return true;
            }
            else
            {
                communication.SendOutput("[Templates] Could not remove template from settings");
                return false;
            }

        }

        #region import_export

        /// <summary>
        /// get xml text from all saved templates
        /// </summary>
        public string AllTemplatesToXML()
        {
            if (SavedTemplatesCount() < 1)
            {
                return "[Export] no templates saved to export";
            }
            string output = string.Empty;

            foreach (BackupTemplate template in CSettings.Default.SavedTemplates)
            {
                output += template.ToXML();
            }

            return output;
        }

        /// <summary>
        /// import templates from xml
        /// </summary>
        public bool ImportFromXML(string txtTemplate)
        {
            if (string.IsNullOrWhiteSpace(txtTemplate) || !txtTemplate.Contains(SplitExport))
            {
                communication.SendOutput("[Import] nothing to import");
                return false;
            }

            int countBefore = SavedTemplatesCount();

            List<string> importTemplates = txtTemplate.Split(new string[] { SplitExport }, StringSplitOptions.RemoveEmptyEntries).ToList();

            bool flag = true;

            foreach (string s in importTemplates)
            {
                if (!AddTemplate(BackupTemplate.FromXML(s)))
                {
                    flag = false;
                }
            }

            if (countBefore == SavedTemplatesCount())
            {
                communication.SendOutput("[Import] 0 templates were imported", true);
                return false;
            }
            else
            {
                communication.SendOutput("[Import] Imported " + (SavedTemplatesCount() - countBefore) + " templates");
            }
            return flag;
        }

        protected int SavedTemplatesCount()
        {
            return (CSettings.Default.SavedTemplates != null) ? CSettings.Default.SavedTemplates.Count : 0;
        }

        #endregion
    }
}
