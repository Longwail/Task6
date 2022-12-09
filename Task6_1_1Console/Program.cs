using System;
namespace ConsoleApplication2
{
    class Class
    {
        static int[] Input()
        {
            Console.WriteLine("введите размерность массива");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; ++i)
            {
                Console.Write("a[{0}]= ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }

        static void Proiz(int[] a, int size)
        {
            int proz = 1;
            for (int i = 0; i < size; i++)
            {

                proz *= a[i];
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
                int[] myArray = Input();
                Console.WriteLine("Результат: ");
                Proiz(myArray, myArray.Length);
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