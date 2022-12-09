using System;
using System.IO;

namespace ConsoleApplication
{
    class Class
    {
        static int[,] Input(out int n)
        {
            Console.WriteLine("введите размерность массива");
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < n; ++j)
                {
                    Console.Write("a[{0},{1}]= ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            return a;
        }

        static void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); ++i, Console.WriteLine())
                for (int j = 0; j < a.GetLength(1); ++j)
                    Console.Write("{0} ", a[i, j]);
        }

        static void Opredelit(int[,] a)
        {

            for (int i = 0; i < a.GetLength(0); ++i)
            {
                Boolean isNegative = false;
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] < 0)
                    {
                        isNegative = true;
                        Console.WriteLine($"строка {i+1}: не положительная строка");
                        break;
                    }
                }
                if (!isNegative)
                    Console.WriteLine($"строка {i+1}: положительные");
            }
        }

        static void Main()
        {
            try
            {
                int n;
                int[,] myArray = Input(out n);
                Console.WriteLine("Результат: ");
                Print(myArray);
                Opredelit(myArray);
            }
            catch (FormatException)
            {
                Console.WriteLine(" Неверное значение данных");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine(" Выход за границы массива");
            }

        }
    }
}