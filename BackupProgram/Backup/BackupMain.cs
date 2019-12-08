using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using BackupProgram.Backup.Copying;

namespace BackupProgram.Backup
{
    /// <summary>
    /// main class for doing backups, contains all needed instances
    /// </summary>
    public class BackupMain
    {
        protected ICommunication communication;
        public BackupDialoges Dialoges { get; }

        public TemplateHandler Templates { get; }

        public ExecuteBackup Backup { get; }

        public RestoreBackup Restore { get; }


        public BackupMain(ICommunication comm)
        {
            communication = comm;
            

            Dialoges = new BackupDialoges();
            Templates = new TemplateHandler(comm);
            Backup = new ExecuteBackup(comm);
            Restore = new RestoreBackup(comm);
        }


    }
}
