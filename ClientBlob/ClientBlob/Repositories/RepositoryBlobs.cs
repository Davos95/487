using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

namespace ClientBlob.Repositories
{
    public class RepositoryBlobs
    {
        CloudBlobClient client;
        public RepositoryBlobs()
        {
            String keys = CloudConfigurationManager.GetSetting("cuentastorage");
            CloudStorageAccount account = CloudStorageAccount.Parse(keys);
            this.client = account.CreateCloudBlobClient();
        }

        public void CrearContenedor (String nombre)
        {
            CloudBlobContainer container = this.client.GetContainerReference(nombre);
            
            container.CreateIfNotExists();
            container.SetPermissions(new BlobContainerPermissions { PublicAccess = BlobContainerPublicAccessType.Blob });
        }

        public void SubirBlob(String nombrecontenedor, String imagen, String path)
        {
            //Recuperamos el contenedor
            CloudBlobContainer container = this.client.GetContainerReference(nombrecontenedor);
            //A partir de este contenedor, creamos un blob
            CloudBlockBlob blob = container.GetBlockBlobReference(imagen);
            //Utilizando Stream leemos el contenido del file y lo subimos a azure
            using (var stream = System.IO.File.OpenRead(path))
            {
                blob.UploadFromStream(stream);
            }
            
        }

        public void EliminarBlob(String nombrecontenedor, String nombreblob)
        {
            CloudBlobContainer container = this.client.GetContainerReference(nombrecontenedor);
            CloudBlockBlob blob = container.GetBlockBlobReference(nombreblob);
            blob.DeleteIfExists();
        }

        public List<String> GetContainerNames()
        {
            List<String> containers = new List<string>();
            List<CloudBlobContainer> contenedores = this.client.ListContainers().ToList();
            foreach (CloudBlobContainer c in contenedores)
            {
                containers.Add(c.Name);
            }
            return containers;
        }

        public List<CloudBlockBlob> GetBlobs(String nombrecontenedor)
        {
            CloudBlobContainer container = this.client.GetContainerReference(nombrecontenedor);
            List<CloudBlockBlob> blockBlobs = new List<CloudBlockBlob>();
            List<IListBlobItem> blobs = container.ListBlobs().ToList();
            foreach(IListBlobItem blob in blobs)
            {
                if(blob is CloudBlockBlob)
                {
                    blockBlobs.Add((CloudBlockBlob)blob);
                }
            }
            return blockBlobs;
        }
        

    }
}
