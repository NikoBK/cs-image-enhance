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
            inputVideoTabControl = new TabControl();
            tabPage1 = new TabPage();
            inputFeedLabel = new Label();
            tabPage2 = new TabPage();
            pictureBox1 = new PictureBox();
            stopButton = new Button();
            controlsTabControl = new TabControl();
            operationsTabPage = new TabPage();
            filterComboBox = new ComboBox();
            renderMethodComboBox = new ComboBox();
            pauseButton = new Button();
            exportButton = new Button();
            filterLabel = new Label();
            currentRenderMethodLabel = new Label();
            hardwareTabPage = new TabPage();
            miscHWDataGridView = new DataGridView();
            miscHardwareLabel = new Label();
            extHWDataGridView = new DataGridView();
            internalHWDataGridView = new DataGridView();
            extHardwareLabel = new Label();
            intHardwareLabel = new Label();
            inputFPSLabel = new Label();
            postProcessFPSLabel = new Label();
            inputResLabel = new Label();
            outputResLabel = new Label();
            tabControl1 = new TabControl();
            tabPage4 = new TabPage();
            pictureBox3 = new PictureBox();
            tabPage3 = new TabPage();
            pictureBox2 = new PictureBox();
            postProcessFeedLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)videoPlayerImageBox).BeginInit();
            inputVideoTabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            controlsTabControl.SuspendLayout();
            operationsTabPage.SuspendLayout();
            hardwareTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)miscHWDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)extHWDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)internalHWDataGridView).BeginInit();
            tabControl1.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // videoPlayerImageBox
            // 
            videoPlayerImageBox.BackColor = SystemColors.ActiveCaptionText;
            videoPlayerImageBox.Dock = DockStyle.Fill;
            videoPlayerImageBox.Location = new Point(3, 3);
            videoPlayerImageBox.Name = "videoPlayerImageBox";
            videoPlayerImageBox.Size = new Size(650, 418);
            videoPlayerImageBox.SizeMode = PictureBoxSizeMode.Zoom;
            videoPlayerImageBox.TabIndex = 0;
            videoPlayerImageBox.TabStop = false;
            // 
            // browseButton
            // 
            browseButton.Location = new Point(6, 6);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(88, 43);
            browseButton.TabIndex = 1;
            browseButton.Text = "Browse";
            browseButton.UseVisualStyleBackColor = true;
            browseButton.Click += browseButton_Click;
            // 
            // playButton
            // 
            playButton.Location = new Point(6, 55);
            playButton.Name = "playButton";
            playButton.Size = new Size(88, 43);
            playButton.TabIndex = 3;
            playButton.Text = "Play";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += playButton_Click;
            // 
            // inputVideoTabControl
            // 
            inputVideoTabControl.Controls.Add(tabPage1);
            inputVideoTabControl.Controls.Add(tabPage2);
            inputVideoTabControl.Location = new Point(3, 5);
            inputVideoTabControl.Name = "inputVideoTabControl";
            inputVideoTabControl.SelectedIndex = 0;
            inputVideoTabControl.Size = new Size(664, 452);
            inputVideoTabControl.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(inputFeedLabel);
            tabPage1.Controls.Add(videoPlayerImageBox);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(656, 424);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Input Video";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // inputFeedLabel
            // 
            inputFeedLabel.AutoSize = true;
            inputFeedLabel.BackColor = Color.Black;
            inputFeedLabel.FlatStyle = FlatStyle.Flat;
            inputFeedLabel.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            inputFeedLabel.ForeColor = SystemColors.ButtonHighlight;
            inputFeedLabel.Location = new Point(201, 175);
            inputFeedLabel.Name = "inputFeedLabel";
            inputFeedLabel.Size = new Size(241, 65);
            inputFeedLabel.TabIndex = 1;
            inputFeedLabel.Text = "No feed...";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(pictureBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(492, 322);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Post-Process Video";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(486, 316);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // stopButton
            // 
            stopButton.Location = new Point(192, 55);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(88, 43);
            stopButton.TabIndex = 4;
            stopButton.Text = "Stop";
            stopButton.UseVisualStyleBackColor = true;
            // 
            // controlsTabControl
            // 
            controlsTabControl.Controls.Add(operationsTabPage);
            controlsTabControl.Controls.Add(hardwareTabPage);
            controlsTabControl.Location = new Point(3, 475);
            controlsTabControl.Name = "controlsTabControl";
            controlsTabControl.SelectedIndex = 0;
            controlsTabControl.Size = new Size(1326, 314);
            controlsTabControl.TabIndex = 9;
            // 
            // operationsTabPage
            // 
            operationsTabPage.BackColor = Color.DarkGray;
            operationsTabPage.Controls.Add(filterComboBox);
            operationsTabPage.Controls.Add(renderMethodComboBox);
            operationsTabPage.Controls.Add(pauseButton);
            operationsTabPage.Controls.Add(exportButton);
            operationsTabPage.Controls.Add(filterLabel);
            operationsTabPage.Controls.Add(currentRenderMethodLabel);
            operationsTabPage.Controls.Add(stopButton);
            operationsTabPage.Controls.Add(playButton);
            operationsTabPage.Controls.Add(browseButton);
            operationsTabPage.Location = new Point(4, 24);
            operationsTabPage.Name = "operationsTabPage";
            operationsTabPage.Padding = new Padding(3);
            operationsTabPage.Size = new Size(1318, 286);
            operationsTabPage.TabIndex = 0;
            operationsTabPage.Text = "Operations";
            // 
            // filterComboBox
            // 
            filterComboBox.FormattingEnabled = true;
            filterComboBox.Location = new Point(8, 183);
            filterComboBox.Name = "filterComboBox";
            filterComboBox.Size = new Size(121, 23);
            filterComboBox.TabIndex = 12;
            filterComboBox.Text = "None";
            // 
            // renderMethodComboBox
            // 
            renderMethodComboBox.FormattingEnabled = true;
            renderMethodComboBox.Items.AddRange(new object[] { "GPU", "CPU" });
            renderMethodComboBox.Location = new Point(8, 125);
            renderMethodComboBox.Name = "renderMethodComboBox";
            renderMethodComboBox.Size = new Size(121, 23);
            renderMethodComboBox.TabIndex = 11;
            renderMethodComboBox.Text = "GPU";
            // 
            // pauseButton
            // 
            pauseButton.Location = new Point(100, 55);
            pauseButton.Name = "pauseButton";
            pauseButton.Size = new Size(86, 43);
            pauseButton.TabIndex = 10;
            pauseButton.Text = "Pause";
            pauseButton.UseVisualStyleBackColor = true;
            // 
            // exportButton
            // 
            exportButton.Location = new Point(100, 6);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(88, 43);
            exportButton.TabIndex = 9;
            exportButton.Text = "Export";
            exportButton.UseVisualStyleBackColor = true;
            // 
            // filterLabel
            // 
            filterLabel.AutoSize = true;
            filterLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            filterLabel.ForeColor = SystemColors.ButtonHighlight;
            filterLabel.Location = new Point(8, 159);
            filterLabel.Name = "filterLabel";
            filterLabel.Size = new Size(111, 21);
            filterLabel.TabIndex = 8;
            filterLabel.Text = "Current Filter:";
            // 
            // currentRenderMethodLabel
            // 
            currentRenderMethodLabel.AutoSize = true;
            currentRenderMethodLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            currentRenderMethodLabel.ForeColor = SystemColors.ButtonHighlight;
            currentRenderMethodLabel.Location = new Point(8, 101);
            currentRenderMethodLabel.Name = "currentRenderMethodLabel";
            currentRenderMethodLabel.Size = new Size(189, 21);
            currentRenderMethodLabel.TabIndex = 6;
            currentRenderMethodLabel.Text = "Current Render Method:\r\n";
            // 
            // hardwareTabPage
            // 
            hardwareTabPage.BackColor = Color.DarkGray;
            hardwareTabPage.Controls.Add(miscHWDataGridView);
            hardwareTabPage.Controls.Add(miscHardwareLabel);
            hardwareTabPage.Controls.Add(extHWDataGridView);
            hardwareTabPage.Controls.Add(internalHWDataGridView);
            hardwareTabPage.Controls.Add(extHardwareLabel);
            hardwareTabPage.Controls.Add(intHardwareLabel);
            hardwareTabPage.Location = new Point(4, 24);
            hardwareTabPage.Name = "hardwareTabPage";
            hardwareTabPage.Padding = new Padding(3);
            hardwareTabPage.Size = new Size(1001, 286);
            hardwareTabPage.TabIndex = 1;
            hardwareTabPage.Text = "Hardware";
            // 
            // miscHWDataGridView
            // 
            miscHWDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            miscHWDataGridView.Location = new Point(623, 26);
            miscHWDataGridView.Name = "miscHWDataGridView";
            miscHWDataGridView.RowTemplate.Height = 25;
            miscHWDataGridView.Size = new Size(284, 254);
            miscHWDataGridView.TabIndex = 5;
            // 
            // miscHardwareLabel
            // 
            miscHardwareLabel.AutoSize = true;
            miscHardwareLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            miscHardwareLabel.ForeColor = SystemColors.ButtonHighlight;
            miscHardwareLabel.Location = new Point(623, 3);
            miscHardwareLabel.Name = "miscHardwareLabel";
            miscHardwareLabel.Size = new Size(105, 20);
            miscHardwareLabel.TabIndex = 4;
            miscHardwareLabel.Text = "Miscellaneous";
            // 
            // extHWDataGridView
            // 
            extHWDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            extHWDataGridView.Location = new Point(314, 26);
            extHWDataGridView.Name = "extHWDataGridView";
            extHWDataGridView.RowTemplate.Height = 25;
            extHWDataGridView.Size = new Size(284, 254);
            extHWDataGridView.TabIndex = 3;
            // 
            // internalHWDataGridView
            // 
            internalHWDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            internalHWDataGridView.Location = new Point(8, 26);
            internalHWDataGridView.Name = "internalHWDataGridView";
            internalHWDataGridView.RowTemplate.Height = 25;
            internalHWDataGridView.Size = new Size(284, 254);
            internalHWDataGridView.TabIndex = 2;
            // 
            // extHardwareLabel
            // 
            extHardwareLabel.AutoSize = true;
            extHardwareLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            extHardwareLabel.ForeColor = SystemColors.ButtonHighlight;
            extHardwareLabel.Location = new Point(314, 3);
            extHardwareLabel.Name = "extHardwareLabel";
            extHardwareLabel.Size = new Size(136, 20);
            extHardwareLabel.TabIndex = 1;
            extHardwareLabel.Text = "External Hardware";
            // 
            // intHardwareLabel
            // 
            intHardwareLabel.AutoSize = true;
            intHardwareLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            intHardwareLabel.ForeColor = SystemColors.ButtonHighlight;
            intHardwareLabel.Location = new Point(3, 3);
            intHardwareLabel.Name = "intHardwareLabel";
            intHardwareLabel.Size = new Size(133, 20);
            intHardwareLabel.TabIndex = 0;
            intHardwareLabel.Text = "Internal Hardware";
            // 
            // inputFPSLabel
            // 
            inputFPSLabel.AutoSize = true;
            inputFPSLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            inputFPSLabel.ForeColor = SystemColors.ButtonHighlight;
            inputFPSLabel.Location = new Point(468, 460);
            inputFPSLabel.Name = "inputFPSLabel";
            inputFPSLabel.Size = new Size(62, 21);
            inputFPSLabel.TabIndex = 10;
            inputFPSLabel.Text = "FPS: 23";
            // 
            // postProcessFPSLabel
            // 
            postProcessFPSLabel.AutoSize = true;
            postProcessFPSLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            postProcessFPSLabel.ForeColor = SystemColors.ButtonHighlight;
            postProcessFPSLabel.Location = new Point(974, 460);
            postProcessFPSLabel.Name = "postProcessFPSLabel";
            postProcessFPSLabel.Size = new Size(59, 21);
            postProcessFPSLabel.TabIndex = 11;
            postProcessFPSLabel.Text = "FPS: 10";
            // 
            // inputResLabel
            // 
            inputResLabel.AutoSize = true;
            inputResLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            inputResLabel.ForeColor = SystemColors.ButtonHighlight;
            inputResLabel.Location = new Point(242, 460);
            inputResLabel.Name = "inputResLabel";
            inputResLabel.Size = new Size(84, 21);
            inputResLabel.TabIndex = 12;
            inputResLabel.Text = "1920x1080";
            // 
            // outputResLabel
            // 
            outputResLabel.AutoSize = true;
            outputResLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            outputResLabel.ForeColor = SystemColors.ButtonHighlight;
            outputResLabel.Location = new Point(779, 460);
            outputResLabel.Name = "outputResLabel";
            outputResLabel.Size = new Size(84, 21);
            outputResLabel.TabIndex = 13;
            outputResLabel.Text = "1920x1080";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(684, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(641, 452);
            tabControl1.TabIndex = 5;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(pictureBox3);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(633, 424);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "Input Video";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Black;
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(627, 418);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(postProcessFeedLabel);
            tabPage3.Controls.Add(pictureBox2);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(633, 424);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "Post-Process Video";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Black;
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(627, 418);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // postProcessFeedLabel
            // 
            postProcessFeedLabel.AutoSize = true;
            postProcessFeedLabel.BackColor = Color.Black;
            postProcessFeedLabel.FlatStyle = FlatStyle.Flat;
            postProcessFeedLabel.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            postProcessFeedLabel.ForeColor = SystemColors.ButtonHighlight;
            postProcessFeedLabel.Location = new Point(226, 175);
            postProcessFeedLabel.Name = "postProcessFeedLabel";
            postProcessFeedLabel.Size = new Size(241, 65);
            postProcessFeedLabel.TabIndex = 2;
            postProcessFeedLabel.Text = "No feed...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1326, 787);
            Controls.Add(tabControl1);
            Controls.Add(outputResLabel);
            Controls.Add(inputVideoTabControl);
            Controls.Add(inputResLabel);
            Controls.Add(postProcessFPSLabel);
            Controls.Add(inputFPSLabel);
            Controls.Add(controlsTabControl);
            Name = "Form1";
            Text = "underwater-drone";
            ((System.ComponentModel.ISupportInitialize)videoPlayerImageBox).EndInit();
            inputVideoTabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            controlsTabControl.ResumeLayout(false);
            operationsTabPage.ResumeLayout(false);
            operationsTabPage.PerformLayout();
            hardwareTabPage.ResumeLayout(false);
            hardwareTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)miscHWDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)extHWDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)internalHWDataGridView).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox videoPlayerImageBox;
        private Button browseButton;
        private Button playButton;
        private TabControl inputVideoTabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private PictureBox pictureBox1;
        private Button stopButton;
        private TrackBar videoTrackBar;
        private TabControl controlsTabControl;
        private TabPage operationsTabPage;
        private TabPage hardwareTabPage;
        private Label inputFeedLabel;
        private Label currentRenderMethodLabel;
        private Label intHardwareLabel;
        private Label extHardwareLabel;
        private DataGridView internalHWDataGridView;
        private Label filterLabel;
        private DataGridView miscHWDataGridView;
        private Label miscHardwareLabel;
        private DataGridView extHWDataGridView;
        private Button exportButton;
        private Label inputFPSLabel;
        private Label postProcessFPSLabel;
        private Button pauseButton;
        private ComboBox filterComboBox;
        private ComboBox renderMethodComboBox;
        private Label inputResLabel;
        private Label outputResLabel;
        private TabControl tabControl1;
        private TabPage tabPage3;
        private Label postProcessFeedLabel;
        private PictureBox pictureBox2;
        private TabPage tabPage4;
        private PictureBox pictureBox3;
    }
}