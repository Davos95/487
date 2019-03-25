using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebJobTitulares.Data;
using WebJobTitulares.Models;

namespace WebJobTitulares.Repositories
{
    public class RepositoryBbdd
    {
        NoticiasContext context;
        public RepositoryBbdd()
        {
            this.context = new NoticiasContext();
        }
        public int GetMaxNoticia()
        {
            var consulta = this.context.Noticias;
            if(consulta.Count() == 0)
            {
                return 1;
            } else
            {
                return consulta.Max(z => z.idTitular) + 1;
            }
        }
        public void ActualizarNoticias(List<Noticia> noticias)
        {
            int id = this.GetMaxNoticia();
            foreach (Noticia no in noticias)
            {
                no.idTitular = id;
                no.Fecha = DateTime.Now;
                id += 1;
                this.context.Noticias.Add(no);
            }
            this.context.SaveChanges();
        }
        
    }
}
