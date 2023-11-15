using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlat_10_megoldas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Írj menüvezérelt programot, amely lehetővé teszi egy futó napi edzéseinek eltárolását
            //1.Új edzés felvitele -Dátum YYYYMMDD formátumban -Táv #,# km formában - Idő HH:MM:SS formátumban Az új edzés bekerül a futónapló fájl végére
            //2.Edzések listázása A konzolra kilistázza az edzéseket
            //3.Statisztikák A konzolra és egy statisztika fájlba kiírja az edzések számát, valamint a távok és idők összegét és átlagát

            //NyilvanTartas nyt = new NyilvanTartas();
            //nyt.Menu();


            //Csevegőprogramot készítünk, amelyben Személy típusú elemekkel reprezentáljuk a kontaktjainkat. Egy Személynek van neve, születési éve és neme.
            //1.Hozzunk létre 5 elemű tömböt, amelyet feltöltünk Személyekkel!A Személy osztályban legyen olyan paraméteres konstruktor, amelynek segítségével név és nem ismeretében, de véletlenszerű születési évvel létrehozhatjuk a személyt.
            //2.Vannak olyan emberek, akiknek ugyanaz a vezeték - vagy keresztnevük, mint a felhasználónak? Ha vannak, akkor listázzuk ki mindet.
            //3.Listázzuk ki az összes olyan Személyt, aki a felhasználóval ellenkező nemű!
            //4.Számoljuk meg, hány olyan Személy van, aki a felhasználóval azonos korosztályba tartozik(azaz maximum 5 év van közöttük)!



            CsevegoProgram cs = new CsevegoProgram();
            cs.Feladatok();

        }
    }
}
