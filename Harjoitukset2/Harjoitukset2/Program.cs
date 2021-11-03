﻿using System;

namespace Harjoitukset2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Harjoitus 1 (PowerPoint esityksestä sivu 16)

            Console.WriteLine("Anna ensimmäinen numero: ");
            int luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen numero: ");
            int luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" x = " + (luku2 + 3));

            //Harjoitus 2
            Console.WriteLine("Anna ensimmäinen numero: ");
            int luku3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen numero: ");
            int luku4 = int.Parse(Console.ReadLine());
            Console.WriteLine(" x = " + (luku4 - 2));


            //Harjoitus 3
            Console.WriteLine("Anna ensimmäinen numero: ");
            int luku5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen numero: ");
            int luku6 = int.Parse(Console.ReadLine());
            Console.WriteLine(" x = " + (luku6 * 5));

            //Harjoitus 4
            Console.Write("Anna ensimmäinen luku: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen luku: ");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" x = " + (luku1 / luku2));

            //Harjoitus 5
            Console.WriteLine("Anna ensimmäinen numero: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen numero: ");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" x = " + (luku1 % luku2));

            // Harjoitus 6
            Console.WriteLine("Anna ensimmäinen numero: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen numero: ");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" x = " + (luku1 += luku2));

            // Harjoitus 7
            Console.WriteLine("Anna ensimmäinen numero: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen numero: ");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" x = " + (luku1 -= luku2));

            // Harjoitus 8
            Console.WriteLine("Anna ensimmäinen numero: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen numero: ");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" x = " + (luku1 *= luku2 * 5));

            //Harjoitus 9
            Console.WriteLine("Anna ensimmäinen numero: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen numero: ");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" x = " + (luku1 /= luku2));

            //PowerPoint esityksestä sivu 24
            // Tehtävä 1
            Console.WriteLine("Anna ensimmäinen numero: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen numero: ");
            luku2 = int.Parse(Console.ReadLine());
            if (luku1 > luku2)
            {
                Console.WriteLine((luku1, luku2));
            }
            else
            {
                Console.WriteLine((luku2, luku1));
            }

            //Tehtävä 2 
            Console.WriteLine("Anna ensimmäinen numero: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen numero: ");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna kolmas numero: ");
            luku3 = int.Parse(Console.ReadLine());
            if (luku1 < luku2 && luku3 < luku2)
            {
                Console.WriteLine("Suurin uvuista on: ", luku2);
            }
            else if (luku1 < luku3)
            {
                Console.WriteLine("Suurin luvuista on: ", luku3);
            }
            else
            {
                Console.WriteLine("Suurin luvuista on:", luku1);
            }

            //Tehtävä 3
            Console.Write("Anna numero väliltä 0-9: ");
            luku1 = int.Parse(Console.ReadLine());
            switch (luku1)
            {
                case 0:
                    Console.WriteLine("Nolla");
                    break;
                case 1:
                    Console.WriteLine("Yksi");
                    break;
                case 2:
                    Console.WriteLine("Kaksi");
                    break;
                case 3:
                    Console.WriteLine("Kolme");
                    break;
                case 4:
                    Console.WriteLine("Neljä");
                    break;
                case 5:
                    Console.WriteLine("Viisi");
                    break;
                case 6:
                    Console.WriteLine("Kuusi");
                    break;
                case 7:
                    Console.WriteLine("Seiska");
                    break;
                case 8:
                    Console.WriteLine("Kasi");
                    break;
                case 9:
                    Console.WriteLine("Ysi");
                    break;
                default:
                    Console.Write("Syöte virheellinen, anna numero 0-9 väliltä!");
                    break;
            }

            //Tehtävä 4
            Console.WriteLine("Anna ensimmäinen numero: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen numero: ");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna kolmas numero: ");
            luku3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna neljäs numero: ");
            luku4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna viides numero: ");
            luku5 = int.Parse(Console.ReadLine());
            if (luku1 < luku2 && luku3 < luku2 && luku4 < luku2 && luku5 < luku2)
            {
                Console.WriteLine("Suurin annetuista luvuista on: ", luku2);
            }
            else if (luku1 < luku3 && luku4 < luku3 && luku5 < luku3)
            {
                Console.WriteLine("Suurin annetuista luvuista on: ", luku3);
            }
            else if (luku1 < luku4 && luku5 < luku4)
            {
                Console.WriteLine("Suurin annetuista luvuista on: ", luku4);
            }
            else if (luku1 < luku5)
            {
                Console.WriteLine("Suurin annetuista luvuista on: ", luku5);
            }
            else
            {
                Console.WriteLine("Suurin annetuista luvuista on: ", luku1);
            }

            //Tehtävä 5
            // funktiolla
           /* static void syote()
            { 
            ALKU
            Console.Write("Millaisen tiedon haluat syöttää ( k= kokonaisluku, D 0 duobleluvun, m=merkkijonon?");
            char syote = char.Parse(Console.ReadLine().ToLower());
            switch (syote)
            {
                case 'k':
                    Console.Write("Ole hyvä ja syötä kokonaisluku:");
                    int luku = int.Parse(Console.ReadLine());
                    break;
                case 'd';





                default:
                    goto ALKU
            }

        }   
            
           // tehtävä 7
           //
           //tee kaikille ykkösille ja kymmenille ja sadoille oma funktio, joihin viittaat
            static void Luvut ()
            {
                string lause = "";
                Console.Write("Anna numero välillä 0-999: ");
                string nro = Console.ReadLine();
                 int maara = nro.Length;
                if (maara == 3)
                {
                    lause += Sadat (nro)
               }
            } 
           */

            //Tehtävät sivuilta 68-69

            //Tehtävä 1
            static int laskeYhteen(int eka, int toka)
            {
                return (eka + toka);
            }
            int luku1, luku2, summa;
            Console.Write("Anna ensimmäinen kokonaisluku: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen kokonaisluku: ");
            luku2 = int.Parse(Console.ReadLine());
            summa = laskeYhteen(luku1, luku2);
            Console.WriteLine(summa);

            //tehtävä 2
            static int CelToFah( int TCelsius);
            {
                return (TCelsius * 9 / 5) + 32;
            }
            static int fahToCel(TFahren);
            {
                return (TFahren - 32) / 1.8;
            }
            int luku1, luku2, celsius, fahrenheit;
            Console.Write("Anna muutettava luku: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen muutettava luku: ");
            luku2 = int.Parse(Console.ReadLine());
            fahrenheit = CelToFah(luku1);
            Console.WriteLine("fahrenheit astetta", fahrenheit);
            celsius = fahToCel(luku2);
            Console.WriteLine("celsiusta", celsius);



        }
    }
}




