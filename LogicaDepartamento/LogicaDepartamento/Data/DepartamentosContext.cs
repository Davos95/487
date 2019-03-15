using LogicaDepartamento.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDepartamento.Data
{
    public class DepartamentosContext: DbContext
    {
        public DepartamentosContext() : base("Data Source = sqlxamarin.database.windows.net; Initial Catalog = HOSPITALXAMARIN; Persist Security Info=True;User ID = adminsql; password=Admin123") { }
        public DbSet<Departamentos> Departamentos { get; set; }
    }
}
