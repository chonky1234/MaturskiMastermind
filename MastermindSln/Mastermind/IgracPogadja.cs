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

        Data.slika[] Resenje = new Data.slika[4];
        Data.slika[,] Polja = new Data.slika[4, 6];
        int red = 0;
        int kolona = 0;


        public IgracPogadja()
        {
            InitializeComponent();

            Setup();
            GenerisiBoje();

            
        }

        private void Setup()
        {
            Polja[0, 0].picture = pictureBox1;
            Polja[1, 0].picture = pictureBox2;
            Polja[2, 0].picture = pictureBox3;
            Polja[3, 0].picture = pictureBox4;

            Polja[0, 1].picture = pictureBox5;
            Polja[1, 1].picture = pictureBox6;
            Polja[2, 1].picture = pictureBox7;
            Polja[3, 1].picture = pictureBox8;

            Polja[0, 2].picture = pictureBox9;
            Polja[1, 2].picture = pictureBox10;
            Polja[2, 2].picture = pictureBox11;
            Polja[3, 2].picture = pictureBox12;

            Polja[0, 3].picture = pictureBox13;
            Polja[1, 3].picture = pictureBox14;
            Polja[2, 3].picture = pictureBox15;
            Polja[3, 3].picture = pictureBox16;

            Polja[0, 4].picture = pictureBox17;
            Polja[1, 4].picture = pictureBox18;
            Polja[2, 4].picture = pictureBox19;
            Polja[3, 4].picture = pictureBox20;

            Polja[0, 5].picture = pictureBox21;
            Polja[1, 5].picture = pictureBox22;
            Polja[2, 5].picture = pictureBox23;
            Polja[3, 5].picture = pictureBox24;

            Resenje[0].picture = pictureBox25;
            Resenje[1].picture = pictureBox26;
            Resenje[2].picture = pictureBox27;
            Resenje[3].picture = pictureBox28;
        }

        void GenerisiBoje()
        {

            int b;
            Random r = new Random();

            for (int i = 0; i < 4; i++)
            {
                b = r.Next(1, 6);
                switch (b)
                {
                    case 1:
                        Resenje[i].boja = Data.Boje.zuta;
                        Resenje[i].picture.BackColor = Color.Yellow;
                        break;
                    case 2:
                        Resenje[i].boja = Data.Boje.zelena;
                        Resenje[i].picture.BackColor = Color.Green;
                        break;
                    case 3:
                        Resenje[i].boja = Data.Boje.plava;
                        Resenje[i].picture.BackColor = Color.Blue;
                        break;
                    case 4:
                        Resenje[i].boja = Data.Boje.crvena;
                        Resenje[i].picture.BackColor = Color.Red;
                        break;
                    case 5:
                        Resenje[i].boja = Data.Boje.ljubicasta;
                        Resenje[i].picture.BackColor = Color.Purple;
                        break;
                    case 6:
                        Resenje[i].boja = Data.Boje.braon;
                        Resenje[i].picture.BackColor = Color.Brown;
                        break;

                }
                    
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void IgracPogadja_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Polja[kolona, red].picture.BackColor = Color.Yellow;
            if (kolona < 3) kolona++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Polja[kolona, red].picture.BackColor = Color.Green;
            if (kolona < 3) kolona++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (Polja[i,red].picture.BackColor == DefaultBackColor)
                {
                    MessageBox.Show("popuni boje");
                    return;
                }
            }

            kolona = 0;
            red++;
        }
    }
}
