using Emgu.CV;
using Emgu.CV.CvEnum;
using System.Drawing;

namespace VideoEnhancer
{
    public partial class Form1 : Form
    {
        public static bool EMULATE { get; private set; } = true;

        private VideoCapture _videoCapture;
        private bool _streamVideo = false;
        private bool _videoLoaded = false;

        public Form1()
        {
            InitializeComponent();
            renderMethodComboBox.Text = "GPU";
            filterComboBox.Text = "NONE";
            inputFPSLabel.Text = "FPS: 0";
            postProcessFPSLabel.Text = "FPS: 0";
            inputFeedLabel.Visible = true;
            postProcessFeedLabel.Visible = true;
            inputResLabel.Text = "0x0";
            outputResLabel.Text = "0x0";
        }

        /// NOTES
        /// Notes: Video 2 at about 7:00 he explains how to extract properties, look into this.
        /// It should be tested with the drone before shipped. Look into backends too around the same
        /// time right after.

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Video Files (*.mp4, *.avi,  *.flv)| *.mp4;*.avi*.flv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Remove the "No feed..." labels.
                inputFeedLabel.Visible = false;
                postProcessFeedLabel.Visible = false;

                Mat frame = new Mat();
                _videoCapture = new VideoCapture(ofd.FileName);
                bool readSuccess = _videoCapture.Read(frame);
                if (readSuccess)
                {
                    //videoPlayerImageBox.Image = frame.ToBitmap();
                    //int inputFPS = Convert.ToInt32(_videoCapture.Get(CapProp.Fps));
                    //inputFPSLabel.Text = $"FPS: {inputFPS}";
                    //inputResLabel.Text = $"{frame.Width}x{frame.Height}";
                    //frame.Dispose();
                    _videoLoaded = true;
                }
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (_videoLoaded)
            {
                _streamVideo = true;
                StreamVideo();
                ProcessVideo();
            }
            else
            {
                MessageBox.Show("No video is loaded!", "Error: Invalid Video", MessageBoxButtons.OK);
                return;
            }
        }

        /// <summary>
        /// TODO: Needs to be tested with the drone.
        /// </summary>
        private void GetCameraProperties()
        {
            foreach (var prop in Enum.GetValues(typeof(CapProp)))
            {
                double propVal = _videoCapture.Get((CapProp)prop);
                if (propVal != -1)
                {
                    var propStr = $"{prop}: {propVal}\r\n";
                    MessageBox.Show("Property", propStr, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // TODO: Add to some data source or whatever.
                }
            }
            // TODO: Check to possibly append a final "\r\n" str.
        }

        /// <summary>
        /// Keep video stream async from UI operations to reduce lag.
        /// </summary>
        public async void StreamVideo()
        {
            while (_streamVideo)
            {
                var frameSize = new Size(1920, 1080);

                // Capture a new Mat array from the default camera
                // Mat frame = new Mat(frameSize, DepthType.Default, 1);
                Mat frame = new Mat();
                _videoCapture.Read(frame);
                int inputFPS = Convert.ToInt32(_videoCapture.Get(CapProp.Fps));

                // Define a new System.Drawing "Size" object to resize the
                // captured Mat, then resize the Mat
                CvInvoke.Resize(frame, frame, frameSize);

                // Convert the Mat to a bitmap to display in the pictureBox
                var img = frame.ToBitmap();
                videoPlayerImageBox.Image = img;

                // Always update labels at last in the while loop
                inputFPSLabel.Text = $"FPS: {inputFPS}";
                inputResLabel.Text = $"{frame.Width}x{frame.Height}";

                // Assuming it runs at 60fps
                await Task.Delay(16);
            }
        }

        private async void ProcessVideo()
        {
            // TODO: Implement something.
        }
    }
}