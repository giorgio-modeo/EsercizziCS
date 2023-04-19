namespace Atleti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            try
            {
                var a1 = new Atleta { Nominativo ="aaa",Disciplina="nuoto",Pettorina=3};
                Console.WriteLine(a1);
                Console.WriteLine(a1.Corro());
                Console.WriteLine(a1.Rovescio());
                var c1 = new Calciatore
                {
                    Nominativo = "Ciro Del Pino",
                    Disciplina = "Calcio",
                    Pettorina = 42,
                    Club= "ff",
                    PartiteGiocate=8,
                    GoalSegnati=12

                };
                Calciatore c2 = (Calciatore)c1.Clone();
                c2.Nominativo = "rob cau";
                c2.GoalSegnati = 3;
                c2.PartiteGiocate = 6;

                var c3 = c1.Clone() as Calciatore;
                if(c1.Equals(c3))
                    Console.WriteLine($"{c1.Nominativo} e uguale a {c3.Nominativo}");
                if(c1.CompareTo(c2)==1)
                    Console.WriteLine($"{c1.Nominativo} a media gol segniati superiore a {c2.Nominativo}");
                if(c1.CompareTo(c2)==-1)
                    Console.WriteLine($"{c2.Nominativo} a media gol segniati superiore a {c1.Nominativo}");
                
            }
            catch (NotImplementedException e) {
                Console.WriteLine("errore");
                Console.WriteLine(e.Message);
            }
        }
    }
}