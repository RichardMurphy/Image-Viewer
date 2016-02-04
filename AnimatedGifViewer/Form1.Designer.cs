namespace AnimatedGifViewer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pictureBoxLeft = new System.Windows.Forms.PictureBox();
            this.pictureBoxRight = new System.Windows.Forms.PictureBox();
            this.pictureBoxFullScreenOn = new System.Windows.Forms.PictureBox();
            this.pictureBoxOpenFile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFullScreenOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenFile)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(696, 325);
            this.webBrowser.TabIndex = 0;
            // 
            // pictureBoxLeft
            // 
            this.pictureBoxLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLeft.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxLeft.Image = global::AnimatedGifViewer.Properties.Resources.left;
            this.pictureBoxLeft.Location = new System.Drawing.Point(626, 70);
            this.pictureBoxLeft.Name = "pictureBoxLeft";
            this.pictureBoxLeft.Size = new System.Drawing.Size(20, 21);
            this.pictureBoxLeft.TabIndex = 7;
            this.pictureBoxLeft.TabStop = false;
            this.pictureBoxLeft.Click += new System.EventHandler(this.pictureBoxLeft_Click);
            // 
            // pictureBoxRight
            // 
            this.pictureBoxRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRight.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxRight.Image = global::AnimatedGifViewer.Properties.Resources.right;
            this.pictureBoxRight.Location = new System.Drawing.Point(652, 71);
            this.pictureBoxRight.Name = "pictureBoxRight";
            this.pictureBoxRight.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxRight.TabIndex = 6;
            this.pictureBoxRight.TabStop = false;
            this.pictureBoxRight.Click += new System.EventHandler(this.pictureBoxRight_Click);
            // 
            // pictureBoxFullScreenOn
            // 
            this.pictureBoxFullScreenOn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxFullScreenOn.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxFullScreenOn.Image = global::AnimatedGifViewer.Properties.Resources.full_screen;
            this.pictureBoxFullScreenOn.Location = new System.Drawing.Point(648, 12);
            this.pictureBoxFullScreenOn.Name = "pictureBoxFullScreenOn";
            this.pictureBoxFullScreenOn.Size = new System.Drawing.Size(24, 23);
            this.pictureBoxFullScreenOn.TabIndex = 5;
            this.pictureBoxFullScreenOn.TabStop = false;
            this.pictureBoxFullScreenOn.Click += new System.EventHandler(this.pictureBoxFullScreenOn_Click);
            // 
            // pictureBoxOpenFile
            // 
            this.pictureBoxOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxOpenFile.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxOpenFile.Image = global::AnimatedGifViewer.Properties.Resources.open_file_emoji_small;
            this.pictureBoxOpenFile.Location = new System.Drawing.Point(635, 42);
            this.pictureBoxOpenFile.Name = "pictureBoxOpenFile";
            this.pictureBoxOpenFile.Size = new System.Drawing.Size(37, 23);
            this.pictureBoxOpenFile.TabIndex = 4;
            this.pictureBoxOpenFile.TabStop = false;
            this.pictureBoxOpenFile.Click += new System.EventHandler(this.pictureBoxOpenFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 325);
            this.Controls.Add(this.pictureBoxLeft);
            this.Controls.Add(this.pictureBoxRight);
            this.Controls.Add(this.pictureBoxFullScreenOn);
            this.Controls.Add(this.pictureBoxOpenFile);
            this.Controls.Add(this.webBrowser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Animated GIF Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFullScreenOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenFile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.PictureBox pictureBoxOpenFile;
        private System.Windows.Forms.PictureBox pictureBoxFullScreenOn;
        private System.Windows.Forms.PictureBox pictureBoxRight;
        private System.Windows.Forms.PictureBox pictureBoxLeft;
    }
}

