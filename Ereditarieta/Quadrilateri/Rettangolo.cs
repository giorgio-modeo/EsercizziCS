using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrilateri
{
    public class Rettangolo : Quadrilatero
    {
        public Rettangolo(double altezza, double @base) : base(@base,altezza , @base, altezza)
        {

        }
        public double Area() => Lato1 * Lato2;

        public double Diagonale() => Math.Sqrt(Math.Pow(Lato1,2)+Math.Pow(Lato2,2));

        public override string ToString() =>
            $"{{Base = {Lato1.ToString()}," +
            $" Altezza = {Lato2.ToString()}," +
            $" Perimetro ={Perimetro()}," +
            $" Diagonale ={Area()}"+
            $" Diagonale ={Diagonale()}}}";    
    }
}
