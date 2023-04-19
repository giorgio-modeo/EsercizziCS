namespace ClasseAuto
{
    internal class Program
    {
        public void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //marca modello cilindrata alimentazzione colore
            // velocitaMax => cilindrata/10+alimentazzione(Benzina=30,disel=10,gpl=-10,metano-30)
            var bmw = new Auto
            {
                Marca = "mbw",
                Modello = "x5",
                Cilindrata = 2000,
                Carburante = Carburante.Benzina,
                Colore = "bianco"
            };
            Console.WriteLine(bmw);
        }//main
    }//classe
}//namespace