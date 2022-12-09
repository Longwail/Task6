using System;
namespace ConsoleApplication
{
    class Class
    {
        static int[][] Input()
        {
            Console.WriteLine("введите размерность массива");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[][] a = new int[n][];
            for (int i = 0; i < n; ++i)
            {
                a[i] = new int[n];
                for (int j = 0; j < n; ++j)
                {
                    Console.Write("a[{0},{1}]= ", i, j);
                    a[i][j] = int.Parse(Console.ReadLine());
                }
            }
            return a;
        }

        static void Print1(int[] a)
        {
            for (int i = 0; i < a.Length; ++i)
                Console.Write("{0,2} ", a[i]);
        }

        static void Print2(int[][] a)
        {
            for (int i = 0; i < a.Length; ++i, Console.WriteLine())
                for (int j = 0; j < a[i].Length; ++j)
                    Console.Write("{0,5} ", a[i][j]);
        }

        static void Sum(int[][] a, ref int[] resArray)
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

        static void Main()
        {
            int[][] myArray = Input();
            Console.WriteLine("Исходный данные:");
            Print2(myArray);
            int[] rez = new int[myArray.Length];
            Sum(myArray, ref rez);
            Console.Write("Результат: ");
            Print1(rez);

            int num_max = rez[0];
            for (int i = 0; i < rez.Length; i++)
            {
                if (num_max < rez[i]) num_max = rez[i];
            }
            Console.WriteLine($"Максимальный элемент равен {num_max}");
        }
    }
}
