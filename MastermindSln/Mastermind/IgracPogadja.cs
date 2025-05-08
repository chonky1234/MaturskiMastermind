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
    public partial class IgracPogadja : Form
    {
        public Red[] redovi = new Red[6];

        Red resenje;

        Data.slika[,] Polja = new Data.slika[6, 4];
        int red = 0;
        public static int kolona = 0;
        string rezultat;

        Label[] odgovori = new Label[6];



        public IgracPogadja()
        {
            InitializeComponent();

            Setup();
            GenerisiBoje();

            resenje.Visible = false;
        }

        private void Setup()
        {
            redovi[0] = red1;
            redovi[1] = red2;
            redovi[2] = red3;
            redovi[3] = red4;
            redovi[4] = red5;
            redovi[5] = red6;
            resenje = red7;
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
            if (redovi[red].slike[0].BackColor == DefaultBackColor)
            {
                kolona = 0;
                return;
            }
            if (redovi[red].slike[1].BackColor == DefaultBackColor)
            {
                kolona = 1;
                return;
            }
            if (redovi[red].slike[2].BackColor == DefaultBackColor)
            {
                kolona = 2;
                return; ;
            }
            if (redovi[red].slike[3].BackColor == DefaultBackColor)
            {
                kolona = 3;
                return;
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




            string s = Data.ProveriResenje(niz, rez);




            redovi[red].StaviResenje(s);

            kolona = 0;
            red++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            resenje.Visible = true;
        }

        private void red1_Load(object sender, EventArgs e)
        {

        }
    }
}
