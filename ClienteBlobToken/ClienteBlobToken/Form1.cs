using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteBlobToken
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToken_Click(object sender, EventArgs e)
        {
            WebClient cliente = new WebClient();
            //LE INDICAMOS EL TIPO DE CONSUMO QUE VAMOS
            //A REALIZAR
            cliente.Headers["Content-type"] = "application/json";

            String url = "http://localhost:54186/Api/Token";

            //DESCARGAMOS LA INFORMACION
            byte[] data = cliente.DownloadData(url);

            //ALMACENAMOS LA INFORMACION RECUPERADA EN UN STREAM
            MemoryStream ms = new MemoryStream();
            ms = new MemoryStream(data);

            //RECUPERAMOS LOS DATOS EN UN OBJETO STRING
            String datos = Encoding.UTF8.GetString(ms.ToArray());
            //SUSTITUIMOS LAS COMILLAS DOBLES PARA PODER RECUPERAR
            //LA URL "LIMPIA"
            datos = datos.Replace("\"", "");
            this.txtToken.Text = datos;

        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                String path = ofd.FileName;
                int ultima = path.LastIndexOf(@"\") + 1;
                String filename = path.Substring(ultima);
                String key = this.txtToken.Text;
                CloudBlobContainer container = new CloudBlobContainer(new Uri(key));
                CloudBlockBlob blob = container.GetBlockBlobReference(filename);
                using (var stream = System.IO.File.OpenRead(path))
                {
                    blob.UploadFromStream(stream);
                }

            }
        }

        public void GetBlobList()
        {
            this.lstBlob.Items.Clear();
            String key = this.txtToken.Text;
            CloudBlobContainer container = new CloudBlobContainer(new Uri(key));
            foreach (ICloudBlob blob in container.ListBlobs())
            {
                this.lstBlob.Items.Add(blob.Name);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.GetBlobList();
        }


        private void lstBlob_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.lstBlob.SelectedIndex != -1)
            {
                String sas = this.txtToken.Text;
                CloudBlobContainer contenedor = new CloudBlobContainer(new Uri(sas));
                String nombreblob = this.lstBlob.SelectedItem.ToString();
                CloudBlockBlob blob = contenedor.GetBlockBlobReference(nombreblob);
                MemoryStream msRead = new MemoryStream();
                msRead.Position = 0;
                blob.DownloadToStream(msRead);
                Console.WriteLine(msRead.Length);
                this.picBlob.Image = Image.FromStream(msRead);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String key = this.txtToken.Text;
            CloudBlobContainer container = new CloudBlobContainer(new Uri(key));
            String blobname = this.lstBlob.SelectedItem.ToString();
            CloudBlockBlob blob = container.GetBlockBlobReference(blobname);
            blob.DeleteIfExists();
            this.GetBlobList();
        }
    }
}
