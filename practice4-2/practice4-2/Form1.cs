using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice4_2
{
    public partial class Form1 : Form
    {
        public int money;
        List<string> his = new List<string>();

        

        public void hide_all()
        {
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            textBox1.Hide();
            textBox2.Hide();
        }

        public Form1()
        {
            money = 10000;
            InitializeComponent();
            hide_all();
            label1.Show();
            label2.Show();
            button1.Show();
            textBox1.Show();
            his.Add("[初始] 10000 NTD\n");

        }

        static string password = "000000";
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string passwd = textBox1.Text;
            if(passwd== password)
            {
                hide_all();
                label3.Show();
                button2.Show();
                button3.Show();
                button4.Show();
                button5.Show();
                button6.Show();
            }
            else
            {
                textBox1.Clear();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            hide_all();
            label4.Show();
            button6.Show();
            button7.Show();
            button8.Show();
            button9.Show();
            button10.Show();
            button11.Show();
            button12.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            hide_all();

            label5.Show();
            button6.Show();
            button13.Show();
            textBox2.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            hide_all();
            label6.Show();
            label6.Text = "餘額剩下: " + money + " NTD";
            button6.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            hide_all();
            button6.Show();

            if (money > 1000)
            {
                money -= 1000;
                label6.Show();
                label6.Text = "餘額剩下: " + money + " NTD";
                his.Add("[提款]  1000 NTD\n");
                his.Add("[餘額] " + money + " NTD\n");
            }
            else
            {
                label7.Show();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hide_all();
            button6.Show();


            if (money > 3000)
            {
                money -= 3000;
                label6.Show();
                label6.Text = "餘額剩下: " + money + " NTD";
                his.Add("[提款]  3000 NTD\n");
                his.Add("[餘額] " + money + " NTD\n");
            }
            else
            {
                label7.Show();
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            hide_all();
            button6.Show();

            if (money > 5000)
            {
                money -= 5000;
                label6.Show();
                label6.Text = "餘額剩下: " + money + " NTD";
                his.Add("[提款]  5000 NTD\n");
                his.Add("[餘額] " + money + " NTD\n");
            }
            else
            {
                label7.Show();
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            hide_all();
            button6.Show();

            if (money > 10000)
            {
                money -= 10000;
                label6.Show();
                label6.Text = "餘額剩下: " + money + " NTD";
                his.Add("[提款] 10000 NTD\n");
                his.Add("[餘額] " + money + " NTD\n");
            }
            else
            {
                label7.Show();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            hide_all();
            button6.Show();

            if (money > 20000)
            {
                money -= 20000;
                label6.Show();
                label6.Text = "餘額剩下: " + money + " NTD";
                his.Add("[提款] 20000 NTD\n");
                his.Add("[餘額] " + money + " NTD\n");
            }
            else
            {
                label7.Show();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            hide_all();
            button6.Show();

            if (money > 30000)
            {
                money -= 30000;
                label6.Show();
                label6.Text = "餘額剩下: " + money + " NTD";
                his.Add("[提款] 30000 NTD\n");
                his.Add("[餘額] " + money + " NTD\n");
            }
            else
            {
                label7.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hide_all();

            label1.Show();
            label2.Show();
            button1.Show();
            textBox1.Show();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            hide_all();
            label6.Show();
            button6.Show();
            money += int.Parse(textBox2.Text);
            label6.Text = "餘額剩下: " + money + " NTD";
            his.Add("[存款] " + int.Parse(textBox2.Text) + " NTD\n");
            his.Add("[餘額] " + money + " NTD\n");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            hide_all();
            button6.Show();
            label8.Show();
            // 清空 list for() .text += ... 
            
            foreach(var h in his)
            {
                label8.Text += h;
            }
        }
    }
}
