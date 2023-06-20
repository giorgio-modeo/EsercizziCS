using MVC_Vuoto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVC_Vuoto.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ChiSiamo()
        {
            ViewBag.Messaggio = "Sezzione Chi Siamo";
            ViewData["Informazioni"] = "ASP.NET ";
            return View();
        }
        public ActionResult Contatti()
        {
            var contatti = new ContattoViewModel();
            return View(contatti);
        }
        public ActionResult RecuperoContatti(ContattoViewModel contatto)
        {
            if (contatto == null) { return new HttpStatusCodeResult(HttpStatusCode.BadRequest); }
            return View(contatto);
        }
    }
}