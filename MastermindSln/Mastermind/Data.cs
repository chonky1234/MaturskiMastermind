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

        



        public static int[,] KompjuterPogadja(int[] niz)
        {
            int[,] resenje = new int[6,4];





            return resenje;

        }




    }
}
