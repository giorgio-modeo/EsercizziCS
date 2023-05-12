using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenditaProdotti
{
    public class ProdottoAlimentare:Prodotti
    {
        public DateTime Scadenza { get; set; }

        public override string ToString()
        {
            return $"Data di scadenza = {Scadenza}" +
                base.ToString();
        }
    }
}
