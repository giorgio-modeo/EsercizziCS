using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

/*
 *                  visualizzare l'elenco dei prodotti
                    visualizzare l'elenco dei prodotti in scadenza (minore di 10 giorni)
                    visualizzare l'elenco delle materie prime con cui è fatto il prodotto
 */
namespace VenditaProdotti
{
    internal class bizProdotti
    {
        List<Prodotti> elenco= new List<Prodotti>();

        public void AggiungiProdotto(Prodotti prodotti)
        {
            elenco.Add(prodotti);
        }
        public string ElencoProdotti()
        {
            return string.Join("\n", elenco);
        }
        public string EPScadenza()
        {
            foreach (var item in elenco)
            {
                if (item is ProdottoAlimentare pa)
                    return pa.Scadenza;
                

            }
        }



    }
}
