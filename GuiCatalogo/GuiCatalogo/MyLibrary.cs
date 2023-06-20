using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace GuiCatalogo
{
    public class MyLibrary
    {
        public static List<Prodotto> LeggiFileOggetti(string path) {
            
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            var elenco = bf.Deserialize(fs) as List<Prodotto>;
            fs.Close();

            return elenco;
        }
        public static List<Prodotto> LeggiFilecsv(string path)
        {
            var lista = new List<Prodotto>();

            StreamReader sr = new StreamReader(path);
            string txt = sr.ReadToEnd();
            sr.Close();
            string[] righe = txt.Split('\n');

            foreach (var item in righe)
            {
                string[] dati = item.Split(";");
                lista.Add(
                    new Prodotto
                    {
                        Codice = Convert.ToInt32(dati[0]),
                        Denominazione = dati[1],
                        Prezzo = Convert.ToDouble(dati[2]),
                        Giacenza = Convert.ToInt32(dati[3])
                    }
                    );
            }

            return lista;
        }


        public static void ScriviFileOggetti(string path, List<Prodotto> elenco) {

            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                        
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, elenco);

            fs.Close();

        }

        public static void ScriviFileCS(string path, List<Prodotto> elenco)
        {
            string txt = string.Empty;
            foreach (var item in elenco)
                txt += (txt.Length!=0 ? "\n":"")+item.ExportCSV();
            

            StreamWriter sw = new StreamWriter(path);
            sw.Write(txt);
            
            sw.Flush()
            sw.Close();
        }
    }
}
