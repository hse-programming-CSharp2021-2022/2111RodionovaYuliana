using System;

namespace ConsoleApp1
{
    class Program
    {
        static double Total(double k, double r, uint n)
        {
            double res = k;
            for (int i = 0; i < n; i++)
            {
                res *= 1 + r/100;
            }
            return res;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите начальный капитал, годовую процентную ставку и количество лет.");
                    var s = Console.ReadLine().Split();
                    double a = double.Parse(s[0]);
                    double b = double.Parse(s[1]);
                    uint c = uint.Parse(s[2]);
                    if (s.Length > 3 || a <= 0 || b<=0)
                        throw new Exception();
                    Console.WriteLine(Total(a, b, c));
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
