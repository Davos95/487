using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServicioCollatz;

namespace ClienteCoreCollatz.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(int numero)
        {
            CollatzClient client = new CollatzClient();
            
            int[] numeros = await client.ConjeturaCollatzAsync(numero);
            return View(numeros);
        }
    }
}