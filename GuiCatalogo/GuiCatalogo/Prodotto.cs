using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiCatalogo
{
    [Serializable]
    public class Prodotto
    {
        public int Codice { get; set; }
        public string Denominazione { get; set; }
        public double Prezzo { get; set; }
        public int Giacenza { get; set; }

        public bool IsInScorta() => Giacenza > 0 && Giacenza<10;
        public bool IsEsaurito() => Giacenza == 0;

        public override string ToString()
        {
            return $"{{" +
                $"{nameof(Codice)}={Codice.ToString()}" +
                $", {nameof(Denominazione)}={Denominazione}" +
                $", {nameof(Prezzo)}={Prezzo.ToString()}" +
                $", {nameof(Giacenza)}={Giacenza.ToString()}" +
                $"}}";
        }
        public string ExportCSV()
        {
            return $"" +
                $"{Codice.ToString()}" +
                $";{Denominazione}" +
                $";{Prezzo.ToString()}" +
                $";{Giacenza.ToString()}"
                ;
        }
    }
}
