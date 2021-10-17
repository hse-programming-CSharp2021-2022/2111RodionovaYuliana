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
                    Console.WriteLine("Введите число элементов массива.");
                    var k = uint.Parse(Console.ReadLine());
                    var arr = new char[k];
                    var arr2 = new char[k];
                    Random rand = new Random();
                    for (int i = 0; i<k; i++)
                    {
                        arr[i] = (char)rand.Next('A', 'Z' + 1);
                        Console.Write(arr[i] + " ");
                    }
                    Console.Write("\nСортированный массив: ");
                    Array.Copy(arr, 0, arr2, 0, k);
                    Array.Sort(arr2);
                    for (int i = 0; i < k; i++)
                        Console.Write(arr2[i] + " ");
                    Console.Write("\nПеревёрнутый массив: ");
                    Array.Reverse(arr2);
                    for (int i = 0; i < k; i++)
                        Console.Write(arr2[i] + " ");
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
