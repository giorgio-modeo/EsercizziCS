using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenditaProdotti
{
    public class ProdottoNonAlimentare:Prodotti
    {
        public int PercentualeMaterialePrincipale { get; set; }
        public List<(string materiale, double percentuale)> Materiali { get; set; }

        public override string ToString()
        {
            return $"Percentuale più alta = {PercentualeMaterialePrincipale}" +
                base.ToString();
        }
    }

}
