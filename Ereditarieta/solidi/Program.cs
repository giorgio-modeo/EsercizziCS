namespace Solidi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("solidi");
            var alluminio = new TipoMateriale { Materiale.Alluminio , PesoSpecifico= 2.5};
            var acciaio = new TipoMateriale { Materiale.Acciaio, PesoSpecifico=7.85};
            var rame = new TipoMateriale { Materiale.Rame, PesoSpecifico=8.96};
            var c1 = new Cubo { Lato = 1, Materiale=acciaio }; 
            Console.WriteLine(c1);
            var c2 = new Cubo { Lato = 1, Materiale=alluminio}; 
            Console.WriteLine(c2);
            var c3 = new Sfera { Raggio = 1, Materiale= alluminio}; 
            Console.WriteLine(c3);
            var c4 = new Sfera { Raggio = 1, Materiale = rame };
            Console.WriteLine(c4);
            var c5 = new Cilindro { Raggio = 1, Materiale = rame };
            Console.WriteLine(c5);


            Solido[] solidi = { c1, c2, c3, c4 };

            foreach(var s in solidi)
                Console.WriteLine(s);
            


        }
    }
}