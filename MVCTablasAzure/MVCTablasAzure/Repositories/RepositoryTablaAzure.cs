using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using MVCTablasAzure.Models;

namespace MVCTablasAzure.Repositories
{
    
    public class RepositoryTablaAzure
    {
        CloudTable table;
        public RepositoryTablaAzure()
        {
            String keys = CloudConfigurationManager.GetSetting("cuentastorage");
            CloudStorageAccount account = CloudStorageAccount.Parse(keys);
            CloudTableClient client = account.CreateCloudTableClient();
            this.table = client.GetTableReference("clientesazure");
            this.table.CreateIfNotExists();
        }
        public void CrearCliente(String empresa, String idCliente, String apellido, String nombre)
        {
            //Creamos el objeto entity
            Cliente cli = new Cliente();

            //ALMACENAMOS LA EMPRESA Y, A LA VEZ, SU PARTITION KEY
            cli.Empresa = empresa;

            //Realizamos lo mismo con idCliente y Rowkey
            cli.IdCliente = idCliente;
            cli.Nombre = nombre;
            cli.Apellidos = apellido;

            //CREAMOS LA OPERACION PARA LA TABLA
            TableOperation opration = TableOperation.Insert(cli);

            //LAS OPERACIONES SE EJECUTAN SOBRE LA TABLA
            this.table.Execute(opration);
        }
        //PARA BUSCAR CLIENTES POR SU "ID" DEBEMOS HACERLO POR SU PARTITION KEY Y SU ROW KEY
        public Cliente BuscarCliente(String partitionkey, String rowkey)
        {
            //PARA BUSCAR POR KEY, SE HACE CON TABLEOPERATION
            TableOperation operation = TableOperation.Retrieve<Cliente>(partitionkey, rowkey);
            //EL RESULTADO DE RETRIEVE ES UN TableResult
            TableResult result = this.table.Execute(operation);
            if(result.Result == null)
            {
                return null;
            } else {
                Cliente cli = result.Result as Cliente;
                return cli;
            }
        }

        public void ModificarCLiente(String empresa, String idCliente, String apellido, String nombre)
        {
            Cliente cliente = this.BuscarCliente(empresa, idCliente);
            if(cliente != null)
            {
                cliente.Nombre = nombre;
                cliente.Apellidos = apellido;
                TableOperation operation = TableOperation.Replace(cliente);
                this.table.Execute(operation);
            }

        }


        public void EliminarCliente(String partitionkey, String rowkey)
        {
            Cliente cliente = this.BuscarCliente(partitionkey, rowkey);
            if(cliente != null)
            {
                TableOperation operation = TableOperation.Delete(cliente);
                this.table.Execute(operation);
            }

        }

        public List<Cliente> GetClienteEmpresa(String empresa)
        {
            TableQuery<Cliente> query = new TableQuery<Cliente>();
            List<Cliente> clientes = this.table.ExecuteQuery(query).Where(x => x.Empresa == empresa).ToList();
            return clientes;
        }

        public List<Cliente> GetClientes()
        {
            TableQuery<Cliente> query = new TableQuery<Cliente>();
            List<Cliente> clientes = this.table.ExecuteQuery(query).ToList();
            return clientes;
        }
    }
}