using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClienteApiSeguridadCore.Filters;
using ClienteApiSeguridadCore.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ClienteApiSeguridadCore.Controllers
{
    public class EmpleadosController : Controller
    {
        IRepositoryApiEmpleados repo;
        public EmpleadosController(IRepositoryApiEmpleados repo)
        {
            this.repo = repo;
        }

        [EmpleadosAuthorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}