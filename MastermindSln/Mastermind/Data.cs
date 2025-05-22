using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastermind
{
    internal class Data
    {



        public static int[,] KonacanRezultat = new int[100, 4];
        public static int red = 0;
        public static List<int[]> skup = new List<int[]>();
        public static int[] trenutni = new int[4];
        public static resenje kod = new resenje();
        public static resenje privkod = new resenje();



        public struct resenje
        {
            public int tacno;
            public int skoro;
        }



        public struct slika
        {
            public PictureBox picture;
            public Boje boja;
        }

        public enum Boje
        {
            zuta,
            zelena,
            plava,
            crvena,
            ljubicasta,
            braon,
            gugugaga
        }




        public static resenje ProveriResenje(int[] niz, int[] rez)
        {
            resenje rezultat;
            rezultat.tacno = 0;
            rezultat.skoro = 0;

            bool[] NizUsed = new bool[4];
            bool[] RezUsed = new bool[4];

            for (int i = 0; i < 4; i++)
            {
                NizUsed[i] = false;
                RezUsed[i] = false;
            }



            for (int i = 0; i < 4; i++)
            { 
                if (niz[i] == rez[i])
                {
                    rezultat.tacno += 1;
                    NizUsed[i] = true;
                    RezUsed[i] = true;
                }
            }


            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if ((niz[i] == rez[j]) && NizUsed[i] == false && RezUsed[j] == false)
                    {
                        rezultat.skoro += 1;
                        NizUsed[i] = true;
                        RezUsed[j] = true;
                    }
                }
            }



            return rezultat;
        }





        static void sredi()
        {
            for (int i = 0; i < skup.Count; i++)
            {
                if (skup[i].SequenceEqual(trenutni))
                {
                    skup.RemoveAt(i);
                    break;
                }
            }
        }



        

        public static int[,] KompjuterPogadja(int[] niz)
        {
            red = 0;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    for (int r = 0; r < 6; r++)
                    {
                        for (int t = 0; t < 6; t++)
                        {

                            skup.Add(new int[] {i,j,r,t });

                        }
                    }
                }
            }

            trenutni = new int[] {0,0,1,1};


            sredi();
            for (int i = 0; i < 4; i++)
            {
                KonacanRezultat[red, i] = trenutni[i];
            }
            red++;


            kod = ProveriResenje(trenutni, niz);
   

            while (skup.Count > 1)
            {
                for (int i = 0; i < skup.Count; i++)
                {

                    privkod  = ProveriResenje(skup[i], trenutni);

                    if ((privkod.tacno != kod.tacno) || (privkod.skoro != kod.skoro))
                    {
                        skup.RemoveAt(i);
                    }

                }



                Random r = new Random();
                int br = r.Next(skup.Count - 1);

                trenutni = skup[br];
                
               
                kod = ProveriResenje(trenutni, niz);



                sredi();
                for (int i = 0; i < 4; i++)
                {
                    KonacanRezultat[red, i] = trenutni[i];
                }
                red++;
                if (kod.tacno == 4)
                {
                    return KonacanRezultat;
                }

/*                if (red == 6)
                {
                    return KonacanRezultat;
                }*/

            }

            return KonacanRezultat;

        }




    }
}
