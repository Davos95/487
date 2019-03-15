using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using ClienteAPIPlantilla.Models;

namespace ClienteAPIPlantilla.Repositories
{
    public class RepositoryApiPlantilla : IRepositoryApiPlantilla
    {
        private String apiUrl;
        public RepositoryApiPlantilla()
        {
            this.apiUrl = "http://localhost:50748/";
        }

        private async Task<T> CallApi<T>(String peticion)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(this.apiUrl);
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

        public async Task<List<PlantillaComplex>> GetPlantilla()
        {
            List<PlantillaComplex> plantilla = await this.CallApi<List<PlantillaComplex>>("api/Plantilla");
            return plantilla;
        }

        public async Task<List<PlantillaComplex>> GetPlantillaFuncion(String funcion)
        {
            List<PlantillaComplex> plantilla = await this.CallApi<List<PlantillaComplex>>("api/PlantillaFuncion/" + funcion);
            return plantilla;
        }

        public async Task<List<String>> GetFunciones()
        {
            List<String> funciones = await this.CallApi<List<String>>("api/Funciones");
            return funciones;
        }
    }
}
