using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NuGetNorthWindAPIdvb
{
    public class ProductList
    {
        [JsonProperty("value")]
        public List<Producto> ListaProductos { get; set; }

    }
}
