namespace Control_Inventario
{
    partial class moduloCompras
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
            this.comboProvedores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cajaBusqueda = new System.Windows.Forms.TextBox();
            this.cajaArticuloAComprar = new System.Windows.Forms.TextBox();
            this.cajaCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.botonComprar = new System.Windows.Forms.Button();
            this.botonBorrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboProvedores
            // 
            this.comboProvedores.FormattingEnabled = true;
            this.comboProvedores.Location = new System.Drawing.Point(12, 28);
            this.comboProvedores.Name = "comboProvedores";
            this.comboProvedores.Size = new System.Drawing.Size(181, 21);
            this.comboProvedores.TabIndex = 0;
            this.comboProvedores.SelectedIndexChanged += new System.EventHandler(this.comboProvedores_SelectedIndexChanged);
            this.comboProvedores.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboProvedores_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Proveedores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Articulo a Comprar";
            // 
            // cajaBusqueda
            // 
            this.cajaBusqueda.Enabled = false;
            this.cajaBusqueda.Location = new System.Drawing.Point(12, 99);
            this.cajaBusqueda.Name = "cajaBusqueda";
            this.cajaBusqueda.Size = new System.Drawing.Size(181, 20);
            this.cajaBusqueda.TabIndex = 3;
            this.cajaBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cajaBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cajaBusqueda_KeyDown);
            // 
            // cajaArticuloAComprar
            // 
            this.cajaArticuloAComprar.Enabled = false;
            this.cajaArticuloAComprar.Location = new System.Drawing.Point(12, 125);
            this.cajaArticuloAComprar.Name = "cajaArticuloAComprar";
            this.cajaArticuloAComprar.Size = new System.Drawing.Size(181, 20);
            this.cajaArticuloAComprar.TabIndex = 4;
            this.cajaArticuloAComprar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cajaCantidad
            // 
            this.cajaCantidad.Enabled = false;
            this.cajaCantidad.Location = new System.Drawing.Point(12, 176);
            this.cajaCantidad.Name = "cajaCantidad";
            this.cajaCantidad.Size = new System.Drawing.Size(181, 20);
            this.cajaCantidad.TabIndex = 6;
            this.cajaCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cantidad a Comprar";
            // 
            // botonComprar
            // 
            this.botonComprar.Location = new System.Drawing.Point(12, 211);
            this.botonComprar.Name = "botonComprar";
            this.botonComprar.Size = new System.Drawing.Size(110, 23);
            this.botonComprar.TabIndex = 7;
            this.botonComprar.Text = "Registrar Compra";
            this.botonComprar.UseVisualStyleBackColor = true;
            this.botonComprar.Click += new System.EventHandler(this.botonComprar_Click);
            // 
            // botonBorrar
            // 
            this.botonBorrar.Location = new System.Drawing.Point(128, 211);
            this.botonBorrar.Name = "botonBorrar";
            this.botonBorrar.Size = new System.Drawing.Size(65, 23);
            this.botonBorrar.TabIndex = 8;
            this.botonBorrar.Text = "Borrar";
            this.botonBorrar.UseVisualStyleBackColor = true;
            this.botonBorrar.Click += new System.EventHandler(this.botonBorrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(12, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Crear Proveedor";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(104, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Eliminar Provedor";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // moduloCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 246);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.botonBorrar);
            this.Controls.Add(this.botonComprar);
            this.Controls.Add(this.cajaCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cajaArticuloAComprar);
            this.Controls.Add(this.cajaBusqueda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboProvedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "moduloCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulo de Compras";
            this.Load += new System.EventHandler(this.moduloCompras_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboProvedores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cajaBusqueda;
        private System.Windows.Forms.TextBox cajaArticuloAComprar;
        private System.Windows.Forms.TextBox cajaCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botonComprar;
        private System.Windows.Forms.Button botonBorrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}