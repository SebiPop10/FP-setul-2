using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FP_seria_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //setul 2
            //P1();
            //P2();
            //P3();
            //P4();
            //P5();
            //P6();
            // P7();
            // P8();
            //P9();
            //P10();
            //P11();
            //P12();
            //P13();
            //P15();
            //P16();
            //P17();
        }
        private static void P1()
        {
            int n, ok = 0, x, i;
            Console.WriteLine("Dati secventa: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                x = Convert.ToInt32(Console.Read());
                if (x % 2 == 0)
                    ok++;
                x = Convert.ToInt32(Console.Read());
            }
            if (ok == 0)
                Console.WriteLine("Nu exista numere pare");
            else
                Console.WriteLine(ok);
        }
        private static void P2()
        {
            int n, numara1 = 0, numara2 = 0, numara3 = 0, i, x;
            Console.WriteLine("Dati secventa: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x < 0)
                    numara1++;
                else
                   if (x == 0)
                    numara2++;
                else
                    numara3++;
            }
            if (numara1 == 0)
                Console.WriteLine("Nu exista nr negative");
            else
                Console.WriteLine("Sunt " + numara1 + " nr negative");
            if (numara2 == 0)
                Console.WriteLine("Nu exista nr egale cu 0");
            else
                Console.WriteLine("Sunt " + numara2 + " nr egale cu 0");
            if (numara3 == 0)
                Console.WriteLine("Nu exista nr pozitive");
            else
                Console.WriteLine("Sunt " + numara3 + " nr pozitive");
        }
        private static void P3()
        {
            //suma
            int n, S = 0, i, P = 1;
            Console.WriteLine("Dati n: ");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                S = S + i;
            }
            Console.WriteLine($"Suma nr este: {S}");
            //produsul
            for (i = 1; i <= n; i++)
            {
                P = P * i;
            }
            Console.WriteLine($"Produsul nr este: {P}");
        }
        private static void P4()
        {
            int n, x, poz = 0, a, i, aux = 0;
            Console.WriteLine("Dati a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati secventa: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x != a)
                    poz++;
                else
                    aux = poz;
            }
            if (aux == 0)
                Console.WriteLine("-1");
            else
                Console.WriteLine($"Numarul se afla pe pozitia: {aux}");
        }
        private static void P5()
        {
            int n, i, x, nr = 0, poz = 0;
            Console.WriteLine("Dati secventa: ");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x == poz)
                    nr++;
                poz++;
            }
            if (nr == 0)
                Console.WriteLine("Nu exista nr egale cu pozitia lor");
            else
                Console.WriteLine($"Exista {nr} numere egale cu pozitia lor");
        }
        private static void P6()
        {
            int i, n, x, y;
            bool ok = true;
            Console.WriteLine("Dati secventa: ");
            n = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            for (i = 1; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x < y)
                {
                    ok = false;
                    //break;
                }
                y = x;
            }
            if (ok)
                Console.WriteLine("Nr sunt in ordine cresc");
            else
                Console.WriteLine("Nr nu sunt in ordine cresc");
        }
        private static void P7()
        {
            int n, i, x, max1 = 0, min1 = 10000000;
            Console.WriteLine("Dati secventa: ");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x > max1)
                    max1 = x;
                if (x < min1)
                    min1 = x;
            }
            Console.WriteLine($"Nr cel mai mare este: {max1}. Nr cel mai mic este: {min1}");
        }
        private static void P8()
        {
            int a = 1, b = 1, c = 0, n, i;
            Console.WriteLine("Dati n: ");
            n = int.Parse(Console.ReadLine());
            //if (n > 45)
            // throw new Exception();
            for (i = 3; i <= n; i++)
            {
                c = a + b;
                a = b; b = c;
            }
            Console.WriteLine($"Al {n}-lea nr din sirul Fibonacci este: {c}");
        }
        private static void P9()
        {
            int n, i, x, y;
            int ok1 = 0, ok2 = 0;
            Console.WriteLine("Dati secventa: ");
            n = int.Parse(Console.ReadLine());
            x = int.Parse(Console.ReadLine()); //prev element
            for (i = 1; i < n; i++)
            {
                y = int.Parse(Console.ReadLine()); //current elem
                if (x <= y)
                    ok1++;
                if (x >= y)
                    ok2++;
                x = y;
            }
            if (ok1 == n - 1 || ok2 == n - 1)
                Console.WriteLine("Secv e monotona");
            else
                Console.WriteLine("Secv nu e monotona");
        }
        private static void P10()
        {
            int n, i, x, nrmax = 1, y;
            Console.WriteLine("Dati n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati secventa: ");
            x = int.Parse(Console.ReadLine());
            for (i = 1; i < n; i++)
            {
                y = int.Parse(Console.ReadLine());
                if (x == y)
                    nrmax++;
                x = y;
            }
            if (nrmax == 1)
                Console.WriteLine("Nu exista nr consecutive egale in secvventa");
            else
                Console.WriteLine($"Nr max de nr consecutive egale este: {nrmax}");
        }
        private static void P11()
        {
            int n, i, x, cif, invers;
            long suma = 0;
            Console.WriteLine("Dati secventa: ");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                x = int.Parse(Console.ReadLine());
                invers = 0;
                while (x != 0)
                {
                    cif = x % 10;
                    invers = invers * 10 + cif;
                    x = x / 10;
                }
                suma = suma + invers;
            }
            Console.WriteLine($"Suma este: {suma}");
        }
        private static void P12()
        {
            Console.WriteLine("Introduceti secventa de numere separate prin spatiu:");
            string input = Console.ReadLine();

            int wordCount = 0;
            bool inWord = false;

            
            foreach (char c in input)
            {
                
                if (c != '0')
                {
                    if (!inWord)
                    {
                       
                        inWord = true;
                        wordCount++;
                    }
                }
                else
                {
                    inWord = false;
                }
            }

            Console.WriteLine($"Numarul de grupuri de numere consecutive diferite de zero este: {wordCount}");
        }
        private static void P13()
        {
            //int n, i, x;
            //Console.WriteLine("Dati secventa: ");
            //n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti secventa de numere separate prin spatiu:");
            string input = Console.ReadLine();


            string[] tokens = input.Split(' ');

            int n = tokens.Length;

            bool ok = false;


            for (int i = 0; i < n; i++)
            {

                int x = int.Parse(tokens[i]);
                int nextIndex = (i + 1) % n;
                int y = int.Parse(tokens[nextIndex]);

                if (x > y)
                {
                    ok = true;
                    break;
                }
            }

            if (ok)
            {
                Console.WriteLine("Secventa este o secventa crescatoare rotita.");
            }
            else
            {
                Console.WriteLine("Secventa nu este o secventa crescatoare rotita.");
            }
        }
        private static void P15()
        {
            int n, i, j, x, y, ok1 = 0, ok2 = 0;
            Console.WriteLine("Dati secventa: ");
            n = int.Parse(Console.ReadLine());
            x = int.Parse(Console.ReadLine());
            for (i = 1; i < n / 2; i++)
            {
                y = int.Parse(Console.ReadLine());
                if (x <= y)
                    ok1++;
                x = y;
            }
            for (j = n / 2; j < n; j++)
            {
                y = int.Parse(Console.ReadLine());
                if (x >= y)
                    ok2++;
                x = y;
            }
            if (ok1 == (n / 2 - 1) && ok2 == (n / 2 - 1))
                Console.WriteLine("Secv e bitonica");
            else
                Console.WriteLine("Secv nu e bitonica");

        }
        private static void P16()
        {
            Console.WriteLine("Introduceti secventa de numere separate prin spatiu:");
            string input = Console.ReadLine();

            
            string[] tokens = input.Split(' ');

            int n = tokens.Length;

            bool isBitonicRotated = false;

            
            for (int i = 0; i < n; i++)
            {
                
                int currentNumber = int.Parse(tokens[i]);

                
                int nextIndex = (i + 1) % n;
                int nextNumber = int.Parse(tokens[nextIndex]);

                if (currentNumber > nextNumber)
                {
                    
                    isBitonicRotated = true;
                    for (int j = nextIndex + 1; j < n; j++)
                    {
                        int currentRotated = int.Parse(tokens[j]);
                        int nextRotatedIndex = (j + 1) % n;
                        int nextRotated = int.Parse(tokens[nextRotatedIndex]);

                        if (currentRotated > nextRotated)
                        {
                            isBitonicRotated = false;
                            break;
                        }
                    }

                    break;
                }
            }

            if (isBitonicRotated)
            {
                Console.WriteLine("Secventa este o secventa bitonica rotita.");
            }
            else
            {
                Console.WriteLine("Secventa nu este o secventa bitonica rotita.");
            }
        }

        private static void P17()
        {
            Console.WriteLine("Introduceti secventa de 0 si 1 separate prin spatiu:");
            string input = Console.ReadLine();
            int nivelcurent = 0, nivelmax = 0;
            foreach (char c in input)
            {
                if (c == '0')
                {
                    nivelcurent++;
                    if (nivelcurent > nivelmax)
                        nivelmax = nivelcurent;
                }
                else if (c == '1')
                {
                    if (nivelcurent == 0)
                    {
                        Console.WriteLine("Secventa este incorecta.");
                        return;
                    }
                    nivelcurent--;
                }
            }

            if (nivelcurent == 0)
            {
                Console.WriteLine($"Secventa este corecta, iar nivelul maxim de incuibare este: {nivelmax}");
            }
            else
            {
                Console.WriteLine("Secventa este incorecta.");
            }
        }
    }     
    
}
