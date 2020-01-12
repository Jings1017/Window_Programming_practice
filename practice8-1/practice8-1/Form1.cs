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

namespace practice8_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string path = "pic";
        private void Form1_Load(object sender, EventArgs e)
        {
            
            if (Directory.Exists(path))
            {
                
               foreach(string name in Directory.GetDirectories(path))
                {
                    comboBox1.Items.Add(name.Split('\\')[1]);
                }
                
            }
            else
            {
                MessageBox.Show("no file exists");
            }

            listBox1.Items.Clear();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                BackColor = colorDialog1.Color;
            }
        }

        private void change(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach(string name in Directory.GetFiles(path+"\\"+comboBox1.Text))
            {
                listBox1.Items.Add(name.Split('\\')[2]);
            }
        }

        private void showpic(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(path + "\\" + comboBox1.Text + "\\" + listBox1.Text);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
