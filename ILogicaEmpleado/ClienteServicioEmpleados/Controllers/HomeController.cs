using ClienteServicioEmpleados.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClienteServicioEmpleados.Controllers
{
    public class HomeController : Controller
    {
        RepositoryEmpleados repo;
        public HomeController()
        {
            this.repo = new RepositoryEmpleados();
        }

        public ActionResult Index()
        {
            List<String> oficios = this.repo.GetOficios();
            ViewBag.Oficios = oficios;
            return View();
        }
        [HttpPost]
        public ActionResult Index(String oficio)
        {
            List<String> oficios = this.repo.GetOficios();
            ViewBag.Oficios = oficios;

            return View(this.repo.GetEmpleadosOficio(oficio));
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