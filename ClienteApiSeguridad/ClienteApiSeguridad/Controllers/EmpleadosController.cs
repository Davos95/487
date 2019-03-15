using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClienteApiSeguridad.Models;
using ClienteApiSeguridad.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClienteApiSeguridad.Controllers
{
    public class EmpleadosController : Controller
    {
        RepositoryEmpleados repo;
        public EmpleadosController(RepositoryEmpleados repo)
        {
            this.repo = repo;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(String usuario, String password)
        {
            String token = await this.repo.GetToken(usuario, password);
            if(token != null)
            {
                HttpContext.Session.SetString("token", token);
                ViewData["MENSAJE"] = "usuario valido";
                return RedirectToAction("Subordinados");
            } else
            {
                ViewData["MENSAJE"] = "USUARIO/PASSWORD incorrectos";
                return View();
            }
            
        }

        public async Task<IActionResult> Subordinados()
        {
            String token = HttpContext.Session.GetString("token");
            List<Empleado> empleados = await this.repo.GetSubordinados(token);
            return View(empleados);
        }

        public async Task<IActionResult> DetallesEmpleado (int empno)
        {
            Empleado empleado = await this.repo.BuscarEmpleado(empno);
            return View(empleado);
        }

    }
}