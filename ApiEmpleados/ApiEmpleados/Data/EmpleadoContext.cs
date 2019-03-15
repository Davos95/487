using ApiEmpleados.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApiEmpleados.Data
{
    public class EmpleadoContext: DbContext
    {
        public EmpleadoContext():base("name=cadenaHospital") { }

        public DbSet<Empleado> Empleados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<EmpleadoContext>(null);
        }
    }
}