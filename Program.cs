using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите два числа и арифметическую операцию(всё через пробел).");
                    var s = Console.ReadLine().Split();
                    if (s.Length != 3)
                        throw new Exception();
                    var a = long.Parse(s[0]);
                    var b = long.Parse(s[1]);
                    string i = s[2];
                    switch (i)
                    {
                        case "+":
                            Console.WriteLine(a + b);
                            break;
                        case "-":
                            Console.WriteLine(a - b);
                            break;
                        case "*":
                            Console.WriteLine(a * b);
                            break;
                        case "/":
                            Console.WriteLine(a / b);
                            break;
                        case "%":
                            Console.WriteLine(a % b);
                            break;

                        default:
                            throw new Exception();
                    }
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
