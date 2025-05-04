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
        Data.slika[,] Polja = new Data.slika[6, 4];
        int red = 0;
        int kolona = 0;
        string rezultat;

        Label[] odgovori = new Label[6];



        public IgracPogadja()
        {
            InitializeComponent();

            Setup();
            GenerisiBoje();

            
        }

        private void Setup()
        {
            odgovori[0] = label1;
            odgovori[1] = label2;
            odgovori[2] = label3;
            odgovori[3] = label4;
            odgovori[4] = label5;
            odgovori[5] = label6;


            Polja[0, 0].picture = pictureBox1;
            Polja[0, 1].picture = pictureBox2;
            Polja[0, 2].picture = pictureBox3;
            Polja[0, 3].picture = pictureBox4;

            Polja[1, 0].picture = pictureBox5;
            Polja[1, 1].picture = pictureBox6;
            Polja[1, 2].picture = pictureBox7;
            Polja[1, 3].picture = pictureBox8;

            Polja[2, 0].picture = pictureBox9;
            Polja[2, 1].picture = pictureBox10;
            Polja[2, 2].picture = pictureBox11;
            Polja[2, 3].picture = pictureBox12;

            Polja[3, 0].picture = pictureBox13;
            Polja[3, 1].picture = pictureBox14;
            Polja[3, 2].picture = pictureBox15;
            Polja[3, 3].picture = pictureBox16;

            Polja[4, 0].picture = pictureBox17;
            Polja[4, 1].picture = pictureBox18;
            Polja[4, 2].picture = pictureBox19;
            Polja[4, 3].picture = pictureBox20;

            Polja[5, 0].picture = pictureBox21;
            Polja[5, 1].picture = pictureBox22;
            Polja[5, 2].picture = pictureBox23;
            Polja[5, 3].picture = pictureBox24;

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
            Polja[red, kolona].picture.BackColor = Color.Yellow;
            Polja[red, kolona].boja = Data.Boje.zuta;
           // MessageBox.Show(Polja[red, kolona].picture.BackColor.ToString());
            if (kolona < 3) kolona++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Polja[red, kolona].picture.BackColor = Color.Green;
            Polja[red, kolona].boja = Data.Boje.zelena;
            // MessageBox.Show(Polja[red, kolona].picture.BackColor.ToString());
            if (kolona < 3) kolona++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Polja[red, kolona].picture.BackColor = Color.Blue;
            Polja[red, kolona].boja = Data.Boje.plava;
            // MessageBox.Show(Polja[red, kolona].picture.BackColor.ToString());
            if (kolona < 3) kolona++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Polja[red, kolona].picture.BackColor = Color.Red;
            Polja[red, kolona].boja = Data.Boje.crvena;
            //  MessageBox.Show(Polja[red, kolona].picture.BackColor.ToString());
            if (kolona < 3) kolona++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Polja[red, kolona].picture.BackColor = Color.Purple;
            Polja[red, kolona].boja = Data.Boje.ljubicasta;
            //MessageBox.Show(Polja[red, kolona].picture.BackColor.ToString());
            if (kolona < 3) kolona++;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Polja[red, kolona].picture.BackColor = Color.Brown;
            Polja[red, kolona].boja = Data.Boje.braon;
            //MessageBox.Show(Polja[red, kolona].picture.BackColor.ToString());
            if (kolona < 3) kolona++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (Polja[red,i].picture.BackColor == DefaultBackColor)
                {
                    MessageBox.Show("popuni boje");
                    return;
                }

            }



            rezultat = "";

            int[] rez = new int[4];

            for (int i = 0; i < 4; i++)
            {
                rez[i] = (int) Resenje[i].boja;
            }


/*            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    MessageBox.Show(Polja[i, j].picture.BackColor.ToString());
                }
            }*/

            

            /*for (int i = 0; i < 4; i++)
            {
                //MessageBox.Show(Polja[red, i].boja.ToString());

                //if (rez.Contains<int>(   (int) Polja[red,i].boja    ))

                if (rez.Contains<int>((int)Polja[red, i].boja))3
                {
                    if ((int) Polja[red,i].boja == rez[i])
                    {
                        rezultat += "tacno ";
                    }
                    else
                    {
                        rezultat += "skoro ";
                    }

                    //rez[i] = 77;
                    Polja[red, i].boja = Data.Boje.gugugaga;
                }

            }*/





            for (int i = 0; i < 4; i++)
            {
                //MessageBox.Show(Polja[red, i].boja.ToString());

                //if (rez.Contains<int>(   (int) Polja[red,i].boja    ))

              
                if ((int) Polja[red,i].boja == rez[i])
                {
                    rezultat += "tacno ";
                    Polja[red, i].boja = Data.Boje.gugugaga;
                    rez[i] = 77;
                }
                //rez[i] = 77;
                    
                
                

            }
            for (int i = 0; i < 4; i++)
            {
                //MessageBox.Show(Polja[red, i].boja.ToString());

                //if (rez.Contains<int>(   (int) Polja[red,i].boja    ))

                for (int j = 0; j < 4; j++)
                {
                    if ((int)Polja[red, i].boja == rez[j])
                    {
                        rezultat += "skoro ";
                        Polja[red, i].boja = Data.Boje.gugugaga;
                        rez[j] = 77;
                    }
                    //rez[i] = 77;
                }
            
                //Polja[red, i].boja = Data.Boje.gugugaga;

            }






            odgovori[red].Text = rezultat;
            //MessageBox.Show(rezultat);

            kolona = 0;
            red++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox25.Visible = true;
            pictureBox26.Visible = true;
            pictureBox27.Visible = true;
            pictureBox28.Visible = true;
        }
    }
}
