using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAuto
{
    public class Auto
    {
        public string Marca { get; set; }
        public string Modello { get; set; }
        public int Cilindrata { get; set; }
        public Carburante Carburante { get; set; }
        public string Colore { get; set; }

        public double VelocitaMax()
        {
            double velocita = Cilindrata / 10;
            switch (Carburante)
            {
                case Carburante.Benzina: velocita += 30; break;
                case Carburante.Disel: velocita += 10; break;
                case Carburante.GPL: velocita -= 10; break;
                case Carburante.Metano: velocita -= 30; break;
                default: velocita += 0; break;
            }
            return velocita;
        }

        public override string ToString()
        {
            return $"{{{nameof(Marca)}={Marca}, {nameof(Modello)}={Modello}, {nameof(Cilindrata)}={Cilindrata.ToString()}, {nameof(Carburante)}={Carburante.ToString()}, {nameof(Colore)}={Colore},{(VelocitaMax().ToString())} }}";
        }
    }
}
