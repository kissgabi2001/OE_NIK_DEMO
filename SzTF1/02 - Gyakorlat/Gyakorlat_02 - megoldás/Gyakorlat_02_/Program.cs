using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlat_02_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1 feladat

            //Kérj be a konzolról egy nevet és nézd meg, hogy a hallgató neve Béla-e

            Console.Write("Kérem, adja meg a hallgató nevét: ");
            string nev = Console.ReadLine();

            string bela = "Béla";

            if (nev == bela)
            {
                Console.WriteLine("SZIA");
            }
            else
            {
                Console.WriteLine("HELLO");
            }

            Console.WriteLine("\n");

            #endregion
            
            
            #region 2 feladat

            //Vizsgáljuk meg, hogy a konzolról bekért szám pozitív, negatív, vagy nulla

            Console.Write("Kérem, adjon meg egy egész számot: ");
            int szam2 = int.Parse(Console.ReadLine());

            if (szam2 > 0)
            {
                Console.WriteLine("A megadott szám pozitív.");
            }
            else if (szam2 < 0)
            {
                Console.WriteLine("A megadott szám negatív.");
            }
            else
            {
                Console.WriteLine("A megadott szám nulla.");
            }

            Console.WriteLine("\n");

            #endregion
            

            #region 3 feladat

            //Írj egy programot, amely segít egy személynek pénzügyi döntéseket hozni.
            //Ha a bankszámla egyenlege nagyobb vagy egyenlő 100 000 egységgel, és a havi jövedelem legalább 5000 egység, akkor a program ajánlja a befektetés lehetőségét.
            //Ha a bankszámla egyenlege kevesebb mint 100 000 egység, de a havi jövedelem legalább 3000 egység, akkor a program ajánlja a megtakarítási lehetőséget.
            //Ha egyik feltétel sem teljesül, a program azt javasolja, hogy a felhasználó folytassa a jelenlegi pénzügyi helyzetének felülvizsgálatát és tervezését.

            Console.Write("Kérem, adja meg a bankszámla egyenlegét: ");
            int egyenleg = int.Parse(Console.ReadLine());

            Console.Write("Kérem, adja meg a havi jövedelmét: ");
            int jovedelem = int.Parse(Console.ReadLine());

            if (egyenleg >= 0 && jovedelem >= 0)
            {
                if (egyenleg >= 100000 && jovedelem >= 5000)
                {
                    Console.WriteLine("Ajánlat: Fontolja meg a befektetési lehetőségeket!");
                }
                else if (egyenleg < 100000 && jovedelem >= 3000)
                {
                    Console.WriteLine("Ajánlat: Gondolkodjon a megtakarítási lehetőségeken!");
                }
                else
                {
                    Console.WriteLine("Ajánlat: Folytassa a pénzügyi tervezést!");
                }
            }
            else
            {
                Console.WriteLine("Hibás bemenet! A bankszámla egyenlege és a havi jövedelem nem lehet negatív.");
            }

            Console.WriteLine("\n");

            #endregion
            
            
            #region 4 feladat
            //Elöltesztelő ciklus
            //Készítsen programot, amely képernyőre írja az első 100 pozitív egész számot, de kihagyja közülük az öttel oszthatókat

            int szamA = 1;
            int szamlalo = 0;

            while (szamlalo < 100)
            {
                if (szamA % 5 != 0)
                {
                    Console.Write("\t" + szamA);
                    szamlalo++;
                }

                szamA++;
            }

            Console.WriteLine("\n");

            #endregion
            
            
            #region 5 feladat

            //Példa a hátultesztelő ciklusra
            //Írj egy programot, amely lehetővé teszi számok megadását, de csak pozitív számokat fogad el

            int szam4;

            do
            {
                Console.Write("Kérem, adjon meg egy nem negatív egész számot: ");
                szam4 = int.Parse(Console.ReadLine());

                if (szam4 < 0)
                {
                    Console.WriteLine("Hibás bemenet! A szám nem lehet negatív.");
                }
            } while (szam4 < 0);

            Console.WriteLine($"Megadott szám: {szam4}");

            Console.WriteLine("\n");

            #endregion
            

            //---------------------------------
            //          PLUSZ FELADATOK
            //---------------------------------

            #region 1 feladat

            //Készíts egy egyszerű számológép programot. A programnak képesnek kell lennie az alábbi műveletek végrehajtására: összeadás, kivonás, szorzás és osztás.

            Console.Write("Kérem, adjon meg egy számot: ");
            double szam5 = double.Parse(Console.ReadLine());

            Console.Write("Kérem, adjon meg egy másik számot: ");
            double szam6 = double.Parse(Console.ReadLine());

            Console.Write("Válassza ki a műveletet (+, -, *, /): ");
            string muveletKezdo = Console.ReadLine();

            char muvelet = Convert.ToChar(muveletKezdo);

            double eredmeny = 0;

            if (muvelet == '+')
            {
                eredmeny = szam5 + szam6;
            }
            else if (muvelet == '-')
            {
                eredmeny = szam5 - szam6;
            }
            else if (muvelet == '*')
            {
                eredmeny = szam5 * szam6;
            }
            else if (muvelet == '/')
            {
                if (szam6 != 0)
                {
                    eredmeny = szam5 / szam6;
                }
                else
                {
                    Console.WriteLine("Hiba: Nullával nem lehet osztani!");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Hiba: Nem ismert művelet!");
                return;
            }

            Console.WriteLine($"Eredmény: {eredmeny}");

            #endregion

        }
    }
}
