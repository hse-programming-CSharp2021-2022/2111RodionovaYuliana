using System;
// задача 6 из презентации
namespace ConsoleApp1
{
    class Program
    {
        static double Fact(int k)
        {
            double w = 1;
            for (int i = 1; i <= k; i++)
                w *= i;
            return w;
        }
        static void Sums(double x)
        {
            double s1 = x*x, s2 = 1, s0 = 0;
            int k = 2, t = 1;
            while (s1 - s0 != 0)
            {
                if (t!=1)
                    s0 = s1;
                double u = x * x;
                for (int i = 0; i < k; i++)
                    u *= x;
                double n = Fact(k+2);
                s1 += (double)Math.Pow(-1, t) * u * (double)Math.Pow(2, k + 1)/n;
                k+=2;
                t++;
            }
            s0 = 0; 
            t = 1;
            while (s1 - s0 != 0)
            {
                if (t != 1)
                    s0 = s2;
                double u = 1;
                for (int i = 0; i < t; i++)
                    u *= x;
                double n = Fact(t);
                s2 += u/n;
            }
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите вещественное число.");
                    var x = double.Parse(Console.ReadLine());
                    Sums(x);
                    break;
                }
                catch
                {
                    Console.WriteLine("Неверный ввод.");
                }
            }
        }
    }
}
