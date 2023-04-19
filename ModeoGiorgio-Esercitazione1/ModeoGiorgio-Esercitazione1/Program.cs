namespace ModeoGiorgio_Esercitazione1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sportello Bancomat");
            Console.WriteLine("\nDisponibilità");

            var b1 = new Bancomat { Cinquanta=3,Venti=5,Dieci=10};
            Console.WriteLine(b1.TotaleSoldi());
            Console.WriteLine(b1.StampaDisponibilità());
            

            Console.WriteLine("\nNumero di pezzi da togliere: ");
            int numero = int.Parse(Console.ReadLine());
            if (b1.Togli50(numero))
                Console.WriteLine("Operazzione riuscita");
            Console.WriteLine("operazzione fallita");

            
            Console.WriteLine(b1.TotaleSoldi());

            Console.WriteLine("\nCifra da prelevare: ");
            numero = int.Parse(Console.ReadLine());
            b1.Prelievo(numero);
            b1.StampaDisponibilità();
            Console.WriteLine(b1.TotaleSoldi());

        }
    }

}