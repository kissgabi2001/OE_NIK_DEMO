using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlat_10_megoldas
{
    class Szemely
    {
        static private Random r = new Random();

        public string Nev
        {
            get;
            private set;
        }

        public string Nem
        {
            get;
            private set;
        }

        public DateTime SzuletesiEv
        {
            get;
            private set;
        }

        public Szemely(string nev, string nem)
        {
            Nev = nev;
            Nem = nem;
            SzuletesiEv = SzuletesiEv.AddYears(r.Next(1940, 2001));
            SzuletesiEv = SzuletesiEv.AddMonths(r.Next(1, 13));
            SzuletesiEv = SzuletesiEv.AddDays(r.Next(1, 31));
        }

        public Szemely()
        {
            SzuletesiEv = new DateTime();
        }

    }
}
