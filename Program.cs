using System;

namespace ConsoleApp1
{
    class Program
    {
        void Reverse(ref string s)
        {
            int i = s.Length - 1;
            if (s != "0")
                while (s[i] == '0')
                {
                    s = s.Remove(i);
                    i--;
                }
            for (int j = s.Length - 1; j >= 0; j--)
                Console.Write(s[j]);
        }

        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите целое число.");
                    var a = long.Parse(Console.ReadLine());
                    string s = a.ToString();
                    Reverse(ref s);
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
