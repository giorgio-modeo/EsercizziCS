namespace Diario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("gestione di un diario!");
            string path = @"c:\files\diario.txt";
            /*
                stampare sul diario 
            
                data e ora 
                frase del giorno
            
                data e ora 
                frase del giorno
            */
            string testo=string.Empty;
            if (!File.Exists(path))
                MyLibrary.ScriviFileTesto(path,testo);
                
            Console.Write("inserisci la frase del giorno: ");
            string frase = Console.ReadLine();
            try
            {
                testo = MyLibrary.LeggiFileTesto(path);
                testo += (testo.Length!=0 ? "\n":"")+DateTime.Now.ToString() + "\n" + frase;
                MyLibrary.ScriviFileTesto(path,testo);
                Console.WriteLine(MyLibrary.LeggiFileTesto(path));


            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

        }
    }
}