using MVCWebJob.Models;
using MVCWebJob.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebJob.Controllers
{
    public class NoticiasController : Controller
    {
        RepositoryNoticias repo;
        public NoticiasController()
        {
            this.repo = new RepositoryNoticias();
        }

        // GET: Noticias
        public ActionResult Index()
        {
            List<Noticia> noticias = this.repo.GetNoticias();
            return View(noticias);
        }
    }
}