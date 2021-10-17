using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Sums(uint number, out uint sumEven, out uint sumOdd)
        {
            string s = number.ToString();
            sumOdd = 0;
            sumEven = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (i % 2 == 0)
                    sumEven += uint.Parse(s[i].ToString());
                else
                    sumOdd += uint.Parse(s[i].ToString());
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите целое неотрицательное число.");
                    uint num = uint.Parse(Console.ReadLine());
                    Sums(num, out uint sumEven, out uint sumOdd);
                    Console.WriteLine("Сумма цифр на чётных позициях: " + sumEven + ", сумма цифр на нечётных позициях: " + sumOdd);
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
