using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak_09
{
    internal class ZH
    {

        //propfull
        private int pont;

        public int Pont
        {
            get { return pont; }
            set { pont = value; }
        }

        private string neptun;

        public string Neptun
        {
            get { return neptun; }
            set { neptun = value; }
        }

        Random r = new Random();

        //ctor
        public ZH()
        {
            pont = r.Next(0,101);
            
        }

    }
}
