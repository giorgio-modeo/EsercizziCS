using System.Collections;

namespace lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var lista = new ArrayList();
            Console.WriteLine($"capacita: {lista.Capacity}");
            Console.WriteLine( lista.Count);
            lista.Add(1);
            lista.Add("p");
            lista.Add(false);
            foreach(int i in lista)
            {
            Console.WriteLine();
            }
            Console.WriteLine($"capacita: {lista.Capacity}");
            Console.WriteLine( lista.Count);

            Console.WriteLine($"elemento in posizzione 2{lista[2]}");

        }
    }
}