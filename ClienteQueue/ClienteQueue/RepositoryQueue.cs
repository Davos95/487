using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;
namespace ClienteQueue
{
    public class RepositoryQueue
    {
        CloudQueueClient client;
        public RepositoryQueue()
        {
            String keys = CloudConfigurationManager.GetSetting("cuentastorage");
            CloudStorageAccount account = CloudStorageAccount.Parse(keys);
            this.client = account.CreateCloudQueueClient();
        }

        public CloudQueue GetColaMensaje(String name)
        {
            CloudQueue queue = this.client.GetQueueReference(name);
            queue.CreateIfNotExists();
            return queue;
        }

        public void CrearMensaje(String queuename, String mensaje)
        {
            CloudQueue queue = this.GetColaMensaje(queuename);
            CloudQueueMessage msj = new CloudQueueMessage(mensaje);
            queue.AddMessage(msj);
        }

        public List<String> GetMensajes(String queuename)
        {
            CloudQueue queue = this.GetColaMensaje(queuename);
            List<String> mensaje = new List<string>();
            foreach (CloudQueueMessage msj in queue.GetMessages(20))
            {
                mensaje.Add(msj.AsString);
            }
            return mensaje;
        }

        public void EliminarMensajes(String queuename)
        {
            CloudQueue queue = this.GetColaMensaje(queuename);
            foreach (CloudQueueMessage msj in queue.GetMessages(20))
            {
                queue.DeleteMessage(msj);
            }

        }

        public void BorrarMensaje(String queuename)
        {
            CloudQueue queue = this.GetColaMensaje(queuename);
            CloudQueueMessage msj = queue.GetMessage();
            queue.DeleteMessage(msj);
        }

        public void ModificarMensaje(String queuename, String mensaje)
        {
            CloudQueue queue = this.GetColaMensaje(queuename);
            CloudQueueMessage msj = queue.GetMessage();
            msj.SetMessageContent(mensaje);
            queue.UpdateMessage(msj, TimeSpan.FromMinutes(2), MessageUpdateFields.Content | MessageUpdateFields.Visibility);
        }
    }

}
