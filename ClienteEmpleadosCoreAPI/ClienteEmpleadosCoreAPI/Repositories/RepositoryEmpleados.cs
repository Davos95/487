using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClienteEmpleadosCoreAPI.Models;
using System.Net.Http.Headers;
using System.Net.Http;
namespace ClienteEmpleadosCoreAPI.Repositories
{
    public class RepositoryEmpleados : IRepositoryEmpleados
    {
        private String url = "";
        public RepositoryEmpleados()
        {
            this.url = "https://apiempleadosdvb.azurewebsites.net/";
        }
        public async Task<List<Empleado>> GetEmpleados()
        {
            using(HttpClient client = new HttpClient())
            {
                //LA PETICION INDICA EL ACCESO AL ROUTE DEL API

                //api/Controller
                String peticion = "api/Empleados";
                //DEBEMOS INDICAR AL CLIENTE LA DIRECCION DEL SERVIDOR API 
                client.BaseAddress = new Uri(this.url);
                client.DefaultRequestHeaders.Accept.Clear();
                MediaTypeWithQualityHeaderValue headerjson = new MediaTypeWithQualityHeaderValue("application/json");
                //AÑADIMOS EL FORMAT AL HEADER DEL CLIENT
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                //REALIZAMOS LA PETICION GET AL SERVICIO API Y NOS DEVUELVE UNA RESPUESTA
                HttpResponseMessage respone = await client.GetAsync(peticion);
                if (respone.IsSuccessStatusCode)
                {
                    //EN LA PROPIEDAD CONTENT DE RESPONSE VIENE EL CONTENIDO DEL JSON MEDIANTE EL METODO ReadAsAsync<T>()
                    //MAPEA DIRECTAMENTE A OBJETOS
                    List<Empleado> empleados = await respone.Content.ReadAsAsync<List<Empleado>>();
                    return empleados;
                }
                else {
                    return null;
                }
            }
        }
    }
}
