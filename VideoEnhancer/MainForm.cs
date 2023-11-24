/*
    file: Test.cs
    author: nikobk
    created on: nov 22 2023
*/
using Emgu.CV;
using System.Collections.Concurrent;
using System.Diagnostics;
using Emgu.CV.CvEnum;

namespace VideoEnhancer
{
    public partial class MainForm : Form
    {
        // Video Processing
        public ConcurrentQueue<(Bitmap input, Bitmap output)> ProcessQueue { get; private set; }
        private VideoCapture? _capture;
        private DateTime _lastOutput;
        private bool _showChannel1, _showChannel2, _showChannel3;
        private Size _inputRes = new Size(1280, 720);
        private Size _outputRes = new Size(1280, 720);

        // Color space conversion
        private ColorConversion _colorConversion = ColorConversion.Bgr2Rgb;

        // Gaussian blur
        private bool _gaussBlur = false;
        private int _gaussKernelSize = Constants.DefaultGaussKernelSize;
        private int _gaussSigmaY = Constants.DefaultGaussSigmaY;

        // Controls
        public int TrackBarValue;

        public MainForm()
        {
            InitializeComponent();

            // Setup form controls
            uiTimer.Interval = Constants.UITimerInterval;
            ProcessQueue = new ConcurrentQueue<(Bitmap, Bitmap)>();
            HideChannelButtons();
            splitButton.Enabled = false;
            gaussKernelSizeTextBox.Text = _gaussKernelSize.ToString();
            gaussSigmaTextBox.Text = _gaussSigmaY.ToString();
            ToggleGaussBlurContent(false);
            ToggleSignalLabels(true);
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
                using Mat processedFrame = new Mat();
                _capture.Retrieve(processedFrame);

                using var inputFrame = processedFrame.Clone();
                if (_inputRes.Width != 3840 && _inputRes.Height != 2160) {
                    CvInvoke.Resize(inputFrame, inputFrame, _inputRes);
                }

                CvInvoke.Resize(processedFrame, processedFrame, _outputRes);

                if (_showChannel1 || _showChannel2 || _showChannel3)
                {
                    var chnlIdx = 0;
                    if (_showChannel1) { chnlIdx = 0; }
                    else if (_showChannel2) { chnlIdx = 1; }
                    else if (_showChannel3) { chnlIdx = 2; }

                    CvInvoke.CvtColor(processedFrame, processedFrame, _colorConversion);
                    using var channel = processedFrame.Split()[chnlIdx];

                    ProcessQueue.Enqueue((input: inputFrame.ToBitmap(), output: channel.ToBitmap()));
                }
                else
                {
                    if (_gaussBlur) {
                        CvInvoke.GaussianBlur(processedFrame, processedFrame, new Size(_gaussKernelSize, _gaussKernelSize), _gaussSigmaY);
                    }

                    // Use the input frame if we're not doing any processing on the frame.
                    if (processedFrame.IsEmpty) {
                        ProcessQueue.Enqueue((input: inputFrame.ToBitmap(), output: processedFrame.ToBitmap()));
                    }
                    else {
                        ProcessQueue.Enqueue((input: inputFrame.ToBitmap(), output: processedFrame.ToBitmap()));
                    }
                }

                // Update the time when the frame should have been processed.
                _lastOutput = dt;
            }
            catch (Exception ex)
            {
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
            startButton.Enabled = false;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Video Files (*.mp4, *.avi,  *.flv)| *.mp4;*.avi*.flv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Spin up the new thread
                _lastOutput = DateTime.Now;
                _capture = new VideoCapture(ofd.FileName);
                _capture.ImageGrabbed += Capture_ImageGrabbed;
                _capture.Start();

                // Enable form controls when the file has been loaded
                splitButton.Enabled = true;
                uiTimer.Start();
                ToggleGaussBlurContent(true);
                ToggleSignalLabels(false);
            }
        }

        private void splitButton_Click(object sender, EventArgs e)
        {
            ShowChannelButtons("Blue", "Green", "Red");
            splitButton.Enabled = false;
        }

        private void HideChannelButtons()
        {
            channelOneButton.Text = "";
            channelOneButton.Enabled = false;
            channelOneButton.Visible = false;

            channelTwoButton.Text = "";
            channelTwoButton.Enabled = false;
            channelTwoButton.Visible = false;

            channelThreeButton.Text = "";
            channelThreeButton.Enabled = false;
            channelThreeButton.Visible = false;

            channelsCancelButton.Enabled = false;
            channelsCancelButton.Visible = false;

            channelsComboBox.Text = "";
            channelsComboBox.Enabled = false;
            channelsComboBox.Visible = false;
        }

        private void ShowChannelButtons(string btn1Text, string btn2Text, string btn3Text)
        {
            // First channel button
            channelOneButton.Text = btn1Text;
            channelOneButton.Enabled = true;
            channelOneButton.Visible = true;

            // Second channel button
            channelTwoButton.Text = btn2Text;
            channelTwoButton.Enabled = true;
            channelTwoButton.Visible = true;

            // Third channel button
            channelThreeButton.Text = btn3Text;
            channelThreeButton.Enabled = true;
            channelThreeButton.Visible = true;

            // Cancel button (hides channel buttons)
            channelsCancelButton.Enabled = true;
            channelsCancelButton.Visible = true;

            // Drop down for color domains
            channelsComboBox.Text = "BGR";
            channelsComboBox.Enabled = true;
            channelsComboBox.Visible = true;
        }

        private void channelOneButton_Click(object sender, EventArgs e)
        {
            channelOneButton.Enabled = false;
            channelTwoButton.Enabled = true;
            channelThreeButton.Enabled = true;
            _showChannel1 = true;
            _showChannel2 = false;
            _showChannel3 = false;
        }

        private void channelTwoButton_Click(object sender, EventArgs e)
        {
            channelOneButton.Enabled = true;
            channelTwoButton.Enabled = false;
            channelThreeButton.Enabled = true;
            _showChannel1 = false;
            _showChannel2 = true;
            _showChannel3 = false;
        }

        private void channelThreeButton_Click(object sender, EventArgs e)
        {
            channelOneButton.Enabled = true;
            channelTwoButton.Enabled = true;
            channelThreeButton.Enabled = false;
            _showChannel1 = false;
            _showChannel2 = false;
            _showChannel3 = true;
        }

        private void channelsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Reset the selected color channel
            _showChannel1 = false;
            _showChannel2 = false;
            _showChannel3 = false;

            var domain = channelsComboBox.Text;
            if (domain == "BGR")
            {
                UpdateChannels("Blue", "Green", "Red");
                return;
            }

            var domains = Constants.ColorDomains;
            if (domains.ContainsKey(domain))
            {
                switch (domain)
                {
                    case "RGB":
                        _colorConversion = ColorConversion.Bgr2Rgb;
                        break;
                    case "HSV":
                        _colorConversion = ColorConversion.Bgr2Hsv;
                        break;
                    case "LAB":
                        _colorConversion = ColorConversion.Bgr2Lab;
                        break;
                    case "GRAY":
                        _colorConversion = ColorConversion.Bgr2Gray;
                        break;
                }
            }
            if (_colorConversion == ColorConversion.Bgr2Gray)
            {
                UpdateChannels(domains[domain][0], "", "", true, false, false);
                return;
            }

            UpdateChannels(domains[domain][0], domains[domain][1], domains[domain][2]);
        }

        private void channelsCancelButton_Click(object sender, EventArgs e)
        {
            HideChannelButtons();
            _showChannel1 = _showChannel2 = _showChannel3 = false;
            splitButton.Enabled = true;
        }

        private void UpdateChannels(string channel1, string channel2, string channel3, bool btn1 = true, bool btn2 = true, bool btn3 = true)
        {
            channelOneButton.Text = channel1;
            channelTwoButton.Text = channel2;
            channelThreeButton.Text = channel3;

            channelOneButton.Enabled = btn1;
            channelOneButton.Visible = btn1;
            channelTwoButton.Enabled = btn2;
            channelTwoButton.Visible = btn2;
            channelThreeButton.Enabled = btn3;
            channelThreeButton.Visible = btn3;
        }

        private void gaussBlurCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int kernelSize;
            int sigmaY;
            if (int.TryParse(gaussKernelSizeTextBox.Text, out kernelSize) && int.TryParse(gaussSigmaTextBox.Text, out sigmaY))
            {
                if (!gaussBlurCheckBox.Checked && kernelSize % 2 == 0)
                {
                    gaussKernelSizeTextBox.Text = Constants.DefaultGaussKernelSize.ToString();
                    MessageBox.Show("A Gaussian blur filter must have an uneven kernel size.", "Invalid Gaussian Kernel Size Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                _gaussKernelSize = kernelSize;
                _gaussSigmaY = sigmaY;
                _gaussBlur = gaussBlurCheckBox.Checked;
            }
        }

        public void ToggleGaussBlurContent(bool enabled)
        {
            gaussBlurCheckBox.Enabled = enabled;
            gaussKernelSizeTextBox.Enabled = enabled;
            gaussSigmaTextBox.Enabled = enabled;
        }

        private void darkModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool darkMode = darkModeCheckBox.Checked;
            var backColor = darkMode ? Color.FromArgb(60, 60, 60) : SystemColors.Control;
            var foreColor = darkMode ? SystemColors.ButtonShadow : SystemColors.ControlText;

            var controls = GetAll(this, typeof(Button));
            foreach (var ctrl in controls)
            {
                ctrl.BackColor = backColor;
                ctrl.ForeColor = foreColor;
            }
        }

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => GetAll(ctrl, type)).Concat(controls).Where(c => c.GetType() == type);
        }

        public void ToggleSignalLabels(bool visible)
        {
            noSignalLeftLabel.Visible = visible;
            noSignalRightLabel.Visible = visible;
        }

        private void screenshotButton_Click(object sender, EventArgs e)
        {

        }

        private void inputResComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = inputResComboBox.Text;
            string oldValue = value;
            var resolution = value.Split('-')[1].Trim().Split('x');
            int width, height;

            if (int.TryParse(resolution[0], out width) && int.TryParse(resolution[1], out height)) {
                Debug.WriteLine($"Width is: {width} and height is: {height}.");
                _inputRes = new Size(width, height);
            } else {
                inputResComboBox.Text = oldValue;
                return;
            }
        }

        private void outputResComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = outputResComboBox.Text;
            string oldValue = value;
            var resolution = value.Split('-')[1].Trim().Split('x');
            int width, height;

            if (int.TryParse(resolution[0], out width) && int.TryParse(resolution[1], out height)) {
                Debug.WriteLine($"Width is: {width} and height is: {height}.");
                _outputRes = new Size(width, height);
            } else {
                outputResComboBox.Text = oldValue;
                return;
            }
        }
    }
}
