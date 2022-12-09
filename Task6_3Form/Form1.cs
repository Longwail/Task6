using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task6_3Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); ++i, Console.WriteLine())
            {
                for (int j = 0; j < a.GetLength(1); ++j)
                {
                    richTextBox1.Text += a[i, j] + " ";
                }
                richTextBox1.Text += Environment.NewLine;
            }
                
        }

        void Opredelit(int[,] a)
        {

            for (int i = 0; i < a.GetLength(0); ++i)
            {
                Boolean isNegative = false;
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] < 0)
                    {
                        isNegative = true;
                        richTextBox1.Text +=$"строка {i + 1}: не положительная строка\n";
                        break;
                    }
                }
                if (!isNegative)
                    richTextBox1.Text += $"строка {i + 1}: положительные\n";

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(textBox1.Text, out n))
            {
                Random random = new Random();
                int[,] mas = new int[n, n];
                richTextBox1.Text = "Массив: " + Environment.NewLine;
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                    {
                        mas[i, j] = random.Next(-3, 10);
                    }
                richTextBox1.Text += Environment.NewLine;
                Print(mas);
                Opredelit(mas);

            }
        }
    }
}
