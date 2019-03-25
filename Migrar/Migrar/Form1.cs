using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

namespace Migrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMigrar_Click(object sender, EventArgs e)
        {
            String keys = CloudConfigurationManager.GetSetting("cuentastorage");
            CloudStorageAccount account = CloudStorageAccount.Parse(keys);
            CloudTableClient client = account.CreateCloudTableClient();
            CloudTable table = client.GetTableReference("alumnos");
            table.CreateIfNotExists();
            String recurso = "Migrar.alumnos_tables_storage.xml";
            Stream stream = this.GetType().Assembly.GetManifestResourceStream(recurso);
            XDocument docxml = XDocument.Load(stream);
            var consulta = from datos in docxml.Descendants("alumno")
                           select new Alumno
                           {
                               Nombre = datos.Element("nombre").Value,
                               Apellido = datos.Element("apellidos").Value,
                               Nota = datos.Element("nota").Value,
                               IdAlumno = datos.Element("idalumno").Value,
                               Curso = datos.Element("curso").Value
                           };

            foreach (Alumno alumno in consulta)
            {
                TableOperation operation = TableOperation.Insert(alumno);
                table.Execute(operation);
            }
            this.label1.Text = "Datos migrados correctamente";

        }
    }
}
