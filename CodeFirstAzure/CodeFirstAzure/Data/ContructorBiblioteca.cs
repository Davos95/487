using CodeFirstAzure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstAzure.Data
{
    public class ContructorBiblioteca: System.Data.Entity.DropCreateDatabaseAlways<LibraryContext>
    {
        protected override void Seed(LibraryContext context)
        {
            base.Seed(context);
            var listaGeneros = new List<Genero>
            {
                new Genero{IdGenero=1,Nombre="algo"}
            };
            listaGeneros.ForEach(l => context.Generos.Add(l));
            context.SaveChanges();
            var listaLibros = new List<Libro>
            {
                new Libro{IdLibro=4,IdGenero=1,Nombre="hssahusdhuisdhui",Sinopsis="qweqrqwrq", Autor="alguien"},
                new Libro{IdLibro=5,IdGenero=1,Nombre="hssahusdhuisdhui",Sinopsis="qweqrqwrq", Autor="alguwien"}
            };
            listaLibros.ForEach(l => context.Libros.Add(l));
            context.SaveChanges();
        }
    }
}