using System;

namespace Nemes_2022_es_verseny_5_ös_feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            int l, sor, elem;
            sor = 0; elem = 0;
            Console.WriteLine("Kérem a lépések számát!");
            l = Convert.ToInt32(Console.ReadLine());
            int[] lepesek = new int[l];
            for (int i = 0; i < l; i++)
            {
                Console.WriteLine("Kérem az "+(i+1)+".lépés értékét!");
                lepesek[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < l; i++)
            {
                switch(lepesek[i])
                { case 0:
                        sor++;
                        elem = elem * 2;
                        break;
                  case 1:
                        sor++;
                        elem = elem * 2 + 1;
                        break;
                  case 2:
                        sor--;
                        elem = (elem - elem % 2) / 2;
                        break;
                  case 3:
                        elem = elem - 1;
                        break;
                  case 4:
                        elem++;
                        break;
                }
                
            }
            Console.WriteLine("Sor száma:" + sor);
            Console.WriteLine("Elem száma:" + elem);
        }
    }
}
