using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeoGiorgio_Esercitazione2
{
    public class ResponsabileVenditori : Venditore
    {
        public List<Venditore> Venditori { get; set; }

        public ResponsabileVenditori()
        {
            Venditori = new List<Venditore>();
        }

        public void AggiungiVenditore(Venditore venditore)
        {
            Venditori.Add(venditore);
        }

        public Venditore RestituisciVenditore(int index)
        {
            return Venditori[index];
        }

        public void CancellaVenditore(int index)
        {
            Venditori.RemoveAt(index);
        }

        public override double Tredicesima()
        {
            double bonus = 0;
            foreach (Venditore venditore in Venditori)
            {
                bonus += venditore.Stipendio / 25 * 0.15;
            }
            return Stipendio * 2 + bonus;
        }

        public override string ToString()
        {
            string venditoriString = "";
            foreach (Venditore venditore in Venditori)
            {
                venditoriString += venditore.ToString() + "\n";
            }
            return $"{Nome} {Cognome} - Settore: {Settore} - Stipendio: {Stipendio}\nVenditori di cui è responsabile:\n{venditoriString}";
        }
    }
}
