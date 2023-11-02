using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlat_08_megoldas
{
    class Auto
    {
        #region 1. feladat
        // Az autó tulajdonságai
        public string Marka { get; set; }
        public string Modell { get; set; }
        public int Evjarat { get; set; }

        // Konstruktor az autó létrehozásához
        //Példány létrehozásakor meghívjuk

        public Auto(string marka, string modell, int evjarat)
        {
            Marka = marka;
            Modell = modell;
            Evjarat = evjarat;
        }

        // Metódus az autó adatainak kiírásához
        public void KiirAutoAdatai()
        {
            Console.WriteLine($"Marka: {Marka}, Modell: {Modell}, Évjárat: {Evjarat}");
        }
        #endregion
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. feladat

            // Autók létrehozása az osztály segítségével
            Auto auto1 = new Auto("Toyota", "Camry", 2020);
            Auto auto2 = new Auto("Ford", "Focus", 2019);

            // Autók adatainak kiírása
            Console.WriteLine("Auto 1 adatai:");
            auto1.KiirAutoAdatai();

            Console.WriteLine("\nAuto 2 adatai:");
            auto2.KiirAutoAdatai();

            #endregion

            #region 2. feladat

            //1. A Négyzet rendelkezzen az alábbi adattagokkal: x, y, szelesseg, magassag
            //2.Mind a négy adattag véletlenszámként jöjjön létre a konstruktorban!
            //3.Legyen a Négyzetnek egy Rajzol() metódusa, amely képes a konzol megfelelő pozíciójában a megadott szélességgel és magassággal kirajzolni # karakterekből a négyzetet!
            //4.Hozzon létre a Main - ben egy 10 elemű Négyzet tömböt!
            //5.Példányosítson a megfelelő tömbindexekre 1 - 1 Négyzetet és hívja meg a Rajzol() metódust minden példányon!


            Negyzet[] n = new Negyzet[10];
            for (int i = 0; i < n.Length; i++)
            {
                n[i] = new Negyzet();
                n[i].Rajzol();
            }

            #endregion

            #region 3. feladat

            //1.Készítsen Kör osztályt, amely egy kört a középpontja koordinátáival és a sugárral reprezentál! Az osztályban legyen metódus, ami megállapítja, hogy egy adott pont benne van-e a körben vagy sem.
            //2.Készítsen példányt a tesztelésre: kérje be a felhasználótól egy kör adatait, majd kérjen be pontokat, és mondja meg, ezek benne vannak-e a körben vagy sem.
            //3.Készítsen a Körhöz egy új konstruktort, amely megadott sugárral, de véletlenszerű középponttal hozza létre a példányt.
            //4.Egészítse ki a Kör osztályt egy metódussal, amely megállapítja, hogy egy adott pont a kör középpontjától pontosan mekkora távolságra van.
            //5.Módosítsa a Kör osztályt Céltábla osztállyá úgy, hogy legyen benne metódus, amely egy adott pontnak a középponttól való távolsága szerint különböző pontszámokat ad!-Ezután készítsen céllövő játékot:
            //hozzon létre egy véletlenszerű középpontú céltáblát, majd kérjen be a felhasználótól 15 lövést(pontot), és számolja, hány pontnyi találata van a felhasználónak a 15 lövés után. Minden lövés után segítségül közölje, mekkora volt a lövés távolsága a céltáblától.

            Jatek();

            #endregion
        }

        static void Jatek()
        {
            CelTabla c = new CelTabla(12);
            int x = 0;
            int y = 0;
            int talalat = 0;
            for (int i = 0; i < 15; i++)
            {
                Console.Write($"{i + 1}. loves(x): ");
                x = int.Parse(Console.ReadLine());
                Console.Write($"{i + 1}. loves(y): ");
                y = int.Parse(Console.ReadLine());
                talalat += c.Pont(x, y);
                Console.WriteLine($"Loves tavolsaga a celtablatol: {c.Tavolsag(x, y)}");
            }

            Console.WriteLine($"Pontod: {talalat}");
        }


    }
}
