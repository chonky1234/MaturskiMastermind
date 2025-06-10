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


        public static bool nastavi;
        public static int[,] KonacanRezultat = new int[6,4];
        public static int red = 0;
        public static List<int[]> skup = new List<int[]>();
        public static List<int[]> skupSvihResenja = new List<int[]>();
        public static int[] trenutni = new int[4];
        public static resenje kod = new resenje();
        public static resenje privkod = new resenje();
        public static List<int[]> brojKodova = new List<int[]>();
        public static List<int> najveciBrojKodova = new List<int>();
        public static List<brojIIndex> MinimaxKandidati = new List<brojIIndex>();
        public static List<int> indexi = new List<int>();


        public struct brojIIndex
        {
            public int index;
            public int vrednost;
        }


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

        public static int[] PocniKompjuterSredjuje()
        {
            red = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    KonacanRezultat[i, j] = -1;
                }
            }

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    for (int r = 0; r < 6; r++)
                    {
                        for (int t = 0; t < 6; t++)
                        {
                            skup.Add(new int[] { i, j, r, t });
                            skupSvihResenja.Add(new int[] { i, j, r, t });
                            brojKodova.Add(new int[14]);
                            najveciBrojKodova.Add(0);
                        }
                    }
                }
            }

            trenutni = new int[] { 0, 0, 1, 1 };

            sredi();
            for (int i = 0; i < 4; i++)
            {
                KonacanRezultat[red, i] = trenutni[i];
            }
            red++;

            return trenutni;
        }


        public static int[] SledeciKorakKompjuterPogadja(int tacninetacni)
        {
            int t = tacninetacni;
            resenje kod;
            kod.skoro = t % 10;
            t -= kod.skoro;
            kod.tacno = t / 10;



            indexi.Clear();
            for (int i = 0; i < najveciBrojKodova.Count; i++)
            {
                najveciBrojKodova[i] = 0;
            }
            for (int i = 0; i < skupSvihResenja.Count; i++)
            {

                brojKodova[i][0] = 0;
                brojKodova[i][1] = 0;
                brojKodova[i][2] = 0;
                brojKodova[i][3] = 0;
                brojKodova[i][4] = 0;
                brojKodova[i][5] = 0;
                brojKodova[i][6] = 0;
                brojKodova[i][7] = 0;
                brojKodova[i][8] = 0;
                brojKodova[i][9] = 0;
                brojKodova[i][10] = 0;
                brojKodova[i][11] = 0;
                brojKodova[i][12] = 0;
                brojKodova[i][13] = 0;


            }

            for (int i = 0; i < skup.Count; i++)
            {

                privkod = ProveriResenje(trenutni, skup[i]);

                if ((privkod.tacno != kod.tacno) || (privkod.skoro != kod.skoro))
                {
                    skup.RemoveAt(i);
                    i--;
                }

            }


            for (int i = 0; i < skupSvihResenja.Count; i++)
            {
                for (int j = 0; j < skup.Count; j++)
                {
                    resenje priv = ProveriResenje(skupSvihResenja[i], skup[j]);

                    if (priv.tacno == 0 && priv.skoro == 0) brojKodova[i][0]++;
                    if (priv.tacno == 0 && priv.skoro == 1) brojKodova[i][1]++;
                    if (priv.tacno == 0 && priv.skoro == 2) brojKodova[i][2]++;
                    if (priv.tacno == 0 && priv.skoro == 3) brojKodova[i][3]++;
                    if (priv.tacno == 0 && priv.skoro == 4) brojKodova[i][4]++;
                    if (priv.tacno == 1 && priv.skoro == 0) brojKodova[i][5]++;
                    if (priv.tacno == 1 && priv.skoro == 1) brojKodova[i][6]++;
                    if (priv.tacno == 1 && priv.skoro == 2) brojKodova[i][7]++;
                    if (priv.tacno == 1 && priv.skoro == 3) brojKodova[i][8]++;
                    if (priv.tacno == 2 && priv.skoro == 0) brojKodova[i][9]++;
                    if (priv.tacno == 2 && priv.skoro == 1) brojKodova[i][10]++;
                    if (priv.tacno == 2 && priv.skoro == 2) brojKodova[i][11]++;
                    if (priv.tacno == 3 && priv.skoro == 0) brojKodova[i][12]++;
                    if (priv.tacno == 4 && priv.skoro == 0) brojKodova[i][13]++;
                }
            }



            for (int i = 0; i < skupSvihResenja.Count; i++)
            {
                int max = 0;
                for (int j = 0; j < 14; j++)
                {
                    if (brojKodova[i][j] > max)
                    {
                        max = brojKodova[i][j];
                    }
                }
                najveciBrojKodova[i] = max;
            }


            int min = najveciBrojKodova.Min();
            for (int i = 0; i < najveciBrojKodova.Count; i++)
            {
                if (najveciBrojKodova[i] == min)
                {
                    indexi.Add(i);
                }

            }



            bool flag = false;
            for (int i = 0; i < indexi.Count; i++)
            {
                for (int j = 0; j < skup.Count; j++)
                {
                    if (skupSvihResenja[indexi[i]].SequenceEqual(skup[j]))
                    {
                        trenutni = skup[j];
                        flag = true;
                        break;
                    }

                    if (flag == true)
                    {
                        break;
                    }

                }
            }

            if (flag == false)
            {
                trenutni = skupSvihResenja[indexi[0]];
            }
            sredi();

            // I DALJE TREBA DODATI DA IH BIRA LEKSIKOGRAFSKI AKO IH IMA VISE IZ LISTE SKUP

            /*Random r = new Random();
            int br = r.Next(skup.Count - 1);

            trenutni = skup[br];*/


            //NOVI TRENUTNI


            for (int i = 0; i < 4; i++)
            {
                KonacanRezultat[red, i] = trenutni[i];
            }

            red++;
            return trenutni;

               

            

        }

        public static resenje KompjuterPogadjaRework()
        {
            resenje rezultat;
            rezultat.tacno = 0;
            rezultat.skoro = 0;



            return rezultat;
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
                for (int j = 0; j < 4; j++)
                {
                    KonacanRezultat[i, j] = -1;
                }
            }


            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    for (int r = 0; r < 6; r++)
                    {
                        for (int t = 0; t < 6; t++)
                        {

                            skup.Add(new int[] {i,j,r,t });
                            skupSvihResenja.Add(new int[] { i, j, r, t });
                            brojKodova.Add(new int[14]);
                            najveciBrojKodova.Add(0);
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


                indexi.Clear();
                for (int i = 0; i < najveciBrojKodova.Count; i++)
                {
                    najveciBrojKodova[i] = 0;
                }
                for (int i = 0; i < skupSvihResenja.Count; i++)
                {

                    brojKodova[i][0] = 0;
                    brojKodova[i][1] = 0;
                    brojKodova[i][2] = 0;
                    brojKodova[i][3] = 0;
                    brojKodova[i][4] = 0;
                    brojKodova[i][5] = 0;
                    brojKodova[i][6] = 0;
                    brojKodova[i][7] = 0;
                    brojKodova[i][8] = 0;
                    brojKodova[i][9] = 0;
                    brojKodova[i][10] = 0;
                    brojKodova[i][11] = 0;
                    brojKodova[i][12] = 0;
                    brojKodova[i][13] = 0;

                   
                }

                for (int i = 0; i < skup.Count; i++)
                {

                    privkod  = ProveriResenje(trenutni, skup[i]);

                    if ((privkod.tacno != kod.tacno) || (privkod.skoro != kod.skoro))
                    {
                        skup.RemoveAt(i);
                        i--;
                    }

                }


                for (int i = 0; i < skupSvihResenja.Count; i++)
                {
                    for (int j = 0; j < skup.Count; j++)
                    {
                        resenje priv = ProveriResenje(skupSvihResenja[i],skup[j]);

                        if (priv.tacno == 0 && priv.skoro == 0) brojKodova[i][0]++;
                        if (priv.tacno == 0 && priv.skoro == 1) brojKodova[i][1]++;
                        if (priv.tacno == 0 && priv.skoro == 2) brojKodova[i][2]++;
                        if (priv.tacno == 0 && priv.skoro == 3) brojKodova[i][3]++;
                        if (priv.tacno == 0 && priv.skoro == 4) brojKodova[i][4]++;
                        if (priv.tacno == 1 && priv.skoro == 0) brojKodova[i][5]++;
                        if (priv.tacno == 1 && priv.skoro == 1) brojKodova[i][6]++;
                        if (priv.tacno == 1 && priv.skoro == 2) brojKodova[i][7]++;
                        if (priv.tacno == 1 && priv.skoro == 3) brojKodova[i][8]++;
                        if (priv.tacno == 2 && priv.skoro == 0) brojKodova[i][9]++;
                        if (priv.tacno == 2 && priv.skoro == 1) brojKodova[i][10]++;
                        if (priv.tacno == 2 && priv.skoro == 2) brojKodova[i][11]++;
                        if (priv.tacno == 3 && priv.skoro == 0) brojKodova[i][12]++;
                        if (priv.tacno == 4 && priv.skoro == 0) brojKodova[i][13]++;
                    }
                }



                for (int i = 0; i < skupSvihResenja.Count; i++)
                {
                    int max = 0;
                    for (int j = 0; j < 14; j++)
                    {
                        if(brojKodova[i][j] > max)
                        {
                            max = brojKodova[i][j];
                        }

                    }
                    najveciBrojKodova[i] = max;

                }


                int max2 = najveciBrojKodova.Min();


                for (int i = 0; i < najveciBrojKodova.Count; i++)
                {
                    if  (najveciBrojKodova[i] == max2)
                    {
                        indexi.Add(i);
                    }

                }



                bool flag = false;
                for (int i = 0; i < indexi.Count; i++)
                {
                    for (int j = 0; j < skup.Count; j++)
                    {
                        if (skupSvihResenja[indexi[i]].SequenceEqual(skup[j]))
                        {
                            trenutni = skup[j];
                            flag = true;    
                            break;
                        }

                        if (flag == true)
                        {
                            break;
                        }    

                    }
                }

                if(flag == false)
                {
                    trenutni = skupSvihResenja[indexi[0]];
                }

                // I DALJE TREBA DODATI DA IH BIRA LEKSIKOGRAFSKI AKO IH IMA VISE IZ LISTE SKUP

                /*Random r = new Random();
                int br = r.Next(skup.Count - 1);

                trenutni = skup[br];*/

                kod = ProveriResenje(trenutni, niz);

                for (int i = 0; i < 4; i++)
                {
                    KonacanRezultat[red, i] = trenutni[i];
                }

                if (kod.tacno == 4)
                {
                    for (int i = red+1; i < 6; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {

                        }
                    }

                    return KonacanRezultat;
                }



                sredi();
               
                red++;
                

                if (red == 6)
                {
                    return KonacanRezultat;
                }

            }

            return KonacanRezultat;

        }




    }
}
