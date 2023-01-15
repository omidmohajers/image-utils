using PA.PersianUtils.ImageUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PA.ImageUtils.Win
{
    public partial class MainForm : Form
    {
        private string imageFileName;

        public MainForm()
        {
            InitializeComponent();
        }

        private void zoomButton_Click(object sender, EventArgs e)
        {
            zoomButton.Checked = !zoomButton.Checked;
        }

        private void sourcePicturebox_MouseMove(object sender, MouseEventArgs e)
        {
            if (!zoomButton.Checked)
            {
                sourcePicturebox.Cursor = Cursors.Default;
                return;
            }
                sourcePicturebox.Cursor = Cursors.Cross;
                Image img = Imaging.ZoomImage(sourcePicturebox.Image, new Rectangle(e.X, e.Y, 200, 200), new Rectangle(0, 0, destpicturebox.Width, destpicturebox.Height));
                if (img != null)
                    destpicturebox.Image = img;
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Jpeg Files|*.jpg";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                imageFileName = ofd.FileName;
                sourcePicturebox.Image = Imaging.FromFile(imageFileName);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (destpicturebox == null)
                return;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Jpeg Files|*.jpg";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                imageFileName = sfd.FileName;
                Imaging.Save(imageFileName,destpicturebox.Image);
                sourcePicturebox.Image = destpicturebox.Image;
            }
        }

        private void srayscaleButton_Click(object sender, EventArgs e)
        {
            if (sourcePicturebox.Image == null)
                return;
            destpicturebox.Image = Imaging.MakeGrayscale((Bitmap)sourcePicturebox.Image);
        }

        private void colorfulButton_Click(object sender, EventArgs e)
        {
            destpicturebox.Image = Imaging.ConvertImageToARGB(sourcePicturebox.Image);
        }

        private void markAreaButton_Click(object sender, EventArgs e)
        {
            destpicturebox.Image = Imaging.MarkImage(sourcePicturebox.Image, new Rectangle(400, 200, 200, 200), Color.Purple);
        }

        private void dominantColorButton_Click(object sender, EventArgs e)
        {
            colorPanel.BackColor = Imaging.GetDominantColor((Bitmap)sourcePicturebox.Image, false);
        }
    }
}
