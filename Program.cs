using System;

namespace ConsoleApp16091
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите целое число.");
                    var num = long.Parse(Console.ReadLine());
                    if (num < 0)
                        num *= -1;
                    string s = num.ToString();
                    int maxi = 0; int mini = 9;
                    for (int i = 0; i < 10; i++)
                    {
                        if (s.Contains(i.ToString()))
                        {
                            if (i > maxi)
                                maxi = i;
                            if (i < mini)
                                mini = i;
                        }
                    }
                    Console.WriteLine(mini + " " + maxi); ;
                    break;
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод. Попробуйте снова.");
                }
            }
        }
    }
}
