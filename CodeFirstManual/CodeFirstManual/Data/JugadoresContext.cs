using CodeFirstManual.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CodeFirstManual.Data
{
    public class JugadoresContext: DbContext
    {
        public JugadoresContext() : base("name=cadenaHospital") { }
        public DbSet<Jugador> Jugadores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}