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
            trackBar1 = new TrackBar();
            label1 = new Label();
            trackBar2 = new TrackBar();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
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
            // trackBar1
            // 
            trackBar1.Location = new Point(12, 614);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(150, 45);
            trackBar1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 596);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 7;
            label1.Text = "Width %";
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(190, 614);
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(150, 45);
            trackBar2.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(232, 596);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 9;
            label2.Text = "Height %";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 546);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 10;
            label3.Text = "DeltaX: 1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 561);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 11;
            label4.Text = "Rigidity: 0";
            // 
            // ImageProcessor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 671);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(trackBar2);
            Controls.Add(label1);
            Controls.Add(trackBar1);
            Controls.Add(liquidRescaleButton);
            Controls.Add(saveButton);
            Controls.Add(cancelButton);
            Controls.Add(pictureBox1);
            Name = "ImageProcessor";
            Text = "ImageProcessor";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button cancelButton;
        private Button saveButton;
        private SaveFileDialog saveFileDialog1;
        private Button liquidRescaleButton;
        private TrackBar trackBar1;
        private Label label1;
        private TrackBar trackBar2;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}