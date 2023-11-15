using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlat_10_megoldas
{
    class CsevegoProgram
    {
        private Szemely[] szemelyek;

        public CsevegoProgram()
        {
            Inicializalas();
        }

        private void Inicializalas()
        {
            szemelyek = new Szemely[5];
            szemelyek[0] = new Szemely("Kiss Gabi", "F");
            szemelyek[1] = new Szemely("Kulcsár Adri", "N");
            szemelyek[2] = new Szemely("Megyeri Ádám", "F");
            szemelyek[3] = new Szemely("Nagy Pisti", "F");
            szemelyek[4] = new Szemely("Rácz Ivett", "N");
        }

        public void Feladatok()
        {
            Console.WriteLine("Add meg az adatokat");
            Console.Write("Nev: ");
            string nev = Console.ReadLine();
            Console.Write("Nem(F,N): ");
            string nem = Console.ReadLine();
            Szemely felhasznalo = new Szemely(nev, nem);
            Ugyanaz_a_nev(felhasznalo);
            Ellenkezo_Nem(felhasznalo);
            Azonos_korosztaly(felhasznalo);
        }

        private void Azonos_korosztaly(Szemely felhasznalo)
        {
            int hany = 0;
            for (int i = 0; i < szemelyek.Length; i++)
            {
                if (Math.Abs(szemelyek[i].SzuletesiEv.Year - felhasznalo.SzuletesiEv.Year) <= 5)
                {
                    hany++;
                }
            }

            StreamWriter sw = new StreamWriter("Egykorosztaly.txt");
            sw.Write(hany);
            sw.Close();
            Console.WriteLine($"Felhasznaloval egy korosztalyuak szama: {hany}");
        }

        private void Ellenkezo_Nem(Szemely felhasznalo)
        {
            string ellenkezo = "";
            for (int i = 0; i < szemelyek.Length; i++)
            {
                if (felhasznalo.Nem != szemelyek[i].Nem)
                {
                    ellenkezo += $"{szemelyek[i].Nev}, ";
                }
            }

            StreamWriter sw = new StreamWriter("Ellenkezonem.txt");
            sw.Write(ellenkezo);
            sw.Close();
            Console.WriteLine($"Ellenkezo Nemuek: {ellenkezo}");
        }

        private void Ugyanaz_a_nev(Szemely felhasznalo)
        {
            string[] fnev = felhasznalo.Nev.Split(' ');
            string ugyanaz = "";
            for (int i = 0; i < szemelyek.Length; i++)
            {
                string[] splitelt = szemelyek[i].Nev.Split(' ');
                if (splitelt[0] == fnev[0] || splitelt[1] == fnev[1])
                {
                    ugyanaz += $"{szemelyek[i].Nev}, ";
                }
            }

            StreamWriter sw = new StreamWriter("Ugyanazanev.txt");
            sw.Write(ugyanaz);
            sw.Close();
            Console.WriteLine($"Ugyanaz a vez vagy kereszt nev: {ugyanaz}");
        }

    }
}
