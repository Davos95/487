using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WebJobTitulares.Models;

namespace WebJobTitulares.Repositories
{
    public class RepositoryRSS
    {
        public List<Noticia> GetNoticiasRss()
        {
            String url = "https://www.20minutos.es/rss/";
            XNamespace ns = "http://purl.org/rss/1.0/";
            XDocument docxml = XDocument.Load(url);
            var consulta = from datos in docxml.Descendants(ns+"item")
                           select new Noticia
                           {
                               Titular = datos.Element(ns+"title").Value,
                               Enlace = datos.Element(ns+"link").Value,
                               Descripcion = datos.Element(ns+"description").Value
                           };
            return consulta.ToList();
        }

    }
}
