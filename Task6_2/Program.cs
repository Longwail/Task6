using System;
namespace ConsoleApplication
{
    class Class
    {
        static double[] Input()
        {
            Console.Write("введите размерность массива ");
            int n = int.Parse(Console.ReadLine());
            double[] a = new double[n];
            for (int i = 0; i < n; ++i)
            {
                Console.Write("a[{0}]= ", i);
                a[i] = double.Parse(Console.ReadLine());
            }
            return a;
        }


        static void Main()
        {
            double[] myArray = Input();
            double n;
            Console.Write("Введите число: ");
            while (!double.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Неверное значение!");
                Console.Write("Введите число: ");
            }
            int kol = 0;
            for (int i = 1; i < myArray.Length; ++i)
            {
                if (Math.Abs(Math.Round(myArray[i - 1] - myArray[i], 2)) == n) kol++;
            }
                
            Console.WriteLine("Количество найденых пар = " + kol);
        }
    }
}
