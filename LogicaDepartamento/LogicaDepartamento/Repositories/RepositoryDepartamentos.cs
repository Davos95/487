using LogicaDepartamento.Data;
using LogicaDepartamento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDepartamento.Repositories
{
    public class RepositoryDepartamentos
    {
        DepartamentosContext context;

        public RepositoryDepartamentos()
        {
            this.context = new DepartamentosContext();
        }

        public List<Departamentos> GetDepartamentos()
        {
            var consulta = from datos in context.Departamentos
                           select datos;
            return consulta.ToList();
        }

        public Task<List<Departamentos>> GetDepartamentosAsync()
        {
            var consulta = from datos in context.Departamentos
                           select datos;
            // Task.FromResult<TIPO>(resultado)
            return Task.FromResult<List<Departamentos>>(consulta.ToList());
        }
    }
}
