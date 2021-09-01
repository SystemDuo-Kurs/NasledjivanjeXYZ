using System;
using System.Collections.Generic;
using NasledjivanjeXYZ.Zivotinje;

namespace NasledjivanjeXYZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Macka m = new();
            Pas p = new();

            Zivotinja zz = m;
            object o = new Pas();

            Macka zklj = o as Macka;
            
            zklj.OglasiSe();
            Console.ReadKey();
            List<Zivotinja> zivotnije = new();
            zivotnije.Add(new Macka());
            zivotnije.Add(new Pas());
            zivotnije.Add(new Pas());
            zivotnije.Add(new Pas());
            zivotnije.Add(new Macka());
            foreach (Zivotinja z in zivotnije)
            {
                if (z is Macka mac)
                {
                    mac.OglasiSe();
                }
                z.OglasiSe();
                /*if (z is Macka)
                {
                    Console.Write($"Macka kaze ");
                    z.OglasiSe();
                } else if (z is Pas)
                {
                    Console.Write($"Pas kaze ");
                    z.OglasiSe();
                }*/
                string asd = "";
                int broj = 4;

                asd = broj % 2 == 0 ? "paran" : "neparan";

                bool nesto = broj % 2 == 0;

                /*
                if (broj%2 == 0)
                {
                    asd = "paran";
                } else
                {
                    asd = "neparan";
                }*/
               
            }
        }
    }
    namespace Zivotinje
    {
        public abstract class Zivotinja
        {
            public abstract void OglasiSe();
        }

        class Konj : Zivotinja
        {
            public override void OglasiSe()
            {
                Console.WriteLine("Njiii?");
            }
        }
    }
}
