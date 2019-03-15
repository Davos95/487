using ApiPlantilla.Models;
using ApiPlantilla.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiPlantilla.Controllers
{
    public class PlantillaController : ApiController
    {
        RepositoryPlantilla repo;
        public PlantillaController()
        {
            this.repo = new RepositoryPlantilla();
        }
        //api/Plantilla
        public List<PlantillaComplex> GetPlantilla()
        {
            return this.repo.GetPlantilla();
        }
        //api/PlantillaFuncion/{funcion}
        [HttpGet]
        [Route("api/PlantillaFuncion/{funcion}")]
        public List<PlantillaComplex> GetPlantillaFuncion(String funcion)
        {
            return this.repo.GetPlantillaFuncion(funcion);
        }
        [HttpGet]
        [Route("api/Funciones")]
        public List<String> GetFunciones()
        {
            return this.repo.GetFunciones();
        }
    }
}
