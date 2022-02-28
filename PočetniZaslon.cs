using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SučeljeZaEvidencijuKnjiga_EM
{
    public partial class PočetniZaslon : Form
    {
        public PočetniZaslon()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NovaKnjiga novaKnjiga = new NovaKnjiga();
            novaKnjiga.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpisNovogKorisnika korisnik = new UpisNovogKorisnika();
            korisnik.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UnosPosudbe novaPosudba = new UnosPosudbe();
            novaPosudba.Show();

        }

        private void btnPregled_Click(object sender, EventArgs e)
        {
            StanjePosudbe stanjePosudbe = new StanjePosudbe();
            stanjePosudbe.Show();
        }
    }
}
