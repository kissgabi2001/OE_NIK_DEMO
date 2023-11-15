using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlat_09_megoldas
{
    class ZH
    {
        static private Random r = new Random();

        private string neptun;

        private int pont;

        public int Pont
        {
            get { return pont; }
        }

        public string Neptun
        {
            get { return neptun; }
        }

        public ZH()
        {
            pont = r.Next(0, 101);
            Neptun_generetor();
        }

        private void Neptun_generetor()
        {
            int szam_betu;
            for (int i = 0; i < 6; i++)
            {
                szam_betu = r.Next(0, 2);
                if (szam_betu == 0)//szamot general
                {
                    neptun += r.Next(0, 10);
                }
                else
                {
                    neptun += (char)r.Next('A', 'Z');
                }
            }
        }

    }
}
