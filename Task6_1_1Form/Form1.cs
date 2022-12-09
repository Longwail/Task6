using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task6_1_1Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(textBox1.Text, out n))
            {
                Random random = new Random();
                int[] mas = new int[n];
                int proiz = 1;
                textBox2.Text = "Массив: " + Environment.NewLine;
                for (int i = 0; i < n; i++)
                {
                    mas[i] = random.Next(1, 10);
                    proiz *= mas[i];
                    textBox2.Text += mas[i] + " ";
                }
                textBox2.Text += Environment.NewLine;

                if (proiz >= 100 && proiz <= 999)
                {
                    textBox2.Text += proiz;
                    textBox2.Text += "Трехзначное";
                }

                else if (proiz <= -100 && proiz >= -999)
                {
                    textBox2.Text += proiz;
                    textBox2.Text += "Трехзначное";
                }

                else
                {
                    textBox2.Text += proiz;
                    textBox2.Text += "Не трехзначное";
                }
            }
            else textBox2.Text = "Некорректные данные";
        }
    }
}
