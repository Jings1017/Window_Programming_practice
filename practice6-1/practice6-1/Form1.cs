using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice6_1
{
    public partial class Form1 : Form
    {
        int level = 3;
        List<Label> bricks = new List<Label>();
        Timer enTmr , bTmr;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
            ball.Image = Image.FromFile(@"..\..\image\pp.gif");
            ball.Location = new Point(230, 420);
            ball.Size = ball.Image.Size;
            ball.BackColor = Color.Transparent;
            panel1.Controls.Add(ball);
            enemy.Location = new Point(200, 275);
            board.Location = new Point(170, 450);
            //board.Size = new Size(1000, 30);

            enTmr = new Timer();
            enTmr.Interval = 300;
            enTmr.Tick += new EventHandler(enemyTmr_Tick);

            bTmr = new Timer();
            bTmr.Interval = 15;
            bTmr.Tick += new EventHandler(ballTmr_Tick);

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < level + 2; j++)
                {
                    Label brick = new Label();
                    brick.BackColor = Color.Salmon;
                    brick.Size = new Size(100, 35);
                    brick.Location = new Point(i *100, j * 35);
                    brick.BorderStyle = BorderStyle.Fixed3D;
                    panel1.Controls.Add(brick);
                    bricks.Add(brick);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ball_Click(object sender, EventArgs e)
        {

        }

        private void barrier_Click(object sender, EventArgs e)
        {

        }

        private void board_move(object sender, MouseEventArgs e)
        {
            bTmr.Start();
            enTmr.Start();
            if(e.X > 360)
            {
                board.Location = new Point(360, board.Location.Y);
            }
            else
            {
                board.Location = new Point(e.X, board.Location.Y);
            }         
        }
        private void enemyTmr_Tick(object sender, EventArgs e)
        {
            if (enemy.Location.X >= 300)
            {
                enemy.Location = new Point(enemy.Location.X - 40, enemy.Location.Y);
            }
            else if (enemy.Location.X <= 100)
            {
                enemy.Location = new Point(enemy.Location.X + 40, enemy.Location.Y);
            }
            else if (ball.Top > enemy.Bottom)
            {
                if (ball.Location.X < enemy.Location.X)
                {
                    enemy.Location = new Point(enemy.Location.X - 40, enemy.Location.Y);
                }
                else if (ball.Location.X > enemy.Location.X)
                {
                    enemy.Location = new Point(enemy.Location.X + 40, enemy.Location.Y);
                }
            }
            else if(ball.Bottom < enemy.Top)
            {
                if (ball.Location.X < enemy.Location.X)
                {
                    enemy.Location = new Point(enemy.Location.X + 40, enemy.Location.Y);
                }
                else if (ball.Location.X > enemy.Location.X)
                {
                    enemy.Location = new Point(enemy.Location.X - 40, enemy.Location.Y);
                }
            }          
        }
        int ball_state = 1; // 1:left-up 2:right-up 3:left-down 4:right-down

        private void easy_Click(object sender, EventArgs e)
        {
            bTmr.Interval = 30;
        }

        private void hard_Click(object sender, EventArgs e)
        {
            bTmr.Interval = 8;
        }

        private void standard_Click(object sender, EventArgs e)
        {
            bTmr.Interval = 15;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你確定嗎?");
            MessageBox.Show("真的不繼續玩嗎?");
            this.Close();
        }

        private void ballTmr_Tick(object sender, EventArgs e)
        {
            label1.Text = "score: " + score;
            if(ball.Bottom >= panel1.Bottom || score>=(level+2)*5)
            {
                enTmr.Stop();
                bTmr.Stop();
                enemy.Location = new Point(1000, 1000);
                board.Location = new Point(1000, 1000);
                ball.Location  = new Point(1000, 1000);
                foreach (Label lab in bricks)
                {
                    lab.Dispose();
                }
                if (ball.Bottom >= panel1.Bottom)
                {
                    MessageBox.Show("GAME OVER");
                }
                else if(score >= (level + 2) * 5)
                {
                    MessageBox.Show("YOU WON");
                }

                // reset 
                score = 0;
                //bTmr.Start();
                //enTmr.Start();
                enemy.Location = new Point(200, 275);
                board.Location = new Point(170, 450);
                ball.Location  = new Point(230, 420);
                ball.Location = new Point(board.Location.X, board.Location.Y - 30);

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < level + 2; j++)
                    {
                        Label brick = new Label();
                        brick.BackColor = Color.Salmon;
                        brick.Size = new Size(100, 35);
                        brick.Location = new Point(i * 100, j * 35);
                        brick.BorderStyle = BorderStyle.Fixed3D;
                        panel1.Controls.Add(brick);
                        bricks.Add(brick);
                    }
                }
            }

            // panel 
            if (ball.Left <= panel1.Left)
            {
                if (ball_state == 1)
                {
                    ball_state = 2;
                }
                else if (ball_state == 3)
                {
                    ball_state = 4;
                }
            }
            else if (ball.Right >= panel1.Right)
            {
                if (ball_state == 2)
                {
                    ball_state = 1;
                }
                else if (ball_state == 4)
                {
                    ball_state = 3;
                }
            }
            else if (ball.Top <= panel1.Top)
            {
                if (ball_state == 1)
                {
                    ball_state = 3;
                }
                else if (ball_state == 2)
                {
                    ball_state = 4;
                }
            }
            // board
            if(ball.Bottom>=board.Top && ball.Left>=board.Left && ball.Right <= board.Right)
            {
                    if(ball_state == 3)
                    {
                        ball_state = 1;
                    }
                    else if (ball_state == 4)
                    {
                        ball_state = 2;
                    }
            }
            // left collision
            else if (ball.Right >= board.Left && ball.Left < board.Left && ball.Top >= board.Top && ball.Bottom <= board.Bottom)
            {
                if (ball_state == 2)
                {
                    ball_state = 1;
                }
                else if (ball_state == 4)
                {
                    ball_state = 3;
                }
            }
            // right collision
            else if (ball.Left <= board.Right && ball.Right > board.Right && ball.Top >= board.Top && ball.Bottom <= board.Bottom)
            {
                if (ball_state == 1)
                {
                    ball_state = 2;
                }
                else if (ball_state == 3)
                {
                    ball_state = 4;
                }
            }


            // enemy
            //bottom collision
            if (ball.Top<enemy.Bottom && ball.Bottom>enemy.Bottom && ball.Left>=enemy.Left && ball.Right <= enemy.Right)
            {
                if(ball_state == 1)
                {
                    ball_state = 3;
                }
                else if(ball_state == 2)
                {
                    ball_state = 4;
                }
            }
            // top collision
            else if (ball.Bottom>enemy.Top && ball.Top<enemy.Top && ball.Left>=enemy.Left && ball.Right <= enemy.Right)
            {
                if(ball_state == 3)
                {
                    ball_state = 1;
                }
                else if(ball_state == 4)
                {
                    ball_state = 2;
                }
            }        
            // left collision
            else if(ball.Right>=enemy.Left && ball.Left<enemy.Left && ball.Top>=enemy.Top && ball.Bottom <= enemy.Bottom)
            {
                if (ball_state == 2)
                {
                    ball_state = 1;
                }
                else if (ball_state == 4){
                    ball_state = 3;
                }
            }
            // right collision
            else if (ball.Left <= enemy.Right && ball.Right > enemy.Right && ball.Top >= enemy.Top && ball.Bottom <= enemy.Bottom)
            {
                if (ball_state == 1)
                {
                    ball_state = 2;
                }
                else if (ball_state == 3)
                {
                    ball_state = 4;
                }
            }

            for(int i=0;i<bricks.Count;++i)
            {
                if (ball.Top <= bricks[i].Bottom && ball.Bottom> bricks[i].Bottom &&
                    ball.Left>= bricks[i].Left && ball.Right <= bricks[i].Right)
                {
                    bricks[i].Location = new Point(1000, 1000);
                    bricks[i].Dispose();
            
                    if (ball_state == 1)
                    {
                        ball_state = 3;
                    }
                    else if(ball_state == 2)
                    {
                        ball_state = 4;
                    }
                    score++;
                }
                else if(ball.Right >= bricks[i].Left && ball.Left < bricks[i].Left &&
                    ball.Top >= bricks[i].Top && ball.Bottom <= bricks[i].Bottom)
                {
                    bricks[i].Location = new Point(1000, 1000);
                    bricks[i].Dispose();
                    if (ball_state == 2)
                    {
                        ball_state = 1;
                    }
                    else if (ball_state == 4)
                    {
                        ball_state = 3;
                    }
                    score++;
                }
                else if(ball.Left <= bricks[i].Right && ball.Right > bricks[i].Right &&
                    ball.Top >= bricks[i].Top && ball.Bottom <= bricks[i].Bottom)
                {
                    bricks[i].Location = new Point(1000, 1000);
                    bricks[i].Dispose();
                    if (ball_state == 1)
                    {
                        ball_state = 2;
                    }
                    else if (ball_state == 3)
                    {
                        ball_state = 4;
                    }
                }
            }

            if (ball_state == 1)
            {
                ball.Location = new Point(ball.Location.X - 5, ball.Location.Y - 5);
            }
            else if (ball_state == 2)
            {
                ball.Location = new Point(ball.Location.X + 5, ball.Location.Y - 5);
            }
            else if (ball_state == 3)
            {
                ball.Location = new Point(ball.Location.X - 5, ball.Location.Y + 5);
            }
            else if (ball_state == 4)
            {
                ball.Location = new Point(ball.Location.X + 5, ball.Location.Y + 5);
            }
        }
    }
}
