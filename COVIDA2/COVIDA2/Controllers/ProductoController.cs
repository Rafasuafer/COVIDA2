using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dominio;

namespace COVIDA2.Controllers
{
    public class ProductoController : Controller
	{
		Sistema sistema = Sistema.Instancia;
		// GET: Producto
		public ActionResult Index()
		{
			ViewBag.productos = sistema.Productos;
			return View();
		}
	}
}