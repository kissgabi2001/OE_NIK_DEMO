using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlat_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. FELADAT
            // Konzolra kiiratás

            Console.WriteLine("1. FELADAT");

            Console.WriteLine("Hello world");

            Console.WriteLine();

            // 2. FELADAT
            // Add meg a programnak a neved

            Console.WriteLine("2. FELADAT");

            Console.WriteLine("Add meg a neved!");
            string nev = Console.ReadLine();
            Console.WriteLine("Szia " + nev + "!");

            Console.WriteLine();

            // 3. FELADAT
            // Adjunk meg egy tetszőleges számot, szorozzuk 10-zel

            Console.WriteLine("3. FELADAT");

            Console.WriteLine("Adj meg egy számot, megmondom a 10x-esét!");

            string szamString = Console.ReadLine();
            int szamInt = int.Parse(szamString);
            int szamSzorozva = szamInt * 10;

            Console.WriteLine("Eredmeny: " + szamSzorozva);
            Console.WriteLine();

            // 4. FELADAT
            // Változó átalakítás

            Console.WriteLine("4. FELADAT");

            //a, string

            Console.WriteLine("Adj meg egy számot!");
            int szam = int.Parse(Console.ReadLine());

            string szoveg = szam.ToString();

            //b, parse

            string szoveg2 = "10";
            int szam2 = int.Parse(szoveg2);

            //c, kaszt - értékvesztéssel

            int valt = 255; // byte: 0-255
            byte masikValt = (byte)valt;

            Console.WriteLine();

            // 5. FELADAT
            // Add meg a téglalap a és b oldalát
            // Számold ki a területét és a kerületét

            Console.WriteLine("5. FELADAT");

            Console.WriteLine("Add meg az 'a' oldalt.");
            int aOldal = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg az 'b' oldalt.");
            int bOldal = int.Parse(Console.ReadLine());

            // kerület: (a+b)*2
            int kerulet = (aOldal + bOldal) * 2;

            // terület: a*b
            int terulet = aOldal * bOldal;

            Console.WriteLine("Kerület=" + kerulet + " \t Terület=" + terulet);
            Console.WriteLine();

            //--------------------------------------------------------------------------
            // PLUSZ FELADATOK

            // 1. FELADAT

            Console.WriteLine("1. FELADAT - PLUSZ");

            Console.WriteLine("Téglalap terület és kerület számológép");

            Console.Write("Adja meg a téglalap hosszát: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Adja meg a téglalap szélességét: ");
            double width = double.Parse(Console.ReadLine());

            double area = length * width;
            double perimeter = 2 * (length + width);

            Console.WriteLine($"A téglalap területe: {area}");
            Console.WriteLine($"A téglalap kerülete: {perimeter}");
            Console.WriteLine();

            // 2. FELADAT

            Console.WriteLine("2. FELADAT - PLUSZ");

            Console.WriteLine("Összeg- és szorzatszámológép");

            Console.Write("Írja be az első számot: ");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.Write("Írja be a második számot: ");
            double secondNumber = double.Parse(Console.ReadLine());

            // Calculate the sum and product
            double sum = firstNumber + secondNumber;
            double product = firstNumber * secondNumber;

            // Display the results
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine();



            // 3. FELADAT
            //Készítsen alkalmazást, amely bekéri a felhasználó nevét és bruttó fizetését!
            //Ezután írassuk ki:
            //Kedves[XY] az ön számított nettó fizetése[ertek] Ft!
            //Bruttó fizetés *0.66

            Console.WriteLine("3. FELADAT - PLUSZ");

            Console.WriteLine("Net Salary Calculator");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your gross salary (in Ft): ");
            double grossSalary = double.Parse(Console.ReadLine());

            double netSalary = grossSalary * 0.66;

            Console.WriteLine($"Dear {name}, your calculated net salary is {netSalary} Ft!");

            Console.ReadKey();
        }
    }
}
