namespace GestioneLibrettoStudenti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gestione libretto Studenti!");
            var biz =new EsameBiz();
            Console.WriteLine("Elenco esami");
            Console.WriteLine(biz.Stampa());
            Console.WriteLine($"Media Esami: {biz.MediaEsami}");
            Console.WriteLine();
            Console.WriteLine("Stampa esami sostenuti dallo studente");
            Console.Write("Inserisci il cogniome dello studente: ");
            string cognome = Console.ReadLine();
            Console.WriteLine(string.Join("\n", biz.EsamiPerStudente(cognome)));

            Console.WriteLine();
            Console.WriteLine("Stampa esami sostenuti in una materia");
            Console.Write("Inserisci la meteria: ");
            string materia = Console.ReadLine();
            Console.WriteLine(string.Join("\n", biz.EsamiPerMateria(materia)));


            Console.WriteLine();
            Console.WriteLine("Stampa numero di esami sostenuti da studente");
            Console.Write("Inserisci il cogniome dello studente: ");
            cognome = Console.ReadLine();
            Console.WriteLine($"Numero di esami sostenuti: {biz.NumeroEsamiPerStudente(cognome)}");

        }
    }
}