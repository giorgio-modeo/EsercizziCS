using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solidi
{
    public class TipoMateriale
    {
        
        public double PesoSpecifico { get; set; }

        public override string ToString()
        {
            return $"Materiale={Denominazzione}, {nameof(PesoSpecifico)}={PesoSpecifico}}}";
        }
    }
}
