/*
    file: ImageProcessor.cs
    author: NikoBK
    created on: nov 22 2023
*/
using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing.Imaging;
using System.Security.Cryptography;
using ImageMagick;
using System.Text.RegularExpressions;

namespace VideoEnhancer
{
    public partial class ImageProcessor : Form
    {
        public Image Image { get; private set; }

        public ImageProcessor()
        {
            InitializeComponent();
        }

        public void CacheFrame(Image img)
        {
            Image = (Image)img.Clone();
            SetImage(Image);
        }

        private void SetImage(Image img)
        {
            pictureBox1.Image = img;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.FileName = "Screenshot";
            this.saveFileDialog1.Filter = "Image Files (*.png, *.jpg, *.jpeg)| *.png;*.jpg*.jpeg";
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(this.saveFileDialog1.FileName, ImageFormat.Jpeg);
                Close();
            }
        }

        private void liquidRescaleButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Video Files (*.png, *.jpg,  *.jpeg)| *.png;*.jpg*.jpeg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using var img = new MagickImage(ofd.FileName);
                img.LiquidRescale(new Percentage(30), new Percentage(30), 1, 0);
                img.Scale(img.BaseWidth, img.BaseHeight);

                using (var stream = new MemoryStream())
                {
                    // Write the image to the memorystream
                    img.Write(stream);
                    try
                    {
                        pictureBox1.Image = new Bitmap(stream);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Could not process image", "Invalid Parameter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
    }
}
