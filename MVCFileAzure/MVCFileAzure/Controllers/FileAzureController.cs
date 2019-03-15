using MVCFileAzure.Models;
using MVCFileAzure.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFileAzure.Controllers
{
    public class FileAzureController : Controller
    {
        RepositoryFileAzure repo;
        public FileAzureController()
        {
            this.repo = new RepositoryFileAzure();
        }


        // GET: FileAzure
        public ActionResult Index()
        {
            List<String> files = this.repo.GetAzureFiles();
            return View(files);
        }

        public ActionResult SubirFicheroAzure()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SubirFicheroAzure(HttpPostedFileBase fichero)
        {
            Stream stream = fichero.InputStream;
            String nombre = fichero.FileName;
            this.repo.UploadFile(nombre, stream);
            ViewBag.Mensaje = "Fichero subido";
            return View();
        }

        public ActionResult LeerFichero(String name)
        {
            List<Pelicula> peliculas = this.repo.LeerXML(name);
            return View(peliculas);
        }

       
    }
}