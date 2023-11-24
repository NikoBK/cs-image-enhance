/*
    file: Test.cs
    author: nikobk
    created on: nov 22 2023
*/
using Emgu.CV;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace VideoEnhancer
{
    public partial class MainForm : Form
    {
        // Video Processing
        public ConcurrentQueue<(Bitmap input, Bitmap output)> ProcessQueue { get; private set; }
        private VideoCapture? _capture;
        private DateTime _lastOutput;

        // Controls
        public int TrackBarValue;

        public MainForm()
        {
            InitializeComponent();

            // Setup form controls
            uiTimer.Interval = Constants.UITimerInterval;
            ProcessQueue = new ConcurrentQueue<(Bitmap, Bitmap)>();
        }

        /// <summary>
        /// <see cref="uiTimer"/> acts as a tick loop for the
        /// application's UI/Main -Thread and is responseable for
        /// updating all UI to ensure thread safety.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiTimer_Tick(object sender, EventArgs e)
        {
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

        /// <summary>
        /// The video capture event for OpenCV's <see cref="VideoCapture"/> object.
        /// This is called everytime a frame is read from the file/stream.
        /// Note that if a file is being read then the <see cref="VideoCapture"/> object
        /// will read it as fast as possible making it neccessary to ensure the
        /// capture speed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Capture_ImageGrabbed(object sender, EventArgs e)
        {
            try
            {
                var dt = DateTime.Now;
                string dt_prefix = $"[{dt.Hour}:{dt.Minute}:{dt.Second}:{dt.Millisecond}]";
                var diff = dt - _lastOutput;

                // Sleep for the difference in time on a tick basis if the
                // video processing is ahead of the framecount.
                if (diff.TotalMilliseconds < Constants.MSPerTick)
                {
                    Thread.Sleep((int)(Constants.MSPerTick - diff.TotalMilliseconds));
                    dt = DateTime.Now;
                }
                // If the processing falls behind skip the frame to ensure
                // that we keep up with the stream of framedata.
                else if (diff.TotalMilliseconds > Constants.MSPerTick)
                {
                    Debug.WriteLine($"{dt_prefix}Skipped frame");
                    _lastOutput += TimeSpan.FromMilliseconds(Constants.MSPerTick);
                    return;
                }
                Debug.WriteLine($"{dt_prefix}video capture tick!");

                // Auto-dispose objects with .NET Core's using object.
                using Mat frame = new Mat();
                _capture.Retrieve(frame);
                CvInvoke.Resize(frame, frame, new Size(1920, 1080));

                // Auto-dispose objects with .NET Core's using object.
                using Mat smoothFrame = new Mat();
                CvInvoke.GaussianBlur(frame, smoothFrame, new Size(17, 17), 0);
                ProcessQueue.Enqueue((input: frame.ToBitmap(), output: smoothFrame.ToBitmap()));

                // Update the time when the frame should have been processed.
                _lastOutput = dt;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Exception Catch", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// TODO: Should just start a video stream considering some
        /// capture device has been connected at the time of pressing
        /// this button. This code can be ported to the Export button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                uiTimer.Start();
            }
        }
    }
}
