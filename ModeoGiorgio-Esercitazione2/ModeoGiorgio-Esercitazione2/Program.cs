namespace ModeoGiorgio_Esercitazione2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creazione di alcuni oggetti di prova
            Venditore venditore1 = new Venditore { Nome = "Mario", Cognome = "Rossi", Stipendio = 1500, Settore = "Auto"};
            Venditore venditore2 = new Venditore { Nome = "Luigi", Cognome = "Verdi", Stipendio = 1700, Settore = "Moto"};
            Meccanico meccanico1 = new Meccanico { Nome = "Giovanni", Cognome = "Bianchi", Stipendio = 1800, Tipologia = "Carrozzeria" };
            Meccanico meccanico2 = new Meccanico { Nome = "Paolo", Cognome = "Neri", Stipendio = 1900, Tipologia = "Meccanica" };

            ResponsabileVenditori responsabile = new ResponsabileVenditori { Nome = "Carlo", Cognome = "Gialli", Stipendio = 2000, Settore = "Auto" };

            responsabile.AggiungiVenditore(venditore1);
            responsabile.AggiungiVenditore(venditore2);

            CapoOfficina capoOfficina = new CapoOfficina { Nome = "Antonio", Cognome = "Rosa", Stipendio = 2200 };

            Prodotto prodotto1 = new Prodotto { Codice = 1, NomeProdotto = "Olio motore", Descrizione = "Olio sintetico per motori a benzina", Prezzo = 20 };
            Prodotto prodotto2 = new Prodotto { Codice = 2, NomeProdotto = "Filtro aria", Descrizione = "Filtro aria per motori diesel", Prezzo = 15 };
            Prodotto prodotto3 = new Prodotto { Codice = 3, NomeProdotto = "Pastiglie freni", Descrizione = "Pastiglie freni per auto", Prezzo = 30 };
            Prodotto prodotto4 = new Prodotto { Codice = 4, NomeProdotto = "Candele", Descrizione = "Candele per motori a benzina", Prezzo = 10 };

            Ordine ordine1 = new Ordine { IdOrdine = 1, Data = new DateTime(2023, 5, 10), Venditore = venditore1, ElencoProdotti = new List<Prodotto> { prodotto1,prodotto2} };
            Ordine ordine2 = new Ordine { IdOrdine = 2, Data = new DateTime(2023, 5, 9), Venditore = venditore2, ElencoProdotti = new List<Prodotto> { prodotto3, prodotto4 } };

            capoOfficina.AggiungiOrdine(ordine1,0);
            capoOfficina.AggiungiOrdine(ordine2,1);

            bool continua = true;
            while (continua)
            {
                Console.WriteLine("Scegli un'opzione:");
                Console.WriteLine("1. Stampa dell'elenco dei venditori");
                Console.WriteLine("2. Stampa dell'elenco dei meccanici");
                Console.WriteLine("3. Stampa di un certo ordine");
                Console.WriteLine("4. Stampa dei dati del responsabile venditori");
                Console.WriteLine("5. Stampa dei dati del capo officina");
                Console.WriteLine("0. Esci");

                string scelta = Console.ReadLine();
                switch (scelta)
                {
                    case "1":
                        Console.WriteLine("Elenco dei venditori:");
                        Console.WriteLine(venditore1.ToString());
                        Console.WriteLine(venditore2.ToString());
                        break;
                    case "2":
                        Console.WriteLine("Elenco dei meccanici:");
                        Console.WriteLine(meccanico1.ToString());
                        Console.WriteLine(meccanico2.ToString());
                        break;
                    case "3":
                        Console.WriteLine("Inserisci l'id dell'ordine:");
                        int idOrdine = int.Parse(Console.ReadLine());
                        Ordine ordine = ordine.Codice.Find(o => o.IdOrdine == idOrdine);
                        if (ordine != null)
                        {
                            Console.WriteLine(ordine.ToString());
                            ordine.Scontrino();
                        }
                        else
                        {
                            Console.WriteLine($"Ordine con id {idOrdine} non trovato.");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Dati del responsabile venditori:");
                        Console.WriteLine(responsabile.ToString());
                        break;
                    case "5":
                        Console.WriteLine("Dati del capo officina:");
                        Console.WriteLine(capoOfficina.ToString());
                        break;
                    case "0":
                        Console.WriteLine("Uscita dal programma");
                        continua = false;
                        break;
                    default:
                        Console.WriteLine("Scelta non valida.");
                        break;
                }
            }
        }
    }
}