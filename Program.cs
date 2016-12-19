using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SzamokFeltetelig
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam = 0;
            int osszeg = 0;
            int max = 0;
            int min = 0;
            int darab = 0;

            Console.Write("Kerek egy szamot (0 végjelig):");
            szam = Convert.ToInt32(Console.ReadLine());

            min = szam;
            while (szam != 0)
            {
                osszeg += szam;
                darab++;
                // van-e max
                if (szam > max)
                {
                    max = szam;
                }
                // van-e min
                if (szam != 0)
                {
                    if (szam < min)
                    {
                        min = szam;
                    } 
                }

                Console.Write("Kerek egy szamot (0 végjelig):");
                szam = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("{0} darab szamot olvastunk be.",darab);
            Console.WriteLine("A minimum érték: {0}",min);
            Console.WriteLine("A maximum érték: {0}", max);
            Console.WriteLine("A szamok osszege: {0}",osszeg);

            Console.ReadKey();
        }
    }
}
