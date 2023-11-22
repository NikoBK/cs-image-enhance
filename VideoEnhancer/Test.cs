using Emgu.CV;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Threading;

namespace VideoEnhancer
{
    public partial class Test : Form
    {
        public ConcurrentQueue<Bitmap> InputQueue { get; private set; }
        public ConcurrentQueue<Bitmap> ProcessedQueue { get; private set; }
        private VideoCapture _capture;
        private bool _streamVideo = false;

        public Test()
        {
            InitializeComponent();

            // Setup queues
            InputQueue = new ConcurrentQueue<Bitmap>();
            ProcessedQueue = new ConcurrentQueue<Bitmap>();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Dequeue the input video frames and display them.
            if (InputQueue.Count > 0)
            {
                Bitmap inputBmap;
                if (InputQueue.TryDequeue(out inputBmap)) {
                    var oldImgInput = pictureBox1.Image;
                    pictureBox1.Image = inputBmap;
                    if (oldImgInput != null) {
                        // Force the cs garbage collector to do his job.
                        using (oldImgInput) { }
                    }
                }
            }

            // Dequeue the processed video frames and display them.
            if (ProcessedQueue.Count > 0)
            {
                Bitmap outputBmap;
                if (ProcessedQueue.TryDequeue(out outputBmap)) {
                    var oldImgOutput = pictureBox2.Image;
                    pictureBox2.Image = outputBmap;
                    if (oldImgOutput != null) {
                        // Force the cs garbage collector to do his job.
                        using (oldImgOutput) { }
                    }
                }
            }
        }

        private void Capture_ImageGrabbed(object sender, EventArgs e)
        {
            try
            {
                if (_streamVideo)
                {
                    // Debug.WriteLine("VideoCapture thread tick");
                    Mat frame = new Mat();
                    _capture.Retrieve(frame);
                    CvInvoke.Resize(frame, frame, new Size(1280, 720));

                    // Debug.WriteLine($"width: {frame.Width}, height: {frame.Height}");

                    // The processing thread needs this.
                    InputQueue.Enqueue(frame.ToBitmap());

                    // Imagine this was actually processed with some filter or something
                    ProcessedQueue.Enqueue(frame.ToBitmap());

                    frame.Dispose();
                }
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
                _streamVideo = true;
                _capture = new VideoCapture(ofd.FileName);
                _capture.ImageGrabbed += Capture_ImageGrabbed;
                _capture.Start();
                timer1.Start();
            }
        }
    }
}
