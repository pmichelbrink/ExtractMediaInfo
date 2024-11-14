namespace ExtractMediaInfo
{
    partial class ExtractMediaInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtractMediaInfo));
            btnExtract = new Button();
            rtbLog = new RichTextBox();
            openFileDialog = new OpenFileDialog();
            txtFiles = new TextBox();
            lblFiles = new Label();
            grpExtract = new GroupBox();
            gbPath = new GroupBox();
            btnFolderBrowse = new Button();
            txtPath = new TextBox();
            rbAllDrives = new RadioButton();
            rbSelectedFolder = new RadioButton();
            grpConsolidate = new GroupBox();
            btnConsolidate = new Button();
            btnBrowse = new Button();
            folderBrowserDialog = new FolderBrowserDialog();
            groupBox1 = new GroupBox();
            btnFindDuplicates = new Button();
            btnDupBrowse = new Button();
            txtDupSourceFile = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtArtist = new TextBox();
            label3 = new Label();
            btnWriteFlacDetails = new Button();
            btnFlacFolderBrowse = new Button();
            label2 = new Label();
            txtFlacFolder = new TextBox();
            grpExtract.SuspendLayout();
            gbPath.SuspendLayout();
            grpConsolidate.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnExtract
            // 
            btnExtract.Location = new Point(308, 554);
            btnExtract.Margin = new Padding(5, 6, 5, 6);
            btnExtract.Name = "btnExtract";
            btnExtract.Size = new Size(125, 44);
            btnExtract.TabIndex = 0;
            btnExtract.Text = "Extract";
            btnExtract.UseVisualStyleBackColor = true;
            btnExtract.Click += btnStart_Click;
            // 
            // rtbLog
            // 
            rtbLog.Location = new Point(17, 37);
            rtbLog.Margin = new Padding(5, 6, 5, 6);
            rtbLog.Name = "rtbLog";
            rtbLog.Size = new Size(404, 292);
            rtbLog.TabIndex = 1;
            rtbLog.Text = "";
            // 
            // txtFiles
            // 
            txtFiles.Location = new Point(78, 31);
            txtFiles.Margin = new Padding(5, 6, 5, 6);
            txtFiles.Name = "txtFiles";
            txtFiles.Size = new Size(291, 31);
            txtFiles.TabIndex = 2;
            // 
            // lblFiles
            // 
            lblFiles.AutoSize = true;
            lblFiles.Location = new Point(17, 31);
            lblFiles.Margin = new Padding(5, 0, 5, 0);
            lblFiles.Name = "lblFiles";
            lblFiles.Size = new Size(50, 25);
            lblFiles.TabIndex = 3;
            lblFiles.Text = "Files:";
            // 
            // grpExtract
            // 
            grpExtract.Controls.Add(gbPath);
            grpExtract.Controls.Add(rtbLog);
            grpExtract.Controls.Add(btnExtract);
            grpExtract.Location = new Point(13, 0);
            grpExtract.Margin = new Padding(5, 6, 5, 6);
            grpExtract.Name = "grpExtract";
            grpExtract.Padding = new Padding(5, 6, 5, 6);
            grpExtract.Size = new Size(457, 623);
            grpExtract.TabIndex = 4;
            grpExtract.TabStop = false;
            grpExtract.Text = "Extract";
            // 
            // gbPath
            // 
            gbPath.Controls.Add(btnFolderBrowse);
            gbPath.Controls.Add(txtPath);
            gbPath.Controls.Add(rbAllDrives);
            gbPath.Controls.Add(rbSelectedFolder);
            gbPath.Location = new Point(17, 344);
            gbPath.Margin = new Padding(5, 6, 5, 6);
            gbPath.Name = "gbPath";
            gbPath.Padding = new Padding(5, 6, 5, 6);
            gbPath.Size = new Size(407, 198);
            gbPath.TabIndex = 4;
            gbPath.TabStop = false;
            gbPath.Text = "Path";
            // 
            // btnFolderBrowse
            // 
            btnFolderBrowse.Location = new Point(353, 127);
            btnFolderBrowse.Margin = new Padding(5, 6, 5, 6);
            btnFolderBrowse.Name = "btnFolderBrowse";
            btnFolderBrowse.Size = new Size(43, 44);
            btnFolderBrowse.TabIndex = 5;
            btnFolderBrowse.Text = "...";
            btnFolderBrowse.UseVisualStyleBackColor = true;
            btnFolderBrowse.Click += btnFolderBrowse_Click;
            // 
            // txtPath
            // 
            txtPath.Location = new Point(62, 127);
            txtPath.Margin = new Padding(5, 6, 5, 6);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(279, 31);
            txtPath.TabIndex = 4;
            // 
            // rbAllDrives
            // 
            rbAllDrives.AutoSize = true;
            rbAllDrives.Checked = true;
            rbAllDrives.Location = new Point(33, 37);
            rbAllDrives.Margin = new Padding(5, 6, 5, 6);
            rbAllDrives.Name = "rbAllDrives";
            rbAllDrives.Size = new Size(153, 29);
            rbAllDrives.TabIndex = 2;
            rbAllDrives.TabStop = true;
            rbAllDrives.Text = "Scan All Drives";
            rbAllDrives.UseVisualStyleBackColor = true;
            // 
            // rbSelectedFolder
            // 
            rbSelectedFolder.AutoSize = true;
            rbSelectedFolder.Location = new Point(33, 81);
            rbSelectedFolder.Margin = new Padding(5, 6, 5, 6);
            rbSelectedFolder.Name = "rbSelectedFolder";
            rbSelectedFolder.Size = new Size(162, 29);
            rbSelectedFolder.TabIndex = 3;
            rbSelectedFolder.Text = "Selected Folder:";
            rbSelectedFolder.UseVisualStyleBackColor = true;
            // 
            // grpConsolidate
            // 
            grpConsolidate.Controls.Add(btnConsolidate);
            grpConsolidate.Controls.Add(btnBrowse);
            grpConsolidate.Controls.Add(lblFiles);
            grpConsolidate.Controls.Add(txtFiles);
            grpConsolidate.Location = new Point(13, 635);
            grpConsolidate.Margin = new Padding(5, 6, 5, 6);
            grpConsolidate.Name = "grpConsolidate";
            grpConsolidate.Padding = new Padding(5, 6, 5, 6);
            grpConsolidate.Size = new Size(457, 171);
            grpConsolidate.TabIndex = 5;
            grpConsolidate.TabStop = false;
            grpConsolidate.Text = "Consolidate";
            // 
            // btnConsolidate
            // 
            btnConsolidate.Location = new Point(315, 112);
            btnConsolidate.Margin = new Padding(5, 6, 5, 6);
            btnConsolidate.Name = "btnConsolidate";
            btnConsolidate.Size = new Size(125, 44);
            btnConsolidate.TabIndex = 5;
            btnConsolidate.Text = "Consolidate";
            btnConsolidate.UseVisualStyleBackColor = true;
            btnConsolidate.Click += btnConsolidate_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(382, 27);
            btnBrowse.Margin = new Padding(5, 6, 5, 6);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(52, 44);
            btnBrowse.TabIndex = 4;
            btnBrowse.Text = "...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnFindDuplicates);
            groupBox1.Controls.Add(btnDupBrowse);
            groupBox1.Controls.Add(txtDupSourceFile);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(20, 817);
            groupBox1.Margin = new Padding(5, 6, 5, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 6, 5, 6);
            groupBox1.Size = new Size(450, 167);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Duplicates";
            // 
            // btnFindDuplicates
            // 
            btnFindDuplicates.Location = new Point(287, 112);
            btnFindDuplicates.Margin = new Padding(5, 6, 5, 6);
            btnFindDuplicates.Name = "btnFindDuplicates";
            btnFindDuplicates.Size = new Size(147, 44);
            btnFindDuplicates.TabIndex = 3;
            btnFindDuplicates.Text = "Find Duplicates";
            btnFindDuplicates.UseVisualStyleBackColor = true;
            btnFindDuplicates.Click += btnFindDuplicates_Click;
            // 
            // btnDupBrowse
            // 
            btnDupBrowse.Location = new Point(375, 27);
            btnDupBrowse.Margin = new Padding(5, 6, 5, 6);
            btnDupBrowse.Name = "btnDupBrowse";
            btnDupBrowse.Size = new Size(57, 44);
            btnDupBrowse.TabIndex = 2;
            btnDupBrowse.Text = "...";
            btnDupBrowse.UseVisualStyleBackColor = true;
            btnDupBrowse.Click += btnDupBrowse_Click;
            // 
            // txtDupSourceFile
            // 
            txtDupSourceFile.Location = new Point(130, 33);
            txtDupSourceFile.Margin = new Padding(5, 6, 5, 6);
            txtDupSourceFile.Name = "txtDupSourceFile";
            txtDupSourceFile.Size = new Size(232, 31);
            txtDupSourceFile.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 38);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 0;
            label1.Text = "Source File:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtArtist);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btnWriteFlacDetails);
            groupBox2.Controls.Add(btnFlacFolderBrowse);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtFlacFolder);
            groupBox2.Location = new Point(13, 996);
            groupBox2.Margin = new Padding(5, 6, 5, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5, 6, 5, 6);
            groupBox2.Size = new Size(457, 196);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Write Flac Details";
            // 
            // txtArtist
            // 
            txtArtist.Location = new Point(95, 84);
            txtArtist.Name = "txtArtist";
            txtArtist.Size = new Size(274, 31);
            txtArtist.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 87);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 6;
            label3.Text = "Artist:";
            // 
            // btnWriteFlacDetails
            // 
            btnWriteFlacDetails.Location = new Point(280, 124);
            btnWriteFlacDetails.Margin = new Padding(5, 6, 5, 6);
            btnWriteFlacDetails.Name = "btnWriteFlacDetails";
            btnWriteFlacDetails.Size = new Size(160, 44);
            btnWriteFlacDetails.TabIndex = 5;
            btnWriteFlacDetails.Text = "Write Flac Details";
            btnWriteFlacDetails.UseVisualStyleBackColor = true;
            btnWriteFlacDetails.Click += button1_Click;
            // 
            // btnFlacFolderBrowse
            // 
            btnFlacFolderBrowse.Location = new Point(382, 27);
            btnFlacFolderBrowse.Margin = new Padding(5, 6, 5, 6);
            btnFlacFolderBrowse.Name = "btnFlacFolderBrowse";
            btnFlacFolderBrowse.Size = new Size(52, 44);
            btnFlacFolderBrowse.TabIndex = 4;
            btnFlacFolderBrowse.Text = "...";
            btnFlacFolderBrowse.UseVisualStyleBackColor = true;
            btnFlacFolderBrowse.Click += btnFlacFolderBrowse_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 34);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 3;
            label2.Text = "Folder:";
            // 
            // txtFlacFolder
            // 
            txtFlacFolder.Location = new Point(95, 31);
            txtFlacFolder.Margin = new Padding(5, 6, 5, 6);
            txtFlacFolder.Name = "txtFlacFolder";
            txtFlacFolder.Size = new Size(274, 31);
            txtFlacFolder.TabIndex = 2;
            // 
            // ExtractMediaInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(480, 1207);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(grpConsolidate);
            Controls.Add(grpExtract);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "ExtractMediaInfo";
            Text = "Extract Media Info";
            grpExtract.ResumeLayout(false);
            gbPath.ResumeLayout(false);
            gbPath.PerformLayout();
            grpConsolidate.ResumeLayout(false);
            grpConsolidate.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox txtFiles;
        private System.Windows.Forms.Label lblFiles;
        private System.Windows.Forms.GroupBox grpExtract;
        private System.Windows.Forms.GroupBox grpConsolidate;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnConsolidate;
        private System.Windows.Forms.GroupBox gbPath;
        private System.Windows.Forms.Button btnFolderBrowse;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.RadioButton rbAllDrives;
        private System.Windows.Forms.RadioButton rbSelectedFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFindDuplicates;
        private System.Windows.Forms.Button btnDupBrowse;
        private System.Windows.Forms.TextBox txtDupSourceFile;
        private System.Windows.Forms.Label label1;
        private GroupBox groupBox2;
        private Button btnWriteFlacDetails;
        private Button btnFlacFolderBrowse;
        private Label label2;
        private TextBox txtFlacFolder;
        private TextBox txtArtist;
        private Label label3;
    }
}

