using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureGeometriche
{
    public class Triangolo
    {
        public double Lato1 { get; set; }
        public double Lato2 { get; set; }
        public double Lato3 { get; set; }

        // costruttore
        public Triangolo(double lato1, double lato2, double lato3)
        {
            Lato1 = lato1;
            Lato2 = lato2;
            Lato3 = lato3;
            if (!IsCostruibile())
                //exeption
                throw new Exception("Con i dati inseriti non e possibile creare un triangolo");
        }

        //overloading - costruisco un triangolo con tre punti
        public Triangolo(Punto punto1, Punto punto2, Punto punto3) :
            this(punto1.Distanza(punto2), punto2.Distanza(punto3), punto3.Distanza(punto1))
        { }
        
        private bool IsCostruibile()
        {
            return Lato1+Lato2>Lato3
                && Lato2+Lato3 > Lato1
                && Lato3+Lato1 > Lato2;
        }

        public double Perimetro()
        {
            return Lato1 + Lato2 + Lato3;
        }
        // formula di Erone
        public double Area() 
        {
            double sp = Perimetro()/2;
            return Math.Sqrt(sp*(sp-Lato1)*(sp-Lato2)*(sp-Lato3));
        }
        public string Tipo()
        {
            if (Lato1 == Lato2 && Lato1 == Lato3)
                return "Equilatero";
            else if (Lato1 == Lato2 || Lato1 == Lato3 || Lato2 == Lato3)
                return "Isoscele";
            return "Scaleno";
        }

        public override string ToString()
        {
            return $"\nLato1: {Lato1}" +
                   $"\nLato2: {Lato2}" +
                   $"\nLato3: {Lato3}" +
                   $"\nPerimetro: {Perimetro()}" +
                   $"\nArea {Area()}" +
                   $"\nTipo {Tipo()}";
        }

    }
}
