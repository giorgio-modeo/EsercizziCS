namespace Quadrilateri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var q1 = new Quadrilatero(1.25, 2.5, 1.75, 3);
            Console.WriteLine(q1);
            var q2 = new Rettangolo(1.95,2.05);
            Console.WriteLine(q2);
            var q3 = new Quadrato(1.35);
            Console.WriteLine(q3);

            Quadrilatero[] qauadrilateri = { q1, q2, q3};
            foreach (var q in qauadrilateri)
            {
                /*  la pui corretta 
                Rettangolo r = null;
                if (q is Rettangolo)
                {
                    Rettangolo r = (Rettangolo)q;
                    Console.WriteLine(r.Area());
                }
                else
                {
                    Console.WriteLine(q);
                }*/
                /* in c# si usa qesta sintassi */
                if (q is Rettangolo r) 
                    Console.WriteLine(r.Area());
            }
        }
    }
}