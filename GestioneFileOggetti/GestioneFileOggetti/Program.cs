using FigureGeometriche;
using System.Runtime.Serialization.Formatters.Binary;

namespace GestioneFileOggetti
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("gestione file oggetti!");

            string path = @"c:\files\dati.dat";
            var q = new Quadrato { Lato = 1.1 };
            if (File.Exists(path))
                File.Delete(path);
            //scrittura
                //accesso al file in modalita scrittura
                FileStream fw = new FileStream(path, FileMode.CreateNew,FileAccess.Write);
                //Serializzazione dei dati su disco
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fw, q);
            fw.Close();
            Console.WriteLine("operazzione avvenuta con successo");

            //lettura
            // accesso al file in bodalita lettura
            FileStream fr = new FileStream(path, FileMode.Open,FileAccess.Read);
            
            BinaryFormatter br = new BinaryFormatter(); 
            var q1 = br.Deserialize(fr) as Quadrato;
            fr.Close();
            Console.WriteLine($"dati recuperati: {q1}");
        }
    }
}