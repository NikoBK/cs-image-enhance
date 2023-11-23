using Emgu.CV;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Threading;
using Emgu.CV.CvEnum;
using System.Windows.Forms;

namespace VideoEnhancer
{
    public partial class Test : Form
    {
        public ConcurrentQueue<Bitmap> InputQueue { get; private set; }
        public ConcurrentQueue<Bitmap> OutputQueue { get; private set; }
        public ConcurrentQueue<(Bitmap input, Bitmap output)> ProcessQueue { get; private set; }
        private VideoCapture _capture;

        public int TrackBarValue;

        private DateTime _lastOutput;

        public Test()
        {
            InitializeComponent();

            // Try to match the tick speed of the processing thread
            timer1.Interval = 30;

            // Setup queues
            InputQueue = new ConcurrentQueue<Bitmap>();
            OutputQueue = new ConcurrentQueue<Bitmap>();
            ProcessQueue = new ConcurrentQueue<(Bitmap, Bitmap)>();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string dt_prefix = $"[{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}:{DateTime.Now.Millisecond}]";

            if (ProcessQueue.TryDequeue(out var pair))
            {
                pictureBox1.Image?.Dispose();
                pictureBox2.Image?.Dispose();

                var input = pair.input;
                var output = pair.output;
                pictureBox1.Image = input;
                pictureBox2.Image = output;
            }
        }

        private void Capture_ImageGrabbed(object sender, EventArgs e)
        {
            try
            {
                var dt = DateTime.Now;
                string dt_prefix = $"[{dt.Hour}:{dt.Minute}:{dt.Second}:{dt.Millisecond}]";
                var diff = dt - _lastOutput;

                if (diff.TotalMilliseconds < Constants.MSPT)
                {
                    Thread.Sleep((int)(Constants.MSPT - diff.TotalMilliseconds));
                    dt = DateTime.Now;
                }
                else if (diff.TotalMilliseconds > Constants.MSPT)
                {
                    Debug.WriteLine($"Skipped frame at {dt_prefix}");
                    _lastOutput += TimeSpan.FromMilliseconds(Constants.MSPT);
                    return;
                }

                Debug.WriteLine($"{dt_prefix}video capture tick!");
                // Debug.WriteLine("VideoCapture thread tick");
                using Mat frame = new Mat();
                _capture.Retrieve(frame);
                CvInvoke.Resize(frame, frame, new Size(1920, 1080));

                // Debug.WriteLine($"width: {frame.Width}, height: {frame.Height}");
                using Mat smoothFrame = new Mat();
                CvInvoke.GaussianBlur(frame, smoothFrame, new Size(17, 17), 0);
                ProcessQueue.Enqueue((input: frame.ToBitmap(), output: smoothFrame.ToBitmap()));

                //// The processing thread needs this.
                //InputQueue.Enqueue(frame.ToBitmap());

                //// Imagine this was actually processed with some filter or something
                //OutputQueue.Enqueue(frame.ToBitmap());
                _lastOutput = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception Catch", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Video Files (*.mp4, *.avi,  *.flv)| *.mp4;*.avi*.flv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _lastOutput = DateTime.Now;
                _capture = new VideoCapture(ofd.FileName);

                _capture.ImageGrabbed += Capture_ImageGrabbed;
                _capture.Start();
                timer1.Start();
            }
        }
    }
}
