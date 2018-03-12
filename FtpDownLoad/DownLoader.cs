using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace FtpDownLoad
{
    public sealed class DownLoader
    {
        #region public property
        public DownloadModel Model { get; private set; }
        #endregion

        #region private field
        private string FtpServer;
        private Stopwatch Timer;
        #endregion

        #region constructors
        public DownLoader(string ftpServer){
            Model = new DownloadModel();
            FtpServer = ftpServer;
            Timer = new Stopwatch();
            
        }
        #endregion

        #region private methods
        private void Refresh()
        {
            Timer.Reset();
            Model.IsAccess = true;
        }

        private string GetPath(string fileName)
        {
            var fullPath = Path.Combine(Environment.CurrentDirectory, fileName);
            if (File.Exists(fullPath))
                File.Delete(fullPath);
            return fullPath;
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.Model.TransferRate = string.Format("{0} b/s", (e.BytesReceived / Timer.Elapsed.TotalSeconds).ToString("0.00"));
            this.Model.EstimatedTimeLeft = ((Model.TotalBytesToReceive - e.BytesReceived) / (e.BytesReceived / Timer.Elapsed.TotalSeconds)).ToString("0.00");
            this.Model.DownLoadedBytes = e.BytesReceived.ToString();
            this.Model.PercentLoaded = (int)(((e.BytesReceived * 100) / Model.TotalBytesToReceive));
        }
        #endregion

        #region public methods
        public async Task Download() {
            Model.IsAccess = false;
            try
            {
                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(new Uri(this.FtpServer));
                request.Method = WebRequestMethods.Ftp.GetFileSize;
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    Model.TotalBytesToReceive = response.ContentLength;
                    using (WebClient client = new WebClient())
                    {
                        client.DownloadProgressChanged += Client_DownloadProgressChanged;
                        client.DownloadFileCompleted += (sender, e) => this.Refresh();
                        Timer.Start();
                        await client.DownloadFileTaskAsync(this.FtpServer, GetPath(Path.GetFileName(this.FtpServer)));
                    }
                }
            }
            catch {
                this.Refresh();
                throw;
            }
        }
        #endregion
    }

    
}
