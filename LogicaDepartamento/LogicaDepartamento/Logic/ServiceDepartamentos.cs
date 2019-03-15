using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaDepartamento.Models;
using LogicaDepartamento.Repositories;

namespace LogicaDepartamento.Logic
{
    public class ServiceDepartamentos : IServiceDepartamentos
    {
        RepositoryDepartamentos repo;

        public ServiceDepartamentos()
        {
            this.repo = new RepositoryDepartamentos();
        }

        public List<Departamentos> GetDepartamentos()
        {
            return this.repo.GetDepartamentos();
        }

        public Task<List<Departamentos>> GetDepartamentosAsynca()
        {
            return this.repo.GetDepartamentosAsync();
        }
    }
}
