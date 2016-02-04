using System;
using System.Windows.Forms;
using System.IO;

namespace AnimatedGifViewer
{
    public partial class Form1 : Form
    {
        string filePath, directoryPath;
        string[] allFiles;
        int currentIndex;
        bool fullScreenIsChecked = false;
        FormWindowState priorWindowState;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBoxFullScreenOn_Click(object sender, EventArgs e)
        {
            if (fullScreenIsChecked == false)
            {
                FormBorderStyle = FormBorderStyle.None;
                priorWindowState = WindowState;

                if (WindowState == FormWindowState.Maximized)
                    WindowState = FormWindowState.Minimized;

                WindowState = FormWindowState.Maximized;
                fullScreenIsChecked = true;

                pictureBoxFullScreenOn.Image = Properties.Resources.full_screen_off;
            }
            else
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = priorWindowState;
                fullScreenIsChecked = false;
                pictureBoxFullScreenOn.Image = Properties.Resources.full_screen_off;
            }
        }

        private void pictureBoxOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                webBrowser.Navigate(filePath);

                directoryPath = Path.GetDirectoryName(filePath);
                allFiles = Directory.GetFiles(directoryPath);
                currentIndex = Array.IndexOf(allFiles, filePath);
            }
        }

        private void pictureBoxLeft_Click(object sender, EventArgs e)
        {
            currentIndex--;
            if (currentIndex == -1)
            {
                currentIndex = allFiles.Length - 1;
            }
            webBrowser.Navigate(allFiles[currentIndex]);
        }

        private void pictureBoxRight_Click(object sender, EventArgs e)
        {
            currentIndex++;
            if (currentIndex == allFiles.Length)
            {
                currentIndex = 0;
            }
            webBrowser.Navigate(allFiles[currentIndex]);
        }       
    }
}
