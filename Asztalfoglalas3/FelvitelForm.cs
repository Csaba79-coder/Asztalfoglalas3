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
    public partial class FelvitelForm : Form
    {
        public FelvitelForm()
        {
            InitializeComponent();
        }

        private void btnFelvitel_Click(object sender, EventArgs e)
        {
            if (tbVendegNeve.Text != "" && 
                dtpErkezesNapja.Value >= DateTime.Now && 
                numErkezesOra.Value>=10 && numLetszam.Value>0)
            {
                StreamWriter writer = new StreamWriter
                    ("asztalfoglalasok.txt", true);
                writer.WriteLine(tbVendegNeve.Text);
                writer.WriteLine(numLetszam.Value);
                writer.WriteLine(cbTorzsVendegE.Checked);
                writer.WriteLine(numErkezesOra.Value);
                writer.WriteLine(dtpErkezesNapja.Value);
                writer.Close();
                DialogResult = DialogResult.OK;
            }
            else { MessageBox.Show("Nincs kitöltve az összes adat"); }
        }
    }
}
