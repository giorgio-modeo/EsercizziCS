using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureGeometriche
{
    public class Quadrato
    {
        //proprietà
        public double Lato { get; set; }

        //metodi
        public double Perimetro()
        {
            return Lato*4;
        }
        public double Area()
        {
            return Lato*Lato;
        }
        public double Diagonale()
        {
            return Lato * Math.Sqrt(2);
        }

        
        public override string ToString()
        {
            return $"Lato: {Lato}"+
                   $"\nPerimetro: {Perimetro()}"+
                   $"\nArea {Area()}"+
                   $"\nDiagonale: {Diagonale()}";
        }
    }
}
