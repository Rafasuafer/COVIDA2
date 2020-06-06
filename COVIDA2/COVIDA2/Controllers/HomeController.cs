using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dominio;

namespace COVIDA2.Controllers
{
    public class HomeController : Controller
    {
		Sistema sistema = Sistema.Instancia;
		// GET: Home
		public ActionResult Index()
        {
            return View();
        }
    }
}