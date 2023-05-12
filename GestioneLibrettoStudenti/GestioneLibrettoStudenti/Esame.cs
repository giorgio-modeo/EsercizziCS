using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLibrettoStudenti
{
    [Serializable]
    public class Esame
    {
        public string Coginome { get; set; }
        public string Nome { get; set; }
        public string Materia { get; set; }
        public DateTime Data { get; set; }
        public int Voto { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(Coginome)}={Coginome}, {nameof(Nome)}={Nome}, {nameof(Materia)}={Materia}, {nameof(Data)}={Data.ToLongDateString()}, {nameof(Voto)}={Voto.ToString()}}}";
        }

    }
}
