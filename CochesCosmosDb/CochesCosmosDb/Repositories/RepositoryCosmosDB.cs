using CochesCosmosDb.Models;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CochesCosmosDb.Repositories
{
    public class RepositoryCosmosDB
    {
        IConfiguration configuration;
        String bbdd;
        String collection;
        DocumentClient client;

        public RepositoryCosmosDB(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.bbdd = "Vehiculos_BBDD";
            this.collection = "vehiculosCollection";
            String endpoint = configuration["CosmosDb:endpoint"];
            String primarykey = configuration["CosmosDb:primarykey"];
            this.client = new DocumentClient(new Uri(endpoint), primarykey);
        }
        public async Task CrearBbddVehiculosAsync()
        {
            Database bbdd = new Database() { Id = this.bbdd };
            await this.client.CreateDatabaseAsync(bbdd);
        }

        public async Task CrearColeccionVehiculosAsync()
        {
            DocumentCollection collection = new DocumentCollection() { Id = this.collection };
            //Crea la URI de la base de datos para implementar la colleción
            await this.client.CreateDocumentCollectionAsync(UriFactory.CreateDatabaseUri(this.bbdd), collection);
        }

        public async Task InsertarVehiculo(Vehiculo car)
        {
            await this.client.CreateDocumentAsync(UriFactory.CreateDocumentCollectionUri(this.bbdd, this.collection), car);
        }

        public async Task<Vehiculo> BuscarVehiculoAsync(String idVehiculo)
        {
            Document document = await this.client.ReadDocumentAsync(UriFactory.CreateDocumentUri(this.bbdd, this.collection, idVehiculo));
            MemoryStream memory = new MemoryStream();
            using (var stream = new StreamReader(memory))
            {
                //ALMACENAMOS EL DOCUMENTO DENTRO DEL MEMORY
                document.SaveTo(memory);
                //PONEMOS LA MEMORIA A ZERO
                memory.Position = 0;
                //DESERIALIZAMOS EL OBJETO CON NEWTONSOFT LEYENDO DEL STREAM
                Vehiculo car = JsonConvert.DeserializeObject<Vehiculo>(await stream.ReadToEndAsync());

                return car;
            }
        }
        public List<Vehiculo> GetListaBaseVehiculos()
        {
            List<Vehiculo> carros = new List<Vehiculo>();
            Vehiculo patinete = new Vehiculo
            {
                Id = "1",
                Marca = "Powell Peralta",
                Modelo = "Patinete urbano",
                Tipo = "LongBoard",
                VelocidadMaxima = 15
            };
            carros.Add(patinete);
            Vehiculo coche = new Vehiculo
            {
                Id = "2",
                Marca = "Mustang",
                Modelo = "GT",
                Tipo = "Deportivo",
                VelocidadMaxima = 340,
                Motor = new Motor
                {
                    Cilindrada = 3000,
                    Caballos = 450,
                    Consumo = 18,
                    Tipo = "Gasolina"
                }
            };
            carros.Add(coche);
            return carros;

        }

        public List<Vehiculo> GetVehiculos()
        {
            //Indicamos el numero de documentos a recuperar
            FeedOptions options = new FeedOptions() { MaxItemCount = -1 }; //-1 te devuelven todos
            String sql = "SELECT * FROM c";
            Uri uri = UriFactory.CreateDocumentCollectionUri(this.bbdd, this.collection);
            IQueryable<Vehiculo> consulta = this.client.CreateDocumentQuery<Vehiculo>(uri, sql, options);
            return consulta.ToList();
        }

        public async Task ModificarVehiculo(Vehiculo car)
        {
            Uri uri = UriFactory.CreateDocumentUri(this.bbdd, this.collection, car.Id);
            await this.client.ReplaceDocumentAsync(uri, car);

        }

        public async Task EliminarVehiculo(String idvehiculo)
        {
            Uri uri = UriFactory.CreateDocumentUri(this.bbdd, this.collection, idvehiculo);
            await this.client.DeleteDocumentAsync(uri);
        }


        public List<Vehiculo> BuscarVehiculoMarca(String marca)
        {
            FeedOptions queryOptions = new FeedOptions { MaxItemCount = -1 };


            IQueryable<Vehiculo> query = this.client.CreateDocumentQuery<Vehiculo>(
                    UriFactory.CreateDocumentCollectionUri(this.bbdd, this.collection), queryOptions)
                    .Where(x => x.Marca == marca);
            return query.ToList();
        }

        public List<Vehiculo> BuscarVehiculoMarcaSQL(String marca)
        {
            FeedOptions queryOptions = new FeedOptions { MaxItemCount = -1 };
            IQueryable<Vehiculo> querysql = this.client.CreateDocumentQuery<Vehiculo>(
                    UriFactory.CreateDocumentCollectionUri(this.bbdd, this.collection),
                    "SELECT * FROM Coches WHERE Vehiculo.Marca = '" + marca + "'",
                    queryOptions);
            return querysql.ToList();
        }

    }
}
