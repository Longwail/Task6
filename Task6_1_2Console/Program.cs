using System;
namespace ConsoleApplication2
{
    class Class
    {
        static int[,] Input(out int n, out int m) 
        {
            Console.WriteLine("введите размерность массива");
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            m = int.Parse(Console.ReadLine());
            int[,] a = new int[n,m];
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < m; ++j)
                {
                    Console.Write("a[{0},{1}]= ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            return a;

        }

        static void Proiz(int[,] a, int n, int m)
        {
            int proz = 1;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    proz *= a[i, j];
                }

            if (proz >= 100 && proz <= 999)
            {
                Console.WriteLine(proz);
                Console.WriteLine("Трехзначное");
            }
            else if (proz <= -100 && proz >= -999)
            {
                Console.WriteLine(proz);
                Console.WriteLine("Трехзначное");
            }

            else
            {
                Console.WriteLine(proz);
                Console.WriteLine("Не трехзначное");
            }
        }

        static void Main()
        {
            try
            {
                int n, m;
                int[,] myArray = Input(out n, out m);
                Console.WriteLine("Результат: ");
                Proiz(myArray, n, m);
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