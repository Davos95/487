using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClienteApiEmpleados.Models;
using System.Net.Http.Headers;
using System.Net.Http;

namespace ClienteApiEmpleados.Repositories
{
    public class RepositoryApiEmpleados : IRepositoryApiEmpleados
    {
        private String apiurl;

        public RepositoryApiEmpleados()
        {
            this.apiurl = 
                "https://apiempleadospgs.azurewebsites.net/";
        }

        private async Task<T> CallApi<T>(String peticion)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(this.apiurl);
                client.DefaultRequestHeaders.Accept.Clear();
                MediaTypeWithQualityHeaderValue headerjson = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                HttpResponseMessage response = await client.GetAsync(peticion);
                if (response.IsSuccessStatusCode)
                {
                    T datos = await response.Content.ReadAsAsync<T>();
                    return (T)Convert.ChangeType(datos, typeof(T));
                }
                else
                {
                    return default(T);
                }
            }


        }

        public async Task<Empleado> BuscarEmpleado(int idempleado)
        {
            Empleado empleado = await this.CallApi<Empleado>("api/Empleados/" + idempleado);
            return empleado;

            #region
            /*using (HttpClient client = new HttpClient())
            //{
            //    client.BaseAddress = new Uri(this.apiurl);
            //    String peticion = "api/Empleados/" + idempleado;
            //    client.DefaultRequestHeaders.Accept.Clear();
            //    MediaTypeWithQualityHeaderValue headerjson = new MediaTypeWithQualityHeaderValue("application/json");
            //    client.DefaultRequestHeaders.Accept.Add(headerjson);
            //    HttpResponseMessage response =
            //        await client.GetAsync(peticion);
            //    if (response.IsSuccessStatusCode)
            //    {
            //        Empleado empleado = await response.Content.ReadAsAsync<Empleado>();
            //        return empleado;
            //    }
            //    else
            //    {
            //        return null;
            //    }
            } */
            #endregion
        }

        public async Task<List<Empleado>> GetEmpleados()
        {
            List<Empleado> empleados = await CallApi<List<Empleado>>("api/Empleados");
            return empleados;
        }

        public async Task<List<Empleado>> GetEmpleados1()
        {

            using (HttpClient client = new HttpClient())
            {
                //LA PETICION INDICA EL ACCESO AL
                //ROUTE DEL API
                // api/Controller
                String peticion = "api/Empleados";
                //DEBEMOS INDICAR AL CLIENTE LA DIRECCION
                //BASE DEL SERVIDOR API
                client.BaseAddress =
                    new Uri(this.apiurl);
                //LIMPIAMOS LAS CABECERAS HTTP
                client.DefaultRequestHeaders.Accept.Clear();
                //INDICAMOS QUE LEEMOS EL FORMATO JSON
                MediaTypeWithQualityHeaderValue headerjson = new MediaTypeWithQualityHeaderValue("application/json");
                //AÑADIMOS EL FORMATO AL HEADER DEL CLIENTE
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                //REALIZAMOS LA PETICION GET AL SERVICIO
                //API Y NOS DEVUELVE UNA RESPUESTA
                HttpResponseMessage response = await client.GetAsync(peticion);
                if (response.IsSuccessStatusCode)
                {
                    //EN LA PROPIEDAD CONTENT DE RESPONSE
                    //VIENE EL CONTENIDO DEL JSON
                    //MEDIANTE EL METODO ReadAsAsync<T>()
                    //MAPEA DIRECTAMENTE A OBJETOS
                    List<Empleado> empleados = await response.Content.ReadAsAsync<List<Empleado>>();
                    return empleados;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<List<Empleado>> GetEmpleadosSalario(int salario)
        {
            List<Empleado> empleados = await CallApi<List<Empleado>>("api/EmpleadosSalario/" + salario);
            return empleados;
            
            #region
            /*
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(this.apiurl);
                String peticion = "api/EmpleadosSalario/" 
                    + salario;
                client.DefaultRequestHeaders.Accept.Clear();
                MediaTypeWithQualityHeaderValue headerjson = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                HttpResponseMessage response = await client.GetAsync(peticion);
                if (response.IsSuccessStatusCode)
                {
                    List<Empleado> empleados = await response.Content.ReadAsAsync<List<Empleado>>();
                    return empleados;
                }
                else
                {
                    return null;
                }
            }
            */
            #endregion
        }
    }
}
