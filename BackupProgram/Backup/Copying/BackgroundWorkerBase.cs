using System.ComponentModel;

namespace BackupProgram.Backup.Copying
{
    /// <summary>
    /// abstract class for implementation of a background worker
    /// </summary>
    public abstract class BackgroundWorkerBase
    {
        // background worker
        protected BackgroundWorker bgrWorker;

        public BackgroundWorkerBase()
        {
            bgrWorker = new BackgroundWorker();
            bgrWorker.DoWork += WorkerDoWork;
            bgrWorker.WorkerSupportsCancellation = true;

            bgrWorker.WorkerReportsProgress = true;
            bgrWorker.ProgressChanged += OnWorkerProgressChanged;
        }

        /// <summary>
        /// cancel the worker if it is running
        /// </summary>
        /// <returns> if anything was cancelled </returns>
        public bool CancelBackup()
        {
            if (bgrWorker.IsBusy)
            {
                bgrWorker.CancelAsync();
                OnBackupCancelled();
                return true;
            }
            return false;
        }

        /// <summary>
        /// check if the worker is running at the moment
        /// </summary>
        /// <returns> IsBusy </returns>
        public bool IsWorkerBusy()
        {
            return bgrWorker.IsBusy;
        }

        /// <summary>
        /// called in CancelBackup()
        /// </summary>
        protected abstract void OnBackupCancelled();

        /// <summary>
        /// called by bgrWorker.ReportProgress(int)
        /// </summary>
        protected abstract void OnWorkerProgressChanged(object sender, ProgressChangedEventArgs e);

        /// <summary>
        /// do work, bgrWorker.RunWorkerAsync
        /// </summary>
        protected abstract void WorkerDoWork(object sender, DoWorkEventArgs e);

    }
}
