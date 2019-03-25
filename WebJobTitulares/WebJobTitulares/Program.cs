using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebJobTitulares.Models;
using WebJobTitulares.Repositories;

namespace WebJobTitulares
{
    class Program
    {
        static void Main(string[] args)
        {
            RepositoryRSS reporss = new RepositoryRSS();
            List<Noticia> noticias = reporss.GetNoticiasRss();
            //foreach (Noticia no in noticias)
            //{
            //    Console.WriteLine(no.Titular);
            //}
            RepositoryBbdd repoBbdd = new RepositoryBbdd();
            repoBbdd.ActualizarNoticias(noticias);
            //Console.WriteLine("Noticias Actualizadas");
            //Console.WriteLine("Pulse para finalizar");
            //Console.ReadLine();
        }
    }
}
