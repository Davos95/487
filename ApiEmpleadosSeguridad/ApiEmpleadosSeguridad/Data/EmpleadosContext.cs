﻿using ApiEmpleadosSeguridad.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApiEmpleadosSeguridad.Data
{
    public class EmpleadosContext: DbContext
    {
        public EmpleadosContext() : base("name=cadenaHospital") { }
        public DbSet<Empleado> Empleados { get; set; }
    }
}