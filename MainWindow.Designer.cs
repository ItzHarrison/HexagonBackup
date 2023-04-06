namespace HexagonBackup
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.list_SourceDirectories = new System.Windows.Forms.ListBox();
            this.textbox_AddSource = new System.Windows.Forms.TextBox();
            this.button_RemoveSource = new System.Windows.Forms.Button();
            this.button_AddSource = new System.Windows.Forms.Button();
            this.button_BrowseSource = new System.Windows.Forms.Button();
            this.label_Version = new System.Windows.Forms.Label();
            this.button_ClearSource = new System.Windows.Forms.Button();
            this.groupbox_Sources = new System.Windows.Forms.GroupBox();
            this.label_Developer = new System.Windows.Forms.Label();
            this.groupbox_Target = new System.Windows.Forms.GroupBox();
            this.label_Status = new System.Windows.Forms.Label();
            this.button_OpenTarget = new System.Windows.Forms.Button();
            this.progress_Backup = new System.Windows.Forms.ProgressBar();
            this.textbox_Target = new System.Windows.Forms.TextBox();
            this.button_Backup = new System.Windows.Forms.Button();
            this.button_BrowseTarget = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.check_Shutdown = new System.Windows.Forms.CheckBox();
            this.groupbox_Sources.SuspendLayout();
            this.groupbox_Target.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // list_SourceDirectories
            // 
            this.list_SourceDirectories.FormattingEnabled = true;
            this.list_SourceDirectories.Location = new System.Drawing.Point(14, 19);
            this.list_SourceDirectories.Name = "list_SourceDirectories";
            this.list_SourceDirectories.Size = new System.Drawing.Size(251, 277);
            this.list_SourceDirectories.TabIndex = 1;
            this.list_SourceDirectories.SelectedIndexChanged += new System.EventHandler(this.list_SourceDirectories_SelectedIndexChanged);
            // 
            // textbox_AddSource
            // 
            this.textbox_AddSource.Location = new System.Drawing.Point(14, 302);
            this.textbox_AddSource.Name = "textbox_AddSource";
            this.textbox_AddSource.Size = new System.Drawing.Size(189, 20);
            this.textbox_AddSource.TabIndex = 3;
            this.textbox_AddSource.TextChanged += new System.EventHandler(this.textbox_AddSource_TextChanged);
            // 
            // button_RemoveSource
            // 
            this.button_RemoveSource.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_RemoveSource.Enabled = false;
            this.button_RemoveSource.Location = new System.Drawing.Point(100, 329);
            this.button_RemoveSource.Name = "button_RemoveSource";
            this.button_RemoveSource.Size = new System.Drawing.Size(80, 49);
            this.button_RemoveSource.TabIndex = 4;
            this.button_RemoveSource.Text = "Remove selected";
            this.button_RemoveSource.UseVisualStyleBackColor = true;
            this.button_RemoveSource.Click += new System.EventHandler(this.button_RemoveSource_Click);
            // 
            // button_AddSource
            // 
            this.button_AddSource.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AddSource.Enabled = false;
            this.button_AddSource.Location = new System.Drawing.Point(186, 329);
            this.button_AddSource.Name = "button_AddSource";
            this.button_AddSource.Size = new System.Drawing.Size(80, 49);
            this.button_AddSource.TabIndex = 5;
            this.button_AddSource.Text = "Add source directory";
            this.button_AddSource.UseVisualStyleBackColor = true;
            this.button_AddSource.Click += new System.EventHandler(this.button_AddSource_Click);
            // 
            // button_BrowseSource
            // 
            this.button_BrowseSource.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_BrowseSource.Location = new System.Drawing.Point(209, 301);
            this.button_BrowseSource.Name = "button_BrowseSource";
            this.button_BrowseSource.Size = new System.Drawing.Size(56, 22);
            this.button_BrowseSource.TabIndex = 6;
            this.button_BrowseSource.Text = "Browse";
            this.button_BrowseSource.UseVisualStyleBackColor = true;
            this.button_BrowseSource.Click += new System.EventHandler(this.button_BrowseSource_Click);
            // 
            // label_Version
            // 
            this.label_Version.AutoSize = true;
            this.label_Version.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_Version.Location = new System.Drawing.Point(3, 395);
            this.label_Version.Name = "label_Version";
            this.label_Version.Size = new System.Drawing.Size(143, 13);
            this.label_Version.TabIndex = 7;
            this.label_Version.Text = "Version 1.2.0 - Release Build";
            this.label_Version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_ClearSource
            // 
            this.button_ClearSource.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ClearSource.Location = new System.Drawing.Point(14, 329);
            this.button_ClearSource.Name = "button_ClearSource";
            this.button_ClearSource.Size = new System.Drawing.Size(80, 49);
            this.button_ClearSource.TabIndex = 8;
            this.button_ClearSource.Text = "Clear all directories";
            this.button_ClearSource.UseVisualStyleBackColor = true;
            this.button_ClearSource.Click += new System.EventHandler(this.button_ClearSource_Click);
            // 
            // groupbox_Sources
            // 
            this.groupbox_Sources.Controls.Add(this.list_SourceDirectories);
            this.groupbox_Sources.Controls.Add(this.button_ClearSource);
            this.groupbox_Sources.Controls.Add(this.textbox_AddSource);
            this.groupbox_Sources.Controls.Add(this.button_RemoveSource);
            this.groupbox_Sources.Controls.Add(this.button_BrowseSource);
            this.groupbox_Sources.Controls.Add(this.button_AddSource);
            this.groupbox_Sources.Location = new System.Drawing.Point(10, 5);
            this.groupbox_Sources.Name = "groupbox_Sources";
            this.groupbox_Sources.Size = new System.Drawing.Size(280, 385);
            this.groupbox_Sources.TabIndex = 9;
            this.groupbox_Sources.TabStop = false;
            this.groupbox_Sources.Text = "Source Directories:";
            // 
            // label_Developer
            // 
            this.label_Developer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Developer.AutoSize = true;
            this.label_Developer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Developer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Developer.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_Developer.Location = new System.Drawing.Point(471, 395);
            this.label_Developer.Name = "label_Developer";
            this.label_Developer.Size = new System.Drawing.Size(118, 13);
            this.label_Developer.TabIndex = 10;
            this.label_Developer.Text = "Made by Harrison Pugh\r\n";
            this.label_Developer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_Developer.Click += new System.EventHandler(this.label_Developer_Click);
            // 
            // groupbox_Target
            // 
            this.groupbox_Target.Controls.Add(this.check_Shutdown);
            this.groupbox_Target.Controls.Add(this.label_Status);
            this.groupbox_Target.Controls.Add(this.button_OpenTarget);
            this.groupbox_Target.Controls.Add(this.progress_Backup);
            this.groupbox_Target.Controls.Add(this.textbox_Target);
            this.groupbox_Target.Controls.Add(this.button_Backup);
            this.groupbox_Target.Controls.Add(this.button_BrowseTarget);
            this.groupbox_Target.Location = new System.Drawing.Point(302, 203);
            this.groupbox_Target.Name = "groupbox_Target";
            this.groupbox_Target.Size = new System.Drawing.Size(280, 187);
            this.groupbox_Target.TabIndex = 10;
            this.groupbox_Target.TabStop = false;
            this.groupbox_Target.Text = "Target Directory:";
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Enabled = false;
            this.label_Status.Location = new System.Drawing.Point(11, 138);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(40, 13);
            this.label_Status.TabIndex = 12;
            this.label_Status.Text = "Status:";
            this.label_Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_OpenTarget
            // 
            this.button_OpenTarget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_OpenTarget.Enabled = false;
            this.button_OpenTarget.Location = new System.Drawing.Point(194, 131);
            this.button_OpenTarget.Name = "button_OpenTarget";
            this.button_OpenTarget.Size = new System.Drawing.Size(71, 49);
            this.button_OpenTarget.TabIndex = 9;
            this.button_OpenTarget.Text = "Open target directory";
            this.button_OpenTarget.UseVisualStyleBackColor = true;
            this.button_OpenTarget.Click += new System.EventHandler(this.button_OpenTarget_Click);
            // 
            // progress_Backup
            // 
            this.progress_Backup.Enabled = false;
            this.progress_Backup.Location = new System.Drawing.Point(14, 102);
            this.progress_Backup.Name = "progress_Backup";
            this.progress_Backup.Size = new System.Drawing.Size(251, 20);
            this.progress_Backup.Step = 1;
            this.progress_Backup.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progress_Backup.TabIndex = 7;
            // 
            // textbox_Target
            // 
            this.textbox_Target.Location = new System.Drawing.Point(14, 20);
            this.textbox_Target.Name = "textbox_Target";
            this.textbox_Target.Size = new System.Drawing.Size(189, 20);
            this.textbox_Target.TabIndex = 3;
            this.textbox_Target.TextChanged += new System.EventHandler(this.textbox_Target_TextChanged);
            // 
            // button_Backup
            // 
            this.button_Backup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Backup.Enabled = false;
            this.button_Backup.Location = new System.Drawing.Point(14, 45);
            this.button_Backup.Name = "button_Backup";
            this.button_Backup.Size = new System.Drawing.Size(251, 53);
            this.button_Backup.TabIndex = 4;
            this.button_Backup.Text = "Begin Backup";
            this.button_Backup.UseVisualStyleBackColor = true;
            this.button_Backup.Click += new System.EventHandler(this.button_Backup_Click);
            // 
            // button_BrowseTarget
            // 
            this.button_BrowseTarget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_BrowseTarget.Location = new System.Drawing.Point(209, 18);
            this.button_BrowseTarget.Name = "button_BrowseTarget";
            this.button_BrowseTarget.Size = new System.Drawing.Size(56, 22);
            this.button_BrowseTarget.TabIndex = 6;
            this.button_BrowseTarget.Text = "Browse";
            this.button_BrowseTarget.UseVisualStyleBackColor = true;
            this.button_BrowseTarget.Click += new System.EventHandler(this.button_BrowseTarget_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(354, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // check_Shutdown
            // 
            this.check_Shutdown.AutoSize = true;
            this.check_Shutdown.Location = new System.Drawing.Point(14, 163);
            this.check_Shutdown.Name = "check_Shutdown";
            this.check_Shutdown.Size = new System.Drawing.Size(149, 17);
            this.check_Shutdown.TabIndex = 13;
            this.check_Shutdown.Text = "Shutdown when complete";
            this.check_Shutdown.UseVisualStyleBackColor = true;
            this.check_Shutdown.CheckedChanged += new System.EventHandler(this.check_Shutdown_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(592, 411);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupbox_Target);
            this.Controls.Add(this.label_Developer);
            this.Controls.Add(this.groupbox_Sources);
            this.Controls.Add(this.label_Version);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Hexagon Backup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupbox_Sources.ResumeLayout(false);
            this.groupbox_Sources.PerformLayout();
            this.groupbox_Target.ResumeLayout(false);
            this.groupbox_Target.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox list_SourceDirectories;
        private System.Windows.Forms.TextBox textbox_AddSource;
        private System.Windows.Forms.Button button_RemoveSource;
        private System.Windows.Forms.Button button_AddSource;
        private System.Windows.Forms.Button button_BrowseSource;
        private System.Windows.Forms.Label label_Version;
        private System.Windows.Forms.Button button_ClearSource;
        private System.Windows.Forms.GroupBox groupbox_Sources;
        private System.Windows.Forms.Label label_Developer;
        private System.Windows.Forms.GroupBox groupbox_Target;
        private System.Windows.Forms.TextBox textbox_Target;
        private System.Windows.Forms.Button button_Backup;
        private System.Windows.Forms.Button button_BrowseTarget;
        private System.Windows.Forms.ProgressBar progress_Backup;
        private System.Windows.Forms.Button button_OpenTarget;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.CheckBox check_Shutdown;
    }
}

