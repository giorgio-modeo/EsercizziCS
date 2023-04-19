using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solidi
{
    internal class Cilindro:Solido
    {
        public double Altezza { get; set;}
        public double Raggio { get; set;}

        public override double Volume() => Math.PI * Math.Pow(Raggio, 2) * Altezza;
        public override string ToString()
        {
            return $"Raggio={Raggio}, Altezza={Altezza}, " + base.ToString();
        }
    }
}
