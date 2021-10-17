using System;

namespace ConsoleApp1
{
    // В условии написано про результат True - false false, но он очевидно неверный... Так что я всё равно больше верю тому, что выводит эта программа.
    class Program
    {
        public static bool Function(bool p, bool q)
        {
            return !(p & q) & !(p | !q);
        }
        static void Function(bool p, bool q, out bool[] res, int i)
        {
            res = new bool[4];
            int p0, q0;
            if (i % 2 == 0)
            {
                q = true;
                q0 = 1;
            }
            else
            {
                q = false;
                q0 = 0;
            }
            if (i <= 1)
            {
                p = true;
                p0 = 1;
            }
            else
            {
                p = false;
                p0 = 0;
            }
            Console.Write(p0 + " " + q0 + " ");
            res[i] = Function(p, q);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Таблица истинности !(p & q) & !(p | !q) {в формате значение 1 значение 2 результат}");
            for (int j = 0; j < 4; j++)
            {
                Function(true, true, out bool[] res, j);
                if (res[j])
                    Console.WriteLine('1');
                else
                    Console.WriteLine('0');
            }
        }
    }
}
