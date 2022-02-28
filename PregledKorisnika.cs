using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SučeljeZaEvidencijuKnjiga_EM
{
    public partial class PregledKorisnika : Form
    {

        static string dokumenti = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        static string putanja = Path.Combine(dokumenti, "Korisnici.xml");
        



        public PregledKorisnika()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PregledKorisnika_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var xml = XElement.Load(putanja);
            txtKorisnici.Text = xml.Value;
        }
    }
}
