using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlat_08_megoldas
{
    internal class Negyzet
    {
        private static Random r = new Random();

        private int x;

        private int y;

        private int szelesseg;

        public Negyzet()
        {
            x = r.Next(0, 50);
            y = r.Next(0, 50);
            szelesseg = r.Next(4, 11);
        }

        public void Rajzol()
        {
            for (int i = 0; i < szelesseg; i++)
            {
                Console.SetCursorPosition(x, y + i);
                for (int j = 0; j < szelesseg; j++)
                {
                    if (i == 0 || i == szelesseg - 1)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        if (j == 0 || j == szelesseg - 1)
                        {
                            Console.SetCursorPosition(x + j, y + i);
                            Console.Write("#");
                        }
                    }
                }

                Console.Write("\n");
            }
        }

    }
}
