using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFileAzure.Models
{
    public class Pelicula
    {
        public String titulo { get; set; }
        public String tituloOriginal { get; set; }
        public String descripcion { get; set; }
        public String poster { get; set; }
        public List<Escena> escenas { get; set; }
    }
}