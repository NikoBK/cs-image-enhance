/*
    file: ImageProcessor.cs
    author: NikoBK
    created on: nov 22 2023
*/
using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing.Imaging;
using System.Security.Cryptography;

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
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK) {
                pictureBox1.Image.Save(this.saveFileDialog1.FileName, ImageFormat.Jpeg);
                Close();
            }
        }
    }
}
