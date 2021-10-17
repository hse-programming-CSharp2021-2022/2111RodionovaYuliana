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
                    Console.WriteLine("Введите оценку (от 1 до 10)");
                    var n = int.Parse(Console.ReadLine());
                    if (n > 10 || n < 1)
                        throw new Exception();
                    if (n == 1 || n == 2 || n == 3)
                        Console.WriteLine("Неудовлетворительно");
                    else if (n == 4 || n == 5)
                        Console.WriteLine("Удовлетворительно");
                    else if (n == 6 || n == 7)
                        Console.WriteLine("Хорошо");
                    else
                        Console.WriteLine("Отлично");
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
