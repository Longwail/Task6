using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task6_5Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


         void Print1(int[] a)
        {
            for (int i = 0; i < a.Length; ++i)
                textBox2.Text += a[i]+ " ";
        }

         void Print2(int[][] a)
        {
            for (int i = 0; i < a.Length; ++i, Console.WriteLine())
                for (int j = 0; j < a[i].Length; ++j)
                    textBox2.Text+=a[i][j]+ " ";
        }

         void Sum(int[][] a, ref int[] resArray)
        {
            for (int i = 0; i < a.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < a[i].Length; j++)
                {
                    sum += a[i][j];
                }
                resArray[i] = sum;

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(textBox1.Text, out n))
            {
                Random random = new Random();
                int[][] mas = new int[n][];
                textBox2.Text = "Массив: " + Environment.NewLine;
                for (int i = 0; i < n; ++i)
                {
                    mas[i] = new int[n];
                    for (int j = 0; j < n; ++j)
                    {
                        mas[i][j] = random.Next(1, 10);
                        textBox2.Text += $"{mas[i][j]}"+" ";
                    }
                    textBox2.Text += Environment.NewLine;
                }
                int[] rez = new int[mas.Length];
                Sum(mas, ref rez);
                textBox2.Text += "Результат сложения";
                textBox2.Text += Environment.NewLine;
                Print1(rez);
                int num_max = rez[0];
                for (int i = 0; i < rez.Length; i++)
                {
                    if (num_max < rez[i]) num_max = rez[i];
                }
                textBox2.Text +=$"Максимальный элемент равен {num_max}";
            }


        }
    }
}
