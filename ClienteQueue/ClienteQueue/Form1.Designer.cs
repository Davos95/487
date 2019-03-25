namespace ClienteQueue
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMensaje = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCola = new System.Windows.Forms.ComboBox();
            this.lstMensajes = new System.Windows.Forms.ListView();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEliminarTodo = new System.Windows.Forms.Button();
            this.btnRecuperarTodo = new System.Windows.Forms.Button();
            this.Mensajes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(37, 57);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(345, 96);
            this.txtMensaje.TabIndex = 0;
            this.txtMensaje.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introduzca su mensaje";
            // 
            // cmbCola
            // 
            this.cmbCola.FormattingEnabled = true;
            this.cmbCola.Items.AddRange(new object[] {
            "programeitor1",
            "programeitor2"});
            this.cmbCola.Location = new System.Drawing.Point(37, 195);
            this.cmbCola.Name = "cmbCola";
            this.cmbCola.Size = new System.Drawing.Size(345, 21);
            this.cmbCola.TabIndex = 2;
            // 
            // lstMensajes
            // 
            this.lstMensajes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Mensajes});
            this.lstMensajes.Location = new System.Drawing.Point(37, 272);
            this.lstMensajes.Name = "lstMensajes";
            this.lstMensajes.Size = new System.Drawing.Size(586, 166);
            this.lstMensajes.TabIndex = 3;
            this.lstMensajes.UseCompatibleStateImageBehavior = false;
            this.lstMensajes.View = System.Windows.Forms.View.Details;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(430, 57);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(193, 44);
            this.btnCrear.TabIndex = 4;
            this.btnCrear.Text = "Crear Mensaje";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Colas de mensajes";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(430, 110);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(193, 43);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar Mensaje";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(430, 172);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(193, 44);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Borrar Mensaje";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEliminarTodo
            // 
            this.btnEliminarTodo.Location = new System.Drawing.Point(430, 225);
            this.btnEliminarTodo.Name = "btnEliminarTodo";
            this.btnEliminarTodo.Size = new System.Drawing.Size(193, 41);
            this.btnEliminarTodo.TabIndex = 8;
            this.btnEliminarTodo.Text = "Eliminar Todos";
            this.btnEliminarTodo.UseVisualStyleBackColor = true;
            this.btnEliminarTodo.Click += new System.EventHandler(this.btnEliminarTodo_Click);
            // 
            // btnRecuperarTodo
            // 
            this.btnRecuperarTodo.Location = new System.Drawing.Point(37, 232);
            this.btnRecuperarTodo.Name = "btnRecuperarTodo";
            this.btnRecuperarTodo.Size = new System.Drawing.Size(345, 34);
            this.btnRecuperarTodo.TabIndex = 9;
            this.btnRecuperarTodo.Text = "Recuperar Todos los Mensajes";
            this.btnRecuperarTodo.UseVisualStyleBackColor = true;
            this.btnRecuperarTodo.Click += new System.EventHandler(this.btnRecuperarTodo_Click);
            // 
            // Mensajes
            // 
            this.Mensajes.Text = "Mensajes";
            this.Mensajes.Width = 293;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Controls.Add(this.btnRecuperarTodo);
            this.Controls.Add(this.btnEliminarTodo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.lstMensajes);
            this.Controls.Add(this.cmbCola);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMensaje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtMensaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCola;
        private System.Windows.Forms.ListView lstMensajes;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEliminarTodo;
        private System.Windows.Forms.Button btnRecuperarTodo;
        private System.Windows.Forms.ColumnHeader Mensajes;
    }
}

