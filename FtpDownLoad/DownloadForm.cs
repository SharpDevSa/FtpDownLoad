using System;
using System.Windows.Forms;

namespace FtpDownLoad
{
    public partial class DownloadForm : Form
    {
        #region ViewModel
        DownLoader loader = new DownLoader(Properties.Settings.Default.FtpImg);
        #endregion
        #region Consturctors
        public DownloadForm()
        {
            InitializeComponent();
            this.Bindings();
        }
        #endregion
        #region private methods
        public void Bindings() {
            this.DownLoadProgress.DataBindings.Add(new Binding("Value", this.loader.Model, "PercentLoaded"));
            this.TransRateValue.DataBindings.Add(new Binding("Text", this.loader.Model, "TransferRate"));
            this.EstTimeValue.DataBindings.Add(new Binding("Text", this.loader.Model, "EstimatedTimeLeft"));
            this.DownBytesValue.DataBindings.Add(new Binding("Text", this.loader.Model, "DownLoadedBytes"));
            this.StartBtn.DataBindings.Add(new Binding("Enabled", this.loader.Model, "IsAccess"));
        }

        private async void  StartBtn_Click(object sender, EventArgs e)
        {
            try
            {
                await loader.Download();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
