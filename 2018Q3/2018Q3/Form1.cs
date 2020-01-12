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
namespace _2018Q3
{
    
    public partial class Form1 : Form
    {
        string path;
        List<string> statment = new List<string>();
        List<string> check = new List<string>();
        public Form1()
        {
            InitializeComponent();
            trackBar1.Maximum = 20;
            trackBar1.Minimum = 9;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dia = new OpenFileDialog();
            dia.ShowDialog();
            
            
            path = dia.FileName;
            StreamReader str = new StreamReader(path);
            string buf;
            while((buf = str.ReadLine() )!= null )
            {
                statment.Add(buf);
                checkedListBox1.Items.Add(buf);
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    listBox1.Items.Add(statment[i]);
                    check.Add(statment[i]);
                }
            }
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.ForeColor = Color.Red;
            
        }

        private void DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Brush mybrush = Brushes.Red;
            e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, mybrush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Font font = new Font("標楷體", trackBar1.Value, FontStyle.Regular);
            listBox1.Font = font;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.ForeColor = Color.Blue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string filePath;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "txt files (*.txt)|*.txt|All files(*.*)|*.*";
            sfd.Title = "Save";
            if( sfd.ShowDialog() == DialogResult.OK)
            {
                filePath = sfd.FileName;
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    for(int i = 0; i < check.Count; i++)
                    {
                        sw.WriteLine(check[i]);
                    }
                }
            }
        }
    }
}
