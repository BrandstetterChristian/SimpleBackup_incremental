using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupProgram.Backup
{
    /// <summary>
    /// interface for sending messages from the backup to the windows form
    /// </summary>
    public interface ICommunication
    {
        void SendOutput(string message, bool isError = false);

        void OnBackupProgressChanged(string progress);

        void OnRestoreProgressChanged(string progress);
    }
}
