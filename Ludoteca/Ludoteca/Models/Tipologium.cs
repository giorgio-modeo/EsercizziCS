using System;
using System.Collections.Generic;

namespace Ludoteca.Models
{
    public partial class Tipologium
    {
        public Tipologium()
        {
            GiochiTavolos = new HashSet<GiochiTavolo>();
        }

        public int IdTipologia { get; set; }
        public string Tipologia { get; set; } = null!;

        public virtual ICollection<GiochiTavolo> GiochiTavolos { get; set; }
    }
}
