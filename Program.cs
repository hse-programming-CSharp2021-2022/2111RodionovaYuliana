using System;
// задача 2 из презентации
namespace ConsoleApp1
{
    class Program
    {
        public static bool Shift(ref char ch)
        {
            string alph = "abcdefghijklmnopqrstuvwxyz";
            if (alph.Contains(ch))
            {
                int k = alph.IndexOf(ch);
                if (k + 4 >= alph.Length)
                    ch = alph[(k + 4) % alph.Length];
                else
                    ch = alph[k + 4];
                return true;
            }
            else
                return false;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите один символ.");
                    var a = Console.ReadLine();
                    if (a.Length > 1)
                        throw new Exception();
                    char i = a[0];
                    Console.WriteLine(Shift(ref i));
                    if (i != a[0])
                        Console.WriteLine(i);
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
