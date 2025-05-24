using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sondaj
{
    class Sondaj
    {
        public int Varsta { get; set; }
        public string Localitate { get; set; }
        public bool ProEuropa { get; set; }
        public Sondaj() { }

        public Sondaj(int varsta, string localitate, bool proEuropa)
        {
            Varsta = varsta;
            Localitate = localitate;
            ProEuropa = proEuropa;
        }
        public override string ToString()
        {
            return string.Format("Localitate: {0}, Varsta: {1}, ProEuropa {2}", Localitate, Varsta, ProEuropa);
        }
    }
}
