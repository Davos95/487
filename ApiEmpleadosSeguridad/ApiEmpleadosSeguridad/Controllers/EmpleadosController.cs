using ApiEmpleadosSeguridad.Models;
using ApiEmpleadosSeguridad.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiEmpleadosSeguridad.Controllers
{
    public class EmpleadosController : ApiController
    {
        RepositoryEmpleados repo;
        public EmpleadosController()
        {
            this.repo = new RepositoryEmpleados();
        }

        [Authorize]
        public List<Empleado> GetEmpleados()
        {
            return this.repo.GetEmpleados();
        }

        
        public Empleado Get(int id)
        {
            return this.repo.BuscarEmpleado(id);
        }

    }
}
