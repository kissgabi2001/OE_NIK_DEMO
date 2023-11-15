using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlat_09_megoldas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hozzunk létre egy 20 elemű tömböt, amelyben Zh típusú elemek vannak.
            //Egy ilyen elemmel egy zh-eredményt reprezentálunk. --> void ZH_feladat()
            //Egy Zh-hoz egy 6 jegyű Neptun-kód és egy 0-100-ig terjedő pontszám tartozik.
            //Egy konstruktor segítségével véletlenszerű Neptun-kóddal és pontszámmal hozzuk létre a tömbben lévő példányokat.
            //1. Sorolja fel, kik mentek át a zh-n! --> string Atmentek(ZH[] zhk)
            //2.Írja ki a legjobb eredményű hallgató Neptun-kódját!
            //Ha több embernek is ez az eredménye, akkor mindegyikükét. --> LegjobbHallgato_neptunok(ZH[] zhk)
            //3. Listázza ki az eredményeket úgy, hogy a nevek mellett a jegyek szerepelnek!
            //A jegyeket a szokásos ponthatár alapján állapítsa meg. --> string Neptun_Jegy(ZH[] zhk)
            //0 - 49 = 1
            //50 - 59 = 2
            //60 - 79 = 3
            //80 - 89 = 4
            //90 - 100 = 5

            ZH_feladat();
        }

        #region 1. feladat
        static void ZH_feladat()
        {
            ZH[] zhk = new ZH[20];
            for (int i = 0; i < zhk.Length; i++)
            {
                zhk[i] = new ZH();
            }

            Console.WriteLine($"ZH-n atmentek: {Atmentek(zhk)}");
            Console.WriteLine($"Legeredmenyesebb hallgatok: {LegjobbHallgato_neptunok(zhk)}");
            Console.Write($"Neptun jegyek:\n{Neptun_Jegy(zhk)}");
        }

        static string Atmentek(ZH[] zhk)
        {
            string neptunok = "";
            for (int i = 0; i < zhk.Length; i++)
            {
                if (zhk[i].Pont >= 50)
                {
                    neptunok += zhk[i].Neptun + ", ";
                }
            }

            return neptunok;
        }

        static string LegjobbHallgato_neptunok(ZH[] zhk)
        {
            string neptunok = "";
            int maxpont = 0;
            for (int i = 0; i < zhk.Length; i++)
            {
                if (zhk[i].Pont > maxpont)
                {
                    maxpont = zhk[i].Pont;
                }
            }

            for (int i = 0; i < zhk.Length; i++)
            {
                if (zhk[i].Pont == maxpont)
                {
                    neptunok += zhk[i].Neptun + ", ";
                }
            }

            return neptunok;
        }

        static string Neptun_Jegy(ZH[] zhk)
        {
            string neptun_jegy = "";
            int[] konvert = new int[4];
            konvert[0] = 49;
            konvert[1] = 64;
            konvert[2] = 76;
            konvert[3] = 84;
            for (int i = 0; i < zhk.Length; i++)
            {
                if (zhk[i].Pont <= konvert[0])
                {
                    neptun_jegy += $"{zhk[i].Neptun} - 1";
                }
                else if (zhk[i].Pont > konvert[0] && zhk[i].Pont <= konvert[1])
                {
                    neptun_jegy += $"{zhk[i].Neptun} - 2";
                }
                else if (zhk[i].Pont > konvert[1] && zhk[i].Pont <= konvert[2])
                {
                    neptun_jegy += $"{zhk[i].Neptun} - 3";
                }
                else if (zhk[i].Pont > konvert[2] && zhk[i].Pont <= konvert[3])
                {
                    neptun_jegy += $"{zhk[i].Neptun} - 4";
                }
                else
                {
                    neptun_jegy += $"{zhk[i].Neptun} - 5";
                }

                neptun_jegy += "\n";
            }

            return neptun_jegy;
        }


        #endregion
    }
}
