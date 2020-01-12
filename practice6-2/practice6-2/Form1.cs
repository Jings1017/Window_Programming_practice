using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice6_2
{
    public partial class Form1 : Form
    {
        Timer timer_1, timer_2;
        List<PictureBox> Enemy = new List<PictureBox>();
        bool live ;
        public Form1()
        {
            InitializeComponent();
            // player part 
            player.Image = Image.FromFile(@"..\..\image\ship 1.png");
            player.BackColor = Color.Transparent;
            player.Location = new Point(220, 450);
            player.Size = new Size(50, 50);
            live = true;
            

            timer_1 = new Timer();
            timer_1.Interval = 400;
            timer_1.Tick += new EventHandler(timer1_Tick);
            timer_1.Start();

            timer_2 = new Timer();
            timer_2.Interval = 1000;
            timer_2.Tick += new EventHandler(timer2_Tick);
            timer_2.Start();

            restart.Enabled = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void player_Click(object sender, EventArgs e)
        {

        }

        private void move(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                player.Location = new Point(player.Location.X, player.Location.Y - 10);
            }
            else if (e.KeyCode == Keys.Down)
            {
                player.Location = new Point(player.Location.X, player.Location.Y + 10);
            }
            else if (e.KeyCode == Keys.Left)
            {
                player.Location = new Point(player.Location.X - 10, player.Location.Y);
            }
            else if (e.KeyCode == Keys.Right)
            {
                player.Location = new Point(player.Location.X + 10, player.Location.Y);
            }

            // boundary
            if(player.Location.X > 410)
            {
                player.Location = new Point(410, player.Location.Y);
            }
            else if(player.Location.X < 0)
            {
                player.Location = new Point(0, player.Location.Y);
            }
            else if (player.Location.Y < 0)
            {
                player.Location = new Point(player.Location.X, 0);
            }
            else if (player.Location.Y > 460)
            {
                player.Location = new Point(player.Location.X, 460);
            }


            for(int i = 0; i < Enemy.Count; i++)
            {
                // error 
                if( ( (player.Top<=Enemy[i].Bottom && player.Bottom>=Enemy[i].Top) ||
                    (player.Top >= Enemy[i].Bottom && player.Bottom <= Enemy[i].Top)  ) &&
                    (player.Left <= Enemy[i].Right && player.Right >= Enemy[i].Left)        )
                {
                    live = false;
                    restart.Enabled = true;
                    timer_1.Stop();
                    timer_2.Stop();
                    MessageBox.Show("GAME OVER");
                }
            }

        }
        int t = 0;
        Random rand = new Random();
        private void timer2_Tick(object sender, EventArgs e)
        {
            
            PictureBox enemy = new PictureBox();
            enemy.Image = Image.FromFile(@"..\..\image\Invader.png");
            enemy.Size = enemy.Image.Size;
            enemy.BackColor = Color.Transparent;
            enemy.Location = new Point(rand.Next(400), 5);
            this.Controls.Add(enemy);
            Enemy.Add(enemy);
            
        }

        private void restart_Click(object sender, EventArgs e)
        {
            live = true;
            player.Location = new Point(220, 450);
            restart.Enabled = false;
            t = 0;

            timer_1.Start();
            timer_2.Start();

            foreach (PictureBox en in Enemy)
            {
                en.Dispose();
            }
            Enemy.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            score.Text = "score: "+t ;
            t++;
            for(int i = 0; i < Enemy.Count; i++)
            {
                Enemy[i].Location = new Point(Enemy[i].Location.X, Enemy[i].Location.Y + 60);
            }
        }
    }
}
