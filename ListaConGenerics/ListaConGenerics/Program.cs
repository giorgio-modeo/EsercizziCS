namespace ListaConGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //lista di tipo specifico,numero interi
            var lista = new List<int>() { 12,4,-8,56,90,78};
            Console.WriteLine(string.Join(", ",lista));
            Random random = new Random();
            var numeri = new List<int>();

            int  NumeriDaGenerare=random.Next(100)+1;
            for (int i=0;i<NumeriDaGenerare;i++)
                numeri.Add(random.Next(100)+1);
            Console.WriteLine("numero da cercare");
            int numero = int.Parse(Console.ReadLine());

            int posizzione=numeri.IndexOf(numero);
            Console.WriteLine($"{numero} trovato in posizzione");
            Console.WriteLine(string.Join(", ",numeri));
        }
    }
}