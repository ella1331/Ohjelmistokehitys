using System;

namespace Oliot
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             PerusLaskut joulupukki = new PerusLaskut();
             int x1 = joulupukki.Summa(4, 5);
             int x2 = joulupukki.Erotus(4, 5);
             double x3 = joulupukki.Osamaara(4, 5);
             int x4 = joulupukki.Tulo(4, 5);
             Console.WriteLine("Lukujen  {0} ja {1} summa, erotus, osamäärä ja tulo ovat {2}, {3}, {4}, {5}", 4, 5, x1, x2, x3, x4);

              */

            Pankkitili elina = new Pankkitili("Elina", "Luumi", "12345-6789", 1000.45);
            Console.WriteLine(elina.NaytaSaldo());
            elina.Pano(200);
            Console.WriteLine(elina.NaytaSaldo());
            elina.Otto(50.51);
            Console.WriteLine(elina.NaytaSaldo());
            elina.Otto(1300);


        }
    }
}
