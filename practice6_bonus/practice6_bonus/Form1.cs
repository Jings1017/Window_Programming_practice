using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice6_bonus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            label2.Text = "按了左鍵於X:" + e.X + ", Y:" + e.Y;
            
        }

        private void Form1_KeyPress(object sender, KeyEventArgs e)
        {
            

            label1.Text = "按了" + e.KeyCode + "鍵，鍵碼:" + e.KeyValue;
            if (e.KeyCode == Keys.Up)
            {
                label1.Location = new Point(label1.Location.X, label1.Location.Y - 10);
            }
            else if (e.KeyCode == Keys.Down)
            {
                label1.Location = new Point(label1.Location.X, label1.Location.Y + 10);
            }
            else if (e.KeyCode == Keys.Left)
            {
                label1.Location = new Point(label1.Location.X-10, label1.Location.Y);
            }
            else if (e.KeyCode == Keys.Right)
            {
                label1.Location = new Point(label1.Location.X+10, label1.Location.Y);
            }
        }

    }
}
