using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice5_1
{
    public partial class Form1 : Form
    {
        //Image[] sauce = new Image[4];
        //sauce[0] = Image.FromFile(@"..\..\image\SAUCE_BLUE.png");

        public Form1()
        {
            InitializeComponent();

            pictureBread.Image= Image.FromFile(@"..\..\image\BREAD.png");
            pictureBread.SizeMode = PictureBoxSizeMode.StretchImage;
            //pictureSauce.Image = Image.FromFile(@"..\..\image\SAUCE_BLUE.png");
            pictureBread.Controls.Add(pictureSauce);
            pictureSauce.BackColor = Color.Transparent;
            pictureSauce.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureSauce.Controls.Add(pictureIngredient);
            pictureIngredient.BackColor = Color.Transparent;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //pictureSauce.Image = Image.FromFile(@"..\..\image\SAUCE_NONE.png");
            //pictureSauce.BackColor = Color.Transparent;
            //pictureSauce.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void blueberry_CheckedChanged(object sender, EventArgs e)
        {
            //pictureSauce.Image = Image.FromFile(@"..\..\image\SAUCE_BLUE.png");
            //pictureSauce.BackColor = Color.Transparent;
            //pictureSauce.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void matcha_CheckedChanged(object sender, EventArgs e)
        {
            //pictureSauce.Image = Image.FromFile(@"..\..\image\SAUCE_GREEN.png");
            //pictureSauce.BackColor = Color.Transparent;
            //pictureSauce.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void tomato_CheckedChanged(object sender, EventArgs e)
        {
            //pictureSauce.Image = Image.FromFile(@"..\..\image\SAUCE_RED.png");
            //pictureSauce.BackColor = Color.Transparent;
            //pictureSauce.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pineapple_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ham_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void make_Click(object sender, EventArgs e)
        {
            if (blueberry.Checked)
            {
                pictureSauce.Image = Image.FromFile(@"..\..\image\SAUCE_BLUE.png");
            }
            else if (matcha.Checked)
            {
                pictureSauce.Image = Image.FromFile(@"..\..\image\SAUCE_GREEN.png");
            }
            else if (tomato.Checked)
            {
                pictureSauce.Image = Image.FromFile(@"..\..\image\SAUCE_RED.png");
            }
            else if (none.Checked)
            {
                pictureSauce.Image = Image.FromFile(@"..\..\image\SAUCE_NONE.png");
            }


            Random rand = new Random();
            if (textBox1.Text != "")
            {
                int num = int.Parse(textBox1.Text);
                if (num > 0)
                {
                    for(int i = 0; i < num; i++)
                    {
                        PictureBox pine = new PictureBox();
                        Image import = Image.FromFile(@"..\..\image\PINEAPPLE.png");
                        Bitmap tmp = new Bitmap(import, new Size(40, 30));
                        pine.Image = tmp;
                        pine.BackColor = Color.Transparent;
                        int x, y;
                        do
                        {
                            x = rand.Next(150);
                            y = rand.Next(150);
                        } while (Math.Sqrt(Math.Pow(62 - x, 2) - Math.Pow(80- y, 2)) > 300);

                        pine.Location = new Point(rand.Next(-100, 120), rand.Next(-100, 120));
                        pictureIngredient.Controls.Add(pine);
                        pictureIngredient.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }
            if (textBox2.Text != "")
            {
                int num = int.Parse(textBox2.Text);
                if (num > 0)
                {
                    for (int i = 0; i < num; i++)
                    {
                        PictureBox ham = new PictureBox();
                        Image import = Image.FromFile(@"..\..\image\HAM.png");
                        Bitmap tmp = new Bitmap(import, new Size(40, 30));
                        ham.Image = tmp;
                        ham.BackColor = Color.Transparent;

                        int x, y;
                        do
                        {
                            x = rand.Next(150);
                            y = rand.Next(150);
                        } while (Math.Sqrt(Math.Pow(62 - x, 2) - Math.Pow(80 - y, 2)) > 300);

                        ham.Location = new Point(rand.Next(-100, 120), rand.Next(-100, 120));
                        pictureIngredient.Controls.Add(ham);
                        pictureIngredient.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }



        }

        private void pictureIngredient_Click(object sender, EventArgs e)
        {

        }
    }
}
