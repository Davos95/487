using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteQueue
{
    public partial class Form1 : Form
    {
        RepositoryQueue repo;
        public Form1()
        {
            InitializeComponent();
            this.repo = new RepositoryQueue();
        }

        public void CargarMensajes(String queue)
        {
            this.lstMensajes.Items.Clear();
            List<String> mensajes = this.repo.GetMensajes(queue);
            foreach (String m in mensajes)
            {
                this.lstMensajes.Items.Add(m);
            }

        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            String cola = this.cmbCola.SelectedItem.ToString();
            String mensaje = DateTime.Now.ToLongDateString() + " "+this.txtMensaje.Text;
            this.repo.CrearMensaje(cola, mensaje);
            this.CargarMensajes(cola);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            String cola = this.cmbCola.SelectedItem.ToString();
            String mensaje = DateTime.Now.ToLongDateString() + " " + this.txtMensaje.Text;
            this.repo.ModificarMensaje(cola, mensaje);
            this.CargarMensajes(cola);
        }

        private void btnRecuperarTodo_Click(object sender, EventArgs e)
        {
            String cola = this.cmbCola.SelectedItem.ToString();
            this.CargarMensajes(cola);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String cola = this.cmbCola.SelectedItem.ToString();
            this.repo.BorrarMensaje(cola);
            this.CargarMensajes(cola);
        }

        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            String cola = this.cmbCola.SelectedItem.ToString();
            this.repo.EliminarMensajes(cola);
        }
    }
}
