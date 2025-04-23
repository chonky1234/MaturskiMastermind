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
            braon
        }

    }
}
