namespace LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var elenco = new List<Cliente>
            {
            new Cliente {CodFiscale="RSSMRA01A01H501K",Nome="Rossi",Cognome="Mario"},
            new Cliente { CodFiscale = "BNCCHR02B41F205L", Nome = "Bianchi", Cognome = "Laura" },
            new Cliente { CodFiscale = "SPSGPP03C02F839M", Nome = "Esposito", Cognome = "Giuseppe" },
            new Cliente { CodFiscale = "RSSMRA04D47G702N", Nome = "Russo", Cognome = "Maria" },
            new Cliente { CodFiscale = "FRRMRC05E12I345O", Nome = "Ferrari", Cognome = "Marco" },
            new Cliente { CodFiscale = "GRCNTN06F30L987P", Nome = "Greco", Cognome = "Antonio" },
            new Cliente { CodFiscale = "RSSMRA08D47G702N", Nome = "Russo", Cognome = "Maria" },
            new Cliente { CodFiscale = "FRRMRC12E12I345O", Nome = "Ferrari", Cognome = "Marco" },
            new Cliente { CodFiscale = "GRCNTN10F30L987P", Nome = "Greco", Cognome = "Antonio" }
            };
            var q1 = from cliente in elenco
                    select cliente.CodFiscale;
            Console.WriteLine(string.Join(", ",q1));

            var q2 = from cliente in elenco
                    select cliente.Cognome +" "+ cliente.Nome;
            Console.WriteLine(string.Join(", ", q2));

            var q3 = from cliente in elenco
                    where cliente.RecuperoEta()<18
                     select cliente.ToString();
            Console.WriteLine(string.Join(", ", q3));


        }
    }
}