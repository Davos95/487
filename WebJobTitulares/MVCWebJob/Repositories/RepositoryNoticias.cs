using MVCWebJob.Data;
using MVCWebJob.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebJob.Repositories
{
    public class RepositoryNoticias
    {
        NoticiasContext context;
        public RepositoryNoticias()
        {
            this.context = new NoticiasContext();
        }

        public List<Noticia> GetNoticias()
        {
            var consulta = from datos in context.Noticias
                           orderby datos.idTitular descending
                           select datos;
            return consulta.ToList();
        }
    }
}