using System;
// Из условия не очень понятно, нужна там таблица значений или сумма, так что вывела сумму.
namespace ConsoleApp1
{
    class Program
    {
        static double Sum(uint n)
        {
            double s = 0;
            for (int i = 1; i <= n; i++)
                s += (i + 0.3) / ((3 * i * i) + 5);
            return s;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите целое неотрицательное число.");
                    Console.WriteLine(Sum(uint.Parse(Console.ReadLine())));
                    break;
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод.");
                }
            }
        }
    }
}
