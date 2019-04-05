using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sonhaftaa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vize, final, ort;

            vize = Convert.ToDouble(textBox1.Text);
            final = Convert.ToDouble(textBox2.Text);

            ort=vize*0.4+final*0.6;
            label3.Text = ort.ToString();

            if(ort>=88)
            {
                label4.Text = "AA";
            }


            else if(ort<88 && ort>=81)
            {
                label4.Text = "BA";

            }
            else if(ort<81 && ort>=74)
            {
                label4.Text = "BB";

            }
            else if(ort<74 && ort>=67)
            {
                label4.Text = "CB";

            }
            else if(ort<67 && ort>=60)
            {
                label4.Text = "CC";

            }
            else if(ort<60 && ort>=53)
            {
                label4.Text = "DC";

            }
            else if(ort<53 && ort>=46)
            {
                label4.Text = "DD";
            }
            else if(ort<46 && ort>=39)
            {
                label4.Text = "FD";
            }
            else
            {
                label4.Text = "FF";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double vize, final, ort;
            Random salla = new Random();
            for (int t = 0; t < 100; t++)
            {
                vize = salla.Next(0, 101);
                listBox1.Items.Add(vize);
                final = salla.Next(0, 101);
                listBox2.Items.Add(final);

                ort = vize * 0.4 + final * 0.6;
                listBox3.Items.Add(ort);
                if (ort >= 88)
                {
                    label4.Text = "AA";
                }


                else if (ort < 88 && ort >= 81)
                {
                    label4.Text = "BA";

                }
                else if (ort < 81 && ort >= 74)
                {
                    label4.Text = "BB";

                }
                else if (ort < 74 && ort >= 67)
                {
                    label4.Text = "CB";

                }
                else if (ort < 67 && ort >= 60)
                {
                    label4.Text = "CC";

                }
                else if (ort < 60 && ort >= 53)
                {
                    label4.Text = "DC";

                }
                else if (ort < 53 && ort >= 46)
                {
                    label4.Text = "DD";
                }
                else if (ort < 46 && ort >= 39)
                {
                    label4.Text = "FD";
                }
                else
                {
                    label4.Text = "FF";
                }
                listBox4.Items.Add(label4.Text);

            }
        }
    }
}
