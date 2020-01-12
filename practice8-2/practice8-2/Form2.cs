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
    public partial class Form2 : Form
    {
        Timer t2 = new Timer();
        int score = 0;
        int ans,input;
        Form1 frm1 = new Form1();
        public Form2()
        {
            InitializeComponent();
            t2.Interval = 1000;
            t2.Tick += new EventHandler(timer1_Tick);
            input = 10;
           
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            ans = frm1.getAns();

            if (ans == input)
            {
                score++;
            }
            this.label1.Text = "分數: " + score;
        }

        
        
        private void start_ctrl_state_click(object sender, EventArgs e)
        {
            t2.Start();
            frm1.t1start();
            input = 10;
            ans = 0;
            
        }

        private void stop_ctrl_state_click(object sender, EventArgs e)
        {
            t2.Stop();
            frm1.t1stop();
            
        }

        private void ter_ctrl_state_click(object sender, EventArgs e)
        {
            score = 0;
            this.label1.Text = "分數: "+score;
            t2.Stop();
            frm1.t1stop();
            frm1.SetPicNull();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            frm1.Show();
        }


        private void keydown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Z)
            {
                input = 10;
                ans = 0;
                t2.Start();
                frm1.t1start();
                
            }
            else if(e.Modifiers == Keys.Control && e.KeyCode == Keys.X)
            {
                t2.Stop();
                frm1.t1stop();
                

            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C)
            {
                score = 0;
                t2.Stop();
                frm1.t1stop();
                frm1.SetPicNull();
                this.label1.Text = "分數: "+score;
                
            }

            if (e.KeyCode == Keys.Up || e.KeyCode==Keys.W)
            {
                input = 3;
            }
            else if(e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                input = 4;
            }
            else if(e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                input = 2;
            }
            else if(e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                input = 1;
            }

        }
    
    }
}
