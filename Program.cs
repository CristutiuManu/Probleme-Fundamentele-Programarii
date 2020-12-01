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
        static void Problema13()
        {
            // Determinati cati ani bisecti sunt intre anii y1 si y2.

            Console.WriteLine("Introduceti intervalele");
            int y1 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Anii bisecti din intervalul [y1, y2] sunt: ");

            for (int i = y1; i <= y2; i ++)
            {
                if (i % 4 == 0)
                {
                    Console.Write(i + " ");
                }
            }

        }
        static void Problema14()
        {
            // Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321.

            Console.WriteLine("Introduceti numarul: ");

            int n = int.Parse(Console.ReadLine());
            int palindrom = 0;
            int m = n;
            while (m != 0)
            {
                palindrom = palindrom * 10 + m % 10;
                m /= 10;
            }

            if (palindrom == n)
            {
                Console.WriteLine(n + " este palindrom.");
            }
            else Console.WriteLine(n + " nu este palindrom");

        }
        static void Problema15()
        {
            // Se dau 3 numere. Sa se afiseze in ordine crescatoare.

            Console.WriteLine("Introdu numerele: ");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a >= b && a >= c)
            {
                if (b >= c)
                {
                    Console.Write(c + " " + " " + b + " " + a);
                }
                else Console.Write(b + " " + " " + c + " " + a);
            }
            else if (b >= a && b >= c)
            {
                if (a >= c)
                    Console.Write(c + " " + a + " " + b);
                else Console.Write(a + " " + " " + c + " " + b);
            }
            else if (c >= a && c >= b)
            {
                if (a >= b)
                    Console.Write(b + " " + " " + a + " " + c);
                else Console.Write(a + " " + " " + b + " " + c);
            }
        }
        static void Problema16()
        {
            // Se dau 5 numere. Sa se afiseze in ordine crescatoare.

            Console.WriteLine("Introdu numerele: ");
            long Numar1, Numar2, Numar3, Numar4, Numar5;

                
                Numar1 = long.Parse(Console.ReadLine());

                Numar2 = long.Parse(Console.ReadLine());
                (Numar1, Numar2) = (Math.Min(Numar1, Numar2), Math.Max(Numar1, Numar2));

                Numar3 = long.Parse(Console.ReadLine());
                (Numar2, Numar3) = (Math.Min(Numar2, Numar3), Math.Max(Numar2, Numar3));
                (Numar1, Numar2) = (Math.Min(Numar1, Numar2), Math.Max(Numar1, Numar2));

                Numar4 = long.Parse(Console.ReadLine());
                (Numar3, Numar4) = (Math.Min(Numar3, Numar4), Math.Max(Numar3, Numar4));
                (Numar2, Numar3) = (Math.Min(Numar2, Numar3), Math.Max(Numar2, Numar3));
                (Numar1, Numar2) = (Math.Min(Numar1, Numar2), Math.Max(Numar1, Numar2));

                Numar5 = long.Parse(Console.ReadLine());
                (Numar4, Numar5) = (Math.Min(Numar4, Numar5), Math.Max(Numar4, Numar5));
                (Numar3, Numar4) = (Math.Min(Numar3, Numar4), Math.Max(Numar3, Numar4));
                (Numar2, Numar3) = (Math.Min(Numar2, Numar3), Math.Max(Numar2, Numar3));
                (Numar1, Numar2) = (Math.Min(Numar1, Numar2), Math.Max(Numar1, Numar2));

                Console.WriteLine($"\n Numerele introduse ordonate crescator sunt: {Numar1}, {Numar2}, {Numar3}, {Numar4}, {Numar5} . \n");  

        }
        static void Problema17()
        {
            // Determinati cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid.
            Console.WriteLine("Introduceti numerele");
            
           int numar1 = int.Parse(Console.ReadLine());
           int numar2 = int.Parse(Console.ReadLine());
        //cmmdc
            //while (numar1 != numar2)
            //{
            //    if (numar1 > numar2)
            //        numar1 -= numar2;
            //    else numar2 -= numar1;
            //}
            
        //cmmmc

            int produs = numar1 * numar2;                          

            while (numar2 != 0)                                 
            {
                int auxiliar = numar1 % numar2;
                numar1 = numar2;
                numar2 = auxiliar;
            }

            Console.WriteLine($"CMMMC este: {produs/numar1}");
            Console.WriteLine("CMMDC este: " + numar1);
        }
        static void Problema18()
        {
            // Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1776 afisati 2^3 x 3^1 x 7^2. 

            Console.WriteLine("Introduceti numarul: ");

            int n = int.Parse(Console.ReadLine());
            int contor = 0;
            Console.Write($"\n Descompunerea in factori primi a numarului {n} este: ");

            if (n % 2 == 0)
            {
                while (n % 2 == 0)
                {
                    contor++;

                    n /= 2;
                }
                Console.Write($"2 ^{contor} ");

                contor = 0;

                if (n > 1)
                {
                    Console.Write("* ");
                }
            }

            for (int i = 3; i <= (int)Math.Sqrt(n); i += 2)
            {
                if (n % i == 0)
                {
                    while (n % i == 0)
                    {
                        contor++;

                        n /= i;
                    }
                    Console.Write($"{i} ^ {contor} ");

                    contor = 0;

                    if (n > 1)
                    {
                        Console.Write("x ");
                    }
                }
            }

            if (n > 1)
            {
                Console.Write($"{n} ^ 1");
            }

            Console.WriteLine("\n");
        }
        static void Problema19()
        {
            // Determinati daca un numar e format doar cu 2 cifre care se pot repeta. De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt. 

            Console.WriteLine("Introdu numarul: ");
            int n = int.Parse(Console.ReadLine());
            bool seRepeta = false;
            int cifra1, cifra2 = -1;

            cifra1 = n % 10;
            n = n / 10;

            while (n != 0)
            {
                if (cifra1 != n % 10 && cifra2 == -1)
                {
                    cifra2 = n % 10;
                    seRepeta = true;
                }
                else if (cifra1 != n % 10 && n % 10 != cifra2)
                {
                    seRepeta = false;
                    n = 0;
                }

                n /= 10;

            }

            if (seRepeta)
                Console.WriteLine( "este format din doua cifre care se pot repeta.");
            else Console.WriteLine( "NU este format din doua cifre care se pot repeta");

        }
        static void Problema20()
        {
            // Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). Exemplu: 13/30 = 0.4(3).

            Console.WriteLine("Introduceti numerele");

            Console.Write("m = ");
            float m = float.Parse(Console.ReadLine());
            Console.Write("n = ");
            float n = float.Parse(Console.ReadLine());


            if (m % n == 0)
                Console.WriteLine($"Fractia este egala cu {m/n}");
            else
            {
                float aux = n;

                while (n % 2 == 0)
                {
                    n = n / 2;
                }
                while (n % 5 == 0)
                {
                    n = n / 5;
                }
                if (n == 1 || m % n == 0)
                {
                    Console.WriteLine($"Fractia este egala cu {m / n}");
                }
                else
                {
                    Console.WriteLine($"Fractia este egala cu {m / aux}");

                    float[] perioada = new float[10];

                    for (int i = 0; i < 10; i++)
                    {
                        m *= 10;
                        perioada[i] = m / n;
                    }

                }
            }

        }
        static void Problema21()
        {
            // Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?".

            Random rnd = new Random();
            int x = rnd.Next(1, 1024);

            Console.WriteLine("Ghiciti un numar intre 1 si 1024");

             static int GetGuess()
            {
                int guess = 0;
                try
                {
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Valoarea introdusa nu este valabila");
                    guess = GetGuess();
                }
                return guess;
            }

            while (true)
            {
                int guess = GetGuess();

                if (guess == x)
                {
                    Console.WriteLine("Ati ghicit, numarul este: " + x);
                    break;
                }
                else if (guess < x)
                {
                    Console.WriteLine("Mai incearca, valoarea introdusa este prea mic");
                }
                else if (guess > x)
                {
                    Console.WriteLine("Mai incearca, valoarea introdusa este prea mare");
                }

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
            //Problema12();
            //Problema13();
            //Problema14();
            //Problema15();
            //Problema16();
            //Problema17();
            //Problema18();
            //Problema19();
            //Problema20();
            Problema21();
        }
    }
}
