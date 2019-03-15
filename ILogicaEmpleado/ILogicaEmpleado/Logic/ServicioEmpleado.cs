using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ILogicaEmpleado.Models;
using ILogicaEmpleado.Repositories;

namespace ILogicaEmpleado.Logic
{
    public class ServicioEmpleado : IServicioEmpleado
    {
        RepositoryEmpleados repo;
        public ServicioEmpleado()
        {
            this.repo = new RepositoryEmpleados();
        }

        public List<Empleado> GetEmpleadosOficio(string oficio)
        {
            return this.repo.GetEmpleadosOficio(oficio);    
        }

        public List<string> GetOficios()
        {
            return this.repo.GetOficios();
        }
    }
}
