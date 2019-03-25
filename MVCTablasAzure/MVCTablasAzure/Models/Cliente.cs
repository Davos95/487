using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTablasAzure.Models
{
    public class Cliente: TableEntity
    {
        //CONSTRUCTOR VACIO A LA FUERZA
        public Cliente() { }

        //PARTITION KEY: ES EL GRUPO QUE UNO DISTINTAS ENTIDADES
        private String _Empresa;
        public String Empresa {
            get {
                return this._Empresa;
            }
            set {
                this.PartitionKey = value;
                this._Empresa = value;
            }
        }

        //ROWKEY ES UNICO PARA CADA EMPRES (PARTITION KEY)
        private String _IdCliente;
        public String IdCliente
        {
            get
            {
                return this._IdCliente;
            }
            set
            {
                this.RowKey = value;
                this._IdCliente = value;
            }
        }
        public String Nombre { get; set; }
        public String Apellidos { get; set; }
    }
}