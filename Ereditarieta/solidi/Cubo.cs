using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solidi
{
    public class Cubo:Solido
    {
        public double Lato { get; set; }


        public override double Volume()
        {
            return Math.Pow(Lato,3);
        }
        public override string ToString()
        {
            return $"Lato = {Lato}, "+
                base.ToString();
        }

    }
}
