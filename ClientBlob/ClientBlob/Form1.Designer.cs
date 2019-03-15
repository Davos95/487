namespace ClientBlob
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstBlobs = new System.Windows.Forms.ListView();
            this.pictureBlob = new System.Windows.Forms.PictureBox();
            this.txtContenedor = new System.Windows.Forms.TextBox();
            this.btnNuevoContenedor = new System.Windows.Forms.Button();
            this.btnSubirBlob = new System.Windows.Forms.Button();
            this.btnMostrarBlob = new System.Windows.Forms.Button();
            this.lstContenedores = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEliminarBlob = new System.Windows.Forms.Button();
            this.URL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SIZE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBlob)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contenedor";
            // 
            // lstBlobs
            // 
            this.lstBlobs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.URL,
            this.SIZE});
            this.lstBlobs.Location = new System.Drawing.Point(41, 316);
            this.lstBlobs.Name = "lstBlobs";
            this.lstBlobs.Size = new System.Drawing.Size(615, 133);
            this.lstBlobs.TabIndex = 1;
            this.lstBlobs.UseCompatibleStateImageBehavior = false;
            this.lstBlobs.View = System.Windows.Forms.View.Details;
            this.lstBlobs.SelectedIndexChanged += new System.EventHandler(this.lstBlobs_SelectedIndexChanged);
            // 
            // pictureBlob
            // 
            this.pictureBlob.Location = new System.Drawing.Point(467, 50);
            this.pictureBlob.Name = "pictureBlob";
            this.pictureBlob.Size = new System.Drawing.Size(189, 196);
            this.pictureBlob.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBlob.TabIndex = 2;
            this.pictureBlob.TabStop = false;
            // 
            // txtContenedor
            // 
            this.txtContenedor.Location = new System.Drawing.Point(41, 50);
            this.txtContenedor.Name = "txtContenedor";
            this.txtContenedor.Size = new System.Drawing.Size(153, 20);
            this.txtContenedor.TabIndex = 3;
            // 
            // btnNuevoContenedor
            // 
            this.btnNuevoContenedor.Location = new System.Drawing.Point(41, 89);
            this.btnNuevoContenedor.Name = "btnNuevoContenedor";
            this.btnNuevoContenedor.Size = new System.Drawing.Size(153, 36);
            this.btnNuevoContenedor.TabIndex = 4;
            this.btnNuevoContenedor.Text = "Nuevo contenedor";
            this.btnNuevoContenedor.UseVisualStyleBackColor = true;
            this.btnNuevoContenedor.Click += new System.EventHandler(this.btnNuevoContenedor_Click);
            // 
            // btnSubirBlob
            // 
            this.btnSubirBlob.Location = new System.Drawing.Point(41, 158);
            this.btnSubirBlob.Name = "btnSubirBlob";
            this.btnSubirBlob.Size = new System.Drawing.Size(153, 37);
            this.btnSubirBlob.TabIndex = 5;
            this.btnSubirBlob.Text = "Subir blob";
            this.btnSubirBlob.UseVisualStyleBackColor = true;
            this.btnSubirBlob.Click += new System.EventHandler(this.btnSubirBlob_Click);
            // 
            // btnMostrarBlob
            // 
            this.btnMostrarBlob.Location = new System.Drawing.Point(41, 238);
            this.btnMostrarBlob.Name = "btnMostrarBlob";
            this.btnMostrarBlob.Size = new System.Drawing.Size(153, 37);
            this.btnMostrarBlob.TabIndex = 6;
            this.btnMostrarBlob.Text = "Mostrar blob";
            this.btnMostrarBlob.UseVisualStyleBackColor = true;
            this.btnMostrarBlob.Click += new System.EventHandler(this.btnMostrarBlob_Click);
            // 
            // lstContenedores
            // 
            this.lstContenedores.FormattingEnabled = true;
            this.lstContenedores.Location = new System.Drawing.Point(224, 50);
            this.lstContenedores.Name = "lstContenedores";
            this.lstContenedores.Size = new System.Drawing.Size(192, 225);
            this.lstContenedores.TabIndex = 7;
            this.lstContenedores.SelectedIndexChanged += new System.EventHandler(this.lstContenedores_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Contenedores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Blobs";
            // 
            // btnEliminarBlob
            // 
            this.btnEliminarBlob.ForeColor = System.Drawing.Color.Red;
            this.btnEliminarBlob.Location = new System.Drawing.Point(486, 269);
            this.btnEliminarBlob.Name = "btnEliminarBlob";
            this.btnEliminarBlob.Size = new System.Drawing.Size(170, 41);
            this.btnEliminarBlob.TabIndex = 10;
            this.btnEliminarBlob.Text = "Eliminar Blob";
            this.btnEliminarBlob.UseVisualStyleBackColor = true;
            this.btnEliminarBlob.Click += new System.EventHandler(this.btnEliminarBlob_Click);
            // 
            // URL
            // 
            this.URL.Text = "URL";
            this.URL.Width = 501;
            // 
            // SIZE
            // 
            this.SIZE.Text = "SIZE";
            this.SIZE.Width = 105;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 477);
            this.Controls.Add(this.btnEliminarBlob);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstContenedores);
            this.Controls.Add(this.btnMostrarBlob);
            this.Controls.Add(this.btnSubirBlob);
            this.Controls.Add(this.btnNuevoContenedor);
            this.Controls.Add(this.txtContenedor);
            this.Controls.Add(this.pictureBlob);
            this.Controls.Add(this.lstBlobs);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBlob)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstBlobs;
        private System.Windows.Forms.PictureBox pictureBlob;
        private System.Windows.Forms.TextBox txtContenedor;
        private System.Windows.Forms.Button btnNuevoContenedor;
        private System.Windows.Forms.Button btnSubirBlob;
        private System.Windows.Forms.Button btnMostrarBlob;
        private System.Windows.Forms.ListBox lstContenedores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEliminarBlob;
        private System.Windows.Forms.ColumnHeader URL;
        private System.Windows.Forms.ColumnHeader SIZE;
    }
}

