using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlat_04_megoldas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1. feladat
            //Egy két dimenziós tömbben tároljuk el  5 hét napjait az i.-ik sor j.-ik oszlopa jelentse az i. hét j. napján hány km-t futottunk,
            //random számokkal töltsük fel a tömböt, majd határozzuk meg adot héten átlag hány km-t futottunk

            int[,] futas_tomb = new int[5, 5];
            int[] szamlalo_futo = new int[5];
            int[] nevezo_futo = new int[5];
            Random r = new Random();

            for (int i = 0; i < futas_tomb.GetLength(0); i++)
            {
                for (int j = 0; j < futas_tomb.GetLength(1); j++)
                {
                    futas_tomb[i, j] = r.Next(3, 16);
                    szamlalo_futo[j] += futas_tomb[i, j];
                    nevezo_futo[j]++;
                }
            }

            double[] atlagok = new double[5];
            for (int i = 0; i < szamlalo_futo.Length; i++)
            {
                atlagok[i] = (double)szamlalo_futo[i] / nevezo_futo[i];
                Console.WriteLine($"Az {i}. het atlaga: {atlagok[i]}");
            }

            #endregion

            #region 2. feladat
            //Készíts programot, amely bemutatja a metódusok használatát!
            //A programnak tartalmaznia kell két különböző metódust és egy Main metódust a futtatáshoz.
            //Hozz létre egy Osszeadas nevű metódust, amely két egész számot kap bemenetként, összeadja őket, majd visszaadja az összeget.
            //Hozz létre egy Koszontes nevű metódust, amely egy szöveget kap bemenetként(pl.egy nevet),
            //és köszöntést jelenít meg a képernyőn, beleértve a megadott nevet.

            // Metódus meghivása
            int eredmeny = Osszeadas(5, 3);
            Console.WriteLine($"Az összeg: {eredmeny}");

            string nev = "John";
            // Metódus meghivása
            Koszontes(nev);
            #endregion

            #region 3. feladat
            //Valósítsa meg a következő metódusokat:
            //1. int[] GenerateArray(int db) – Előállít egy db elemű tömböt, melynek elemeit feltölti 0 és 1000 közötti véletlen egész számokkal.
            //2. string OutArray(int[] t) – A t tömb elemeit formázottan(egy sorba, vesszővel elválasztva) elhelyezi a kimeneti string-be(segédmetódus a tömb megjelenítéséhez).
            //3. bool IsPrime(int num) – Megadja, hogy a bemeneti num változó prím-e.
            //4. int NumOfPrimes(int[] t) – Meghatározza, hogy a t tömbben hány darab prímszám van.
            //5. int GetMin(int[] t) – Meghatározza a t legkisebb elemének indexét.
            //6. int NumOdds(int[] t) – Meghatározza, hogy a t tömbben hány darab páratlan szám van.

            int[] array = GenerateArray(10); // 10 elemű tömb véletlen számokkal
            Console.WriteLine("Generált tömb: " + OutArray(array));

            int numOfPrimes = NumOfPrimes(array);
            Console.WriteLine("Prímszámok száma: " + numOfPrimes);

            IsPrime(21);

            int minIndex = GetMin(array);
            Console.WriteLine("A legkisebb elem indexe: " + minIndex);

            int numOfOdds = NumOdds(array);
            Console.WriteLine("Páratlan számok száma: " + numOfOdds);


            #endregion

            #region 4.feladat

            //Adjunk meg két változót, majd cimzés szerinti értékadással cseréljük ki az eredetileg megadott értékeit

            int num1 = 5;
            int num2 = 10;

            Console.WriteLine($"Eredeti értékek: num1 = {num1}, num2 = {num2}");

            // Címszerinti paraméterátadás a Swap metódussal
            Swap(ref num1, ref num2);

            Console.WriteLine($"Csere után: num1 = {num1}, num2 = {num2}");

            //FYI: Alapértelmezés szerint a C# érték szerinti paraméterátadást használ, ami azt jelenti,
            //hogy egy metódus másolatot kap a bemeneti változóról, és az eredeti változót nem módosítja.
            //A ref kulcsszó használatával azonban a metódus a változó memóriacímét kapja meg,
            //így képes közvetlenül módosítani az eredeti változót.

            #endregion

        }

        #region 2. feladat
        //zárójelben paraméterek
        static int Osszeadas(int szam1, int szam2)
        {
            int osszeg = szam1 + szam2;
            return osszeg;
        }


        static void Koszontes(string nev)
        {
            Console.WriteLine($"Hello, {nev}!");
        }

        #endregion

        #region 3. feladat

        static int[] GenerateArray(int db)
        {
            int[] array = new int[db];
            Random random = new Random();

            for (int i = 0; i < db; i++)
            {
                array[i] = random.Next(0, 1001); // Véletlen számok 0 és 1000 között
            }

            return array;
        }

        static string OutArray(int[] t)
        {
            return string.Join(", ", t);
        }

        static bool IsPrime(int num)
        {
            if (num <= 1)
                return false;

            if (num == 2)
                return true;

            if (num % 2 == 0)
                return false;

            int sqrt = (int)Math.Sqrt(num);
            for (int i = 3; i <= sqrt; i += 2)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }

        static int NumOfPrimes(int[] t)
        {
            int hany_prim = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (IsPrime(t[i]))
                {
                    hany_prim++;
                }
            }

            return hany_prim;

        }

        static int GetMin(int[] t)
        {
            int min = t[0];
            int minIndex = 0;
            for (int i = 1; i < t.Length; i++)
            {
                if (t[i] < min)
                {
                    min = t[i];
                    minIndex = i;
                }
            }
            return minIndex;
        }

        static int NumOdds(int[] t)
        {
            int paratlan = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] % 2 != 0)
                {
                    paratlan++;
                }
            }

            return paratlan;

        }

        #endregion

        #region 4. feladat

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        #endregion


    }
}
