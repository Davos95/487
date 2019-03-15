using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAlumno
{
    [ServiceContract]
    public interface IServiceAlumno
    {
        [OperationContract]
        List<Alumno> GetAlumnos();

        [OperationContract]
        Alumno BuscarAlumno(int idAlumno);
    }
}
