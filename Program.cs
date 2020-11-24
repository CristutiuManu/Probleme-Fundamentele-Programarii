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
                x = -b / a;
            }

            return x;

        }
        static void Problema2()
        {
            Console.WriteLine("Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile. ");
            Console.WriteLine("Introdu valorile");
            int x1, x2;
            float delta;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a == 0)
                if (b == 0)
                    if (c == 0)
                    {
                        Console.WriteLine("Ecuatie nedeterminata");
                    }
                    else
                    {
                        Console.WriteLine("Ecuatia este imposibila");
                    }
                else
                {
                    x1 = -c / b;
                }

            else
            {
                delta = (float)Math.Pow(2, b) - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("Ecuatia are solutii complexe");
                }
                else if (delta == 0)
                {
                    x1 = x2 = -b / (2 * a);
                }
                else
                {
                    x1 = (int)((-b + Math.Sqrt(delta)) / (2 * a));
                    x2 = (int)((-b - Math.Sqrt(delta)) / (2 * a));
                    Console.WriteLine("Solutiile sunt x1 = {0}, x2 = {1}", x1, x2);
                }
            }



        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Solutia este = " + Problema1());
            Problema2();
        }
    }
}
