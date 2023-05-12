using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLibrettoStudenti
{
    internal class EsameBiz
    {
        private List<Esame> elenco;
        private string path = @"..\..\..\files\Esami.csv";
        public EsameBiz()
        {
            elenco = new List<Esame>();
            CaricaDati();
        }
        private void CaricaDati()
        {
            string dati = MyLibrary.LeggiFileTesto(path);
            string[] righe = dati.Split('\n');
            for(int i=0;i<righe.Length;i++)
            {
                string[] contenuti = righe[i].Split(';'); 
                elenco.Add(
                    new Esame { Coginome = contenuti[0]
                    , Nome = contenuti[1]
                    , Materia = contenuti[2]
                    , Data = DateTime.Parse(contenuti[3])
                    , Voto = int.Parse(contenuti[4])
                });  
            }
        }
        public string Stampa()
        {
            return string.Join("\n", elenco);
        }
        //media globale degli esami sostenuti
        public double MediaEsami()
        {
            int somma = 0;
            foreach(var e in elenco)
            {
                somma += e.Voto;

            }
            return (double)somma;
        }
        public List<Esame>EsamiPerStudente(string cognome) { 
            var list = new List<Esame>();
            foreach (var e in elenco)
                if (e.Coginome == cognome)
                    list.Add(e);
            return list;
         }
        public List<Esame> EsamiPerMateria(string materia)
        {
            var list = new List<Esame>();
            foreach (var e in elenco)
                if (e.Materia == materia)
                    list.Add(e);
            return list;
        }
        public int NumeroEsamiPerStudente(string cognome)
        {
            return EsamiPerMateria(cognome).Count;
        }

        public override string? ToString()
        {
            return Stampa();
        }
    }
}
