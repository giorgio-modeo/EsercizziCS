using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeoGiorgio_Esercitazione2
{
    public class Prodotto
    {
        public int Codice { get; set; }
        public string NomeProdotto{ get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(Codice)}={Codice}," +
                $" {nameof(NomeProdotto)}={NomeProdotto}," +
                $" {nameof(Descrizione)}={Descrizione}," +
                $" {nameof(Prezzo)}={Prezzo}}}";
        }
    }
}
