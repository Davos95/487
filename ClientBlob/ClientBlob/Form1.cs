using ClientBlob.Repositories;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientBlob
{
    public partial class Form1 : Form
    {
        RepositoryBlobs repo;
        public Form1()
        {
            InitializeComponent();
            this.repo = new RepositoryBlobs();
        }

        private void lstContenedores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevoContenedor_Click(object sender, EventArgs e)
        {
            this.repo.CrearContenedor(this.txtContenedor.Text);
            this.CargarContenedores();
        }
        private void btnSubirBlob_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            String nombrecontenedor = this.lstContenedores.SelectedItem.ToString();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                String path = ofd.FileName;
                int ultima = path.LastIndexOf(@"\") + 1;
                String filename = path.Substring(ultima);
                this.repo.SubirBlob(nombrecontenedor, filename, path);
                this.CargarBlobs();
            }
            
        }

        private void btnMostrarBlob_Click(object sender, EventArgs e)
        {
            this.CargarBlobs();
        }


        private void CargarBlobs()
        {
            this.lstBlobs.Items.Clear();
            String nombrecontenedor = this.lstContenedores.SelectedItem.ToString();
            foreach (CloudBlockBlob blob in this.repo.GetBlobs(nombrecontenedor))
            {
                String url = blob.StorageUri.PrimaryUri.ToString();
                String size = blob.Properties.Length.ToString();
                ListViewItem it = new ListViewItem();
                it.Text = url;
                it.SubItems.Add(size);
                this.lstBlobs.Items.Add(it);
            }
        }
        private void CargarContenedores()
        {
            this.lstContenedores.Items.Clear();
            foreach (String c in this.repo.GetContainerNames())
            {
                this.lstContenedores.Items.Add(c);
            }

        }

        private void btnEliminarBlob_Click(object sender, EventArgs e)
        {
            String url = this.lstBlobs.SelectedItems[0].Text;
            int ultima = url.LastIndexOf("/") + 1;
            String imagen = url.Substring(ultima);
            String nombrecontenedor = this.lstContenedores.SelectedItem.ToString();
            this.repo.EliminarBlob(nombrecontenedor, imagen);
            this.CargarBlobs();
        }

        private void lstBlobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.lstBlobs.SelectedItems.Count != 0)
            {
                String url = this.lstBlobs.SelectedItems[0].Text;
                this.pictureBlob.Load(url);
            }
        }
    }
}
