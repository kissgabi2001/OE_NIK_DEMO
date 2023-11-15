using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlat_10_megoldas
{
    class Futo
    {
        public double Tav
        {
            get;
            private set;
        }

        private DateTime datum_ido;

        public Futo(double tav, int ev, int ho, int nap, int ora, int perc, int mp)
        {
            datum_ido = new DateTime(ev, ho, nap, ora, perc, mp);
            Tav = tav;
        }

        public string Datum()
        {
            return datum_ido.ToString("yyyy.mm.dd");
        }

        public string Ido()
        {
            return datum_ido.ToString("HH:mm:ss");
        }

    }
}
