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


        public static string ProveriResenje(int[] niz, int[] rez)
        {
            string rezultat = "";



            for (int i = 0; i < 4; i++)
            { 
                if (niz[i] == rez[i])
                {
                    rezultat += "tacno ";
                    niz[i] = 777;
                    rez[i] = 77;
                }
            }


            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (niz[i] == rez[j])
                    {
                        rezultat += "skoro ";
                        niz[i] = 777;
                        rez[j] = 77;
                    }
                }
            }



            return rezultat;
        }

    }
}
