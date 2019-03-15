using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ClienteDepartamentos.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Departamentos()
        {
            ServiceReference1.ServiceDepartamentosClient service = new ServiceReference1.ServiceDepartamentosClient();
            ServiceReference1.Departamentos[] departamentos = await service.GetDepartamentosAsyncaAsync();
            return View(departamentos);
        }

        public ActionResult Index()
        {
            return View();
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