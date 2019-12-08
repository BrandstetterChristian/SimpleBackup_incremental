using System.Collections.Generic;
using System.Configuration;

namespace BackupProgram
{
    sealed class CSettings : ApplicationSettingsBase
    {
        // a static instance of this settings
        public static readonly CSettings Default = new CSettings();

        // settings:
        [UserScopedSetting()]
        public List<Backup.BackupTemplate> SavedTemplates
        {
            get
            {
                return (List<Backup.BackupTemplate>)this["SavedTemplates"];
            }
            set
            {
                this["SavedTemplates"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("0")]
        public int LastUsedTemplate
        {
            get
            {
                return (int)this["LastUsedTemplate"];
            }
            set
            {
                this["LastUsedTemplate"] = value;
            }
        }

     

        [UserScopedSetting()]
        [DefaultSettingValue("")]
        public string DestinationPath
        {
            get
            {
                return (string)this["DestinationPath"];
            }
            set
            {
                this["DestinationPath"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("")]
        public string RestorePath
        {
            get
            {
                return (string)this["RestorePath"];
            }
            set
            {
                this["RestorePath"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("False")]
        public bool OnlyChanged
        {
            get
            {
                return (bool)this["OnlyChanged"];
            }
            set
            {
                this["OnlyChanged"] = value;
            }
        }
    }
}
