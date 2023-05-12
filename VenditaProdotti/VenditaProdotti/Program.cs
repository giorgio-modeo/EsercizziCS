namespace VenditaProdotti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vendita Prodotti");
            /*
             * Esercizio n. 1 - VenditaProdotti
               Un commerciante vende prodotti alimentari e non alimentari. 
               Di ogni prodotto si conosce un codice numerico, il nome, il prezzo, la data di produzione. 
               Se il prodotto è alimentare allora deve essere presente la data di scadenza,
               mentre se non è un prodotto alimentare si conosce la percentuale di materiale principale con il quale è costruito.
               Realizzare le classi necessarie per gestire un elenco di prodotti.
               Creare un menu testuale per rispondere alle seguenti richieste:
                    visualizzare l'elenco dei prodotti
                    visualizzare l'elenco dei prodotti in scadenza (minore di 10 giorni)
                    visualizzare l'elenco delle materie prime con cui è fatto il prodotto
             */

            /* prodotti
             *  cod
             *  nome
             *  prezzo
             *  data produzzione
             * 
             * alimentare
             *  data schadenza
             * 
             * non alimentare
             *  materiale
             *  percentuale di materiale
             *  
            */

            bizProdotti biz = new bizProdotti();

            var PNA1 = new ProdottoNonAlimentare { Codice = 1, Nome = "maglia", Prezzo = 12.50, DataProduzzione = new DateTime(2002, 12, 02), List<ProdottoNonAlimentare>("cotone", 90) };

            var PNA1 = new ProdottoNonAlimentare { Codice = 1, Nome = "maglia", Prezzo = 12.50, DataProduzzione = new DateTime(2002, 12, 02), PercentualeMaterialePrincipale = 90 };
            var PNA2 = new ProdottoNonAlimentare { Codice = 1, Nome = "maglia", Prezzo = 12.50, DataProduzzione = new DateTime(2002, 12, 02), PercentualeMaterialePrincipale = 90 };

            var PA1 = new ProdottoAlimentare { Codice = 1, Nome = "maglia", Prezzo = 12.50, DataProduzzione = new DateTime(2022, 12, 02), Scadenza = new DateTime(2023, 01, 05) };
            var PA2 = new ProdottoAlimentare { Codice = 1, Nome = "maglia", Prezzo = 12.50, DataProduzzione = new DateTime(2022, 12, 30), Scadenza = new DateTime(2023, 03, 07) };

            biz.AggiungiProdotto(PNA1);
            biz.AggiungiProdotto(PNA2);
            biz.AggiungiProdotto(PA1);
            biz.AggiungiProdotto(PA2);
            biz.EPScadenza();

        }
    }
}