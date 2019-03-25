using MVCTablasAzure.Models;
using MVCTablasAzure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTablasAzure.Controllers
{
    public class ClientesController : Controller
    {
        RepositoryTablaAzure repo;
        public ClientesController()
        {
            this.repo = new RepositoryTablaAzure();
        }

        // GET: Clientes
        public ActionResult Index()
        {
            List<Cliente> clientes = this.repo.GetClientes();
            return View(clientes);
        }

        [HttpPost]
        public ActionResult Index(String empresa)
        {
            List<Cliente> clientes = this.repo.GetClienteEmpresa(empresa);
            return View(clientes);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Cliente cliente)
        {
            this.repo.CrearCliente(cliente.Empresa, cliente.IdCliente, cliente.Apellidos, cliente.Nombre);
            return RedirectToAction("Index");
        }

        public ActionResult Details(String empresa, String idcliente)
        {
            Cliente cliente = this.repo.BuscarCliente(empresa, idcliente);
            return View(cliente);
        }

        public ActionResult Edit(String empresa, String idcliente)
        {
            Cliente cliente = this.repo.BuscarCliente(empresa, idcliente);
            return View();
        }

        [HttpPost]
        public ActionResult Edit(Cliente cliente)
        {
            this.repo.ModificarCLiente(cliente.Empresa, cliente.IdCliente, cliente.Apellidos, cliente.Nombre);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(String empresa, String idcliente)
        {
            this.repo.EliminarCliente(empresa, idcliente);
            return RedirectToAction("Index");
        }

    }
}