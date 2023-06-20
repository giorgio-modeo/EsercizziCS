namespace LinqEsempio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomi = { "piero","mario","giulia","francesca",
                "laura","piero","antonio","vito","giada","rossella ","simone", "rosa" ,"andrea","mattia" ,"ilaria" ,"alessandro", "vanessa" ,"roberto" ,"leonardo"};
            var query = from tutti in nomi select tutti;
            Console.WriteLine(string.Join(", ",query));

            Console.WriteLine("\nnomi che inizziano con a");


            var query2 = from iniziaA in nomi 
                         //where iniziaA.StartsWith('A') 
                         where iniziaA.Substring(0,1).ToUpper().Equals("A")
                         select iniziaA;

            Console.WriteLine(string.Join(", ",query2));
            
            Console.WriteLine("\nelenco dei nomi ordinato crescente");
            var query3 = from ordinaAsc in nomi
                         orderby ordinaAsc 
                         select ordinaAsc;
            Console.WriteLine(string.Join(", ", query3));

            Console.WriteLine("\nnomi che hanno lungezza 7 caratteri");
            var query4 = from lungezza7 in nomi
                         where lungezza7.Length == 7
                         orderby lungezza7 descending
                         select lungezza7;
            Console.WriteLine(string.Join(", ", query4));

            int[] numeri = { 1, 2, 3, 4, 5, 6, -1, -2, -3, -4, -5, -6,51,52,103 };
            Console.WriteLine("numeri");
            var q1 =from elenco in numeri select elenco;
            Console.WriteLine(string.Join(", ",q1));
            
            Console.WriteLine("\nnumeri lambda");
            Console.WriteLine($"max: {numeri.Max()}");
            Console.WriteLine($"min: {numeri.Min()}");
            Console.WriteLine($"coun: {numeri.Count()}");
            Console.WriteLine($"sum: {numeri.Sum()}");
            Console.WriteLine($"sum: {numeri.Where(x=> x>0).Sum()}");
            var q2 =from n in numeri
                    where n>0
                    select n;
            Console.WriteLine($"sum {q2.Sum()}");
            
            var q3 = numeri.Where(x=> x%2==1).ToList();
            Console.WriteLine(string.Join(", ",q3));

            Console.WriteLine("numeri pari appartenenti al intervallo [50,100] ordinati decrescente");
            var q4 = from n1 in numeri
                     where n1 % 2 == 0 && ((n1 > 50) || (n1 < 100))
                     select n1;
            Console.WriteLine($"sum {string.Join(", ",q4)}");






        }
    }
}