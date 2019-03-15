using ILogicaEmpleado.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILogicaEmpleado.Data
{
    public class EmpleadosContext: DbContext
    {
        public EmpleadosContext() : base("name=cadenaHospital") { }
        public DbSet<Empleado> Empleados { get; set; }
    }
}
