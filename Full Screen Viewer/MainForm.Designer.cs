namespace PictureViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.mainImageOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pictureBoxOpenFile = new System.Windows.Forms.PictureBox();
            this.pictureBoxFullScreen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFullScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.BackColor = System.Drawing.Color.Black;
            this.mainPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPictureBox.Location = new System.Drawing.Point(0, 0);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(684, 332);
            this.mainPictureBox.TabIndex = 0;
            this.mainPictureBox.TabStop = false;
            this.mainPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainPictureBox_MouseClick);
            this.mainPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPictureBox_MouseDown);
            this.mainPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPictureBox_MouseMove);
            this.mainPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPictureBox_MouseUp);
            // 
            // mainImageOpenFileDialog
            // 
            this.mainImageOpenFileDialog.Filter = "bmp jpg gif png|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            this.mainImageOpenFileDialog.Title = "Open a Picture";
            // 
            // pictureBoxOpenFile
            // 
            this.pictureBoxOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxOpenFile.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxOpenFile.Image = global::PictureViewer.Properties.Resources.open_file_emoji_small;
            this.pictureBoxOpenFile.Location = new System.Drawing.Point(640, 41);
            this.pictureBoxOpenFile.Name = "pictureBoxOpenFile";
            this.pictureBoxOpenFile.Size = new System.Drawing.Size(38, 23);
            this.pictureBoxOpenFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxOpenFile.TabIndex = 4;
            this.pictureBoxOpenFile.TabStop = false;
            this.pictureBoxOpenFile.Click += new System.EventHandler(this.pictureBoxOpenFile_Click);
            // 
            // pictureBoxFullScreen
            // 
            this.pictureBoxFullScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxFullScreen.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFullScreen.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFullScreen.Image")));
            this.pictureBoxFullScreen.Location = new System.Drawing.Point(652, 8);
            this.pictureBoxFullScreen.Name = "pictureBoxFullScreen";
            this.pictureBoxFullScreen.Size = new System.Drawing.Size(26, 23);
            this.pictureBoxFullScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxFullScreen.TabIndex = 5;
            this.pictureBoxFullScreen.TabStop = false;
            this.pictureBoxFullScreen.Click += new System.EventHandler(this.pictureBoxFullScreen_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(684, 332);
            this.Controls.Add(this.pictureBoxFullScreen);
            this.Controls.Add(this.pictureBoxOpenFile);
            this.Controls.Add(this.mainPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Picture Viewer";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFullScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPictureBox;        
        private System.Windows.Forms.OpenFileDialog mainImageOpenFileDialog;
        private System.Windows.Forms.PictureBox pictureBoxOpenFile;
        private System.Windows.Forms.PictureBox pictureBoxFullScreen;
    }
}

