using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2018Q4
{
    public partial class Form1 : Form
    {
        Timer t1,t2;
        int life, grade;
        Random rand = new Random();
        List<Label> block = new List<Label>();
        char[] word = new char[26] { 'A', 'B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
        public Form1()
        {
            InitializeComponent();
            t1 = new Timer();
            t1.Interval = 1200;
            t1.Tick += new EventHandler(timer1_Tick);
            t2 = new Timer();
            t2.Interval = 500;
            t2.Tick += new EventHandler(timer2_Tick);
            grade = 0;
            life = 10;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            int n = rand.Next(1, 27);
            int x = rand.Next(0, 450);
            Label lab = new Label();
            lab.BackColor = Color.Salmon;
            lab.Text = Char.ToString(word[n-1]);
            lab.Size = new Size(40, 40);
            lab.Location = new Point(x, 40);
            lab.Font = new Font("標楷體", 14, FontStyle.Regular);
            lab.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(lab);
            block.Add(lab);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        

        private void remove(object sender, KeyEventArgs e)
        {
            foreach(Label l in block)
            {
                if (l.Location.Y <= pictureBox1.Location.Y)
                {
                    if ((e.KeyCode == Keys.A && l.Text == "A") || (e.KeyCode == Keys.B && l.Text == "B") ||
                    (e.KeyCode == Keys.C && l.Text == "C") || (e.KeyCode == Keys.D && l.Text == "D") ||
                    (e.KeyCode == Keys.E && l.Text == "E") || (e.KeyCode == Keys.F && l.Text == "F") ||
                    (e.KeyCode == Keys.H && l.Text == "H") || (e.KeyCode == Keys.I && l.Text == "I") ||
                    (e.KeyCode == Keys.J && l.Text == "J") || (e.KeyCode == Keys.K && l.Text == "K") ||
                    (e.KeyCode == Keys.G && l.Text == "G") || (e.KeyCode == Keys.L && l.Text == "L") ||
                    (e.KeyCode == Keys.M && l.Text == "M") || (e.KeyCode == Keys.N && l.Text == "N") ||
                    (e.KeyCode == Keys.O && l.Text == "O") || (e.KeyCode == Keys.P && l.Text == "P") ||
                    (e.KeyCode == Keys.Q && l.Text == "Q") || (e.KeyCode == Keys.R && l.Text == "R") ||
                    (e.KeyCode == Keys.S && l.Text == "S") || (e.KeyCode == Keys.T && l.Text == "T") ||
                    (e.KeyCode == Keys.U && l.Text == "U") || (e.KeyCode == Keys.V && l.Text == "V") ||
                    (e.KeyCode == Keys.W && l.Text == "W") || (e.KeyCode == Keys.Y && l.Text == "Y") ||
                    (e.KeyCode == Keys.Z && l.Text == "Z") || (e.KeyCode == Keys.X && l.Text == "X"))
                    {
                        l.Location = new Point(0, -1000000);
                        this.Controls.Remove(l);
                        l.Dispose();
                        grade++;
                    }
                }               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t1.Start();
            t2.Start();
            button1.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            foreach(Label lab in block)
            {
                lab.Location = new Point(lab.Location.X, lab.Location.Y + 40);
            }
            
            foreach(Label l in block)
            {
                if (l.Location.Y > pictureBox1.Location.Y)
                {
                    life--;
                }

                if (l.Location.Y > pictureBox1.Location.Y + 30)
                {
                    l.Location = new Point(0, -1000000);
                }
            }
            grade_label.Text = "grade: " + grade;
            life_label.Text = "life: " + life;
            if (life <= 0)
            {
                t1.Stop();
                t2.Stop();
                MessageBox.Show("game over");
            }
        }
    }
}
