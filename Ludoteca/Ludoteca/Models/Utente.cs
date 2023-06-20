using System;
using System.Collections.Generic;

namespace Ludoteca.Models
{
    public partial class Utente
    {
        public string CodiceFiscale { get; set; } = null!;
        public string Cognome { get; set; } = null!;
        public string Nome { get; set; } = null!;
        public DateTime DataNascita { get; set; }
        public string LuogoNascita { get; set; } = null!;
        public string Indirizzo { get; set; } = null!;
        public string Cap { get; set; } = null!;
        public string Città { get; set; } = null!;
        public string Provincia { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int IdPrestito { get; set; }

        public virtual Prestiti IdPrestitoNavigation { get; set; } = null!;
    }
}
