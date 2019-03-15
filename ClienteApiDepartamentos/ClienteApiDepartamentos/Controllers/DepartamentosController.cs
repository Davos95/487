using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClienteApiDepartamentos.Models;
using ClienteApiDepartamentos.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ClienteApiDepartamentos.Controllers
{
    public class DepartamentosController : Controller
    {
        RepositoryDepartamentos repo;
        public DepartamentosController(RepositoryDepartamentos repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DepartamentosCliente()
        {

            return View();
        }
        
        public async Task<IActionResult> DepartamentosServidor()
        {
            List<Departamento> departamentos = await this.repo.GetDepartamentosAync();
            return View(departamentos);
        }

        public async Task<IActionResult> DetallesDepartamento(int deptno)
        {
            Departamento dept = await this.repo.BuscarDepartamentosAync(deptno);
            return View(dept);
        }

        public IActionResult InsertarDepartamento()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> InsertarDepartamento(Departamento dept)
        {
            await this.repo.InsertarDepartamentoAsync(dept.Numero, dept.Nombre, dept.Localidad);

            return RedirectToAction("DepartamentosServidor"); 
        }

        public async Task<IActionResult> ModificarDepartamento(int deptno)
        {
            Departamento dept = await this.repo.BuscarDepartamentosAync(deptno);
            return View(dept);
        }
        [HttpPost]
        public async Task<IActionResult> ModificarDepartamento(int deptno, Departamento departamento)
        {
            await this.repo.ModificarDepartamentoAsync(departamento.Numero, departamento.Nombre, departamento.Localidad);
            
            return RedirectToAction("DepartamentosServidor");
        }

        public async Task<IActionResult> EliminarDepartamento(int deptno)
        {
            await this.repo.DeleteDepartamentoAsync(deptno);

            return RedirectToAction("DepartamentosServidor");
        }

        public async Task<IActionResult> EmpleadosDepartamento()
        {
            List<Departamento> departamentos = await this.repo.GetDepartamentosAync();
            ViewData["DEPARTAMENTOS"] = departamentos;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> EmpleadosDepartamento(List<int> depts)
        {
            List<Empleado> empleados = await this.repo.GetEmpleadosDepartamentoAync(depts);

            List<Departamento> departamentos = await this.repo.GetDepartamentosAync();
            ViewData["DEPARTAMENTOS"] = departamentos;
            return View(empleados);
        }
    }
}