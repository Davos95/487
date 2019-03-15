using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClienteAPIPlantilla.Models;
using ClienteAPIPlantilla.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ClienteAPIPlantilla.Controllers
{
    public class PlantillaController : Controller
    {
        IRepositoryApiPlantilla repo;
        public PlantillaController(IRepositoryApiPlantilla repo)
        {
            this.repo = repo;
        }
        public async  Task<IActionResult> Index()
        {
            List<PlantillaComplex> plantilla = await this.repo.GetPlantilla();
            return View(plantilla);
        }
    }
}