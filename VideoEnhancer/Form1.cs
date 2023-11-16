using Emgu.CV;
using Emgu.CV.CvEnum;

namespace VideoEnhancer
{
    public partial class Form1 : Form
    {
        public static bool EMULATE { get; private set; } = true;

        private VideoCapture _videoCapture;

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
                    videoPlayerImageBox.Image = frame.ToBitmap();
                    int inputFPS = Convert.ToInt32(_videoCapture.Get(CapProp.Fps));
                    inputFPSLabel.Text = $"FPS: {inputFPS}";
                    inputResLabel.Text = $"{frame.Width}x{frame.Height}";
                    frame.Dispose();
                }
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            // TODO: Implement something here..
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
    }
}