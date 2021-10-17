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
                    Console.WriteLine("Введите размер массива массивов.");
                    var n = uint.Parse(Console.ReadLine());
                    Random rand = new();
                    var arr = new int[n][];
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("\n");
                        arr[i] = new int[rand.Next(5, 16)];
                        for (int j = 0; j < arr[i].Length; j++)
                        {
                            arr[i][j] = rand.Next(-10, 11);
                            Console.Write(arr[i][j] + " ");
                        }
                    }
                    Console.WriteLine();
                    for (int i = 0; i < n; i++)
                    {
                        Array.Sort(arr[i]);
                        Array.Reverse(arr[i]);
                        Console.Write("\n");
                        for (int j = 0; j < arr[i].Length; j++)
                            Console.Write(arr[i][j] + " ");
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
