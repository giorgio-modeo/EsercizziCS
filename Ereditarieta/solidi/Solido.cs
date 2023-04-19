using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solidi
{
    public abstract class Solido
    {

        public Materiale Materiale { get; set; }
        public abstract double Volume();
        public double Peso()
        {
            return Materiale.PesoSpecifico*Volume();
        }

        public override string ToString()
        {
            return $"{Materiale}" +
                $", Peso={Peso()}" +
                $", Volume = {Volume()}";
        }
    }
}
