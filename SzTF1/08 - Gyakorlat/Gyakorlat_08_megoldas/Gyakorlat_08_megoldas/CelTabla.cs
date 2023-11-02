using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlat_08_megoldas
{
    internal class CelTabla
    {
        private static Random ra = new Random();

        private int x;

        private int y;

        private int r;

        public CelTabla(int x, int y, int r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
        }

        public CelTabla(int r)
        {
            this.r = r;
            x = ra.Next(3, 11);
            y = ra.Next(3, 11);
        }

        public bool Bennevan_E(int x, int y)
        {
            return Tavolsag(x, y) <= r;
        }

        public double Tavolsag(int x, int y)
        {
            return Math.Sqrt(Math.Pow(x - this.x, 2) + Math.Pow(y - this.y, 2));
        }

        public int Pont(int x, int y)
        {
            double tav = Tavolsag(x, y);
            if (tav == 0)
            {
                return 10;
            }
            else if (tav > 0 && tav < r)
            {
                return 5;
            }
            else if (tav == r)
            {
                return 2;
            }

            return 0;
        }

    }
}
