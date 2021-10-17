using System;
//6.2
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
                    Console.WriteLine("Введите размер массива");
                    var n = uint.Parse(Console.ReadLine());
                    Random rand = new Random();
                    var arr = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        arr[i] = rand.Next(-10, 11);
                        Console.Write(arr[i] + " ");
                        if (arr[i] % 2 == 0)
                            arr[i] = 100;
                    }
                    Console.WriteLine("\n Сжатый массив(без элементов с чётными значениями): \n");
                    for (int i = 0; i < n; i++)
                    {
                        if (arr[i] != 100)
                            Console.Write(arr[i] + " ");
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
