using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CochesCosmosDb.Models
{
    public class Motor
    {
        public String Tipo { get; set; }
        public int Consumo { get; set; }
        public int Cilindrada { get; set; }
        public int Caballos { get; set; }
    }
}
