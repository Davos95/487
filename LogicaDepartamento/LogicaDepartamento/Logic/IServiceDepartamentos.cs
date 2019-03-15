using LogicaDepartamento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDepartamento.Logic
{
    [ServiceContract]
    public interface IServiceDepartamentos
    {
        [OperationContract]
        List<Departamentos> GetDepartamentos();

        [OperationContract]
        Task<List<Departamentos>> GetDepartamentosAsynca();
    }
}
