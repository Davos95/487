using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClienteEmpleadosCoreAPI.Models;
using ClienteEmpleadosCoreAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ClienteEmpleadosCoreAPI.Controllers
{
    public class EmpleadosController : Controller
    {
        IRepositoryEmpleados repo;
        public EmpleadosController(IRepositoryEmpleados repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EmpleadosCliente()
        {
            return View();
        }
        public async Task<IActionResult> EmpleadosServidor()
        {
            List<Empleado> empleados = await this.repo.GetEmpleados();
            return View(empleados);
        }
        
    }
}