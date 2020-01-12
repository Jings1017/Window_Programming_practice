using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace practice5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        int first = 0, second = 0;
        double multi=1,ans=1;
        string unit="",err;
        
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void black2_CheckedChanged(object sender, EventArgs e)
        {
            second = 0;
        }

        private void red1_CheckedChanged(object sender, EventArgs e)
        {
            first = 2;
        }

        private void orange1_CheckedChanged(object sender, EventArgs e)
        {
            first = 3;
        }

        private void yellow1_CheckedChanged(object sender, EventArgs e)
        {
            first = 4;
        }

        private void green1_CheckedChanged(object sender, EventArgs e)
        {
            first = 5;
        }

        private void blue1_CheckedChanged(object sender, EventArgs e)
        {
            first = 6;
        }

        private void violet1_CheckedChanged(object sender, EventArgs e)
        {
            first = 7;
        }

        private void gray1_CheckedChanged(object sender, EventArgs e)
        {
            first = 8;
        }

        private void white1_CheckedChanged(object sender, EventArgs e)
        {
            first = 9;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            first = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void brown1_CheckedChanged(object sender, EventArgs e)
        {
            first = 1;
        }

        private void color1_Enter(object sender, EventArgs e)
        {
            
        }

        private void color2_Enter(object sender, EventArgs e)
        {
            
        }

        private void red2_CheckedChanged(object sender, EventArgs e)
        {
            second = 2;
        }

        private void orange2_CheckedChanged(object sender, EventArgs e)
        {
            second = 3;
        }

        private void yellow2_CheckedChanged(object sender, EventArgs e)
        {
            second = 4;
        }

        private void green2_CheckedChanged(object sender, EventArgs e)
        {
            second = 5;
        }

        private void blue2_CheckedChanged(object sender, EventArgs e)
        {
            second = 6;
        }

        private void violet2_CheckedChanged(object sender, EventArgs e)
        {
            second = 7;
        }

        private void gray2_CheckedChanged(object sender, EventArgs e)
        {
            second = 8;
        }

        private void black3_CheckedChanged(object sender, EventArgs e)
        {
            multi = 1;
            ans = (first * 10 + second) * multi;
        }

        private void brown3_CheckedChanged(object sender, EventArgs e)
        {
            multi = 10;
            ans = (first * 10 + second) * multi;
        }

        private void red3_CheckedChanged(object sender, EventArgs e)
        {
            multi = 100;
            ans = (first * 10 + second) * multi;
            if (ans < 1000)
            {
                unit = "";
            }
            else if (ans >= 1000)
            {
                ans /= 1000;
                unit = "K";
            }
        }

        private void orange3_CheckedChanged(object sender, EventArgs e)
        {
            multi = 1;
            ans = (first * 10 + second) * multi;
            if (ans < 0)
            {
                ans *= 1000;
                unit = "";
            }
            else if (ans < 1000)
            {
                unit = "K";
            }
            
        }

        private void yellow3_CheckedChanged(object sender, EventArgs e)
        {
            multi = 10;
            ans = (first * 10 + second) * multi;
            if (ans < 0)
            {
                ans *= 1000;
                unit = "";
            }
            else if (ans < 1000)
            {
                unit = "K";
            }

        }

        private void green3_CheckedChanged(object sender, EventArgs e)
        {
            multi = 100;
            ans = (first * 10 + second) * multi;
            if (ans < 1000)
            {
                unit = "K";
            }
            else if (ans > 1000)
            {
                unit = "M";
                ans /= 1000;
            }
        }

        private void blue3_CheckedChanged(object sender, EventArgs e)
        {
            multi = 1;
            ans = (first * 10 + second) * multi;
            if (ans < 0)
            {
                ans *= 1000;
                unit = "K";
            }
            else if (ans < 1000)
            {
                unit = "M";
            }
        }

        private void violet3_CheckedChanged(object sender, EventArgs e)
        {
            multi = 10;
            ans = (first * 10 + second) * multi;
            if (ans < 0)
            {
                ans *= 1000;
                unit = "K";
            }
            else if (ans < 1000)
            {
                unit = "M";
            }
        }

        private void gray3_CheckedChanged(object sender, EventArgs e)
        {
            multi = 100;
            ans = (first * 10 + second) * multi;
            if (ans < 1000)
            {
                unit = "M";
            }
            else if (ans >= 1000)
            {
                unit = "G";
                ans /= 1000;
            }
        }

        private void white3_CheckedChanged(object sender, EventArgs e)
        {
            multi = 1;
            ans = (first * 10 + second) * multi;
            if (ans < 0)
            {
                ans *= 1000;
                unit = "M";
            }
            else if (ans < 1000)
            {
                unit = "G";
            }
        }

        private void lightgray3_CheckedChanged(object sender, EventArgs e)
        {
            multi = 0.01;
            ans = (first * 10 + second) * multi;

        }

        private void golden3_CheckedChanged(object sender, EventArgs e)
        {
            multi = 0.1;
            ans = (first * 10 + second) * multi;
        }

        private void brown4_CheckedChanged(object sender, EventArgs e)
        {
            err = " ±1%";
            label7.Text = ans + unit + "Ω" + err;
        }

        private void red4_CheckedChanged(object sender, EventArgs e)
        {
            err = " ±2%";
            label7.Text = ans + unit + "Ω" + err;
        }

        private void green4_CheckedChanged(object sender, EventArgs e)
        {
            err = " ±0.5%";
            label7.Text = ans + unit + "Ω" + err;
        }

        private void blue4_CheckedChanged(object sender, EventArgs e)
        {
            err = " ±0.25%";
            label7.Text = ans + unit + "Ω" + err;
        }

        private void violet4_CheckedChanged(object sender, EventArgs e)
        {
            err = " ±0.10%";
            label7.Text = ans + unit + "Ω" + err;
        }

        private void gray4_CheckedChanged(object sender, EventArgs e)
        {
            err = " ±0.05%";
            label7.Text = ans + unit + "Ω" + err;
        }

        private void golden4_CheckedChanged(object sender, EventArgs e)
        {
            err = " ±5%";
            label7.Text = ans + unit + "Ω" + err;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        int A = 1, B = 1;
        private void plus_Click(object sender, EventArgs e)
        {
            resist.Add(AddNewTextBox());
            
            ohm.Add(AddNewLabel());
            
            
        }
        List<TextBox> resist = new List<TextBox>();
        List<Label> ohm = new List<Label>();
        public TextBox AddNewTextBox()
        {
            TextBox txt = new TextBox();
            this.tabPage2.Controls.Add(txt);
            txt.Top = A * 30;
            txt.Left = 400;
            A = A + 1;
            return txt;
        }
        
        public Label AddNewLabel()
        {
            Label lab = new Label();
            this.tabPage2.Controls.Add(lab);
            lab.Top = B * 30 + 5;
            lab.Left = 500;
            lab.Text = "Ω(ohm)";
            B = B + 1;
            return lab;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ser = 0;
            double para = 0;


            foreach(TextBox item in resist)
            {
                if (item.Text == "") continue;
                ser += double.Parse(item.Text);
                para += Math.Pow(double.Parse(item.Text), -1);
            }
            para = 1 / para;
            label8.Text = ser.ToString("f2")+ "Ω";
            label9.Text = para.ToString("f2")+ "Ω";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(TextBox item in resist)
            {
                item.Dispose();
            }
            foreach(Label lab in ohm)
            {
                lab.Dispose();
            }
            resist.Clear();
            ohm.Clear();
            A = 1;
            B = 1;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void lightgray4_CheckedChanged(object sender, EventArgs e)
        {
            err = " ±10%";
            label7.Text = ans + unit + "Ω" + err;
        }

        private void white2_CheckedChanged(object sender, EventArgs e)
        {
            second = 9;
        }

        private void brown2_CheckedChanged(object sender, EventArgs e)
        {
            second = 1;
        }
        
    }
}
