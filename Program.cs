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
                    Console.WriteLine("Введите размер массива.");
                    var n = uint.Parse(Console.ReadLine());
                    var arr = new int[n];
                    Random rand = new();
                    for (int i = 0; i < n; i++)
                    {
                        arr[i] = rand.Next(1000,10000);
                        Console.Write(arr[i] + " ");
                    }
                    Console.WriteLine("\nПалиндромы: ");
                    for (int j = 0; j < n; j++)
                    {
                        if (arr[j] / 100 == arr[j] % 10 * 10 + arr[j] / 10 % 10)
                            Console.Write(arr[j] + " ");
                    }
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
