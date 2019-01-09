using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncHalf
{
    public partial class Form1 : Form
    {
        private ImageHelper _imageHelper;
        public Form1()
        {
            InitializeComponent();
            _imageHelper = new ImageHelper(progressBar1, pictureBox1);
            pictureBox1.ImageLocation = "./img.jpg"; //path to image
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            _imageHelper.RunWorkerAsync();
        }
    }
}
