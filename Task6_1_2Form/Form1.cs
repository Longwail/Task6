using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task6_1_2Form
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
            int m;
            if (int.TryParse(textBox1.Text, out n) && int.TryParse(textBox2.Text, out m))
            {
                Random random = new Random();
                int[,] mas = new int[n, m];
                int proiz = 1;
                textBox3.Text = "Массив: " + Environment.NewLine;
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < m; j++)
                    {
                        mas[i, j] = random.Next(1, 10);
                        proiz *= mas[i, j];
                        textBox3.Text += mas[i, j] + " ";
                    }
                textBox3.Text += Environment.NewLine;

                if (proiz >= 100 && proiz <= 999)
                {
                    textBox3.Text += proiz;
                    textBox3.Text += "Трехзначное";
                }

                else if (proiz <= -100 && proiz >= -999)
                {
                    textBox3.Text += proiz;
                    textBox3.Text += "Трехзначное";
                }

                else
                {
                    textBox3.Text += proiz;
                    textBox3.Text += "Не трехзначное";
                }
            }

            else textBox3.Text = "Некорректные данные";
        }
    }
}
