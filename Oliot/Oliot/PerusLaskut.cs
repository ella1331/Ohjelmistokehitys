using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oliot
{
    class PerusLaskut
    {
        int summa;
        int erotus;
        int osamaara;
        int tulo;

        public int Summa(int a, int b)
        {
            return a + b;
        }
        public int Erotus(int a, int b)
        {
            return a - b;
        }
        public double Osamaara(int a, int b)
        {
            return a / (double)b;
        }
        public int Tulo( int a, int b)
        {
            return a * b;
        }
    }
}
