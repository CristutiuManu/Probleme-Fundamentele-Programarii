using System;

namespace FPTeme
{
    class Program
    {
        static int Problema1()
        {
            Console.WriteLine("Rezolvare ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare");
            Console.WriteLine("Introdu valori pentru a si b");

            string a1 = Console.ReadLine();
            string b1 = Console.ReadLine();
            int a = Convert.ToInt32(a1);
            int b = Convert.ToInt32(b1);
            int x = 0;
            if (a > 0 && b > 0)
            {
                x = -b + a;

            }

            return x;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Solutia este = " + Problema1());
        }
    }
}
