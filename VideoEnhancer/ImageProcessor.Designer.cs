namespace VideoEnhancer
{
    partial class ImageProcessor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            cancelButton = new Button();
            saveButton = new Button();
            saveFileDialog1 = new SaveFileDialog();
            liquidRescaleButton = new Button();
            label1 = new Label();
            splitChannelsButton = new Button();
            channelOneButton = new Button();
            channelTwoButton = new Button();
            channelThreeButton = new Button();
            colorSpaceComboBox = new ComboBox();
            colorCancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Desktop;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(911, 507);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // cancelButton
            // 
            cancelButton.ForeColor = SystemColors.ControlText;
            cancelButton.Location = new Point(376, 525);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 51);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // saveButton
            // 
            saveButton.ForeColor = SystemColors.ControlText;
            saveButton.Location = new Point(457, 525);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 51);
            saveButton.TabIndex = 4;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // liquidRescaleButton
            // 
            liquidRescaleButton.Location = new Point(12, 525);
            liquidRescaleButton.Name = "liquidRescaleButton";
            liquidRescaleButton.Size = new Size(75, 51);
            liquidRescaleButton.TabIndex = 5;
            liquidRescaleButton.Text = "Liquid Rescale";
            liquidRescaleButton.UseVisualStyleBackColor = true;
            liquidRescaleButton.Click += liquidRescaleButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(93, 543);
            label1.Name = "label1";
            label1.Size = new Size(172, 15);
            label1.TabIndex = 6;
            label1.Text = "<- This is really broken :keksad:";
            // 
            // splitChannelsButton
            // 
            splitChannelsButton.Location = new Point(538, 525);
            splitChannelsButton.Name = "splitChannelsButton";
            splitChannelsButton.Size = new Size(75, 51);
            splitChannelsButton.TabIndex = 7;
            splitChannelsButton.Text = "Split Channels";
            splitChannelsButton.UseVisualStyleBackColor = true;
            // 
            // channelOneButton
            // 
            channelOneButton.Location = new Point(649, 525);
            channelOneButton.Name = "channelOneButton";
            channelOneButton.Size = new Size(75, 23);
            channelOneButton.TabIndex = 8;
            channelOneButton.Text = "Channel 1";
            channelOneButton.UseVisualStyleBackColor = true;
            channelOneButton.Click += channelOneButton_Click;
            // 
            // channelTwoButton
            // 
            channelTwoButton.Location = new Point(730, 525);
            channelTwoButton.Name = "channelTwoButton";
            channelTwoButton.Size = new Size(75, 23);
            channelTwoButton.TabIndex = 9;
            channelTwoButton.Text = "Channel 2";
            channelTwoButton.UseVisualStyleBackColor = true;
            channelTwoButton.Click += channelTwoButton_Click;
            // 
            // channelThreeButton
            // 
            channelThreeButton.Location = new Point(811, 525);
            channelThreeButton.Name = "channelThreeButton";
            channelThreeButton.Size = new Size(75, 23);
            channelThreeButton.TabIndex = 10;
            channelThreeButton.Text = "Channel 3";
            channelThreeButton.UseVisualStyleBackColor = true;
            channelThreeButton.Click += channelThreeButton_Click;
            // 
            // colorSpaceComboBox
            // 
            colorSpaceComboBox.FormattingEnabled = true;
            colorSpaceComboBox.Items.AddRange(new object[] { "BGR", "RGB", "HSV", "LAB", "GRAY" });
            colorSpaceComboBox.Location = new Point(765, 554);
            colorSpaceComboBox.Name = "colorSpaceComboBox";
            colorSpaceComboBox.Size = new Size(121, 23);
            colorSpaceComboBox.TabIndex = 11;
            colorSpaceComboBox.SelectedIndexChanged += colorSpaceComboBox_SelectedIndexChanged;
            // 
            // colorCancelButton
            // 
            colorCancelButton.Location = new Point(649, 553);
            colorCancelButton.Name = "colorCancelButton";
            colorCancelButton.Size = new Size(110, 23);
            colorCancelButton.TabIndex = 12;
            colorCancelButton.Text = "Cancel";
            colorCancelButton.UseVisualStyleBackColor = true;
            colorCancelButton.Click += colorCancelButton_Click;
            // 
            // ImageProcessor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 583);
            Controls.Add(colorCancelButton);
            Controls.Add(colorSpaceComboBox);
            Controls.Add(channelThreeButton);
            Controls.Add(channelTwoButton);
            Controls.Add(channelOneButton);
            Controls.Add(splitChannelsButton);
            Controls.Add(label1);
            Controls.Add(liquidRescaleButton);
            Controls.Add(saveButton);
            Controls.Add(cancelButton);
            Controls.Add(pictureBox1);
            Name = "ImageProcessor";
            Text = "ImageProcessor";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button cancelButton;
        private Button saveButton;
        private SaveFileDialog saveFileDialog1;
        private Button liquidRescaleButton;
        private Label label1;
        private Button splitChannelsButton;
        private Button channelOneButton;
        private Button channelTwoButton;
        private Button channelThreeButton;
        private ComboBox colorSpaceComboBox;
        private Button colorCancelButton;
    }
}