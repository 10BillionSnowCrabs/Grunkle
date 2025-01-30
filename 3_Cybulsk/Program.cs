using System;
using System.Security.Cryptography;
using System.Text;

namespace _2_Cybulsk
{
    class Program
    {

        static void Main(string[] args)
        {





            /*
            // Zad 1
            Int32[] tab1 = new Int32[20];
            Random liczba = new Random();
            for (int i = 0; i < tab1.Length; i++)
            {
                tab1[i] = liczba.Next(0, 10);
                Console.WriteLine("numer indeksu = " + i + " wartość komórki tablicy = " + tab1[i]);
            }
            Console.ReadKey();
            */

            /*
            //Zad 2
            Int32[] tab1 = new Int32[10];
            int j = 9;
            for (int i = 0; i < tab1.Length || j == 0; i++)
            {
                tab1[i] = j;
                Console.WriteLine("numer indeksu = " + i + " wartość komórki tablicy = " + tab1[i]);
                j--;
            }
            Console.ReadKey();
            */


            /*
            //zad 3

            Int32[ , ] tab1 = new Int32[4, 3];
            for (int a = 0; a <= 3; a++)
            {
         
                for (int b = 0; b <= 2; b++)
                {
                    tab1 [a, b] = b;
                    Console.WriteLine(tab1[a, b]);
                };
            }; 
            zestaw funkcji b wykonuję się 3 razy (dla wartości 0, 1, 2) po czym zwiększa a o wartość 1 i ponownie wykonuje się 3 razy, ten proces powtarza się dopóki a nie osiągnie wartości 3.
            */


            /*
            // Zad 4

            Random liczba = new Random();
            Int32[ , ] tab1 = new Int32[4, 6];
            for (int a = 0; a <= 3; a++)
            {
                
                for (int b = 0; b <= 5; b++)
                {
                    tab1 [a, b] = liczba.Next(100,1000);
                    Console.Write(tab1[a, b] + " ");
                };
                Console.WriteLine();
            };
            */



            /*
            // Zad 5
            int suma = 0, liczbaMax = 0, MaxX = 0, MaxY = 0, liczbaMin = 1000, MinX = 0, MinY = 0;
            Random liczba = new Random();
            Int32[,] tab1 = new Int32[4, 6];
            for (int a = 0; a <= 3; a++)
            {

                for (int b = 0; b <= 5; b++)
                {
                    tab1[a, b] = liczba.Next(100, 1000);
                    Console.Write(tab1[a, b] + " ");
                    suma += tab1[a, b];
                    if (tab1[a, b] > liczbaMax) { liczbaMax = tab1[a, b]; MaxX = b; MaxY = a; }
                    if (tab1[a, b] < liczbaMin) { liczbaMin = tab1[a, b]; MinX = b; MinY = a; }
                };
                Console.WriteLine();
            };
            Console.WriteLine();
            Console.WriteLine("Macierz Transponowana: ");
            Console.WriteLine();
            Int32[,] tabT = new Int32[6, 4];
            for (int a = 0; a <= 5; a++)
            {

                for (int b = 0; b <= 3; b++)
                {
                    tabT[a, b] = tab1[b, a];
                    Console.Write(tabT[a, b] + " ");
                };
                Console.WriteLine();
            };
            Console.WriteLine();
            Console.WriteLine("Suma wartości tablicy to " + suma);
            Console.WriteLine("Największa wartość to " + liczbaMax + " i znajduje się w komórce z numerami indeksu " + MaxX + " " + MaxY);
            Console.WriteLine("Najmniejsza wartość to " + liczbaMin + " i znajduje się w komórce z numerami indeksu " + MinX + " " + MinY);

            Console.ReadKey();
            */


            /*
            // Zad 6
            int length = 0;
            Random liczba = new Random();
            Int32[,] tab1 = new Int32[10, 10];
            for (int a = 0; a <= 9; a++)
            {

                for (int b = 0; b <= 9; b++)
                {
                    tab1[a, b] = liczba.Next(0, 1000);
                    if (tab1[a, b] < 100) length = 3; else if (tab1[a, b] > 10) length = 2; else length = 1;
                    switch (length)
                    {
                        case 1: Console.Write(tab1[a, b] + " "); break;
                        case 2: Console.Write(tab1[a, b] + " " + " "); break;
                        case 3: Console.Write(tab1[a, b] + " " + " " + " "); break;
                        default: Console.Write("ERR" + " "); break;
                    }
                };
                Console.WriteLine();
            };
             */


            /* 
           // ZAD 6
           int length = 0;
           Random liczba = new Random();
           Int32[,] tab1 = new Int32[10, 10];
           for (int a = 0; a <= 9; a++)
           {

               for (int b = 0; b <= 9; b++)
               {
                   tab1[a, b] = liczba.Next(0, 1000);
                   if (tab1[a, b] < 100) length = 3; else if (tab1[a, b] > 10) length = 2; else length = 1;
                   switch (length)
                   {
                       case 1: Console.Write(tab1[a, b] + " "); break;
                       case 2: Console.Write(tab1[a, b] + " " + " "); break;
                       case 3: Console.Write(tab1[a, b] + " " + " " + " "); break;
                       default: Console.Write("ERR" + " "); break;
                   }
               };
               Console.WriteLine();
           };
           */
        }
    }
}
