using ILogicaEmpleado.Data;
using ILogicaEmpleado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILogicaEmpleado.Repositories
{
    public class RepositoryEmpleados
    {
        EmpleadosContext context;
        public RepositoryEmpleados()
        {
            this.context = new EmpleadosContext();
        }

        public List<String> GetOficios()
        {
            var consulta = (from datos in context.Empleados
                           select datos.Oficio).Distinct();
            return consulta.ToList();
        }

        public List<Empleado> GetEmpleadosOficio(String oficio)
        {
            var consulta = from datos in context.Empleados
                           where datos.Oficio == oficio
                           select datos;
            return consulta.ToList();
        }
    }
}
