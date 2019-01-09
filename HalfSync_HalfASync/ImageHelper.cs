using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncHalf
{
    class ImageHelper: BackgroundWorker
    {
        private ProgressBar _progressBar;
        private PictureBox _pictureBox;

        public ImageHelper(ProgressBar progressBar, PictureBox pictureBox)
        {
            this.DoWork += imageWorker_DoWork;
            this.ProgressChanged += imagheWorker_ProgressChanged;
            this.WorkerReportsProgress = true;
            _progressBar = progressBar;
            _pictureBox = pictureBox;
        }

        private void imageWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                Uri uri = new Uri("https://www.gettyimages.com/gi-resources/images/CreativeLandingPage/HP_Sept_24_2018/CR3_GettyImages-159018836.jpg");
                client.DownloadFile(uri, @".\image35.png");
                this.ReportProgress(10, @".\image35.png");
            }

            for (int i = 20; i < 100; i++)
            {
                Thread.Sleep(100);
                this.ReportProgress(i, @".\image35.png");
            }
        }

        private void imagheWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            var imagePath = e.UserState;
            _pictureBox.ImageLocation = imagePath.ToString();
            _progressBar.Value = e.ProgressPercentage;
        }
    }
}
