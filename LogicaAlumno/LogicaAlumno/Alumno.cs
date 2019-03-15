using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAlumno
{
    [DataContract]
    public class Alumno
    {
        [DataMember]
        public int IdAlumno { get; set; }
        [DataMember]
        public String Nombre { get; set; }
        [DataMember]
        public String Apellido { get; set; }
        [DataMember]
        public int Nota { get; set; }

    }
}
