using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Vuoto.Models
{
    public class ContattoViewModel
    {
        public string Nominativo { get; set; }
        public string Email { get; set; }
        public string Oggetto { get; set; }
        public string Messaggio { get; set; }

        public override string ToString()
        {
            return $"Data: {DateTime.Now}" +
                $"{nameof(Nominativo)}={Nominativo}" +
                $", {nameof(Email)}={Email}," +
                $" {nameof(Oggetto)}={Oggetto}, " +
                $"{nameof(Messaggio)}={Messaggio}}}";
        }
    }


}