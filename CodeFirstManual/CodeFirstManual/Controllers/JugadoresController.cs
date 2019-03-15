using CodeFirstManual.Models;
using CodeFirstManual.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstManual.Controllers
{
    public class JugadoresController : Controller
    {
        RepositoryJugador repo;
        public JugadoresController()
        {
            this.repo = new RepositoryJugador();
        }
        // GET: Jugadores
        public ActionResult Index()
        {
            List<Jugador> jugadores = this.repo.GetJugadores();
            return View(jugadores);
        }

        public ActionResult Details(int id)
        {
            Jugador jugador = this.repo.BuscarJugador(id);
            return View(jugador);
        }

        public ActionResult Edit(int id)
        {
            Jugador jugador = this.repo.BuscarJugador(id);
            return View(jugador);
        }

        [HttpPost]
        public ActionResult Edit(Jugador jugador)
        {
            this.repo.ModificarJugador(jugador.JugadorId, jugador.Nombre, jugador.Calidad);
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Jugador jugador)
        {
            this.repo.InsertarJugador(jugador.Nombre, jugador.Calidad);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            this.repo.EliminarJugador(id);
            return RedirectToAction("Index");
        }



    }
}