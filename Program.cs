using System;
using System.Linq;
// возможно, предполагалось, что в этой задаче массив вводится пользователем, ноо я решила, что буду генерировать его сама. И искать элементы, которые повторяются ровно дважды.
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
                    var arr = new int[100];
                    Random rand = new();
                    for (int i = 0; i < 100; i++)
                    {
                        arr[i] = rand.Next(1, 101);
                        Console.Write(arr[i] + " ");
                    }
                    Console.WriteLine("\nЭлементы, повторяющиеся дважды: ");
                    for (int j = 0; j < 100; j++)
                        if (arr.Count(u => u == j) == 2)
                            Console.Write(j + " ");
                    break;
                }
                catch
                {
                    Console.WriteLine("Ошибка");
                }
            }
        }
    }
}
