using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ClienteTableSaS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public String GetToken(String curso)
        {
            String urlApi = "http://localhost:63026/api/Token/" + curso.ToUpper();
            WebClient client = new WebClient();
            client.Headers["content-type"] = "application/xml";
            String datosxml = client.DownloadString(urlApi);
            XDocument docxml = XDocument.Parse(datosxml);
            XElement element = (XElement)docxml.FirstNode;
            return element.Value;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            String curso = this.txtCurso.Text;
            String token = this.GetToken(curso);
            Uri uri = new Uri("https://storagetajamardvb.table.core.windows.net");
            StorageCredentials credentials = new StorageCredentials(token);
            CloudTableClient client = new CloudTableClient(uri, credentials);
            CloudTable table = client.GetTableReference("alumnos");
            TableQuery<Alumno> query = new TableQuery<Alumno>();
            var consulta = table.ExecuteQuery(query);
            if(consulta == null)
            {
                this.gridAlumnos.DataSource = null;
            } else
            {
                this.gridAlumnos.DataSource = consulta.ToList();
            }

        }
    }
}
