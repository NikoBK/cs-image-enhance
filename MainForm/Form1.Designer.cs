namespace MainForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            playButton = new Button();
            pauseButton = new Button();
            stopButton = new Button();
            browseButton = new Button();
            splitContainer1 = new SplitContainer();
            videoPlayerImageBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)videoPlayerImageBox).BeginInit();
            SuspendLayout();
            // 
            // playButton
            // 
            playButton.Location = new Point(57, 3);
            playButton.Name = "playButton";
            playButton.Size = new Size(95, 54);
            playButton.TabIndex = 0;
            playButton.Text = "play";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += playButton_Click;
            // 
            // pauseButton
            // 
            pauseButton.Location = new Point(245, 9);
            pauseButton.Name = "pauseButton";
            pauseButton.Size = new Size(102, 48);
            pauseButton.TabIndex = 1;
            pauseButton.Text = "pause";
            pauseButton.UseVisualStyleBackColor = true;
            pauseButton.Click += pauseButton_Click;
            // 
            // stopButton
            // 
            stopButton.Location = new Point(426, 22);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(75, 23);
            stopButton.TabIndex = 2;
            stopButton.Text = "stop";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += stopButton_Click;
            // 
            // browseButton
            // 
            browseButton.Location = new Point(12, 12);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(99, 53);
            browseButton.TabIndex = 3;
            browseButton.Text = "browse";
            browseButton.UseVisualStyleBackColor = true;
            browseButton.Click += browseButton_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(134, 12);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(videoPlayerImageBox);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(stopButton);
            splitContainer1.Panel2.Controls.Add(playButton);
            splitContainer1.Panel2.Controls.Add(pauseButton);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(592, 426);
            splitContainer1.SplitterDistance = 343;
            splitContainer1.TabIndex = 4;
            // 
            // videoPlayerImageBox
            // 
            videoPlayerImageBox.BackColor = SystemColors.ActiveCaptionText;
            videoPlayerImageBox.Location = new Point(0, 0);
            videoPlayerImageBox.Name = "videoPlayerImageBox";
            videoPlayerImageBox.Size = new Size(592, 340);
            videoPlayerImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            videoPlayerImageBox.TabIndex = 0;
            videoPlayerImageBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(browseButton);
            Name = "Form1";
            Text = "Under Water Drone Project";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)videoPlayerImageBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button playButton;
        private Button pauseButton;
        private Button stopButton;
        private Button browseButton;
        private SplitContainer splitContainer1;
        private PictureBox videoPlayerImageBox;
    }
}