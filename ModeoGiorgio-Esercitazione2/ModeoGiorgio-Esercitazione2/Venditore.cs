using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeoGiorgio_Esercitazione2
{
    public class Venditore:Persona
    {
        public string Settore { get; set; }
        public override double Tredicesima() => Stipendio * 1.91;
        public Venditore Clone()
        {
            return (Venditore)this.MemberwiseClone();
        }

        public override string ToString()
        {
            return base.ToString() + 
                $"{{{nameof(Settore)}={Settore}," +
                $" Tredicesima = {Tredicesima()}";
        }
    }
}
