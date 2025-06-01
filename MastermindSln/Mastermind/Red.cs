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
    public partial class Red : UserControl
    {


        public int[] indexBoja = new int[4];
        public PictureBox[] slike = new PictureBox[4];


        public Red()
        {
            InitializeComponent();

            slike[0] = boja1;
            slike[1] = boja2;
            slike[2] = boja3;
            slike[3] = boja4;

            for (int i = 0; i < 4; i++)
            {
                indexBoja[i] = 7;
            }
        }


        public void StaviBoju(int boja, int kolona)
        {

            if (boja == 0) slike[kolona].BackColor = Color.Yellow;
            if (boja == 1) slike[kolona].BackColor = Color.Green;
            if (boja == 2) slike[kolona].BackColor = Color.Cyan;
            if (boja == 3) slike[kolona].BackColor = Color.Red;
            if (boja == 4) slike[kolona].BackColor = Color.Purple;
            if (boja == 5) slike[kolona].BackColor = Color.Fuchsia;

            indexBoja[kolona] = boja;
            /* zuta,
            zelena,
            plava,
            crvena,
            ljubicasta,
            braon,*/

        }


        public void StaviResenje(string r)
        {
            resenje.Text = r;
        }




        private void Red_Load(object sender, EventArgs e)
        {

        }

        private void boja1_Click(object sender, EventArgs e)
        {
            IgracPogadja.kolona = 0;
            indexBoja[0] = 7;
            boja1.BackColor = DefaultBackColor;
        }

        private void boja2_Click(object sender, EventArgs e)
        {
            IgracPogadja.kolona = 1;
            indexBoja[1] = 7;
            boja2.BackColor = DefaultBackColor;
        }

        private void boja3_Click(object sender, EventArgs e)
        {
            IgracPogadja.kolona = 2;
            indexBoja[2] = 7;
            boja3.BackColor = DefaultBackColor;
        }

        private void boja4_Click(object sender, EventArgs e)
        {
            IgracPogadja.kolona = 3;
            indexBoja[3] = 7;
            boja4.BackColor = DefaultBackColor;
        }




    }
}
