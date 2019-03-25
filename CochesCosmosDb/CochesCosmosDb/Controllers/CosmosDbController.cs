using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CochesCosmosDb.Models;
using CochesCosmosDb.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CochesCosmosDb.Controllers
{
    public class CosmosDbController : Controller
    {
        RepositoryCosmosDB repo;
        public CosmosDbController(RepositoryCosmosDB repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            List<Vehiculo> vehiculos = this.repo.GetVehiculos();
            return View(vehiculos);
        }
        [HttpPost]
        public async Task <IActionResult> Index(String accion)
        {
            //await this.repo.CrearBbddVehiculosAsync();
            //await this.repo.CrearColeccionVehiculosAsync();
            //List<Vehiculo> coches = this.repo.GetListaBaseVehiculos();
            //foreach (Vehiculo car in coches)
            //{
            //    await this.repo.InsertarVehiculo(car);
            //}

            List<Vehiculo> vehiculos = this.repo.GetVehiculos();
            
            Vehiculo vehiculo = await this.repo.BuscarVehiculoAsync("1");
            ViewData["CAR"] = vehiculo;
            return View(vehiculos);
        }
        public async Task<IActionResult> DetallesVehiculo(string idvehiculo)
        {
            Vehiculo vehiculo = await this.repo.BuscarVehiculoAsync(idvehiculo);
            return View(vehiculo);
        }

        public IActionResult InsertarCoche()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> InsertarCoche(Vehiculo car, String incluirmotor)
        {
            if(incluirmotor == null)
            {
                //Limpiamos el motor del coche
                car.Motor = null;
            }
            await this.repo.InsertarVehiculo(car);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> EliminarVehiculo(string idvehiculo)
        {
            await this.repo.EliminarVehiculo(idvehiculo);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> ModificarVehiculo(String idvehiculo)
        {
            Vehiculo car = await this.repo.BuscarVehiculoAsync(idvehiculo);
            return View(car);
        }

        [HttpPost]
        public async Task<IActionResult> ModificarVehiculo(Vehiculo car, String incluirmotor)
        {
            if (incluirmotor == null)
            {
                //Limpiamos el motor del coche
                car.Motor = null;
            }
            await this.repo.ModificarVehiculo(car);
            return RedirectToAction("Index");
        }
        public IActionResult BuscarVehiculo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BuscarVehiculo(String marca)
        {
            List<Vehiculo> coches = this.repo.BuscarVehiculoMarca(marca);
            return View(coches);
        }

    }
}