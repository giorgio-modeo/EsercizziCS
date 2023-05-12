using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenditaProdotti
{
    public class Prodotti
    {
        public int Codice { get; set; }
        public string Nome { get; set; }
        public double Prezzo { get; set; }
        public DateTime DataProduzzione { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(Codice)}={Codice.ToString()}," +
                $" {nameof(Nome)}={Nome}," +
                $" {nameof(Prezzo)}={Prezzo.ToString()}," +
                $" {nameof(DataProduzzione)}={DataProduzzione.ToString()}}}";
        }
    }
}
