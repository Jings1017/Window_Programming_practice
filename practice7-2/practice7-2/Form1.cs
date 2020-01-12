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
using System.Text.RegularExpressions;
namespace practice7_2
{
    public partial class Form1 : Form
    {
        int mon, d, h, min;
        Dictionary<int, string> sheduler = new Dictionary<int, string>();
        List<int> dataKey = new List<int>();
        private void clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void search_Click(object sender, EventArgs e)
        {
            mon = Decimal.ToInt32(month.Value);
            d = Decimal.ToInt32(day.Value);
            h = Decimal.ToInt32(hour.Value);
            min = Decimal.ToInt32(minute.Value);
            string path = "schedule\\" + mon + "_" + d + ".txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while((s=sr.ReadLine())!=null)
                {
                    string s1 = Regex.Replace(s, ":", "", RegexOptions.IgnoreCase);
                    int k = int.Parse(s1);
                    foreach(int i in sheduler.Keys)
                    {
                        if (k == i)
                        {
                            k += 1;
                        }
                    }
                    sheduler.Add(k, sr.ReadLine());
                    sr.ReadLine();
                }
                sr.Close();
                // show the text 
                var dics = from obj in sheduler orderby obj.Key select obj;
                foreach(KeyValuePair<int,string> kvp in dics)
                {
                    if (kvp.Key % 100 < 10)
                    {
                        richTextBox1.Text += kvp.Key / 100 + " : 0" + kvp.Key % 100 + "\n";
                    }
                    else
                    {
                        richTextBox1.Text += kvp.Key / 100 + " : " + kvp.Key % 100 + "\n";
                    }
                    
                    richTextBox1.Text += kvp.Value+"\n";
                    richTextBox1.Text += "-----------------\n";
                }   
            }
        }

        public Form1()
        {
            InitializeComponent();
            month.Maximum = 12;
            month.Minimum = 1;
            day.Maximum = 31;
            day.Minimum = 1;
            hour.Maximum = 23;
            hour.Minimum = 0;
            minute.Maximum = 59;
            minute.Minimum = 0;
        }

        private void write_Click(object sender, EventArgs e)
        {
            mon = Decimal.ToInt32(month.Value);
            d   = Decimal.ToInt32(day.Value);
            h   = Decimal.ToInt32(hour.Value);
            min = Decimal.ToInt32(minute.Value);
            string path = "schedule\\" + mon + "_" + d + ".txt";
            string time;
            if((mon==2 && d>29) || (mon==4 && d>30) || (mon==6 && d>30) ||
                (mon==9 && d>30) || (mon==11 && d > 30))
            {
                MessageBox.Show("日期錯誤，請重新輸入");
            }
            else
            {
                if (h < 10)
                {
                    if (min < 10)
                    {
                        time = "0" + h + ":0" + min;
                    }
                    else
                    {
                        time = "0" + h + ":" + min;
                    }
                }
                else
                {
                    if (min < 10)
                    {
                        time = h + ":0" + min;
                    }
                    else
                    {
                        time = h + ":" + min;
                    }
                }


                string statement = richTextBox1.Text;
                string line = "-----------------";
                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(time);
                        sw.WriteLine(statement);
                        sw.WriteLine(line);
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine(time);
                        sw.WriteLine(statement);
                        sw.WriteLine(line);
                    }
                }
            }
            
        }
    }
}
