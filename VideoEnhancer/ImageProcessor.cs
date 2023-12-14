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
using Emgu.CV.CvEnum;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace VideoEnhancer
{
    public partial class ImageProcessor : Form
    {
        public Image Image { get; private set; }
        public Image ProcessedImage { get; private set; }

        // Color space conversion
        private bool _showChannel1, _showChannel2, _showChannel3;
        private ColorConversion _colorConversion = ColorConversion.Bgr2Rgb;

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
            this.saveFileDialog1.Filter = "Image Files (*.png, *.jpg, *.jpeg)| *.png;*.jpg;*.jpeg";
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(this.saveFileDialog1.FileName, ImageFormat.Jpeg);
                // Close();
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

        private void channelOneButton_Click(object sender, EventArgs e)
        {
            channelOneButton.Enabled = false;
            channelTwoButton.Enabled = true;
            channelThreeButton.Enabled = true;
            _showChannel1 = true;
            _showChannel2 = false;
            _showChannel3 = false;
        }

        private void channelTwoButton_Click(object sender, EventArgs e)
        {
            channelOneButton.Enabled = true;
            channelTwoButton.Enabled = false;
            channelThreeButton.Enabled = true;
            _showChannel1 = false;
            _showChannel2 = true;
            _showChannel3 = false;
        }

        private void channelThreeButton_Click(object sender, EventArgs e)
        {
            channelOneButton.Enabled = true;
            channelTwoButton.Enabled = true;
            channelThreeButton.Enabled = false;
            _showChannel1 = false;
            _showChannel2 = false;
            _showChannel3 = true;
        }

        private void colorSpaceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Reset the selected color channel
            _showChannel1 = false;
            _showChannel2 = false;
            _showChannel3 = false;

            var domain = colorSpaceComboBox.Text;
            if (domain == "BGR")
            {
                UpdateChannels("Blue", "Green", "Red");
                return;
            }

            var domains = Constants.ColorDomains;
            if (domains.ContainsKey(domain))
            {
                switch (domain)
                {
                    case "RGB":
                        _colorConversion = ColorConversion.Bgr2Rgb;
                        break;
                    case "HSV":
                        _colorConversion = ColorConversion.Bgr2Hsv;
                        break;
                    case "LAB":
                        _colorConversion = ColorConversion.Bgr2Lab;
                        break;
                    case "GRAY":
                        _colorConversion = ColorConversion.Bgr2Gray;
                        break;
                }
            }
            if (_colorConversion == ColorConversion.Bgr2Gray)
            {
                UpdateChannels(domains[domain][0], "", "", true, false, false);
                return;
            }

            UpdateChannels(domains[domain][0], domains[domain][1], domains[domain][2]);
            // ProcessedImage = CvInvoke.CvtColor(Image, ProcessedImage, _colorConversion);
        }

        private void UpdateChannels(string channel1, string channel2, string channel3, bool btn1 = true, bool btn2 = true, bool btn3 = true)
        {
            channelOneButton.Text = channel1;
            channelTwoButton.Text = channel2;
            channelThreeButton.Text = channel3;

            channelOneButton.Enabled = btn1;
            channelOneButton.Visible = btn1;
            channelTwoButton.Enabled = btn2;
            channelTwoButton.Visible = btn2;
            channelThreeButton.Enabled = btn3;
            channelThreeButton.Visible = btn3;
        }

        private void colorCancelButton_Click(object sender, EventArgs e)
        {
            HideChannelButtons();
            _showChannel1 = _showChannel2 = _showChannel3 = false;
            splitChannelsButton.Enabled = true;
            pictureBox1.Image = Image;
        }

        private void HideChannelButtons()
        {
            channelOneButton.Text = "";
            channelOneButton.Enabled = false;
            channelOneButton.Visible = false;

            channelTwoButton.Text = "";
            channelTwoButton.Enabled = false;
            channelTwoButton.Visible = false;

            channelThreeButton.Text = "";
            channelThreeButton.Enabled = false;
            channelThreeButton.Visible = false;

            colorCancelButton.Enabled = false;
            colorCancelButton.Visible = false;

            colorSpaceComboBox.Text = "";
            colorSpaceComboBox.Enabled = false;
            colorSpaceComboBox.Visible = false;
        }
    }
}
