namespace ClienteBlobToken
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
            this.btnToken = new System.Windows.Forms.Button();
            this.btnSubir = new System.Windows.Forms.Button();
            this.txtToken = new System.Windows.Forms.RichTextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.picBlob = new System.Windows.Forms.PictureBox();
            this.lstBlob = new System.Windows.Forms.ListBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBlob)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Token";
            // 
            // btnToken
            // 
            this.btnToken.Location = new System.Drawing.Point(28, 24);
            this.btnToken.Name = "btnToken";
            this.btnToken.Size = new System.Drawing.Size(206, 58);
            this.btnToken.TabIndex = 1;
            this.btnToken.Text = "Token Acceso";
            this.btnToken.UseVisualStyleBackColor = true;
            this.btnToken.Click += new System.EventHandler(this.btnToken_Click);
            // 
            // btnSubir
            // 
            this.btnSubir.Location = new System.Drawing.Point(295, 24);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(206, 58);
            this.btnSubir.TabIndex = 2;
            this.btnSubir.Text = "Subir Blob";
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(28, 113);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(473, 124);
            this.txtToken.TabIndex = 3;
            this.txtToken.Text = "";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(28, 255);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(206, 58);
            this.btnMostrar.TabIndex = 4;
            this.btnMostrar.Text = "Mostrar Blobs";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // picBlob
            // 
            this.picBlob.Location = new System.Drawing.Point(295, 255);
            this.picBlob.Name = "picBlob";
            this.picBlob.Size = new System.Drawing.Size(206, 280);
            this.picBlob.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBlob.TabIndex = 6;
            this.picBlob.TabStop = false;
            // 
            // lstBlob
            // 
            this.lstBlob.FormattingEnabled = true;
            this.lstBlob.Location = new System.Drawing.Point(28, 329);
            this.lstBlob.Name = "lstBlob";
            this.lstBlob.Size = new System.Drawing.Size(206, 173);
            this.lstBlob.TabIndex = 7;
            this.lstBlob.SelectedIndexChanged += new System.EventHandler(this.lstBlob_SelectedIndexChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(28, 508);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(206, 53);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar Blob";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 573);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lstBlob);
            this.Controls.Add(this.picBlob);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.btnToken);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBlob)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnToken;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.RichTextBox txtToken;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.PictureBox picBlob;
        private System.Windows.Forms.ListBox lstBlob;
        private System.Windows.Forms.Button btnEliminar;
    }
}

