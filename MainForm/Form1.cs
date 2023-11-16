using Emgu.CV;

namespace MainForm
{
    public partial class Form1 : Form
    {
        private VideoCapture _videoCapture;
        private bool _isPlaying = false;
        private int _totalFrames;
        private int _currentFrameNo;
        private Mat currentFrame;
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

            if (ofd.ShowDialog() == DialogResult.OK) {
                _videoCapture = new VideoCapture(ofd.FileName);
                _totalFrames = Convert.ToInt32(_videoCapture)
            }
        }
    }
}