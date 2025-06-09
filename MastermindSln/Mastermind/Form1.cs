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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIgracPogadja_Click(object sender, EventArgs e)
        {
            IgracPogadja igracPogadja = new IgracPogadja("covek");
            igracPogadja.ShowDialog();
        }


        private void btnKompjuterPogadja_Click(object sender, EventArgs e)
        {
            IgracPogadja igracPogadja = new IgracPogadja("kompjuter");
            igracPogadja.ShowDialog();
        }

    }
}
