using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeoGiorgio_Esercitazione2
{
    public class CapoOfficina : Meccanico
    {
        List<Ordine> Ordini = new List<Ordine>();

        public void AggiungiOrdine(Ordine ordine, int index)
        {
            Ordini.Insert(index, ordine);
        }

        public int NoOrdini()
        {
            return Ordini.Count;
        }

        public override double Tredicesima()
        {
            double bonus = 0;
            foreach (Ordine ordine in Ordini)
            {
                bonus += ordine.Totale() * 0.05;
            }
            return Stipendio * 2 + bonus;
        }

        public override string ToString()
        {
            string ordiniString = "";
            foreach (Ordine ordine in Ordini)
            {
                ordiniString += ordine.ToString() + "\n";
            }
            return $"{Nome} {Cognome} - Stipendio: {Stipendio}\nOrdini gestiti:\n{ordiniString}";
        }
    }

}
