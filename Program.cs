using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Calc(ulong aa, ulong bb, out ulong b, out ulong s)
        {
            b = 0; 
            s = 0;
            if (aa >= bb)
            {
                for (ulong i = bb; i>=1; i--)
                    if (aa % i==0 && bb % i == 0)
                    {
                        b = i;
                        break;
                    }
                for (ulong j = aa; j <= aa*bb; j++)
                    if (j % aa==0 && j % bb == 0)
                    {
                        s = j;
                        break;
                    }
            }
            else
            {
                for (ulong i = aa; i >= 1; i--)
                    if (aa % i == 0 && bb % i == 0)
                    {
                        b = i;
                        break;
                    }
                for (ulong j = bb; j <= aa * bb; j++)
                    if (j % aa == 0 && j % bb == 0)
                    {
                        s = j;
                        break;
                    }
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите два целых неотрицательных числа через пробел.");
                    var s = Console.ReadLine().Split();
                    if (!ulong.TryParse(s[0], out ulong aa) || !ulong.TryParse(s[1], out ulong bb) || s.Length != 2)
                        throw new Exception();
                    Calc(aa, bb, out ulong b, out ulong f);
                    Console.WriteLine("НОД: " + b + ", НОК: " + f);
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
