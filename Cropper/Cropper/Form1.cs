using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cropper
{
    public partial class Form1 : Form
    {
        UserRect rect;
        public Form1()
        {
            InitializeComponent();

            rect = new UserRect(new Rectangle(0, 0, 100, 150));
            rect.SetPictureBox(this.pictureBox1);
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}