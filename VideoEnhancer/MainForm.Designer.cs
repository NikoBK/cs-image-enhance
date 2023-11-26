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
            exportButton = new Button();
            screenshotOutputButton = new Button();
            screenshotInputButton = new Button();
            splitButton = new Button();
            channelOneButton = new Button();
            channelTwoButton = new Button();
            channelThreeButton = new Button();
            channelsComboBox = new ComboBox();
            channelsCancelButton = new Button();
            groupBox2 = new GroupBox();
            tabControl1 = new TabControl();
            contrastTab = new TabPage();
            claheResetButton = new Button();
            tileGridSizeTextBox = new TextBox();
            label11 = new Label();
            clipLimitUpdateButton = new Button();
            claheClipLimitTextBox = new TextBox();
            label10 = new Label();
            label8 = new Label();
            claheCheckBox = new CheckBox();
            colorCorrectionTab = new TabPage();
            brightnessMultTextBox = new TextBox();
            label9 = new Label();
            colorCompCheckBox = new CheckBox();
            colorCorrectionComboBox = new ComboBox();
            label7 = new Label();
            whiteBalanceCheckBox = new CheckBox();
            resolutionsTab = new TabPage();
            outputResComboBox = new ComboBox();
            label6 = new Label();
            inputResComboBox = new ComboBox();
            label5 = new Label();
            miscTab = new TabPage();
            label4 = new Label();
            darkModeCheckBox = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            gaussSigmaTextBox = new TextBox();
            label1 = new Label();
            gaussBlurCheckBox = new CheckBox();
            gaussKernelSizeTextBox = new TextBox();
            noSignalLeftLabel = new Label();
            noSignalRightLabel = new Label();
            groupBox3 = new GroupBox();
            tabControl2 = new TabControl();
            gaussTabPage = new TabPage();
            medianTabPage = new TabPage();
            label12 = new Label();
            colorsUpdateButton = new Button();
            colorsResetButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tabControl1.SuspendLayout();
            contrastTab.SuspendLayout();
            colorCorrectionTab.SuspendLayout();
            resolutionsTab.SuspendLayout();
            miscTab.SuspendLayout();
            groupBox3.SuspendLayout();
            tabControl2.SuspendLayout();
            gaussTabPage.SuspendLayout();
            medianTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Desktop;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(745, 426);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Desktop;
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
            groupBox1.Controls.Add(exportButton);
            groupBox1.Controls.Add(screenshotOutputButton);
            groupBox1.Controls.Add(screenshotInputButton);
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
            // exportButton
            // 
            exportButton.ForeColor = SystemColors.ControlText;
            exportButton.Location = new Point(168, 22);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(75, 51);
            exportButton.TabIndex = 8;
            exportButton.Text = "Export";
            exportButton.UseVisualStyleBackColor = true;
            exportButton.Click += exportButton_Click;
            // 
            // screenshotOutputButton
            // 
            screenshotOutputButton.ForeColor = SystemColors.ControlText;
            screenshotOutputButton.Location = new Point(87, 79);
            screenshotOutputButton.Name = "screenshotOutputButton";
            screenshotOutputButton.Size = new Size(75, 51);
            screenshotOutputButton.TabIndex = 7;
            screenshotOutputButton.Text = "Screenshot Output";
            screenshotOutputButton.UseVisualStyleBackColor = true;
            screenshotOutputButton.Click += screenshotOutputButton_Click;
            // 
            // screenshotInputButton
            // 
            screenshotInputButton.ForeColor = SystemColors.ControlText;
            screenshotInputButton.Location = new Point(6, 79);
            screenshotInputButton.Name = "screenshotInputButton";
            screenshotInputButton.Size = new Size(75, 51);
            screenshotInputButton.TabIndex = 6;
            screenshotInputButton.Text = "Screenshot Input";
            screenshotInputButton.UseVisualStyleBackColor = true;
            screenshotInputButton.Click += screenshotButton_Click;
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
            groupBox2.Size = new Size(381, 166);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Adjustments";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(contrastTab);
            tabControl1.Controls.Add(colorCorrectionTab);
            tabControl1.Controls.Add(resolutionsTab);
            tabControl1.Controls.Add(miscTab);
            tabControl1.Location = new Point(6, 15);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(369, 145);
            tabControl1.TabIndex = 12;
            // 
            // contrastTab
            // 
            contrastTab.BackColor = SystemColors.Control;
            contrastTab.Controls.Add(claheResetButton);
            contrastTab.Controls.Add(tileGridSizeTextBox);
            contrastTab.Controls.Add(label11);
            contrastTab.Controls.Add(clipLimitUpdateButton);
            contrastTab.Controls.Add(claheClipLimitTextBox);
            contrastTab.Controls.Add(label10);
            contrastTab.Controls.Add(label8);
            contrastTab.Controls.Add(claheCheckBox);
            contrastTab.Location = new Point(4, 24);
            contrastTab.Name = "contrastTab";
            contrastTab.Size = new Size(361, 117);
            contrastTab.TabIndex = 3;
            contrastTab.Text = "Contrast";
            // 
            // claheResetButton
            // 
            claheResetButton.Location = new Point(283, 62);
            claheResetButton.Name = "claheResetButton";
            claheResetButton.Size = new Size(75, 23);
            claheResetButton.TabIndex = 7;
            claheResetButton.Text = "Reset";
            claheResetButton.UseVisualStyleBackColor = true;
            claheResetButton.Click += claheResetButton_Click;
            // 
            // tileGridSizeTextBox
            // 
            tileGridSizeTextBox.Location = new Point(123, 76);
            tileGridSizeTextBox.Name = "tileGridSizeTextBox";
            tileGridSizeTextBox.Size = new Size(100, 23);
            tileGridSizeTextBox.TabIndex = 6;
            tileGridSizeTextBox.Text = "8";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(123, 58);
            label11.Name = "label11";
            label11.Size = new Size(73, 15);
            label11.TabIndex = 5;
            label11.Text = "Tile Grid Size";
            // 
            // clipLimitUpdateButton
            // 
            clipLimitUpdateButton.Location = new Point(283, 91);
            clipLimitUpdateButton.Name = "clipLimitUpdateButton";
            clipLimitUpdateButton.Size = new Size(75, 23);
            clipLimitUpdateButton.TabIndex = 4;
            clipLimitUpdateButton.Text = "Update";
            clipLimitUpdateButton.UseVisualStyleBackColor = true;
            clipLimitUpdateButton.Click += clipLimitUpdateButton_Click;
            // 
            // claheClipLimitTextBox
            // 
            claheClipLimitTextBox.Location = new Point(6, 76);
            claheClipLimitTextBox.Name = "claheClipLimitTextBox";
            claheClipLimitTextBox.Size = new Size(100, 23);
            claheClipLimitTextBox.TabIndex = 3;
            claheClipLimitTextBox.Text = "2.0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 58);
            label10.Name = "label10";
            label10.Size = new Size(58, 15);
            label10.TabIndex = 2;
            label10.Text = "Clip Limit";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(6, 28);
            label8.Name = "label8";
            label8.Size = new Size(252, 13);
            label8.TabIndex = 1;
            label8.Text = "(Contrast Limited Adaptive Histogram Equalization)";
            // 
            // claheCheckBox
            // 
            claheCheckBox.AutoSize = true;
            claheCheckBox.Location = new Point(6, 6);
            claheCheckBox.Name = "claheCheckBox";
            claheCheckBox.Size = new Size(85, 19);
            claheCheckBox.TabIndex = 0;
            claheCheckBox.Text = "Use CLAHE";
            claheCheckBox.UseVisualStyleBackColor = true;
            claheCheckBox.CheckedChanged += claheCheckBox_CheckedChanged;
            // 
            // colorCorrectionTab
            // 
            colorCorrectionTab.BackColor = SystemColors.Control;
            colorCorrectionTab.Controls.Add(colorsResetButton);
            colorCorrectionTab.Controls.Add(colorsUpdateButton);
            colorCorrectionTab.Controls.Add(brightnessMultTextBox);
            colorCorrectionTab.Controls.Add(label9);
            colorCorrectionTab.Controls.Add(colorCompCheckBox);
            colorCorrectionTab.Controls.Add(colorCorrectionComboBox);
            colorCorrectionTab.Controls.Add(label7);
            colorCorrectionTab.Controls.Add(whiteBalanceCheckBox);
            colorCorrectionTab.Location = new Point(4, 24);
            colorCorrectionTab.Name = "colorCorrectionTab";
            colorCorrectionTab.Size = new Size(361, 117);
            colorCorrectionTab.TabIndex = 4;
            colorCorrectionTab.Text = "Colors";
            // 
            // brightnessMultTextBox
            // 
            brightnessMultTextBox.Location = new Point(6, 47);
            brightnessMultTextBox.Name = "brightnessMultTextBox";
            brightnessMultTextBox.Size = new Size(116, 23);
            brightnessMultTextBox.TabIndex = 6;
            brightnessMultTextBox.Text = "25";
            brightnessMultTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 28);
            label9.Name = "label9";
            label9.Size = new Size(116, 15);
            label9.TabIndex = 5;
            label9.Text = "Brightness Multiplier";
            // 
            // colorCompCheckBox
            // 
            colorCompCheckBox.AutoSize = true;
            colorCompCheckBox.Location = new Point(161, 6);
            colorCompCheckBox.Name = "colorCompCheckBox";
            colorCompCheckBox.Size = new Size(158, 19);
            colorCompCheckBox.TabIndex = 3;
            colorCompCheckBox.Text = "Use Color Compensation";
            colorCompCheckBox.UseVisualStyleBackColor = true;
            colorCompCheckBox.CheckedChanged += colorCompCheckBox_CheckedChanged;
            // 
            // colorCorrectionComboBox
            // 
            colorCorrectionComboBox.FormattingEnabled = true;
            colorCorrectionComboBox.Items.AddRange(new object[] { "None", "ColorCompensation" });
            colorCorrectionComboBox.Location = new Point(161, 46);
            colorCorrectionComboBox.Name = "colorCorrectionComboBox";
            colorCorrectionComboBox.Size = new Size(91, 23);
            colorCorrectionComboBox.TabIndex = 2;
            colorCorrectionComboBox.Text = "None";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(161, 28);
            label7.Name = "label7";
            label7.Size = new Size(145, 15);
            label7.TabIndex = 1;
            label7.Text = "Channel Color Correction:";
            // 
            // whiteBalanceCheckBox
            // 
            whiteBalanceCheckBox.AutoSize = true;
            whiteBalanceCheckBox.Location = new Point(6, 6);
            whiteBalanceCheckBox.Name = "whiteBalanceCheckBox";
            whiteBalanceCheckBox.Size = new Size(135, 19);
            whiteBalanceCheckBox.TabIndex = 0;
            whiteBalanceCheckBox.Text = "Apply White Balance";
            whiteBalanceCheckBox.UseVisualStyleBackColor = true;
            whiteBalanceCheckBox.CheckedChanged += whiteBalanceCheckBox_CheckedChanged;
            // 
            // resolutionsTab
            // 
            resolutionsTab.BackColor = SystemColors.Control;
            resolutionsTab.Controls.Add(outputResComboBox);
            resolutionsTab.Controls.Add(label6);
            resolutionsTab.Controls.Add(inputResComboBox);
            resolutionsTab.Controls.Add(label5);
            resolutionsTab.Location = new Point(4, 24);
            resolutionsTab.Name = "resolutionsTab";
            resolutionsTab.Size = new Size(361, 117);
            resolutionsTab.TabIndex = 2;
            resolutionsTab.Text = "Resolution";
            // 
            // outputResComboBox
            // 
            outputResComboBox.FormattingEnabled = true;
            outputResComboBox.Items.AddRange(new object[] { "480p - 640x480", "720p - 1280x720", "1080p - 1920x1080", "1440p - 2560x1440", "2160p - 3840x2160" });
            outputResComboBox.Location = new Point(12, 81);
            outputResComboBox.Name = "outputResComboBox";
            outputResComboBox.Size = new Size(121, 23);
            outputResComboBox.TabIndex = 3;
            outputResComboBox.Text = "720p - 1280x720";
            outputResComboBox.SelectedIndexChanged += outputResComboBox_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 63);
            label6.Name = "label6";
            label6.Size = new Size(140, 15);
            label6.TabIndex = 2;
            label6.Text = "Output Video Resolution:";
            // 
            // inputResComboBox
            // 
            inputResComboBox.FormattingEnabled = true;
            inputResComboBox.Items.AddRange(new object[] { "480p - 640x480", "720p - 1280x720", "1080p - 1920x1080", "1440p - 2560x1440", "2160p - 3840x2160" });
            inputResComboBox.Location = new Point(12, 28);
            inputResComboBox.Name = "inputResComboBox";
            inputResComboBox.Size = new Size(121, 23);
            inputResComboBox.TabIndex = 1;
            inputResComboBox.Text = "2160p - 3840x2160";
            inputResComboBox.SelectedIndexChanged += inputResComboBox_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 10);
            label5.Name = "label5";
            label5.Size = new Size(130, 15);
            label5.TabIndex = 0;
            label5.Text = "Input Video Resolution:";
            // 
            // miscTab
            // 
            miscTab.BackColor = SystemColors.Control;
            miscTab.Controls.Add(label4);
            miscTab.Controls.Add(darkModeCheckBox);
            miscTab.Location = new Point(4, 24);
            miscTab.Name = "miscTab";
            miscTab.Padding = new Padding(3);
            miscTab.Size = new Size(361, 117);
            miscTab.TabIndex = 1;
            miscTab.Text = "Misc";
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
            // noSignalLeftLabel
            // 
            noSignalLeftLabel.AutoSize = true;
            noSignalLeftLabel.BackColor = SystemColors.Desktop;
            noSignalLeftLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            noSignalLeftLabel.ForeColor = SystemColors.ButtonShadow;
            noSignalLeftLabel.Location = new Point(295, 196);
            noSignalLeftLabel.Name = "noSignalLeftLabel";
            noSignalLeftLabel.Size = new Size(179, 45);
            noSignalLeftLabel.TabIndex = 12;
            noSignalLeftLabel.Text = "No Signal...";
            // 
            // noSignalRightLabel
            // 
            noSignalRightLabel.AutoSize = true;
            noSignalRightLabel.BackColor = SystemColors.Desktop;
            noSignalRightLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            noSignalRightLabel.ForeColor = SystemColors.ButtonShadow;
            noSignalRightLabel.Location = new Point(1041, 196);
            noSignalRightLabel.Name = "noSignalRightLabel";
            noSignalRightLabel.Size = new Size(179, 45);
            noSignalRightLabel.TabIndex = 13;
            noSignalRightLabel.Text = "No Signal...";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tabControl2);
            groupBox3.Location = new Point(682, 478);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(356, 166);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Filters";
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(gaussTabPage);
            tabControl2.Controls.Add(medianTabPage);
            tabControl2.Location = new Point(6, 15);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(343, 145);
            tabControl2.TabIndex = 0;
            // 
            // gaussTabPage
            // 
            gaussTabPage.BackColor = SystemColors.Control;
            gaussTabPage.Controls.Add(label3);
            gaussTabPage.Controls.Add(gaussBlurCheckBox);
            gaussTabPage.Controls.Add(label2);
            gaussTabPage.Controls.Add(gaussKernelSizeTextBox);
            gaussTabPage.Controls.Add(gaussSigmaTextBox);
            gaussTabPage.Controls.Add(label1);
            gaussTabPage.Location = new Point(4, 24);
            gaussTabPage.Name = "gaussTabPage";
            gaussTabPage.Padding = new Padding(3);
            gaussTabPage.Size = new Size(335, 117);
            gaussTabPage.TabIndex = 0;
            gaussTabPage.Text = "Gaussian Blur";
            // 
            // medianTabPage
            // 
            medianTabPage.BackColor = SystemColors.Control;
            medianTabPage.Controls.Add(label12);
            medianTabPage.Location = new Point(4, 24);
            medianTabPage.Name = "medianTabPage";
            medianTabPage.Padding = new Padding(3);
            medianTabPage.Size = new Size(335, 117);
            medianTabPage.TabIndex = 1;
            medianTabPage.Text = "Median Filter";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(192, 0, 0);
            label12.Location = new Point(123, 58);
            label12.Name = "label12";
            label12.Size = new Size(103, 15);
            label12.TabIndex = 6;
            label12.Text = "Work in progress...";
            // 
            // colorsUpdateButton
            // 
            colorsUpdateButton.Location = new Point(283, 91);
            colorsUpdateButton.Name = "colorsUpdateButton";
            colorsUpdateButton.Size = new Size(75, 23);
            colorsUpdateButton.TabIndex = 7;
            colorsUpdateButton.Text = "Update";
            colorsUpdateButton.UseVisualStyleBackColor = true;
            colorsUpdateButton.Click += colorsUpdateButton_Click;
            // 
            // colorsResetButton
            // 
            colorsResetButton.Location = new Point(283, 62);
            colorsResetButton.Name = "colorsResetButton";
            colorsResetButton.Size = new Size(75, 23);
            colorsResetButton.TabIndex = 8;
            colorsResetButton.Text = "Reset";
            colorsResetButton.UseVisualStyleBackColor = true;
            colorsResetButton.Click += colorsResetButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1526, 656);
            Controls.Add(groupBox3);
            Controls.Add(noSignalRightLabel);
            Controls.Add(noSignalLeftLabel);
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
            contrastTab.ResumeLayout(false);
            contrastTab.PerformLayout();
            colorCorrectionTab.ResumeLayout(false);
            colorCorrectionTab.PerformLayout();
            resolutionsTab.ResumeLayout(false);
            resolutionsTab.PerformLayout();
            miscTab.ResumeLayout(false);
            miscTab.PerformLayout();
            groupBox3.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            gaussTabPage.ResumeLayout(false);
            gaussTabPage.PerformLayout();
            medianTabPage.ResumeLayout(false);
            medianTabPage.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private TabPage miscTab;
        private Label label3;
        private Label label2;
        private TextBox gaussSigmaTextBox;
        private Label label1;
        private CheckBox gaussBlurCheckBox;
        private TextBox gaussKernelSizeTextBox;
        private CheckBox darkModeCheckBox;
        private Button splitButton;
        private TabPage resolutionsTab;
        private Label label4;
        private Label noSignalLeftLabel;
        private Label noSignalRightLabel;
        private Button screenshotInputButton;
        private ComboBox outputResComboBox;
        private Label label6;
        private ComboBox inputResComboBox;
        private Label label5;
        private Button screenshotOutputButton;
        private Button exportButton;
        private TabPage contrastTab;
        private TabPage colorCorrectionTab;
        private CheckBox claheCheckBox;
        private CheckBox colorCompCheckBox;
        private ComboBox colorCorrectionComboBox;
        private Label label7;
        private CheckBox whiteBalanceCheckBox;
        private Label label8;
        private GroupBox groupBox3;
        private TabControl tabControl2;
        private TabPage gaussTabPage;
        private TabPage medianTabPage;
        private Label label9;
        private TextBox brightnessMultTextBox;
        private TextBox claheClipLimitTextBox;
        private Label label10;
        private Button clipLimitUpdateButton;
        private TextBox tileGridSizeTextBox;
        private Label label11;
        private Button claheResetButton;
        private Label label12;
        private Button colorsResetButton;
        private Button colorsUpdateButton;
    }
}