using ApiDepartamentos.Models;
using ApiDepartamentos.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace ApiDepartamentos.Controllers
{
    public class DepartamentosController : ApiController
    {
        RepositoryDepartamento repo;
        public DepartamentosController()
        {
            this.repo = new RepositoryDepartamento();
        }

        //api/Departamentos
        public List<Departamento> GetDepartamentos()
        {
            return this.repo.GetDepartamentos();
        }

        //api/Departamentos/{id}
        public Departamento Get(int id)
        {
            return this.repo.BuscarDepartamento(id);
        }

        //InserDept [HttpPost] [Route("")]
        public void Post(Departamento dept)
        {
            this.repo.InsertarDepartamento(dept.Numero, dept.Nombre, dept.Localidad);
        }
        //PUT: Modificar dept
        //api/Departamentos/{id}
        public void Put(int id, Departamento dept)
        {
            this.repo.ModificarDepartamento(dept.Numero, dept.Nombre, dept.Localidad);
        }

        //api/Departamentos/{id}
        public void Delete(int id)
        {
            this.repo.EliminarDepartamento(id);
        }


        [HttpGet]
        [Route("api/EmpleadosDepartamento")]
        public List<Empleado> EmpleadosDepartamento([FromUri]List<int?> deptno)
        {
            return this.repo.GetEmpleadosDepartamento(deptno);
        }
    }
}