using System;
using System.Linq;

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
                    Random rand = new Random();
                    var arr = new int[99];
                    int k = 0;
                    for (int i = 0; i < 99; i++)
                    {
                        k = rand.Next(1, 101);
                        while (arr.Any(n => n == k))
                            k = rand.Next(1, 101);
                        arr[i] = k;
                        Console.Write(arr[i] + " ");
                    }                   
                    int q = 0;
                    for (int i = 1; i < 101; i++)
                    {
                        if (!arr.Any(n => n == i))
                        {
                            q = i;
                            break;
                        }
                    }
                    Console.WriteLine("\nОтсутствующий элемент: " + q);
                    break;
                }
                catch
                {
                    Console.WriteLine("Ошибка выполнения");
                }

            }
        }
    }
}
