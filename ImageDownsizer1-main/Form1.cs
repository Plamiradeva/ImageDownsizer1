using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageDownsizer
{
    public partial class Form1 : Form
    {
        private Bitmap originalImage;
        private Bitmap downScaledImage;

        public Form1()
        {
            InitializeComponent();
        }

        private void chooseImgBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    originalImage = new Bitmap(openFileDialog.FileName);
                    pictureBox.Image = originalImage;
                }
            }
        }

        private void downscaleBtn_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Please select an image first.");
                return;
            }

            if (!double.TryParse(txtPercentage.Text, out double downscaleFactor))
            {
                MessageBox.Show("Invalid downscaling factor.");
                return;
            }

            bool isParallel = parallelBtn.Checked;

            if (isParallel)
            {
                downScaledImage = ParallelDownscale(originalImage, downscaleFactor);
            }
            else
            {
                downScaledImage = ConsecutiveDownscale(originalImage, downscaleFactor);
            }

            pictureBox.Image = downScaledImage;
        }
        private Bitmap ConsecutiveDownscale(Bitmap original, double downscaleFactor)
        {
            int Widthnew = (int)(original.Width * (downscaleFactor / 100));
            int Heightnew = (int)(original.Height * (downscaleFactor / 100));

            Bitmap downScaled = new Bitmap(Widthnew, Heightnew);

            for (int x = 0; x < Widthnew; x++)
            {
                for (int y = 0; y < Heightnew; y++)
                {
                    int Xorig = (int)(x / downscaleFactor);
                    int Yorig = (int)(y / downscaleFactor);
                    downScaled.SetPixel(x, y, original.GetPixel(Xorig, Yorig));
                }
            }
            return downScaled;
        }
        private Bitmap ParallelDownscale(Bitmap original, double downscaleFactor)
        {
            int Widthnew = (int)(original.Width * (downscaleFactor / 100));
            int Heightnew = (int)(original.Height * (downscaleFactor / 100));

            Bitmap downScaled = new Bitmap(Widthnew, Heightnew);

            Parallel.For(0, Widthnew, x =>
            {
                for (int y = 0; y < Heightnew; y++)
                {
                    int Xorig = (int)(x / downscaleFactor);
                    int Yorig = (int)(y / downscaleFactor);
                    downScaled.SetPixel(x, y, original.GetPixel(Xorig, Yorig));
                }
            });
            return downScaled;
        }
    }
}
