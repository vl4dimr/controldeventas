namespace Control_Inventario
{
    partial class moduloCatalogoModificarArticulo
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bCrearArticulo = new System.Windows.Forms.Button();
            this.tDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cajaBusqueda = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bCrearArticulo
            // 
            this.bCrearArticulo.Enabled = false;
            this.bCrearArticulo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCrearArticulo.ForeColor = System.Drawing.Color.Black;
            this.bCrearArticulo.Location = new System.Drawing.Point(121, 316);
            this.bCrearArticulo.Name = "bCrearArticulo";
            this.bCrearArticulo.Size = new System.Drawing.Size(130, 26);
            this.bCrearArticulo.TabIndex = 4;
            this.bCrearArticulo.Text = "Modificar Articulo";
            this.bCrearArticulo.UseVisualStyleBackColor = true;
            this.bCrearArticulo.Click += new System.EventHandler(this.bCrearArticulo_Click);
            // 
            // tDescripcion
            // 
            this.tDescripcion.Enabled = false;
            this.tDescripcion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDescripcion.Location = new System.Drawing.Point(15, 200);
            this.tDescripcion.Multiline = true;
            this.tDescripcion.Name = "tDescripcion";
            this.tDescripcion.Size = new System.Drawing.Size(237, 93);
            this.tDescripcion.TabIndex = 3;
            this.tDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(11, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Descripcion:";
            // 
            // tPrecio
            // 
            this.tPrecio.Enabled = false;
            this.tPrecio.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPrecio.Location = new System.Drawing.Point(14, 144);
            this.tPrecio.Name = "tPrecio";
            this.tPrecio.Size = new System.Drawing.Size(238, 21);
            this.tPrecio.TabIndex = 2;
            this.tPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Precio:";
            // 
            // tNombre
            // 
            this.tNombre.Enabled = false;
            this.tNombre.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNombre.Location = new System.Drawing.Point(15, 93);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(237, 21);
            this.tNombre.TabIndex = 1;
            this.tNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Buscar Articulo";
            // 
            // cajaBusqueda
            // 
            this.cajaBusqueda.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaBusqueda.Location = new System.Drawing.Point(14, 25);
            this.cajaBusqueda.Name = "cajaBusqueda";
            this.cajaBusqueda.Size = new System.Drawing.Size(237, 21);
            this.cajaBusqueda.TabIndex = 29;
            this.cajaBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cajaBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cajaBusqueda_KeyDown);
            // 
            // moduloCatalogoModificarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 354);
            this.Controls.Add(this.cajaBusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bCrearArticulo);
            this.Controls.Add(this.tDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "moduloCatalogoModificarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Articulo";
            this.Load += new System.EventHandler(this.moduloCatalogoModificarArticulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCrearArticulo;
        private System.Windows.Forms.TextBox tDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cajaBusqueda;
    }
}