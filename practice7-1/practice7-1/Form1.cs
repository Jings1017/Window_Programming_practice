using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice7_1
{
    public partial class Form1 : Form
    {
        Timer musTmr;
        Random rand = new Random();
        PictureBox[,] bar = new PictureBox[10, 20];
        TrackBar[] tb = new TrackBar[10];
        System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
        
        public Form1()
        {
            InitializeComponent();
            hScrollBarR.Maximum = 255;
            hScrollBarR.Minimum = 0;
            hScrollBarG.Maximum = 255;
            hScrollBarG.Minimum = 0;
            hScrollBarB.Maximum = 255;
            hScrollBarB.Minimum = 0;
            musTmr = new Timer();
            musTmr.Interval = 300;
            musTmr.Tick += new EventHandler(timer1_Tick);
            hScrollBarR.Value = 0;
            hScrollBarG.Value = 0;
            hScrollBarB.Value = 255;
            color.BackColor = Color.FromArgb(0, 0, 255);
            sp.SoundLocation = @"..\..\awaken.wav";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; ++i)
            {
                tb[i] = new TrackBar();
                tb[i].Location = new Point(20 + i * 55, 300);
                tb[i].Orientation = Orientation.Vertical;
                tb[i].Size = new Size(5, 200);
                tb[i].Maximum = 20;
                tb[i].Minimum = 0;
                tabControl1.TabPages[0].Controls.Add(tb[i]);

                for(int j = 0; j < 20; ++j)
                {
                    bar[i,j] = new PictureBox();
                    bar[i, j].Location = new Point(tb[i].Location.X, tb[i].Location.Y - j * 15);
                    bar[i, j].Size = new Size(45, 10);
                    bar[i, j].BackColor = Color.Blue;
                    bar[i, j].Visible = false;
                    tabControl1.TabPages[0].Controls.Add(bar[i, j]);
                }
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            sp.Play();
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < tb[i].Value; j++)
                {
                    bar[i, j].Visible = true;
                }
            }
            musTmr.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                if (tb[i].Value <= 2)
                {
                    tb[i].Value += 2;
                    
                }
                else if(tb[i].Value >= 18)
                {
                    tb[i].Value -= 2;
                    
                }
                else
                {
                    if (rand.Next() % 2 == 0)
                    {
                        tb[i].Value += 2;
                    }
                    else
                    {
                        tb[i].Value -= 2;
                    }

                }

                for (int j = 0; j < 20; j++)
                {
                    if (j <= tb[i].Value)
                    {
                        bar[i, j].Visible = true;
                    }
                    else
                    {
                        bar[i, j].Visible = false;
                    }
                    
                }

            }
        }

        private void hScrollBarR_Scroll(object sender, ScrollEventArgs e)
        {
            color.BackColor = Color.FromArgb(hScrollBarR.Value, hScrollBarG.Value, hScrollBarB.Value);
            foreach(PictureBox p in bar)
            {
                p.BackColor = color.BackColor;
            }
        }

        private void hScrollBarG_Scroll(object sender, ScrollEventArgs e)
            
        {
            color.BackColor = Color.FromArgb(hScrollBarR.Value, hScrollBarG.Value, hScrollBarB.Value);
            foreach (PictureBox p in bar)
            {
                p.BackColor = color.BackColor;
            }
        }

        private void hScrollBarB_Scroll(object sender, ScrollEventArgs e)
        {
            color.BackColor = Color.FromArgb(hScrollBarR.Value, hScrollBarG.Value, hScrollBarB.Value);
            foreach (PictureBox p in bar)
            {
                p.BackColor = color.BackColor;
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            musTmr.Stop();
            sp.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sp.SoundLocation = @"..\..\lion.wav";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sp.SoundLocation = @"..\..\awaken.wav";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sp.SoundLocation = @"..\..\fafafa.wav";
        }
    }
}
