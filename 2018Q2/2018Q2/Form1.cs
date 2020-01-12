using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace _2018Q2
{
    public partial class Form1 : Form
    {
        string[] pic = new string[4] { "down", "left", "right", "up" };
        int n;
        int DX, DY, UX, UY;
        public Form1()
        {
            InitializeComponent();
            n = 0;
        }

        private void pre_Click(object sender, EventArgs e)
        {
            if (n > 0)
            {
                n--;
                pictureBox1.Image = Image.FromFile("image\\" + pic[n] + ".png");
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                MessageBox.Show("error");
            }
            
        }

        private void MU(object sender, MouseEventArgs e)
        {
            UX = e.X;
            UY = e.Y;
            if ((UY > DY && n==0) || (UX<DX && n==1) || (UX > DX && n == 2) || (UY < DY && n == 3))
            {
                MessageBox.Show("You are right");
            }
            else
            {
                MessageBox.Show("wrong");
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (n < 3)
            {
                n++;
                pictureBox1.Image = Image.FromFile("image\\" + pic[n] + ".png");
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                MessageBox.Show("error");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("image\\"+pic[n]+".png");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void MD(object sender, MouseEventArgs e)
        {
            DX = e.X;
            DY = e.Y;
        }
    }
}
