using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persone
{
    public class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataNascita { get; set; }
        public string LugoNascita { get; set; }
        public Sesso Sesso { get; set; }
        public int Eta()
        {
            int e = DateTime.Now.Year-DataNascita.Year;
            if (DateTime.Now.Month < DataNascita.Month)
                e--;
            else if (DateTime.Now.Month < DataNascita.Month && DateTime.Now.Day < DataNascita.Day)
                e--;
            return e;
        }

        public override string ToString()
        {
            return $"{{{nameof(Nome)}={Nome}, {nameof(Cognome)}={Cognome} , {nameof(DataNascita)}={DataNascita.ToString()}, {nameof(LugoNascita)}={LugoNascita}, {nameof(Sesso)}={Sesso.ToString()}}}";
        }
    }
}
