namespace Last_Project
{
    partial class Form
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
            this.components = new System.ComponentModel.Container();
            this.upload = new System.Windows.Forms.Button();
            this.picsList = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.single = new System.Windows.Forms.ToolStripMenuItem();
            this.multi = new System.Windows.Forms.ToolStripMenuItem();
            this.SlideShow = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.uploadFiles = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.hints = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // upload
            // 
            this.upload.Location = new System.Drawing.Point(22, 677);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(266, 85);
            this.upload.TabIndex = 1;
            this.upload.Text = "Upload";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // picsList
            // 
            this.picsList.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.picsList.FormattingEnabled = true;
            this.picsList.ItemHeight = 16;
            this.picsList.Location = new System.Drawing.Point(22, 63);
            this.picsList.Name = "picsList";
            this.picsList.Size = new System.Drawing.Size(266, 580);
            this.picsList.TabIndex = 1;
            this.picsList.SelectedIndexChanged += new System.EventHandler(this.picsList_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.single,
            this.multi,
            this.SlideShow,
            this.Exit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(152, 100);
            // 
            // single
            // 
            this.single.CheckOnClick = true;
            this.single.Name = "single";
            this.single.Size = new System.Drawing.Size(151, 24);
            this.single.Text = "Single";
            this.single.Click += new System.EventHandler(this.single_Click);
            // 
            // multi
            // 
            this.multi.CheckOnClick = true;
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(151, 24);
            this.multi.Text = "Multi";
            this.multi.Click += new System.EventHandler(this.multi_Click);
            // 
            // SlideShow
            // 
            this.SlideShow.CheckOnClick = true;
            this.SlideShow.Name = "SlideShow";
            this.SlideShow.Size = new System.Drawing.Size(151, 24);
            this.SlideShow.Text = "Slide Show";
            this.SlideShow.Click += new System.EventHandler(this.SlideShow_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(151, 24);
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(758, 710);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 34);
            this.label1.TabIndex = 2;
            // 
            // uploadFiles
            // 
            this.uploadFiles.FileName = "uploadFiles";
            this.uploadFiles.Filter = "\"images(select|*.GIF; *.JPEG; *.EXIF; *.PNG; *.TIFF; *.SVG; *.jpg;)\"";
            this.uploadFiles.Multiselect = true;
            this.uploadFiles.RestoreDirectory = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(53, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pictures List";
            // 
            // hints
            // 
            this.hints.AutoSize = true;
            this.hints.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hints.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hints.Location = new System.Drawing.Point(663, 9);
            this.hints.Name = "hints";
            this.hints.Size = new System.Drawing.Size(586, 29);
            this.hints.TabIndex = 4;
            this.hints.Text = "Upload and Right click to choose the view mode";
            this.hints.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(1362, 823);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.hints);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picsList);
            this.Controls.Add(this.upload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.ListBox picsList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem single;
        private System.Windows.Forms.ToolStripMenuItem multi;
        private System.Windows.Forms.ToolStripMenuItem SlideShow;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog uploadFiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label hints;
    }
}

