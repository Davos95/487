using ClienteCollatz.ServicioCollatz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClienteCollatz.Controllers
{
    public class HomeController : Controller
    {
        
        
        public ActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Index(int numero)
        {
            CollatzClient client = new CollatzClient();
            int[] numeros = client.ConjeturaCollatz(numero);
            return View(numeros);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}