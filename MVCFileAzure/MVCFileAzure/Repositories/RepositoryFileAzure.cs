using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.File;
using MVCFileAzure.Models;

namespace MVCFileAzure.Repositories
{
    public class RepositoryFileAzure
    {
        CloudFileDirectory root;
        public RepositoryFileAzure()
        {
            String keys = CloudConfigurationManager.GetSetting("cloudstorage");
            CloudStorageAccount account = CloudStorageAccount.Parse(keys);
            CloudFileClient client = account.CreateCloudFileClient();
            CloudFileShare share = client.GetShareReference("sharedtajamar");
            this.root = share.GetRootDirectoryReference();
        }

        public void UploadFile(String nombre, Stream stream)
        {
            //NECESITAMOS UNA REFERENCIA AL FICHERO
            CloudFile file = this.root.GetFileReference(nombre);
            file.UploadFromStream(stream);
        }
        public List<String> GetAzureFiles()
        {
            List<String> files = new List<string>();
            List<IListFileItem> azureFiles = this.root.ListFilesAndDirectories().ToList();
            foreach(IListFileItem f in azureFiles)
            {
                String uri = f.StorageUri.PrimaryUri.AbsoluteUri;
                int ultima = uri.LastIndexOf("/")+1;
                String nombre = uri.Substring(ultima);
                files.Add(nombre);
            }

            return files;
        }

        public List<Pelicula> LeerXML(String name)
        {
            //CloudFile file = root.GetFileReference(name);
            //String content = file.DownloadTextAsync().Result;
            //XDocument document = XDocument.Parse(content);

            //var consulta = from datos in document.Descendants("pelicula")
            //               select new Pelicula
            //               {
            //                   titulo = datos.Element("titulo").Value,
            //                   tituloOriginal = datos.Element("titulooriginal").Value,
            //                   descripcion = datos.Element("descipcion").Value,
            //                   poster = datos.Element("poster").Value
            //                   //escenas = (from datos2 in document.Descendants("pelicula")
            //                   //           where datos2.Element("titulo").ToString() == datos.Element("titulo").ToString()
            //                   //           select new Escena
            //                   //           {
            //                   //               tituloEscena = datos2.Element("tituloescena").Value,
            //                   //               descripcion = datos2.Element("descripcion").Value,
            //                   //               imagen = datos2.Element("imagen").Value
            //                   //           }).ToList()
            //               };
            //return consulta.ToList();



            CloudFile file = root.GetFileReference(name);
            String content = file.DownloadTextAsync().Result;
            XDocument xmlDoc = XDocument.Parse(content);
            var query = from data in xmlDoc.Descendants("pelicula")
                        select new Pelicula
                        {
                            titulo = data.Element("titulo").Value,
                            tituloOriginal = data.Element("titulooriginal").Value,
                            descripcion = data.Element("descripcion").Value,
                            poster = data.Element("poster").Value,
                            escenas = new List<Escena>(from esc in data.Descendants("escena")
                                                   select new Escena {
                                                       tituloEscena = data.Element("tituloescena").Value,
                                                       descripcion = data.Element("descripcion").Value,
                                                       imagen = data.Element("imagen").Value
                                                   })
                        };
            return query.ToList();
        }
    }
}