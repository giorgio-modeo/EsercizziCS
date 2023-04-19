namespace FigureGeometriche
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Quadrato quadrato = new Quadrato();//istanza
            Console.WriteLine("Inserire un dato");
            quadrato.Lato = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Lato: {quadrato.Lato}");
            Console.WriteLine($"Perimetro: {quadrato.Perimetro()}");
            Console.WriteLine($"Area: {quadrato.Area()}");
            Console.WriteLine($"Diagonale: {quadrato.Diagonale()}");
            Console.WriteLine($"\n{quadrato}");

            var quadrato2 = new Quadrato { Lato=2.5 };// istanza non specifica
            Console.WriteLine(quadrato2 );
            

            // in questo caso non si puo utilizzare l'istanza veloce perchè
            // nel codice abbiamo determinato il costruttore
            try
            {
                Console.Write("inserisci il lato 1: ");
                double lato1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("inserisci il lato 2: ");
                double lato2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("inserisci il lato 3: ");
                double lato3 = Convert.ToDouble(Console.ReadLine());

                var triangolo = new Triangolo(lato1, lato2, lato3);
                Console.WriteLine(triangolo);

            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            */

            var p = new Punto { X = -22.5, Y = 3.75 };
            var q = new Punto { X = -1.25, Y = -2.25 };
            var r = new Punto { X = -3.3, Y = -2.5 };


            Console.WriteLine($"OP={p.Distanza()}");
            Console.WriteLine($"OQ={q.Distanza()}");

            Console.WriteLine($"PQ={p.Distanza(q)}");
            Console.WriteLine($"QP={q.Distanza(p)}");
            try
            {
                var t2 = new Triangolo(q, r, p);
                Console.WriteLine(t2);
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            
            

        }
    }
}