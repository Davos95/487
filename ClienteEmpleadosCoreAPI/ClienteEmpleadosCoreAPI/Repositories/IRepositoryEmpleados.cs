using ClienteEmpleadosCoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteEmpleadosCoreAPI.Repositories
{
    public interface IRepositoryEmpleados
    {
        Task<List<Empleado>> GetEmpleados();

    }
}
