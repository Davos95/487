using ApiTablasToken.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiTablasToken.Controllers
{
    public class CursoController : ApiController
    {
        RepositoryTablaToken repo;
        public CursoController()
        {
            this.repo = new RepositoryTablaToken();
        }

        [HttpGet]
        [Route("api/Token/{curso}")]
        public String Token(String curso)
        {
            return this.repo.GetToken(curso);
        }
    }
}
