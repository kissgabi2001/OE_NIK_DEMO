using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlat_10_megoldas
{
    class NyilvanTartas
    {
        private readonly string menu;

        private StreamWriter sw;

        public NyilvanTartas()
        {
            menu = $"1. - Uj edzes felvitele\n2. - Edzesek Listazasa\n3. - Statisztikak\n4. - Kilepes\n";
        }

        public void Menu()
        {
            bool kilepes = false;
            do
            {
                Console.Clear();
                Console.Write(menu);
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        AdatFelvetel();
                        break;
                    case ConsoleKey.D2:
                        Edzesek_lista();
                        break;
                    case ConsoleKey.D3:
                        Statisztika();
                        break;
                    case ConsoleKey.D4:
                        kilepes = true;
                        break;
                    default:
                        break;
                }
            } while (!kilepes);
        }

        private void AdatFelvetel()
        {
            Console.Clear();
            Console.Write("ev: ");
            int ev = int.Parse(Console.ReadLine());
            Console.Write("ho: ");
            int ho = int.Parse(Console.ReadLine());
            Console.Write("nap: ");
            int nap = int.Parse(Console.ReadLine());
            Console.Write("ora: ");
            int ora = int.Parse(Console.ReadLine());
            Console.Write("perc: ");
            int perc = int.Parse(Console.ReadLine());
            Console.Write("mp: ");
            int mp = int.Parse(Console.ReadLine());
            Console.Write("Tavja: ");
            double tav = double.Parse(Console.ReadLine());
            Futo f = new Futo(tav, ev, ho, nap, ora, perc, mp);
            sw = new StreamWriter("FutoNaplo.txt", true, Encoding.Default);
            string w = $"{f.Datum()} {f.Ido()} {f.Tav}";
            sw.WriteLine(w);

            sw.Close();
        }

        private void Edzesek_lista()
        {
            Console.Clear();
            string[] sorok = File.ReadAllLines("FutoNaplo.txt");
            for (int i = 0; i < sorok.Length; i++)
            {
                Console.WriteLine($"{i + 1}. edzes(Datum, ido, tav): {sorok[i]}");
            }

            Console.ReadKey();
        }

        private void Statisztika()
        {
            Console.Clear();
            string[] sorok = File.ReadAllLines("FutoNaplo.txt");

            DateTime osszeg = new DateTime();
            double tavszamlalo = 0;
            for (int i = 0; i < sorok.Length; i++)
            {
                string[] splitelt = sorok[i].Split(' ');
                string[] ido = splitelt[1].Split(':');
                osszeg = osszeg.AddHours(double.Parse(ido[0]));
                osszeg = osszeg.AddMinutes(double.Parse(ido[1]));
                osszeg = osszeg.AddSeconds(double.Parse(ido[2]));
                tavszamlalo += double.Parse(splitelt[2]);
            }

            double tavatlag = tavszamlalo / sorok.Length;
            StreamWriter sw = new StreamWriter("Statisztika.txt", false, Encoding.Default);
            sw.WriteLine($"Edzesek szama: {sorok.Length}, Tavosszeg: {tavszamlalo}, Idoosszeg: {osszeg.ToString("HH:mm:ss")}, Tavatlag: {tavatlag}");
            sw.Close();
            //Console.ReadKey();

        }

    }
}
