﻿using System;
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
    public partial class IgracPogadja : Form
    {
        public Red[] redovi = new Red[7];

        Red resenje;

        //Data.slika[,] Polja = new Data.slika[6, 4];
        int red = 0;
        public static int kolona = 0;
        string rezultat;

        Label[] odgovori = new Label[6];

        public string player;



        public IgracPogadja(string igrac)
        {
            InitializeComponent();
            player = igrac;


            if (igrac == "covek")
            {
                button8.Text = "Pokazi resenje";
                Setup();
                GenerisiBoje();

                resenje.Visible = false;
            }

            if (igrac == "kompjuter")
            {
                button8.Text = "Potvrdi kombinaciju";
                Setup();
                red = 6;
                button7.Hide();
            }
        }



        private void Setup()
        {
            redovi[0] = red1;
            redovi[1] = red2;
            redovi[2] = red3;
            redovi[3] = red4;
            redovi[4] = red5;
            redovi[5] = red6;
            redovi[6] = resenje = red7;

            for (int i = 1; i < redovi.Length; i++)
            {
                redovi[i].Enabled = false;
            }
        }

        void GenerisiBoje()
        {

            int b;
            Random r = new Random();

            for (int i = 0; i < 4; i++)
            {
                b = r.Next(1, 6);

                resenje.StaviBoju(b, i);
                /*switch (b)
                {
                    case 1:
                        resenje.StaviBoju(b, i);
                        break;
                    case 2:
                        resenje.StaviBoju(b, i);
                        break;
                    case 3:
                        resenje.StaviBoju(b, i);
                        break;
                    case 4:
                        resenje.StaviBoju(b, i);
                        break;
                    case 5:
                        resenje.StaviBoju(b, i);
                        break;
                    case 6:
                        resenje.StaviBoju(b, i);
                        break;

                }*/
                    
            }
        }




        private void IgracPogadja_Load(object sender, EventArgs e)
        {

        }

        public void namestiKolonu()
        {
            for (int i = 0; i < 4; i++)
            {
                if (redovi[red].slike[i].BackColor == DefaultBackColor)
                {
                    kolona = i;
                    return;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            namestiKolonu();
            redovi[red].StaviBoju(0, kolona);
            namestiKolonu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            namestiKolonu();
            redovi[red].StaviBoju(1, kolona);
            namestiKolonu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            namestiKolonu();
            redovi[red].StaviBoju(2, kolona);
            namestiKolonu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            namestiKolonu();
            redovi[red].StaviBoju(3, kolona);
            namestiKolonu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            namestiKolonu();
            redovi[red].StaviBoju(4, kolona);
            namestiKolonu();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            namestiKolonu();
            redovi[red].StaviBoju(5, kolona);
            namestiKolonu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
        /*    for (int i = 0; i < 4; i++)
            {
                if (Polja[red,i].picture.BackColor == DefaultBackColor)
                {
                    MessageBox.Show("popuni boje");
                    return;
                }

            }*/



            rezultat = "";

            int[] rez = new int[4];
            int[] niz = new int[4];

            for (int i = 0; i < 4; i++)
            {
                rez[i] = resenje.indexBoja[i];
            }

            for (int i = 0; i < 4; i++)
            {
                niz[i] = redovi[red].indexBoja[i];
            }




            Data.resenje t = Data.ProveriResenje(niz, rez);




            redovi[red].StaviResenje(t.tacno + " " + t.skoro);

            kolona = 0;
            if (red<6)
            {
                redovi[red].Enabled = false;
                red++;
                redovi[red].Enabled = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (player == "covek")
            {
                resenje.Visible = true;
            }

            if (player == "kompjuter")
            {
                button1.Hide();
                button2.Hide();
                button3.Hide();
                button4.Hide();
                button5.Hide();
                button6.Hide();


                int[,] RezultatKompjutera = new int[6, 4];



                RezultatKompjutera = Data.KompjuterPogadja(redovi[6].indexBoja);

                string blabla = "";
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        redovi[i].StaviBoju(RezultatKompjutera[i, j], j);
                        //blabla += RezultatKompjutera[i,j].ToString();
                    }

                   /* MessageBox.Show(blabla);
                    blabla = "";*/
                }

                

            }

        }

        private void red1_Load(object sender, EventArgs e)
        {

        }

        private void red2_Load(object sender, EventArgs e)
        {

        }

        private void red7_Load(object sender, EventArgs e)
        {

        }
    }
}
