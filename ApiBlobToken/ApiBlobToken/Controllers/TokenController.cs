using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.WindowsAzure;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage;

namespace ApiBlobToken.Controllers
{
    public class TokenController : ApiController
    {
        //METODO PARA DEVOLVER EL CONTENEDOR  PARA GENERAR SU CLAVE POSTERIORMENTE
        public CloudBlobContainer RecuperarContenedor()
        {
            String keys = CloudConfigurationManager.GetSetting("cuentastorage");
            CloudStorageAccount account = CloudStorageAccount.Parse(keys);
            CloudBlobClient client = account.CreateCloudBlobClient();
            CloudBlobContainer container = client.GetContainerReference("contenedorseguro");
            container.CreateIfNotExists();
            return container;
        }

        public String Get()
        {
            CloudBlobContainer container = this.RecuperarContenedor();
            SharedAccessBlobPolicy permisos = new SharedAccessBlobPolicy();
            permisos.SharedAccessExpiryTime = DateTime.Now.AddMinutes(10);
            permisos.Permissions = SharedAccessBlobPermissions.Create
                | SharedAccessBlobPermissions.List
                | SharedAccessBlobPermissions.Read
                | SharedAccessBlobPermissions.Write
                /*| SharedAccessBlobPermissions.Delete*/;
            String token = container.GetSharedAccessSignature(permisos);
            //PARA DAR ACCESO, EL TOKEN VA DENTRO DEL URI DEL CONTAINER
            return container.Uri + token;
        }
    }
}
