using Emgu.CV;
using Emgu.CV.CvEnum;

namespace VideoEnhancer
{
    public partial class Form1 : Form
    {
        private VideoCapture _videoCapture;

        public Form1()
        {
            InitializeComponent();
        }

        

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Video Files (*.mp4, *.avi,  *.flv)| *.mp4;*.avi*.flv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Mat frame = new Mat();
                _videoCapture = new VideoCapture(ofd.FileName);
                {
                    videoPlayerImageBox.Image = frame.ToBitmap();
                    frame.Dispose();
                }
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            // TODO: Implement something here..
        }     
    }
}