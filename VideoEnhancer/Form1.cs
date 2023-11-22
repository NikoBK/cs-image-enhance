using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoEnhancer
{
    public partial class Form1 : Form
    {
        private bool _streamVideo = false;

        public Mat Frame;
        public Size FrameSize = new Size(1920, 1080);
        public VideoCapture VideoCapture;

        public Form1()
        {
            InitializeComponent();
            InitializeUI();
        }

        /// <summary>
        /// Setup all the main form userinterface objects.
        /// </summary>
        private void InitializeUI()
        {
            renderMethodComboBox.Text = "GPU";
            filterComboBox.Text = "NONE";
            inputFPSLabel.Text = "FPS: 0";
            postProcessFPSLabel.Text = "FPS: 0";
            inputFeedLabel.Visible = true;
            postProcessFeedLabel.Visible = true;
            inputResLabel.Text = "0x0";
            outputResLabel.Text = "0x0";
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Video Files (*.mp4, *.avi,  *.flv)| *.mp4;*.avi*.flv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                inputFeedLabel.Visible = false;
                postProcessFeedLabel.Visible = false;
                VideoCapture = new VideoCapture(ofd.FileName);
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            _streamVideo = true;

            // Increase the FPS for better response during processing.
            VideoCapture.Set(CapProp.Fps, 5);

            VideoCapture.ImageGrabbed += Capture_ImageGrabbed;
            VideoCapture.Start();
        }

        private void Capture_ImageGrabbed(object sender, EventArgs e)
        {
            try
            {
                if (_streamVideo)
                {
                    Mat frame = new Mat();
                    Debug.WriteLine("before retrieve frame");
                    VideoCapture.Retrieve(frame);
                    Debug.WriteLine("Hello from event");

                    // Resize the frame for processing.
                    CvInvoke.Resize(frame, frame, FrameSize);

                    // Display the input image on the left picturebox.
                    videoPlayerImageBox.Image = frame.ToBitmap();

                    // Start a new thread for image processing.
                    //ProcessImage();

                    // Dispose each frame to free up memory and reduce lag for processing.
                    frame.Dispose();
                }
            }
            catch(Exception ex) { 
                MessageBox.Show(ex.Message, "Image Grab Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async void ProcessImage()
        {
            await Task.Run(() => EnhanceImage());
        }

        public void EnhanceImage()
        {
            Debug.WriteLine("before capture query frame");
            Frame = VideoCapture.QueryFrame();
            if (Frame == null || Frame.IsEmpty) {
                return;
            }

            Debug.WriteLine("hello");
            CvInvoke.Resize(Frame, Frame, FrameSize);
            postProcessVideoImageBox.Image = Frame.ToBitmap();
            Frame.Dispose();
        }
    }
}