using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlat_05_megoldas
{
    internal class Program
    {
        static string[] csapatok = { "Mercedes", "Red Bull Racing", "Ferrari", "McLaren", "Aston Martin", "Alpine" };
        static int[,] eredmenyek = new int[6, 6];

        static void Main(string[] args)
        {
            #region 1. feladat

            //1.Állítsunk elő egy tíz elemű tömböt, melynek minden eleme 1 és 20 közötti véletlen egész szám.
            //2. Megjeleníti a tömb elemeit.
            //3. Minimumkiválasztásos rendezéssel rendezi a tömb elemeit.

            Random r = new Random();

            int[] rend = new int[10];
            for (int i = 0; i < rend.Length; i++)
            {
                rend[i] = r.Next(1, 21);
            }

            Min_rendezes(ref rend);
            for (int i = 0; i < rend.Length; i++)
            {
                Console.Write($"{rend[i]}, ");
            }

            Console.WriteLine();

            #endregion

            #region 2. feladat

            //Készítsen programot, amely egy Forma 1-es Grand Prix ponttábláját kezeli.
            //A GP-n 6 csapat vesz részt. A csapatok neveit a csapatok tömbben tároljuk, ezek előre adottak a programban.
            //A verseny ponttáblája az eredmenyek tömbben van.
            //Az eredmenyek[i,j] értéke 0, ha az i-edik csapat otthon kikapott a j-edik csapattól, 1, ha a két csapat az i-edik csapat otthonában döntetlent játszott, és 2, ha az i-edik csapat otthon legyőzte a j-edik csapatot.
            //a) Írjon metódust, amely az eredmenyek tömb elemeit feltölti véletlen értékekkel.Természetesen eredmenyek[i, i] minden esetben 0 lesz.
            //b) Írjon metódust, amely segítségével megjeleníthetők az eredmények.
            //c) Írjon metódust, amely meghatározza, hogy egy adott csapat összesen hány pontot ért el a bajnokságban. (Ez az adott csapat eredmenyek tömbbeli sorának és oszlopának összegeként adható meg.)
            //d) Írjon metódust, amely segítségével egy új tömbben előállítható a bajnokság minden egyes csapatára, hogy összesen hány pontot szereztek.
            //e) Írjon metódust, amely megadja, hogy melyik csapat nyerte a bajnokságot.    

            FeltoltEredmenyek();
            KiirEredmenyek();

            Console.WriteLine("\nA Forma 1 bajnokságot nyerte: " + BajnoksagNyertese());

            Console.ReadLine();

            #endregion
        }

        #region 1. feladat
        static void Min_rendezes(ref int[] t)
        {
            int min = 0;
            for (int i = 0; i < t.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < t.Length; j++)
                {
                    if (t[min] > t[j])
                    {
                        min = j;
                    }
                }

                Csere(ref t[i], ref t[min]);
            }
        }

        static void Csere(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        #endregion

        #region 2. feladat

        static void FeltoltEredmenyek()
        {
            Random rand = new Random();

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (i == j)
                    {
                        eredmenyek[i, j] = 0;
                    }
                    else
                    {
                        eredmenyek[i, j] = rand.Next(3); // 0, 1 vagy 2
                    }
                }
            }
        }

        static void KiirEredmenyek()
        {
            Console.WriteLine("Forma 1 bajnokság eredmények:");
            for (int i = 0; i < 6; i++)
            {
                Console.Write(csapatok[i] + ": ");
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(eredmenyek[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static int CsapatPontok(int csapatIndex)
        {
            int pontok = 0;
            for (int i = 0; i < 6; i++)
            {
                pontok += eredmenyek[csapatIndex, i];
            }
            return pontok;
        }

        static int[] OsszesCsapatPontjai()
        {
            int[] pontok = new int[6];
            for (int i = 0; i < 6; i++)
            {
                pontok[i] = CsapatPontok(i);
            }
            return pontok;
        }

        static string BajnoksagNyertese()
        {
            int[] pontok = OsszesCsapatPontjai();
            int maxPont = pontok[0];
            int nyertesIndex = 0;

            for (int i = 1; i < 6; i++)
            {
                if (pontok[i] > maxPont)
                {
                    maxPont = pontok[i];
                    nyertesIndex = i;
                }
            }

            return csapatok[nyertesIndex];
        }

        #endregion

    }
}
