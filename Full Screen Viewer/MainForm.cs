using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace JibbaJabba
{
    public partial class MainForm : Form
    {
        Image maimImage = JibbaJabba.Properties.Resources.my_logo;
        bool mouseIsDown = false, fullScreenIsChecked = false, isDraging = false;
        FormWindowState priorWindowState;
        List<string> files;
        int index;

        Picture picture = new Picture();

        public MainForm()
        {
            InitializeComponent();
            picture.Fit(maimImage, ref mainPictureBox);
            this.mainPictureBox.Paint += new PaintEventHandler(mainImage_Paint);
            mainPictureBox.Refresh();
        }

        private void mainPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            mouseIsDown = true;

            MouseEventArgs mouse = e as MouseEventArgs;

            picture.InitialiseMousePosition(mouse.X, mouse.Y);
        }

        private void mainPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            MouseEventArgs mouse = e as MouseEventArgs;

            if (mouse.Button == MouseButtons.Left && mouseIsDown)
            {
                isDraging = true;
                picture.Drag(maimImage, mouse, ref mainPictureBox);
                mainPictureBox.Refresh();
            }
        }

        private void mainPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;

            if (isDraging)
                isDraging = false;
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            MouseEventArgs mouse = e as MouseEventArgs;

            picture.Zoom(maimImage, ref mainPictureBox, mouse);
            mainPictureBox.Refresh();
        }       

        private void mainImage_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            e.Graphics.DrawImage(maimImage, picture.X, picture.Y, picture.Width, picture.Height); //System.OverflowException 
        }        

        private void MainForm_Resize(object sender, EventArgs e)
        {
            picture.Fit(maimImage, ref mainPictureBox);
            mainPictureBox.Refresh();
        }  
               
        private void pictureBoxOpenFile_Click(object sender, EventArgs e)
        {
            if (mainImageOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                maimImage = Image.FromFile(mainImageOpenFileDialog.FileName);
                picture.Fit(maimImage, ref mainPictureBox);

                this.mainPictureBox.Paint += new PaintEventHandler(mainImage_Paint);
                mainPictureBox.Refresh(); //calls MainImage_Paint

                string path = Path.GetDirectoryName(mainImageOpenFileDialog.FileName);
                files = Directory.EnumerateFiles(path, "*.*", SearchOption.TopDirectoryOnly)
                    .Where(s => s.ToLower().EndsWith(".bmp") || s.ToLower().EndsWith(".jpg") || s.ToLower().EndsWith(".png")).ToList();

                index = files.IndexOf((mainImageOpenFileDialog.FileName));
            }
        }       

        private void mainPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.X < mainPictureBox.Width / 2 && isDraging == false)
            {
                if (files != null)
                {
                    if (index > 0)
                    {
                        index -= 1;
                        maimImage = Image.FromFile(files.ElementAt(index));
                    }
                    else if (index == 0)
                    {
                        index = files.Count - 1;
                        maimImage = Image.FromFile(files.ElementAt(index));
                    }

                    picture.Fit(maimImage, ref mainPictureBox);
                    mainPictureBox.Refresh();
                }
            }
            else if (e.X > mainPictureBox.Width / 2 && isDraging == false)
            {
                if (files != null)
                {
                    if (index < files.Count - 1)
                    {
                        index += 1;
                        maimImage = Image.FromFile(files.ElementAt(index));
                    }
                    else if (index == files.Count - 1)
                    {
                        index = 0;
                        maimImage = Image.FromFile(files.ElementAt(index));
                    }
                    picture.Fit(maimImage, ref mainPictureBox);
                    mainPictureBox.Refresh();
                }
            }
        }

        private void pictureBoxFullScreen_Click(object sender, EventArgs e)
        {           
            if (fullScreenIsChecked == false)
            {
                FormBorderStyle = FormBorderStyle.None;
                priorWindowState = WindowState;

                if (WindowState == FormWindowState.Maximized)
                    WindowState = FormWindowState.Minimized;

                WindowState = FormWindowState.Maximized;
                fullScreenIsChecked = true;

                pictureBoxFullScreen.Image = global::JibbaJabba.Properties.Resources.full_screen_off;
            }
            else
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = priorWindowState;
                fullScreenIsChecked = false;
                pictureBoxFullScreen.Image = global::JibbaJabba.Properties.Resources.full_screen;
            }

            picture.Fit(maimImage, ref mainPictureBox);
        }
    }
}
