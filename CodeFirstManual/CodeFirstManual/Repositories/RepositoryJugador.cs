using CodeFirstManual.Data;
using CodeFirstManual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstManual.Repositories
{
    public class RepositoryJugador
    {
        JugadoresContext context;

        public RepositoryJugador()
        {
            this.context = new JugadoresContext();
        }

        public List<Jugador> GetJugadores()
        {
            var consulta = from datos in context.Jugadores
                           select datos;
            if (consulta.Count() == 0)
            {
                return null;
            }
            else
            {
                return consulta.ToList();
            }
        }

        public Jugador BuscarJugador(int idjugador)
        {
            var consulta = from datos in context.Jugadores
                           where datos.JugadorId == idjugador
                           select datos;
            return consulta.FirstOrDefault();
        }

        public int GetMaximoJugadorId()
        {
            var consulta = from datos in context.Jugadores
                           select datos;
            if (consulta.Count() == 0)
            {
                return 1;
            }
            else
            {
                return consulta.Max(z => z.JugadorId) + 1;
            }
        }

        public void InsertarJugador(String nombre, int calidad)
        {
            Jugador j = new Jugador();
            j.JugadorId = GetMaximoJugadorId();
            j.Nombre = nombre;
            j.Calidad = calidad;
            context.Jugadores.Add(j);
            context.SaveChanges();
        }

        public void ModificarJugador(int idjugador, String nombre, int calidad)
        {
            Jugador j = this.BuscarJugador(idjugador);
            j.Nombre = nombre;
            j.Calidad = calidad;
            context.SaveChanges();
        }

        public void EliminarJugador(int idjugador)
        {
            Jugador j = this.BuscarJugador(idjugador);
            context.Jugadores.Remove(j);
            context.SaveChanges();
        }
    }
}