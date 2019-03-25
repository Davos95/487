using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

namespace ApiTablasToken.Repositories
{
    public class RepositoryTablaToken
    {
        CloudTable tabla;
        public RepositoryTablaToken()
        {
            String keys = CloudConfigurationManager.GetSetting("cuentastorage");
            CloudStorageAccount account = CloudStorageAccount.Parse(keys);
            CloudTableClient client = account.CreateCloudTableClient();
            this.tabla = client.GetTableReference("alumnos");
        }

        public String GetToken(String curso)
        {
            //CREAR LA POLITICA DE TIPO DE ACCESO Y TIEMPO A LA TABLA
            SharedAccessTablePolicy permisos = new SharedAccessTablePolicy()
            {
                SharedAccessExpiryTime = DateTime.Now.AddMinutes(30),
                Permissions = SharedAccessTablePermissions.Query
            };
            //EL TOKEN SE GENERA CON LOS PERMISOS, INDICAMOS EL ACCESO A LOS DATOS POR PK,RK
            //SI PONEMOS NULL, DEVUELVE TODOS
            String token = tabla.GetSharedAccessSignature(permisos
                ,null //ID PARA ESTOS PERMISOS
                ,curso //INICIO PARA BUSCAR PARTITION KEY
                ,null //INICIO PARA ROWKEY 
                ,curso //FIN PARA PARTITION KEY
                ,null //FIN PARA ROW KEY
                );


            return token;
        }
    }
}