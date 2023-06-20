using MVC_Vuoto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Vuoto.Controllers
{
    public class ProdottiController : Controller
    {
        // GET: Prodotti
        public ActionResult Index()
        {
            var prodotto=new Prodotto { Codice=1,
                Denominazzione="a",
                Descrizzione="b",
                Giacenza=3,
                Prezzo=12.50};
            return View(prodotto);
        }
    }
}