using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClienteNumerosAleatorios.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ServiceNumerosAleatorios.WCFNumeroAleatoriosClient cliente =
                new ServiceNumerosAleatorios.WCFNumeroAleatoriosClient("BasicHttpBinding_IWCFNumeroAleatorios");
            int[] listanumeros = cliente.GetListaNumeros();
            return View(listanumeros);
        }

    }
}