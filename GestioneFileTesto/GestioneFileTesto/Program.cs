namespace GestioneFileTesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gestione file di testo");
            string path = @"c:\files\testo.txt";
             
             // scrittura 
             // crea se non essiste o sovrascrive se esiste
             StreamWriter sw = new StreamWriter(path);

             Console.Write("inserisci una frase: ");
             string frase = Console.ReadLine();

             //scrivo la frase presa in input nel file
             sw.WriteLine(frase);

             //salvo le modifiche
             sw.Flush();
             //chiudo la connessione
             sw.Close();
             Console.WriteLine("idati inseriti sono stati salvati con successo");
            
            // lettura
            StreamReader sr = null;
            try
            {
            sr = new StreamReader(path);//apro il file in modalita lettura
            string testo = string.Empty;
            testo = sr.ReadToEnd();//leggo tutto il contenuto del file 
            sr.Close();
            Console.WriteLine($"testo recuperato dalla lettura del file:\n{testo}");
            }catch(FileNotFoundException e) {
                Console.WriteLine("Errore!\nfile non trovato");
                Console.WriteLine($"Errore! {e.Message}");
            }
            //si possono mettere pui di un errore dopo il try
            //e consigiato avere sempre l'exepion generico 
            catch (Exception e) 
            {
                Console.WriteLine("si e verificato un errore");
                Console.WriteLine($"Errore! {e.Message}");
                
            }
            finally
            {
                if (sr!=null)
                {
                    sr.Close();
                }
            }


        }
    }
}