using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlat_06_megoldas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. feladat
            //Egy szöveges változóban megszámoljuk meg a betűket
            Betuk_szama("294863epoje 6546463");
            #endregion

            #region 2.feladat
            //Megszámoljuk egy szövegben a magánhangzókat
            Maganhangzok_szama("rfigugdsdhds öóüöÁŰŰÚ");

            #endregion

            #region 3. feladat
            //Bekér a felhasználóótól egy stringet és megvizsgálja hogy érvényes e-mail cím-e.
            //a) A címben pontosan 1 db @ (kukac)jel szerepel.
            //b) A @ előtti rész: a.legfeljebb 64 karakter hosszú lehet,
            //b.az első és utolsó karaktere nem lehet. (pont),
            //c.valamint nem szerepelhet benne két pont közvetlenül egymás mellett.
            //c) A @ utáni rész: a.legfeljebb 255 karakter hosszú lehet,
            //b.tartalmazhat betűket és számokat,
            //c. írásjeleket azonban nem, kivéve. (pont) vagy - (kötőjel), feltéve hogy az nem az első vagy utolsó karakter,
            //d.valamint nem szerepelhet benne két pont közvetlenül egymás mellett


            Email_vizsg();
            #endregion

            #region 4. feladat
            //Készíts egy consolos alkalmazást ami megadott string esetén az alábi logika szerint adja vissza:
            //Mumbling(abcd)->A - Bb - Ccc - Dddd
            //Mumbling(trump)->T - Rr - Uuu - Mmmm - Ppppp


            Mumbling("abcd");
            Mumbling("trump");
            #endregion

            #region 5. feladat
            //Egy string tömbbe 6 autó típust tárolunk el, hozzá tartozó árlistát egy egy dimenziós stirng tömbbe tároljuk el.
            //Végezd el a következő feladatokat:
            //Az auto tömb adatait kérd be a felhasználótól, nem tartalmazhat speciális karaktereket illetve ékezetes karaktereket
            //Az auto típusokhoz tartalmazó ár listát random számokkal töltsd fel
            //Ha az árlistában valamelyik ár középső 2 számjegye osztható 3 - mal akkor szorozuk meg 2 - vel ezt a 2 jegyü számot és illeszuk be.


            string[] autok = Autok();
            string[] arlista = Arlista();
            Megjelenit(arlista);
            ArKozepso_Szamjegy(arlista);
            Console.WriteLine("-----------------------");
            Megjelenit(arlista);

            #endregion

        }

        #region 1.feladat
        static void Betuk_szama(string sz)
        {
            int osszeg = 0;
            for (int i = 0; i < sz.Length; i++)
            {
                if (char.IsLetter(sz[i]))
                {
                    osszeg++;
                }
            }

            Console.WriteLine($"{osszeg} betu van a szovegben");
        }

        #endregion

        #region 2. feladat

        static void Maganhangzok_szama(string sz)
        {
            int osszeg = 0;
            for (int i = 0; i < sz.Length; i++)
            {
                if (Maganhangzo_e(sz[i]))
                {
                    osszeg++;
                }
            }

            Console.WriteLine($"{osszeg} maganhangzo van a stringbe");
        }

        static bool Maganhangzo_e(char c)
        {
            string maganhangzok = "ÖöüÜóÓeEuUoOiIőŐúÚaAéÉáÁűŰíÍ";
            return maganhangzok.Contains(c.ToString());
        }


        #endregion

        #region 3. feladat
        static void Email_vizsg()
        {
            Console.Write("Email cim: ");
            string email = Console.ReadLine();
            if (Egy_kukac(email) && Kukac_elott_utan(email) && PontFeltetel(email) && Irasjelek(email))
            {
                Console.WriteLine("Ez egy jo email");
            }
            else
            {
                Console.WriteLine("Hibas email");
            }
        }

        static bool Egy_kukac(string email)
        {
            string[] seged = email.Split('@');
            return seged.Length == 2;
        }

        static bool Kukac_elott_utan(string email)
        {
            string[] seged = email.Split('@');
            return seged[0].Length <= 64 && seged[1].Length <= 255;
        }

        static bool PontFeltetel(string email)
        {
            for (int i = 0; i < email.Length - 1; i++)
            {
                if (i + 1 < email.Length && email[i] == '.' && email[i + 1] == '.')
                {
                    return false;
                }
            }

            return email[0] != '.' && email[email.Length - 1] != '.';
        }

        static bool Irasjelek(string email)
        {
            string megengedettirasjelek = "-_@.";
            for (int i = 0; i < email.Length; i++)
            {
                if (!char.IsLetterOrDigit(email[i]) && !megengedettirasjelek.Contains(email[i]))
                {
                    return false;
                }
            }

            return true;
        }

        #endregion

        #region 4. feladat
        static void Mumbling(string szoveg)
        {
            string vissza = "";
            for (int i = 0; i < szoveg.Length; i++)
            {
                vissza += char.ToUpper(szoveg[i]);
                int j = 0;
                while (j < i)
                {
                    vissza += szoveg[i];
                    j++;
                }

                if (i != szoveg.Length - 1)
                {
                    vissza += "-";
                }
            }

            Console.WriteLine(vissza);
        }

        #endregion

        #region 5. feladat

        static string[] Autok()
        {
            string[] autok = new string[6];
            int j = 0;
            while (j < autok.Length)
            {
                Console.Write($"Az {j + 1}. auto neve: ");
                autok[j] = Console.ReadLine();
                if (HelyesNev(autok[j]))
                {
                    j++;
                }
                else
                {
                    Console.WriteLine("Hibas nev");
                }
            }

            return autok;
        }

        static bool HelyesNev(string auto)
        {
            string megengedetbetuk = "qQwWeErRtTzZuUiIoOpPaAsSdDfFgGhHjJkKlLyYxXcCvVbBnNmM ";
            for (int i = 0; i < auto.Length; i++)
            {
                if (!char.IsDigit(auto[i]) && !megengedetbetuk.Contains(auto[i]))
                {
                    return false;
                }
            }

            return true;
        }

        static string[] Arlista()
        {
            string[] arlista = new string[6];
            Random r = new Random();
            for (int i = 0; i < arlista.Length; i++)
            {
                arlista[i] = r.Next(5000000, 50000000).ToString();
            }

            return arlista;
        }

        static void ArKozepso_Szamjegy(string[] arak)
        {
            for (int i = 0; i < arak.Length; i++)
            {
                string seged = arak[i].Substring((arak[i].Length / 2) - 1, 2);
                int szam = int.Parse(seged);
                if (szam % 3 == 0)
                {
                    szam *= 2;
                    arak[i] = arak[i].Replace(seged, szam.ToString());
                }
            }
        }

        static void Megjelenit(string[] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
        }


        #endregion
    }
}
