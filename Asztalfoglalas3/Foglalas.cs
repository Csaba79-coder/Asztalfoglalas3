using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asztalfoglalas3
{
    class Foglalas
    {
        string vendegNev;
        int vendegLetszam;
        DateTime erkezesNap;
        int erkezesOra;
        bool torzsVendegE;
        public string VendegNev
        {
            get { return vendegNev; }
            set { vendegNev = value; }
        }
        public int VendegLetszam
        {
            get { return vendegLetszam; }
            set { vendegLetszam = value; }
        }
        public DateTime ErkezesNap
        {
            get { return erkezesNap; }
            set { erkezesNap = value; }
        }
        public int ErkezesOra
        {
            get { return erkezesOra; }
            set { erkezesOra = value; }
        }
        public bool TorzsVendegE
        {
            get { return torzsVendegE; }
            set { torzsVendegE = value; }
        }
    }
}
