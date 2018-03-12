using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FtpDownLoad
{
    public class DownloadModel: INotifyPropertyChanged
    {
        #region public property
        public string TransferRate { get { return transferRate; } set { transferRate = value; this.OnPropertyChanged(); } }
        public string EstimatedTimeLeft { get { return timeLeft; } set { timeLeft = value; OnPropertyChanged(); } }
        public string DownLoadedBytes { get { return downloadedBytes; } set { downloadedBytes = value; this.OnPropertyChanged(); } }
        public int PercentLoaded { get { return percentLoaded; } set { percentLoaded = value; this.OnPropertyChanged(); } }
        public bool IsAccess { get { return isAccess; } set { isAccess  = value; OnPropertyChanged(); } }
        public long TotalBytesToReceive { get { return totalBytesToReceive; } set { totalBytesToReceive = value; OnPropertyChanged(); } }
        #endregion

        #region private property
        private long totalBytesToReceive;
        private bool isAccess;
        private string timeLeft;
        private string downloadedBytes;
        private string transferRate;
        private int percentLoaded;
        #endregion

        #region constructors
        public DownloadModel()
        {
            this.IsAccess = true;
        }
        #endregion

        #region events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region private methods
        private void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        #endregion
    }
}
