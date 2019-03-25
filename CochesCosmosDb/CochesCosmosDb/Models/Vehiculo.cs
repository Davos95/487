using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CochesCosmosDb.Models
{
    public class Vehiculo
    {
        [JsonProperty(PropertyName ="id")]
        public String Id { get; set; }
        public String Marca { get; set; }
        public String Modelo { get; set; }
        public String Tipo { get; set; }
        public int VelocidadMaxima { get; set; }
        public Motor Motor { get; set; }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
