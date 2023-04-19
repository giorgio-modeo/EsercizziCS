using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atleti
{
    public class Calciatore:Atleta,ICloneable,IComparable
    {
        public string Club { get; set; }
        public int PartiteGiocate { get; set; }
        public int GoalSegnati { get; set; }

        public object Clone()
        {
            if(PartiteGiocate==0)
                throw new NotSupportedException();
            return this.MemberwiseClone();

        }

        public int CompareTo(object? obj)
        {
            // 1 => this.media > calciatore.media
            // -1 => this.media < calciatore.media
            // 0 => tutti gli altri casi
            if(obj is Calciatore calciatore)
                if(this.MediaGoalSegnati() > calciatore.MediaGoalSegnati())
                    return 1;
                else if(this.MediaGoalSegnati() < calciatore.MediaGoalSegnati())
                    return -1;
            return 0;
        }

        public override bool Equals(object? obj)
        {
            return obj is Calciatore calciatore &&
                   Nominativo == calciatore.Nominativo &&
                   Disciplina == calciatore.Disciplina &&
                   Pettorina == calciatore.Pettorina &&
                   Club == calciatore.Club &&
                   PartiteGiocate == calciatore.PartiteGiocate &&
                   GoalSegnati == calciatore.GoalSegnati;
        }

        public double MediaGoalSegnati(){
            return (double)GoalSegnati / PartiteGiocate;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"{{{nameof(Club)}={Club}," +
                $" {nameof(PartiteGiocate)}={PartiteGiocate.ToString()}, " +
                $"{nameof(GoalSegnati)}={GoalSegnati.ToString()}," +
                $"Media dei goal={MediaGoalSegnati()}" ;
        }

    }
}
