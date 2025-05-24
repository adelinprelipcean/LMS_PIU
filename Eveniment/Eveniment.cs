using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eveniment
{
    class Eveniment
    {
        public string TipEveniment { get; set; }
        public DateTime DataEveniment { get; set; }
        public string Locatie { get; set; }
        public Eveniment() { }
        public Eveniment(string tipEveniment, DateTime dataEveniment, string locatie)
        {
            TipEveniment = tipEveniment;
            DataEveniment = dataEveniment;
            Locatie = locatie;
        }
        public override string ToString()
        {
            return string.Format("Evenimentul de tip {0} are loc la data de {1} la locatia {2}", TipEveniment, DataEveniment, Locatie);
        }
    }
}
