using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeoGiorgio_Esercitazione2
{
    public class Meccanico:Persona
    {
        public string Tipologia { get; set; }

        public override double Tredicesima() => Stipendio * 1.91;

        public override bool Equals(object? obj)
        {
            return obj is Meccanico meccanico &&
                   Nome == meccanico.Nome &&
                   Cognome == meccanico.Cognome &&
                   Stipendio == meccanico.Stipendio &&
                   Tipologia == meccanico.Tipologia;
        }

        public override string ToString()
        {
            return base.ToString() + 
                $"{{{nameof(Tipologia)}={Tipologia},";
        }
    }
}
