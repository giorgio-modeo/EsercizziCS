using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeoGiorgio_Esercitazione1
{
    public class Bancomat
    {
        public int Cinquanta { get; set; }
        public int Venti { get; set; }
        public int Dieci { get; set; }


        public bool Prelievo(int importo)
        {
            int restante = importo;

            int CinquantaUtilizzate = Math.Min(restante / 50, Cinquanta);
            restante -= CinquantaUtilizzate * 50;

            int VentiUtilizzate = Math.Min(restante / 20, Venti);
            restante -= VentiUtilizzate * 20;

            int DieciUtilizzate = Math.Min(restante / 10, Dieci);
            restante -= DieciUtilizzate * 10;

            if (restante == 0)
            {
                Cinquanta -= CinquantaUtilizzate;
                Venti -= VentiUtilizzate;
                Dieci -= DieciUtilizzate;
                Console.WriteLine($"Prelievo di {importo} riuscito!");
                return true;
            }
            else
            {
                Console.WriteLine($"Prelievo di {importo} non riuscito!");
                return false;
            }
        }


        public string StampaDisponibilità()
        {
            return $"Banconote da 50: {Cinquanta}\n" +
                   $"Banconote da 20: {Venti}\n"+
                   $"Banconote da 10: {Dieci}";
        }
        public string TotaleSoldi()
        {
            int totale = Cinquanta * 50 + Venti * 20 + Dieci * 10;
            return $"Totale: {totale}Euro";
        }

        public bool Togli50(int n)
        {
            if (Cinquanta >= n)
            {
                Cinquanta -= n;
                return true;
            }
            else
            {
                return false;
            }
        }

    }

}
