using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeoGiorgio_Esercitazione2
{
    public sealed class Ordine : Prodotto
    {
        public int IdOrdine { get; set; }
        public DateTime Data{ get; set; }
        public List<Prodotto> ElencoProdotti { get; set; }
        public Venditore Venditore { get; set; }

        public int NoProdotti()
        {
            int totale = 0;
            foreach (Prodotto prodotto in ElencoProdotti)
            {
                totale += 1;
            }
            return totale;
        }
        public double Totale()
        {
            double totale = 0;
            foreach (Prodotto prodotto in ElencoProdotti)
            {
                totale += prodotto.Prezzo /* * prodotto.Quantita*/;
            }
            return totale;
        }


        public void Scontrino()
        {
            Console.WriteLine($"Scontrino dell'ordine {IdOrdine} del {Data.ToShortDateString()} - Venditore: {Venditore.Nome} {Venditore.Cognome}");
            Console.WriteLine("Codice\tNome\tQuantità\tPrezzo unitario\tSubtotale");
            foreach (Prodotto prodotto in ElencoProdotti)
            {
                Console.WriteLine($"{prodotto.Codice}\t{prodotto.NomeProdotto}\t\t{prodotto.Prezzo}");
            }
            Console.WriteLine($"Totale: {Totale()}");
        }




        public override string ToString()
        {
            return $"{{{nameof(IdOrdine)}={IdOrdine.ToString()}," +
                $" {nameof(Data)}={Data.ToString()}," +
                $" {nameof(ElencoProdotti)}={ElencoProdotti}," +
                $" {nameof(Venditore)}={Venditore}," +
                $" {nameof(Codice)}={Codice.ToString()}," +
                $" {nameof(NomeProdotto)}={NomeProdotto}," +
                $" {nameof(Descrizione)}={Descrizione}," +
                $" {nameof(Prezzo)}={Prezzo}," +
                $" }}";
        }

        public bool Equals(Ordine? other)
        {
            throw new NotImplementedException();
        }
    }

}
