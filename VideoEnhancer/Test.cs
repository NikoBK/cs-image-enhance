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
        private Thread _procThread;
        private bool _isRunning = false;
        public string _videoFileName { get; private set; }
        private bool _tickReady = false;

        public Test()
        {
            InitializeComponent();

            // Try to match the tick speed of the processing thread
            timer1.Interval = 25;

            // Setup queues
            InputQueue = new ConcurrentQueue<Bitmap>();
            ProcessedQueue = new ConcurrentQueue<Bitmap>();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string dt_prefix = $"[{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}:{DateTime.Now.Millisecond}]";
            Debug.WriteLine($"{dt_prefix}timer1 tick!");
            // Dequeue the input video frames and display them.
            if (InputQueue.Count > 0)
            {
                Bitmap inputBmap;
                if (InputQueue.TryDequeue(out inputBmap))
                {
                    var oldImgInput = pictureBox1.Image;
                    pictureBox1.Image = inputBmap;
                    if (oldImgInput != null)
                    {
                        // Force the cs garbage collector to do his job.
                        using (oldImgInput) { }
                    }
                }
            }

            // Dequeue the processed video frames and display them.
            if (ProcessedQueue.Count > 0)
            {
                Bitmap outputBmap;
                if (ProcessedQueue.TryDequeue(out outputBmap))
                {
                    var oldImgOutput = pictureBox2.Image;
                    pictureBox2.Image = outputBmap;
                    if (oldImgOutput != null)
                    {
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
                if (_streamVideo && TickReady)
                {
                    string dt_prefix = $"[{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}:{DateTime.Now.Millisecond}]";
                    Debug.WriteLine($"{dt_prefix}video capture tick!");
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
                    TickReady = false;
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
                _isRunning = true;
                _streamVideo = true;
                _videoFileName = ofd.FileName;
                _procThread = new Thread(ProcessVideo)
                {
                    Name = "vidproccv",
                    CurrentCulture = CultureInfo.InvariantCulture
                };
                _procThread.Start();
                timer1.Start();
            }
        }

        private void ProcessVideo()
        {
            _capture = new VideoCapture(_videoFileName);
            _capture.ImageGrabbed += Capture_ImageGrabbed;
            _capture.Start();

            Stopwatch sw = new Stopwatch();
            long dt = 0;
            long tickCount = 0;
            sw.Start();

            do
            {
                if (!_isRunning)
                {
                    break;
                }

                long times = dt / Constants.MSPT;
                dt -= times * Constants.MSPT;
                times++;
                long tickTimes = sw.ElapsedMilliseconds;
                tickCount += times;

                if (!TickReady)
                {
                    TickReady = true;
                }

                Thread.Sleep(Constants.MSPT);
                dt += Math.Max(0, sw.ElapsedMilliseconds - tickTimes - Constants.MSPT);
            }
            while (true);
            Debug.WriteLine("Logic loop stopped");
        }

        private Int32 _IsRefreshingDNU;
        /// <summary>
        /// Gets or sets a thread safe (<see cref="Interlocked"/> controlled) manner of specifying whether pollers should exit their loop when they complete/wake up next.
        /// </summary>
        public Boolean TickReady
        {
            get { return (Interlocked.CompareExchange(ref _IsRefreshingDNU, 1, 1) == 1); }
            set
            {
                if (value)
                { Interlocked.CompareExchange(ref _IsRefreshingDNU, 1, 0); }
                else
                { Interlocked.CompareExchange(ref _IsRefreshingDNU, 0, 1); }
            }
        }
    }
}
