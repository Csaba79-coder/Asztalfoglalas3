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

namespace Asztalfoglalas3
{
    public partial class Form1 : Form
    {
        List<Foglalas> foglalasok = new List<Foglalas>();
        public Form1()
        {
            InitializeComponent();
            beolvas();
            kiir();
        }
        private void kiir()
        {
            lbFoglalas.Items.Clear();
            foreach(Foglalas f in foglalasok)
            {
                lbFoglalas.Items.Add(f.VendegNev+"  "
                    +f.VendegLetszam);
            }
        }
        private void beolvas()
        {
            foglalasok.Clear();
            StreamReader reader = new StreamReader
                ("asztalfoglalasok.txt");
            while (!reader.EndOfStream)
            {
                Foglalas fog = new Foglalas();
                fog.VendegNev = reader.ReadLine();
                fog.VendegLetszam = Convert.ToInt32(reader.ReadLine());
                fog.TorzsVendegE = Convert.ToBoolean(reader.ReadLine());
                fog.ErkezesOra = Convert.ToInt32(reader.ReadLine());
                fog.ErkezesNap = Convert.ToDateTime(reader.ReadLine());
                foglalasok.Add(fog);
            }
            reader.Close();
        }
        private void btnFelvitel_Click(object sender, EventArgs e)
        {
            FelvitelForm felvitel = new FelvitelForm();
            felvitel.ShowDialog();
            if (felvitel.DialogResult == DialogResult.OK)
            {
                beolvas();
                kiir();
            }
        }

        private void lbFoglalas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTorzsVendegE.Checked = false;
            if (lbFoglalas.SelectedIndex >= 0)
            {
                tbVendegNeve.Text = foglalasok[lbFoglalas.SelectedIndex].VendegNev;
                tbLetszam.Text = foglalasok[lbFoglalas.SelectedIndex].VendegLetszam.ToString();
                tbErkezesOra.Text = foglalasok[lbFoglalas.SelectedIndex].ErkezesOra.ToString();
                tbErkezesnap.Text = foglalasok[lbFoglalas.SelectedIndex].ErkezesNap.ToString();
                bool torzsvendeg = foglalasok[lbFoglalas.SelectedIndex].TorzsVendegE;
                if (torzsvendeg) { cbTorzsVendegE.Checked = true; }
                else { cbTorzsVendegE.Checked = false; }
            }
            else { MessageBox.Show("Nincs kiválasztva vendég"); }
        }
    }
}
