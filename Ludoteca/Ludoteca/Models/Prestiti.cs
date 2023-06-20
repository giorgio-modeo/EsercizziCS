using System;
using System.Collections.Generic;

namespace Ludoteca.Models
{
    public partial class Prestiti
    {
        public Prestiti()
        {
            Utentes = new HashSet<Utente>();
        }

        public int IdPrestito { get; set; }
        public DateTime DataPrestito { get; set; }
        public DateTime DataRestituzione { get; set; }
        public string? Note { get; set; }
        public int IdGioco { get; set; }

        public virtual GiochiTavolo IdGiocoNavigation { get; set; } = null!;
        public virtual ICollection<Utente> Utentes { get; set; }
    }
}
