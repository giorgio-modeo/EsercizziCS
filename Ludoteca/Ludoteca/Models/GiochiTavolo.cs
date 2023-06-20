using System;
using System.Collections.Generic;

namespace Ludoteca.Models
{
    public partial class GiochiTavolo
    {
        public GiochiTavolo()
        {
            Prestitis = new HashSet<Prestiti>();
        }

        public int IdGioco { get; set; }
        public string Denominazione { get; set; } = null!;
        public string Descrizione { get; set; } = null!;
        public int? IdTipologia { get; set; }
        public string EtàGiocatori { get; set; } = null!;
        public string NumeroGiocatori { get; set; } = null!;
        public string DurataPartita { get; set; } = null!;
        public string PezziDisponibili { get; set; } = null!;

        public virtual Tipologium? IdTipologiaNavigation { get; set; }
        public virtual ICollection<Prestiti> Prestitis { get; set; }
    }
}
