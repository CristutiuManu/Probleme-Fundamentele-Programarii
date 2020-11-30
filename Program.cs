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
        static void Problema3()
        {
            // Determinati daca n se divide cu k, unde n si k sunt date de intrare.

            bool seDivide = false;

            Console.WriteLine("Introdu numarul");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introdu divizorul");
            int k = int.Parse(Console.ReadLine());

            if (n % k == 0)
            {
                seDivide = true;
                Console.WriteLine("N se divide cu K");
            }
            else Console.WriteLine("N NU se divide cu K");
        }
        static void Problema4()
        {
            // Detreminati daca un an y este an bisect.

            bool bisect = false;
            Console.WriteLine("Introdu anul:");
            int y = int.Parse(Console.ReadLine());

            if (y % 4 == 0)
            {
                bisect = true;
            }

            if (bisect)
            {
                Console.WriteLine("Anul " + y + " este bisect");
            }
            else Console.WriteLine("Anul " + y + " NU este bisect");
        }
        static void Problema5()
        {
            // Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. 

            Console.WriteLine("Introdu un numar");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Intrody a cata cifra de la sfarsitul numarului");
            int k = int.Parse(Console.ReadLine());


            int cifra = 0;
            while (k > 0)
            {
                cifra = n % 10;
                n = n / 10;
                k--;
            }
            Console.WriteLine(cifra);
        }
        static void Problema6()
        {
            // Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi.
            Console.WriteLine("Introdu numerele: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            bool esteTriunghi = false;
            if (a > 0 && b > 0 && c > 0)
            {
                if (a + b > c)
                    esteTriunghi = true;
                if (a + c > b)
                    esteTriunghi = true;
                if (b + c > a)
                    esteTriunghi = true;
            }
            if (esteTriunghi)
            {
                Console.WriteLine("Numerele pot constitui lungimile laturilor unui triunghiu.");
            }
            else Console.WriteLine("Numerele NU pot constitui lungimile laturilor unui triunghiu.");
        }
        static void Problema7()
        {
            // (Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor.

            Console.WriteLine("Introdu numerele: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            void Interschimbare()
            {
                int aux;
                aux = a;
                a = b;
                b = aux;
            }
            Interschimbare();
            Console.WriteLine("Numerele sunt: " + a + " si " + b);

        }
        static void Problema8()
        {
            // (Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.

            Console.WriteLine("Introdu numerele: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            a += b;

            b = a - b;

            a -= b;

            Console.WriteLine("Numerele sunt: " + a + " si " + b);

        }
        static void Problema9()
        {
            // Afisati toti divizorii numarului n.

            Console.WriteLine("Introdu numarul: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Divizorii numarului sunt: ");
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write(i + " ");
                }
            }

        }
        static void Problema10()
        {
            // Test de primalitate: determinati daca un numar n este prim.

            Console.WriteLine("Introdu numarul: ");
            int n = int.Parse(Console.ReadLine());

            bool estePrim = false;

            for (int i = 2; i < n / 2; i++)
            {
                if (n % i == 0)
                {
                    estePrim = false;
                    break;
                }
                else estePrim = true;
            }

            if (estePrim)
            {
                Console.WriteLine(n + " este prim");
            }
            else Console.WriteLine(n + " NU este prim");

        }
        static void Problema11()
        {
            // Afisati in ordine inversa cifrele unui numar n.

            Console.WriteLine("Introdu numarul: ");
            int n = int.Parse(Console.ReadLine());
            int oglinditul = 0;

            while (n != 0)
            {
                int cifra = n % 10;
                n = n / 10;
                oglinditul = 10 * oglinditul + cifra;

            }

            Console.WriteLine("Oglinditul este: " + oglinditul);

        }
        static void Problema12()
        {
            // Determinati cate numere integi divizibile cu n se afla in intervalul[a, b].

            Console.WriteLine("Introduceti intervalele");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Introdu numarul: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Divizorii sunt: ");
            for (int i = a; i <= b; i++)
            {
                if (n % i == 0)
                    Console.Write(i + " ");
            }

        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Solutia este = " + Problema1());
            //Problema2();
            //Problema3();
            //Problema4();
            //Problema5();
            //Problema6();
            //Problema7();
            //Problema8();
            //Problema9();
            //Problema10();
            //Problema11();
            Problema12();
        }
    }
}
