using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
namespace LogicaAlumno
{
    public class ServiceAlumno : IServiceAlumno
    {
        public XDocument GetDocumentoXmlAlumno()
        {
            //EL DOCUMENTO XML ESTA INCRUTADO DENTRO DEL ASSEMBLY
            //PARA PODER LEER CUALQUIER RECURSO, NECESITAMOS UN Stream 
            //Y EL NOMBRE DEL ASSEMBLY DONDE ESTAMOS RECUPERANDO EL RECURSO
            //Esamblado = NameSpace.recurso.extension
            //Si esta en una carpeta, es igual
            String esamblado = "LogicaAlumno.alumnos.xml";
            Stream datos = this.GetType().Assembly.GetManifestResourceStream(esamblado);
            XDocument docxml = XDocument.Load(datos);
            return docxml;
        }
        public Alumno BuscarAlumno(int idAlumno)
        {

            return this.GetAlumnos().SingleOrDefault(x => x.IdAlumno == idAlumno);
        }

        public List<Alumno> GetAlumnos()
        {
            XDocument docxml = GetDocumentoXmlAlumno();
            var consulta = from datos in docxml.Descendants("alumno")
                           select new Alumno
                           {
                               IdAlumno = int.Parse(datos.Element("idalumno").Value),
                               Nombre = datos.Element("nombre").Value,
                               Apellido = datos.Element("apellidos").Value,
                               Nota = int.Parse(datos.Element("nota").Value)
                           };
            return consulta.ToList();
        }
    }
}
