using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebJobTitulares.Models;

namespace WebJobTitulares.Data
{
    public class NoticiasContext: DbContext
    {
        public NoticiasContext(): base("name=cadenanoticias") { }
        public DbSet<Noticia> Noticias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<NoticiasContext>(null);
        }
    }
}
