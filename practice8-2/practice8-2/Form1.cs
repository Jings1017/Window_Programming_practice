using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice8_2
{
    public partial class Form1 : Form
    {
        Timer t1 = new Timer();
        int num;

        public Form1()
        {
            
            InitializeComponent();
            pictureBox1.Image = null;
            num = 0;
            t1.Interval = 1500;
            t1.Tick += new EventHandler(timer1_Tick);
            t1.Stop();
        }

        
        public void t1start()
        {
            t1.Start();
        }

        public void t1stop()
        {
            t1.Stop();
        }

        public void SetPicNull()
        {
            pictureBox1.Image = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            num = rand.Next(1, 5);
            pictureBox1.Image = Image.FromFile("pic\\eyechart-" + num + ".jpg");
            //frm2.getAns = num;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public int getAns()
        {
            return num;
        }

        private void keydown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Z)
            {
                t1.Start();
            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.X)
            {
                t1.Stop();
            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C)
            {
                pictureBox1.Image = null;
                t1.Stop();
            }
        }

        private void start_ctrl_Click(object sender, EventArgs e)
        {
            t1.Start();
        }

        private void stop_ctrl_Click(object sender, EventArgs e)
        {
            t1.Stop();
        }

        private void ter_ctrl_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            t1.Stop();
        }
    }
}
