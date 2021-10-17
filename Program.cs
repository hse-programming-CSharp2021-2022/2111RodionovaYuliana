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
                    Console.WriteLine("Введите размер массива. ");
                    var n = uint.Parse(Console.ReadLine());
                    Random rand = new();
                    var arr = new double[n];
                    var arr1 = new double[n];
                    var arr2 = new double[n];
                    for (int i = 0; i < n; i++)
                    {
                        arr[i] = rand.NextDouble();
                        Console.Write(arr[i] + " ");
                        arr1[i] = Math.Truncate(arr[i]);
                        arr2[i] = arr[i] - arr1[i];
                    }
                    Console.WriteLine("\nЦелая и дробная части: ");
                    for (int j = 0; j < n; j++)
                        Console.Write(arr1[j] + "     " + arr2[j]);
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
