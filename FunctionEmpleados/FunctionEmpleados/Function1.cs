
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;


namespace FunctionEmpleados
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]HttpRequest req, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            string name = req.Query["name"];

            string requestBody = new StreamReader(req.Body).ReadToEnd();
            dynamic data = JsonConvert.DeserializeObject(requestBody);
            name = name ?? data?.name;
            if(name == null)
            {
                return new BadRequestObjectResult("No me has dado el numedo de Empleado");
            } else
            {
                string cnnstring = "Data Source=sqlxamarin.database.windows.net;Initial Catalog=HOSPITALXAMARIN;Persist Security Info=True;User ID=adminsql; password=Admin123";
                string sql = "UPDATE EMP SET SALARIO = SALARIO + 500 WHERE EMP_NO="+name;
                SqlConnection cn = new SqlConnection(cnnstring);
                SqlCommand com = new SqlCommand();
                com.CommandText = sql;
                com.Connection = cn;
                cn.Open();
                com.ExecuteNonQuery();
                cn.Close();

                SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM EMP WHERE EMP_NO="+name, cnnstring);
                DataSet ds = new DataSet();
                ad.Fill(ds, "TABLA");
                DataRow fila = ds.Tables["TABLA"].Rows[0];
                return (ActionResult)new OkObjectResult("El empleado "+ fila["APELLIDO"] + " tiene un nuevo salario de "+fila["SALARIO"]);
            }
            



            return name != null
                ? (ActionResult)new OkObjectResult($"Hello, {name}")
                : new BadRequestObjectResult("Please pass a name on the query string or in the request body");
        }
    }
}
