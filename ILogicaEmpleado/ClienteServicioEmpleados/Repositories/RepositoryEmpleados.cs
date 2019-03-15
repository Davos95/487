using ClienteServicioEmpleados.ServicioEmpleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClienteServicioEmpleados.Repositories
{
    public class RepositoryEmpleados
    {

        ServicioEmpleadoClient service;
        public RepositoryEmpleados()
        {
            this.service = new ServicioEmpleadoClient();
        }
        public List<String> GetOficios()
        {
            return this.service.GetOficios().ToList();
        }
        public List<Empleado> GetEmpleadosOficio(String oficio)
        {
            return this.service.GetEmpleadosOficio(oficio).ToList();
        }
    }
}