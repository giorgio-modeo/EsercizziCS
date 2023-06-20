using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public class Cliente
    {
        public String CodFiscale { get; set; }
        public String Nome { get; set; }
        public String Cognome { get; set; }
        public Sesso RecuperoSesso() 
        {
            int giorno = int.Parse(CodFiscale.Substring(9,2))-4;
            return giorno >= 0 ? Sesso.F : Sesso.M;
        }
        public DateTime RecuperoDataNascita()
        {
            char[] mesiCodfiscale = { 'A', 'B', 'C', 'D', 'E', 'H','L','M','P','R','S','T' };
            int giorno = int.Parse(CodFiscale.Substring(9, 2))+ (RecuperoSesso() == Sesso.F ? -40 : 0);
            int mese = Array.IndexOf(mesiCodfiscale,CodFiscale[8])+1;
            int anno = int.Parse(CodFiscale.Substring(6, 2));
            anno += (anno >= 0 && anno <= DateTime.Now.Year - 2000) ? 2000 : 1900;
            return new DateTime(anno, mese, giorno);

                
        }
        public int RecuperoEta()
        {
            return DateTime.Now.Year - RecuperoDataNascita().Year;
        }
        public override string ToString()
        {
            return $"{nameof(CodFiscale)}={CodFiscale}," +
                $" {nameof(Nome)}={Nome}," +
                $" {nameof(Cognome)}={Cognome}," +
                $"sesso = {RecuperoSesso()}," +
                $"data di nascita = {RecuperoDataNascita()}";

        }
    }
}
