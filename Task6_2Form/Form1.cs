using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task6_2Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double n;
            string[] numbers = textBox1.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (double.TryParse(textBox2.Text, out n))
            {
                Random random = new Random();
                double[] myArray = new double[numbers.Length];
                for (int i = 0; i < numbers.Length; i++)
                {
                    myArray[i] = double.Parse(numbers[i]);
                }
                int kol = 0;
                textBox3.Text = "Массив: " + Environment.NewLine;
                for (int i = 1; i < myArray.Length; ++i)
                {
                    if (Math.Abs(Math.Round(myArray[i - 1] - myArray[i], 2)) == n) kol++;

                }

                for (int i = 0; i < myArray.Length; i++)
                {
                    textBox3.Text += myArray[i] + " ";
                }
                textBox3.Text += Environment.NewLine;
                textBox3.Text += ("Количество найденых пар = " + kol);

            }
        }
    }
}
