namespace Control_Inventario
{
    partial class moduloCatalogoEliminarArticulo
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
            this.label1 = new System.Windows.Forms.Label();
            this.bCrearArticulo = new System.Windows.Forms.Button();
            this.cajaBusqueda = new System.Windows.Forms.TextBox();
            this.cajaArticulo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Buscar Articulo:";
            // 
            // bCrearArticulo
            // 
            this.bCrearArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCrearArticulo.ForeColor = System.Drawing.Color.Black;
            this.bCrearArticulo.Location = new System.Drawing.Point(12, 77);
            this.bCrearArticulo.Name = "bCrearArticulo";
            this.bCrearArticulo.Size = new System.Drawing.Size(113, 21);
            this.bCrearArticulo.TabIndex = 31;
            this.bCrearArticulo.Text = "Eliminar Articulo";
            this.bCrearArticulo.UseVisualStyleBackColor = true;
            this.bCrearArticulo.Visible = false;
            this.bCrearArticulo.Click += new System.EventHandler(this.bCrearArticulo_Click);
            // 
            // cajaBusqueda
            // 
            this.cajaBusqueda.Location = new System.Drawing.Point(12, 25);
            this.cajaBusqueda.Name = "cajaBusqueda";
            this.cajaBusqueda.Size = new System.Drawing.Size(113, 20);
            this.cajaBusqueda.TabIndex = 32;
            this.cajaBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cajaBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cajaBusqueda_KeyDown);
            // 
            // cajaArticulo
            // 
            this.cajaArticulo.Enabled = false;
            this.cajaArticulo.Location = new System.Drawing.Point(12, 51);
            this.cajaArticulo.Name = "cajaArticulo";
            this.cajaArticulo.Size = new System.Drawing.Size(113, 20);
            this.cajaArticulo.TabIndex = 33;
            this.cajaArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // moduloCatalogoEliminarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(138, 110);
            this.Controls.Add(this.cajaArticulo);
            this.Controls.Add(this.cajaBusqueda);
            this.Controls.Add(this.bCrearArticulo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "moduloCatalogoEliminarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Articulo";
            this.Load += new System.EventHandler(this.moduloCatalogoEliminarArticulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bCrearArticulo;
        private System.Windows.Forms.TextBox cajaBusqueda;
        private System.Windows.Forms.TextBox cajaArticulo;
    }
}