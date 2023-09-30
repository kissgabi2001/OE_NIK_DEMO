using System;


namespace _3.Labor
{
    public class Program1
    {
        static void Main(string[] args)
        {

            //int index = 0;

            //while (index < 10)
            //{
            //    Console.WriteLine($"I >> {++index}");
            //    // index++;
            //    /*
            //     * index = index + 1
            //     * index += 1
            //     * index++
            //     */
            //}

            //string felh = "", jelsz = "";

            //Console.WriteLine(new string('=',10));
            //// Console.WriteLine("===============");

            ////do
            ////{
            ////    Console.Write("Felhasznalo nev:\t");
            ////    felh = Console.ReadLine();
            ////    Console.Write("Jelszo:\t");
            ////    jelsz = Console.ReadLine();
            ////} while (felh == string.Empty || jelsz == string.Empty);

            ////Console.WriteLine("Sikeres bejelentkezes");

            //Console.Write("Kerek egy kezdobetut a-tol b-ig:");
            //string rov = Console.ReadLine();

            //switch (rov)
            //{
            //    case "a": 
            //        Console.WriteLine("Szia Anna");
            //        Console.WriteLine();
            //        ;
            //        ;
            //        ;

            //        break;
            //    case "b": Console.WriteLine("Hali Béla");
            //        break;
            //    default:
            //        Console.WriteLine("Ilyen betuvel kezdodo nevet nem ismerek");
            //        break;
            //}


            //const double PI = Math.PI;
            // PI = 3.14; >> nem lehet

            double pi = System.Math.PI;

            Random r = new Random();
            ;

            //Console.WriteLine($"Random ertekem ={r.Next(0,11).ToString()}");
            //Console.WriteLine("Random ertekem ={0}",r.Next(0, 11).ToString());
            //Console.WriteLine("Random ertekem = " + r.Next(0, 11).ToString());

            int[] tomb = new int[3];

            tomb[0] = r.Next(0, 11);
            tomb[1] = r.Next(0, 11);
            tomb[2] = r.Next(0, 11);

            Console.WriteLine($"Random ertekem ={tomb[0]}");
            Console.WriteLine("Random ertekem ={0}", tomb[1]);
            Console.WriteLine("Random ertekem = " + tomb[2]);
            //tomb[3] = r.Next(0, 11); >> hibas

            int[] tomb2 = new int[] { 0, 2, 3 };
            string[] tomb3 = new string[3]; // string[] tomb3 = new string[]{"","",""};
            char[] t4 = new char[3];
            bool[] t5 = new bool[3];
            double[] t6 = new double[3];

            Console.WriteLine("Tomb 2. eleme = " + tomb2[1].ToString());
            Console.WriteLine(tomb2[tomb.Length - 1].ToString());
            ;

            //Console.WriteLine(tomb);

            for (int i = 0; i < tomb.Length -1; i++)
            {
                tomb[i] = tomb[i] + 1;
                Console.WriteLine(tomb[i]);
            }

            int idx = 0;

            while (idx < tomb.Length - 1)
            {
                tomb[idx] = tomb[idx] + 1;
                Console.WriteLine(tomb[idx]);
                idx++;
            }

            foreach (var item in tomb)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }

    }
}
