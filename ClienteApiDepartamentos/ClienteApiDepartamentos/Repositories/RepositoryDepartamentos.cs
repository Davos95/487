using ClienteApiDepartamentos.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ClienteApiDepartamentos.Repositories
{
    public class RepositoryDepartamentos
    {
        private String urlApi;
        private MediaTypeWithQualityHeaderValue headerjson;
        public RepositoryDepartamentos()
        {
            this.urlApi = "http://localhost:51591/";
            //this.urlApi = "https://apidepartamentosdvb.azurewebsites.net/";
            this.headerjson = new MediaTypeWithQualityHeaderValue("application/json");
        }

        public async Task<List<Departamento>> GetDepartamentosAync()
        {
            using(HttpClient client = new HttpClient())
            {
                String peticion = "api/Departamentos";
                client.BaseAddress = new Uri(this.urlApi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                HttpResponseMessage response = await client.GetAsync(peticion);
                if (response.IsSuccessStatusCode)
                {
                    List<Departamento> departamentos = await response.Content.ReadAsAsync<List<Departamento>>();
                    return departamentos;
                } else
                {
                    return null;
                }

            }
        }


        public async Task<Departamento> BuscarDepartamentosAync(int deptno)
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/Departamentos/"+deptno;
                client.BaseAddress = new Uri(this.urlApi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                HttpResponseMessage response = await client.GetAsync(peticion);
                if (response.IsSuccessStatusCode)
                {
                    Departamento departamento = await response.Content.ReadAsAsync<Departamento>();
                    return departamento;
                }
                else
                {
                    return null;
                }

            }
        }

        public async Task InsertarDepartamentoAsync(int num, String nom, String loc)
        {
            using(HttpClient client = new HttpClient())
            {
                String peticion = "api/Departamentos";
                client.BaseAddress = new Uri(this.urlApi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                Departamento dept = new Departamento();
                dept.Numero = num;
                dept.Nombre = nom;
                dept.Localidad = loc;
                String json = JsonConvert.SerializeObject(dept);
                StringContent content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                await client.PostAsync(peticion, content);

            }
        }

        public async Task ModificarDepartamentoAsync(int num, String nom, String loc)
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/Departamentos/"+num;
                client.BaseAddress = new Uri(this.urlApi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                Departamento dept = new Departamento();
                dept.Numero = num;
                dept.Nombre = nom;
                dept.Localidad = loc;
                String json = JsonConvert.SerializeObject(dept);
                StringContent content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                await client.PutAsync(peticion,content);
                
            }
        }

        public async Task DeleteDepartamentoAsync(int num)
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/Departamentos/" + num;
                client.BaseAddress = new Uri(this.urlApi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                
                await client.DeleteAsync(peticion);
            }
        }


        public async Task<List<Empleado>> GetEmpleadosDepartamentoAync(List<int> depts)
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/EmpleadosDepartamento?";
                String datos = "";
                foreach (int d in depts)
                {
                    datos += "deptno=" + d + "&";
                }
                datos = datos.Trim('&');
                peticion += datos;

                client.BaseAddress = new Uri(this.urlApi);
                client.DefaultRequestHeaders.Accept.Clear();
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
        }


    }
}
