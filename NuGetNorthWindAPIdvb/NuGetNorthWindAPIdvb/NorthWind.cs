using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace NuGetNorthWindAPIdvb
{
    public class NorthWind
    {
        public ProductList GetProductos()
        {
            String url = "https://services.odata.org/V4/Northwind/Northwind.svc/Products";
            WebClient client = new WebClient();
            client.Headers["content-type"] = "application/json";
            String info = client.DownloadString(url);
            //DESERIALIZAMOS
            ProductList product = JsonConvert.DeserializeObject<ProductList>(info);
            return product;
        }
    }
}
