using ApiPlantilla.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApiPlantilla.Data
{
    public class PlantillaContext: DbContext
    {
        public PlantillaContext() : base("name=cadenaHospital") { }

        public DbSet<Hospital> Hospitales { get; set; }
        public DbSet<Plantilla> Plantillas { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<PlantillaContext>(null);
        }
    }

}