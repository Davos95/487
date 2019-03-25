using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrar
{
    public class Alumno: TableEntity
    {
        private String _IdAlumno;
        private String _Curso;
        public String IdAlumno
        {
            get
            {
                return this._IdAlumno;
            }
            set
            {
                this._IdAlumno = value;
                this.RowKey = value;
            }
        }

        public String Curso
        {
            get
            {
                return this._Curso;
            }
            set
            {
                this._Curso = value;
                this.PartitionKey = value;
            }
        }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Nota { get; set; }

    }
}
