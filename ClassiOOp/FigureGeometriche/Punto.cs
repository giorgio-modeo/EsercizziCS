using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureGeometriche
{
    public class Punto
    {
        public double X { get; set; }
        public double Y { get; set; }

        //metodo 
        //distanza tra due punti 
        public double Distanza(Punto punto)
        {
            //                      this non e obbligatorio ma lo mettiamo per capire acosa ci stiamo riferendo
            return Math.Sqrt(Math.Pow(this.X - punto.X, 2) + Math.Pow(this.Y - punto.Y, 2));
        }
        //distanza di un punto dall'origine
        //overlading di Distanza(Punto punto)
        public double Distanza()
        {
            var o = new Punto { X = 0, Y = 0 };
            return Distanza(o);
            //possiamo utilizzare anche questo modo perche l'oggetto viene inizzializzato a X=0 Y=0
            //return Distanza(new Punto());
        }

        //auto generato grazzie all estensione AutoToString
        public override string ToString()
        {
            return $"{{{nameof(X)}={X.ToString()}, {nameof(Y)}={Y.ToString()}}}";
        }
    }
}
