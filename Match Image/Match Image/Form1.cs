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

namespace Match_Image
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_snipImage1_Click(object sender, EventArgs e)
        {
            Image image;
            Rectangle rcSelect;
            this.Hide();
            Thread.Sleep(1000);
            if (SnippingTool.Snip(out image, out rcSelect))
            {
                if (image != null)
                {
                     pictureBox_snip1.Image = image;
                }
                this.Show();
            }
        }

        private void button_snipImage2_Click(object sender, EventArgs e)
        {
            Image image;
            Rectangle rcSelect;
            this.Hide();
            Thread.Sleep(1000);
            if (SnippingTool.Snip(out image, out rcSelect))
            {
                if (image != null)
                {
                    pictureBox_snip2.Image = image;
                }
                this.Show();
            }
        }

        private void button_notMatch_Click(object sender, EventArgs e)
        {
            Image image1 = pictureBox_snip1.Image;
            Image image2 = pictureBox_snip2.Image;
            Image matchImage = subImage(image1, image2, 0, 0, 0, 0);
            
            //show result
            DialogResult dr;
            ResultForm resultForm = new ResultForm(matchImage);
            dr = resultForm.ShowDialog();

        }

        private Image subImage(Image image1, Image image2, int startXImage1, int startYImage1, int startXImage2, int startYImage2)
        {
            Bitmap bmpImage1 = (Bitmap)image1;
            Bitmap bmpImage2 = (Bitmap)image2;
            if(bmpImage1 == null || bmpImage2 == null)
            {
                return null;
            }
            Bitmap bmpSubImage;
            if (image1.Width > image2.Width && image1.Height > image2.Height)
            {
                bmpSubImage = (Bitmap)image1.Clone();
            }
            else
            {
                bmpSubImage = (Bitmap)image2.Clone();
            }

            for (int x = 0; x + startXImage1 < image1.Width && x + startXImage2 < image2.Width; x++)
            {
                for (int y = 0; y + startYImage1 < image1.Height && y + startYImage2 < image2.Height; y++)
                {
                    Color pixelImage1 = bmpImage1.GetPixel(x + startXImage1, y + startYImage1);
                    Color pixelImage2 = bmpImage2.GetPixel(x + startXImage2, y + startYImage2);
                    int subR = Math.Abs((int)(pixelImage1.R - pixelImage2.R));
                    int subG = Math.Abs((int)(pixelImage1.G - pixelImage2.G));
                    int subB = Math.Abs((int)(pixelImage1.B - pixelImage2.B));

                    Color subColor = Color.FromArgb(subR, subG, subB);
                    bmpSubImage.SetPixel(x + startXImage2, y + startYImage2, subColor);
                }
            }
            return bmpSubImage;
        }
    }
}
