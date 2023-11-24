namespace VideoEnhancer
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            startButton = new Button();
            uiTimer = new System.Windows.Forms.Timer(components);
            groupBox1 = new GroupBox();
            splitButton = new Button();
            channelOneButton = new Button();
            channelTwoButton = new Button();
            channelThreeButton = new Button();
            channelsComboBox = new ComboBox();
            channelsCancelButton = new Button();
            groupBox2 = new GroupBox();
            tabControl1 = new TabControl();
            gaussBlurTab = new TabPage();
            label3 = new Label();
            label2 = new Label();
            gaussSigmaTextBox = new TextBox();
            label1 = new Label();
            gaussBlurCheckBox = new CheckBox();
            gaussKernelSizeTextBox = new TextBox();
            miscTab = new TabPage();
            darkModeCheckBox = new CheckBox();
            label4 = new Label();
            tabPage1 = new TabPage();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tabControl1.SuspendLayout();
            gaussBlurTab.SuspendLayout();
            miscTab.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(745, 426);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Black;
            pictureBox2.Location = new Point(770, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(745, 426);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // startButton
            // 
            startButton.ForeColor = SystemColors.ControlText;
            startButton.Location = new Point(6, 22);
            startButton.Name = "startButton";
            startButton.Size = new Size(75, 51);
            startButton.TabIndex = 2;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // uiTimer
            // 
            uiTimer.Interval = 25;
            uiTimer.Tick += uiTimer_Tick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(splitButton);
            groupBox1.Controls.Add(startButton);
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(12, 478);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(268, 166);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Operations";
            // 
            // splitButton
            // 
            splitButton.ForeColor = SystemColors.ControlText;
            splitButton.Location = new Point(87, 22);
            splitButton.Name = "splitButton";
            splitButton.Size = new Size(75, 51);
            splitButton.TabIndex = 5;
            splitButton.Text = "Split Colors";
            splitButton.UseVisualStyleBackColor = true;
            splitButton.Click += splitButton_Click;
            // 
            // channelOneButton
            // 
            channelOneButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            channelOneButton.Location = new Point(994, 444);
            channelOneButton.Name = "channelOneButton";
            channelOneButton.Size = new Size(110, 28);
            channelOneButton.TabIndex = 6;
            channelOneButton.Text = "Channel";
            channelOneButton.UseVisualStyleBackColor = true;
            channelOneButton.Click += channelOneButton_Click;
            // 
            // channelTwoButton
            // 
            channelTwoButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            channelTwoButton.Location = new Point(1110, 444);
            channelTwoButton.Name = "channelTwoButton";
            channelTwoButton.Size = new Size(110, 28);
            channelTwoButton.TabIndex = 7;
            channelTwoButton.Text = "Channel";
            channelTwoButton.UseVisualStyleBackColor = true;
            channelTwoButton.Click += channelTwoButton_Click;
            // 
            // channelThreeButton
            // 
            channelThreeButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            channelThreeButton.Location = new Point(1226, 444);
            channelThreeButton.Name = "channelThreeButton";
            channelThreeButton.Size = new Size(110, 28);
            channelThreeButton.TabIndex = 8;
            channelThreeButton.Text = "Channel";
            channelThreeButton.UseVisualStyleBackColor = true;
            channelThreeButton.Click += channelThreeButton_Click;
            // 
            // channelsComboBox
            // 
            channelsComboBox.FormattingEnabled = true;
            channelsComboBox.Items.AddRange(new object[] { "BGR", "RGB", "HSV", "LAB", "GRAY" });
            channelsComboBox.Location = new Point(1342, 444);
            channelsComboBox.Name = "channelsComboBox";
            channelsComboBox.Size = new Size(110, 23);
            channelsComboBox.TabIndex = 9;
            channelsComboBox.SelectedIndexChanged += channelsComboBox_SelectedIndexChanged;
            // 
            // channelsCancelButton
            // 
            channelsCancelButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            channelsCancelButton.Location = new Point(878, 444);
            channelsCancelButton.Name = "channelsCancelButton";
            channelsCancelButton.Size = new Size(110, 28);
            channelsCancelButton.TabIndex = 10;
            channelsCancelButton.Text = "Cancel";
            channelsCancelButton.UseVisualStyleBackColor = true;
            channelsCancelButton.Click += channelsCancelButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tabControl1);
            groupBox2.Location = new Point(295, 478);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(462, 166);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Adjustments";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(gaussBlurTab);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(miscTab);
            tabControl1.Location = new Point(6, 15);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(450, 145);
            tabControl1.TabIndex = 12;
            // 
            // gaussBlurTab
            // 
            gaussBlurTab.BackColor = SystemColors.Control;
            gaussBlurTab.Controls.Add(label3);
            gaussBlurTab.Controls.Add(label2);
            gaussBlurTab.Controls.Add(gaussSigmaTextBox);
            gaussBlurTab.Controls.Add(label1);
            gaussBlurTab.Controls.Add(gaussBlurCheckBox);
            gaussBlurTab.Controls.Add(gaussKernelSizeTextBox);
            gaussBlurTab.Location = new Point(4, 24);
            gaussBlurTab.Name = "gaussBlurTab";
            gaussBlurTab.Padding = new Padding(3);
            gaussBlurTab.Size = new Size(442, 117);
            gaussBlurTab.TabIndex = 0;
            gaussBlurTab.Text = "Gaussian Blur";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(192, 0, 0);
            label3.Location = new Point(6, 28);
            label3.Name = "label3";
            label3.Size = new Size(321, 30);
            label3.TabIndex = 5;
            label3.Text = "A Gaussian blur filter might impact processing performance.\r\nRecommended Sigma values are: 0.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 70);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 4;
            label2.Text = "Sigma Y";
            // 
            // gaussSigmaTextBox
            // 
            gaussSigmaTextBox.Location = new Point(114, 88);
            gaussSigmaTextBox.Name = "gaussSigmaTextBox";
            gaussSigmaTextBox.Size = new Size(90, 23);
            gaussSigmaTextBox.TabIndex = 3;
            gaussSigmaTextBox.Text = "0";
            gaussSigmaTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 70);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 2;
            label1.Text = "Blur Kernel Size:";
            // 
            // gaussBlurCheckBox
            // 
            gaussBlurCheckBox.AutoSize = true;
            gaussBlurCheckBox.Location = new Point(6, 6);
            gaussBlurCheckBox.Name = "gaussBlurCheckBox";
            gaussBlurCheckBox.Size = new Size(118, 19);
            gaussBlurCheckBox.TabIndex = 1;
            gaussBlurCheckBox.Text = "Apply Gauss. Blur";
            gaussBlurCheckBox.UseVisualStyleBackColor = true;
            gaussBlurCheckBox.CheckedChanged += gaussBlurCheckBox_CheckedChanged;
            // 
            // gaussKernelSizeTextBox
            // 
            gaussKernelSizeTextBox.Location = new Point(6, 88);
            gaussKernelSizeTextBox.Name = "gaussKernelSizeTextBox";
            gaussKernelSizeTextBox.Size = new Size(90, 23);
            gaussKernelSizeTextBox.TabIndex = 0;
            gaussKernelSizeTextBox.Text = "3";
            gaussKernelSizeTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // miscTab
            // 
            miscTab.BackColor = SystemColors.Control;
            miscTab.Controls.Add(label4);
            miscTab.Controls.Add(darkModeCheckBox);
            miscTab.Location = new Point(4, 24);
            miscTab.Name = "miscTab";
            miscTab.Padding = new Padding(3);
            miscTab.Size = new Size(442, 117);
            miscTab.TabIndex = 1;
            miscTab.Text = "Misc";
            // 
            // darkModeCheckBox
            // 
            darkModeCheckBox.AutoSize = true;
            darkModeCheckBox.Location = new Point(6, 6);
            darkModeCheckBox.Name = "darkModeCheckBox";
            darkModeCheckBox.Size = new Size(84, 19);
            darkModeCheckBox.TabIndex = 0;
            darkModeCheckBox.Text = "Dark Mode";
            darkModeCheckBox.UseVisualStyleBackColor = true;
            darkModeCheckBox.CheckedChanged += darkModeCheckBox_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(192, 0, 0);
            label4.Location = new Point(6, 28);
            label4.Name = "label4";
            label4.Size = new Size(153, 30);
            label4.TabIndex = 6;
            label4.Text = "All settings on this page are\r\nexperimental!";
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Control;
            tabPage1.Controls.Add(label5);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(442, 117);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Resolution";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(192, 0, 0);
            label5.Location = new Point(174, 51);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 7;
            label5.Text = "To be added...";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1526, 656);
            Controls.Add(groupBox2);
            Controls.Add(channelsCancelButton);
            Controls.Add(channelsComboBox);
            Controls.Add(channelThreeButton);
            Controls.Add(channelTwoButton);
            Controls.Add(channelOneButton);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "MainForm";
            Text = "Underwater Drone Software";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            gaussBlurTab.ResumeLayout(false);
            gaussBlurTab.PerformLayout();
            miscTab.ResumeLayout(false);
            miscTab.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button startButton;
        private System.Windows.Forms.Timer uiTimer;
        private GroupBox groupBox1;
        private Button channelOneButton;
        private Button channelTwoButton;
        private Button channelThreeButton;
        private ComboBox channelsComboBox;
        private Button channelsCancelButton;
        private GroupBox groupBox2;
        private TabControl tabControl1;
        private TabPage gaussBlurTab;
        private TabPage miscTab;
        private Label label3;
        private Label label2;
        private TextBox gaussSigmaTextBox;
        private Label label1;
        private CheckBox gaussBlurCheckBox;
        private TextBox gaussKernelSizeTextBox;
        private CheckBox darkModeCheckBox;
        private Button splitButton;
        private TabPage tabPage1;
        private Label label4;
        private Label label5;
    }
}