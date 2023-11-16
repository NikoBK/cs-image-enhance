namespace VideoEnhancer
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
            videoPlayerImageBox = new PictureBox();
            browseButton = new Button();
            playButton = new Button();
            ((System.ComponentModel.ISupportInitialize)videoPlayerImageBox).BeginInit();
            SuspendLayout();
            // 
            // videoPlayerImageBox
            // 
            videoPlayerImageBox.BackColor = SystemColors.ActiveCaptionText;
            videoPlayerImageBox.Location = new Point(95, 12);
            videoPlayerImageBox.Name = "videoPlayerImageBox";
            videoPlayerImageBox.Size = new Size(537, 353);
            videoPlayerImageBox.SizeMode = PictureBoxSizeMode.Zoom;
            videoPlayerImageBox.TabIndex = 0;
            videoPlayerImageBox.TabStop = false;
            // 
            // browseButton
            // 
            browseButton.Location = new Point(104, 395);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(75, 23);
            browseButton.TabIndex = 1;
            browseButton.Text = "Browse";
            browseButton.UseVisualStyleBackColor = true;
            browseButton.Click += browseButton_Click;
            // 
            // playButton
            // 
            playButton.Location = new Point(186, 394);
            playButton.Name = "playButton";
            playButton.Size = new Size(75, 23);
            playButton.TabIndex = 3;
            playButton.Text = "Play";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += playButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(playButton);
            Controls.Add(browseButton);
            Controls.Add(videoPlayerImageBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)videoPlayerImageBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox videoPlayerImageBox;
        private Button browseButton;
        private Button playButton;
    }
}