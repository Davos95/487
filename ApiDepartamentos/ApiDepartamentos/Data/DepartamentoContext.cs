using ApiDepartamentos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApiDepartamentos.Data
{
    public class DepartamentoContext: DbContext
    {
        public DepartamentoContext():base("name=cadenaHospital") { }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<DepartamentoContext>(null);
        }
    }
}