using Emgu.CV;
using Emgu.CV.CvEnum;

namespace MainForm
{
    public partial class Form1 : Form
    {
        private VideoCapture _videoCapture;
        private bool _isPlaying = false;
        private int _totalFrames;
        private int _currentFrameNo;
        private Mat _currentFrame;
        public int FPS { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            string path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/udnerwater-drone-backup/res/vid";
            VideoCapture vid = new VideoCapture($"{path}/jammerbugt.mp4");

        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Video Files (*.mp4, *.avi, *.flv)| *.mp4;*.avi*.flv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _videoCapture = new VideoCapture(ofd.FileName);

                // GetCaptureProperty() -> Get()
                _totalFrames = Convert.ToInt32(_videoCapture.Get(CapProp.FrameCount));
                FPS = Convert.ToInt32(_videoCapture.Get(CapProp.Fps));
                _videoCapture.Set(CapProp.FrameWidth, 1280);
                _videoCapture.Set(CapProp.FrameHeight, 720);
                _isPlaying = true;
                _currentFrame = new Mat();
                _currentFrameNo = 0;
                // TODO: Play the video (if we want autoplay)
            }
        }

        private async void PlayVideo()
        {
            if (_videoCapture == null)
            {
                DisplayError("Video Read Error", "There was an issue reading the video file. Please try again.");
                return;
            }

            // Try to load and parse the video
            try
            {
                while (_isPlaying == true && _currentFrameNo < _totalFrames)
                {
                    // SetCaptureProperty() -> Set()
                    _videoCapture.Set(CapProp.PosFrames, _currentFrameNo);
                    _videoCapture.Read(_currentFrame);
                    _currentFrame.ToBitmap().SetResolution(100, 100);

                    // .Bitmap -> .ToBitmap()
                    videoPlayerImageBox.Image = _currentFrame.ToBitmap();

                    _currentFrameNo += 1;
                    await Task.Delay(1000 / FPS);
                }
            }
            catch (Exception ex)
            {
                DisplayError("Exception Encounter", ex.Message);
            }
        }

        private void PauseVideo()
        {

        }

        private void StopVideo()
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DisplayError(string title, string message)
        {
            MessageBox.Show(title, message, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (_videoCapture != null)
            {
                _isPlaying = true;
                PlayVideo();
            }
            else
            {
                _isPlaying = false;
                DisplayError("Play Error", "Something went wrong trying to play a video.");
            }
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            _isPlaying = false;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            _isPlaying = false;
            _currentFrameNo = 0;
            videoPlayerImageBox.Image = null;
            videoPlayerImageBox.Invalidate();
        }
    }
}