using ILogicaEmpleado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ILogicaEmpleado.Logic
{
    [ServiceContract]
    public interface IServicioEmpleado
    {
        [OperationContract]
        List<String> GetOficios();
        [OperationContract]
        List<Empleado> GetEmpleadosOficio(String oficio);
    }
}
