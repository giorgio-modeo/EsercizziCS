using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Vuoto.Models
{
    public class Prodotto
    {
        public int Codice { get; set; }
        public int Giacenza { get; set; }
        public double Prezzo { get; set; }
        public string Descrizzione { get; set; }
        public string Denominazzione{ get; set; }

        public override string ToString()
        {
            return $"{nameof(Codice)}={Codice.ToString()}, " +
                $" {nameof(Giacenza)}={Giacenza.ToString()}, " +
                $" {nameof(Prezzo)}={Prezzo.ToString()}, " +
                $" {nameof(Descrizzione)}={Descrizzione}, " +
                $" {nameof(Denominazzione)}={Denominazzione}";
        }
    }
}