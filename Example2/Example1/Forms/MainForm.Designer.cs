namespace Example1.Forms
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdInputFile = new System.Windows.Forms.OpenFileDialog();
            this.fbdInputFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.tbExpectedResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveCurrent = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbBlackWhite = new System.Windows.Forms.PictureBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCurrentIndex = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nudImageSide = new System.Windows.Forms.NumericUpDown();
            this.btnLearn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLearningRate = new System.Windows.Forms.TextBox();
            this.nudEpochCount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudHiddenLayerCount = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnShowResults = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlackWhite)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudImageSide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEpochCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHiddenLayerCount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(568, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.folderToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // folderToolStripMenuItem
            // 
            this.folderToolStripMenuItem.Name = "folderToolStripMenuItem";
            this.folderToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.folderToolStripMenuItem.Text = "Folder";
            this.folderToolStripMenuItem.Click += new System.EventHandler(this.folderToolStripMenuItem_Click);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(34, 17);
            this.pbImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(225, 206);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 1;
            this.pbImage.TabStop = false;
            this.pbImage.Paint += new System.Windows.Forms.PaintEventHandler(this.pbImage_Paint);
            // 
            // tbExpectedResult
            // 
            this.tbExpectedResult.Location = new System.Drawing.Point(70, 12);
            this.tbExpectedResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbExpectedResult.Name = "tbExpectedResult";
            this.tbExpectedResult.Size = new System.Drawing.Size(76, 20);
            this.tbExpectedResult.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Expected";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveCurrent);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbExpectedResult);
            this.groupBox1.Location = new System.Drawing.Point(9, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(150, 65);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnSaveCurrent
            // 
            this.btnSaveCurrent.Location = new System.Drawing.Point(34, 35);
            this.btnSaveCurrent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveCurrent.Name = "btnSaveCurrent";
            this.btnSaveCurrent.Size = new System.Drawing.Size(80, 19);
            this.btnSaveCurrent.TabIndex = 12;
            this.btnSaveCurrent.Text = "Save current";
            this.btnSaveCurrent.UseVisualStyleBackColor = true;
            this.btnSaveCurrent.Click += new System.EventHandler(this.btnSaveCurrent_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLeft.Location = new System.Drawing.Point(192, 228);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(28, 19);
            this.btnLeft.TabIndex = 6;
            this.btnLeft.Text = "<-";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRight.Location = new System.Drawing.Point(327, 228);
            this.btnRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(28, 19);
            this.btnRight.TabIndex = 7;
            this.btnRight.Text = "->";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pbBlackWhite);
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblCurrentIndex);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.pbImage);
            this.groupBox2.Controls.Add(this.btnRight);
            this.groupBox2.Controls.Add(this.btnLeft);
            this.groupBox2.Location = new System.Drawing.Point(9, 262);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(550, 252);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // pbBlackWhite
            // 
            this.pbBlackWhite.Location = new System.Drawing.Point(290, 17);
            this.pbBlackWhite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbBlackWhite.Name = "pbBlackWhite";
            this.pbBlackWhite.Size = new System.Drawing.Size(225, 206);
            this.pbBlackWhite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBlackWhite.TabIndex = 12;
            this.pbBlackWhite.TabStop = false;
            this.pbBlackWhite.Paint += new System.Windows.Forms.PaintEventHandler(this.pbBlackWhite_Paint);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(301, 228);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 13);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 228);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "of";
            // 
            // lblCurrentIndex
            // 
            this.lblCurrentIndex.AutoSize = true;
            this.lblCurrentIndex.Location = new System.Drawing.Point(235, 228);
            this.lblCurrentIndex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentIndex.Name = "lblCurrentIndex";
            this.lblCurrentIndex.Size = new System.Drawing.Size(13, 13);
            this.lblCurrentIndex.TabIndex = 9;
            this.lblCurrentIndex.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 231);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 8;
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(7, 30);
            this.lblFilePath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(52, 13);
            this.lblFilePath.TabIndex = 11;
            this.lblFilePath.Text = "File name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.nudImageSide);
            this.groupBox3.Controls.Add(this.btnLearn);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tbLearningRate);
            this.groupBox3.Controls.Add(this.nudEpochCount);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.nudHiddenLayerCount);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(355, 53);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(205, 164);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 105);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Converted Image Side";
            // 
            // nudImageSide
            // 
            this.nudImageSide.Location = new System.Drawing.Point(160, 103);
            this.nudImageSide.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudImageSide.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudImageSide.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudImageSide.Name = "nudImageSide";
            this.nudImageSide.Size = new System.Drawing.Size(40, 20);
            this.nudImageSide.TabIndex = 9;
            this.nudImageSide.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // btnLearn
            // 
            this.btnLearn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLearn.Location = new System.Drawing.Point(70, 141);
            this.btnLearn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLearn.Name = "btnLearn";
            this.btnLearn.Size = new System.Drawing.Size(64, 19);
            this.btnLearn.TabIndex = 5;
            this.btnLearn.Text = "Learn";
            this.btnLearn.UseVisualStyleBackColor = true;
            this.btnLearn.Click += new System.EventHandler(this.btnLearn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Learning Rate";
            // 
            // tbLearningRate
            // 
            this.tbLearningRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLearningRate.Location = new System.Drawing.Point(152, 73);
            this.tbLearningRate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbLearningRate.Name = "tbLearningRate";
            this.tbLearningRate.Size = new System.Drawing.Size(50, 20);
            this.tbLearningRate.TabIndex = 7;
            // 
            // nudEpochCount
            // 
            this.nudEpochCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudEpochCount.Location = new System.Drawing.Point(130, 42);
            this.nudEpochCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudEpochCount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudEpochCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEpochCount.Name = "nudEpochCount";
            this.nudEpochCount.Size = new System.Drawing.Size(70, 20);
            this.nudEpochCount.TabIndex = 6;
            this.nudEpochCount.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Epoch Count";
            // 
            // nudHiddenLayerCount
            // 
            this.nudHiddenLayerCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudHiddenLayerCount.Location = new System.Drawing.Point(165, 13);
            this.nudHiddenLayerCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudHiddenLayerCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudHiddenLayerCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHiddenLayerCount.Name = "nudHiddenLayerCount";
            this.nudHiddenLayerCount.Size = new System.Drawing.Size(35, 20);
            this.nudHiddenLayerCount.TabIndex = 4;
            this.nudHiddenLayerCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Hidden Layer Neurons";
            // 
            // btnShowResults
            // 
            this.btnShowResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowResults.Enabled = false;
            this.btnShowResults.Location = new System.Drawing.Point(355, 238);
            this.btnShowResults.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowResults.Name = "btnShowResults";
            this.btnShowResults.Size = new System.Drawing.Size(95, 19);
            this.btnShowResults.TabIndex = 6;
            this.btnShowResults.Text = "Show Results";
            this.btnShowResults.UseVisualStyleBackColor = true;
            this.btnShowResults.Click += new System.EventHandler(this.btnShowResults_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(516, 240);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(40, 13);
            this.lblResult.TabIndex = 13;
            this.lblResult.Text = " Result";
            this.lblResult.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 514);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnShowResults);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Recognize images";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlackWhite)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudImageSide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEpochCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHiddenLayerCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem folderToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofdInputFile;
        private System.Windows.Forms.FolderBrowserDialog fbdInputFolder;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.TextBox tbExpectedResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCurrentIndex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveCurrent;
        private System.Windows.Forms.PictureBox pbBlackWhite;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLearningRate;
        private System.Windows.Forms.NumericUpDown nudEpochCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudHiddenLayerCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLearn;
        private System.Windows.Forms.Button btnShowResults;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudImageSide;
    }
}