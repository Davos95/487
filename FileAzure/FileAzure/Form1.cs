using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.File;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileAzure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //ACCESO DE LA CUENTA
            String keys = CloudConfigurationManager.GetSetting("cuentastorage");
            //RECUPERAMOS LA CUENTA STORAGE
            CloudStorageAccount account = CloudStorageAccount.Parse(keys);
            //CREAR UN CLIENTE DEL TIPO DE CONSUMO QUE DESEAMOS REALIZAR (File Client)
            CloudFileClient client = account.CreateCloudFileClient();

            //FILE TRABAJA CON RECURSOS COMPARTIDOS
            //DEBEMOS ACCEDER AL RECURSO QUE NECESITEMOS
            CloudFileShare share = client.GetShareReference("sharedtajamar");

            //ACCEDEMOS A LA RUA DEL DIRECTORIO RAIZ DEL SHARED
            CloudFileDirectory root = share.GetRootDirectoryReference();

            //DEBEMOS ACCEDER AL FICHERO DE AZURE
            CloudFile file = root.GetFileReference("Incidencias de red.txt");
            String content = file.DownloadTextAsync().Result;
            this.txtContenido.Text = content;
        }
    }
}
