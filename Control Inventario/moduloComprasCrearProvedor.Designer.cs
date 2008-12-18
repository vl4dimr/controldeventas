namespace Control_Inventario
{
    partial class moduloComprasCrearProvedor
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
            this.cajaNombre = new System.Windows.Forms.TextBox();
            this.cajaDireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cajaTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cajaRFC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.botonCrearProvedor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // cajaNombre
            // 
            this.cajaNombre.Location = new System.Drawing.Point(12, 25);
            this.cajaNombre.Name = "cajaNombre";
            this.cajaNombre.Size = new System.Drawing.Size(163, 20);
            this.cajaNombre.TabIndex = 1;
            this.cajaNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cajaNombre_KeyDown);
            // 
            // cajaDireccion
            // 
            this.cajaDireccion.Location = new System.Drawing.Point(12, 64);
            this.cajaDireccion.Name = "cajaDireccion";
            this.cajaDireccion.Size = new System.Drawing.Size(163, 20);
            this.cajaDireccion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Direccion";
            // 
            // cajaTelefono
            // 
            this.cajaTelefono.Location = new System.Drawing.Point(12, 103);
            this.cajaTelefono.Name = "cajaTelefono";
            this.cajaTelefono.Size = new System.Drawing.Size(163, 20);
            this.cajaTelefono.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefono";
            // 
            // cajaRFC
            // 
            this.cajaRFC.Location = new System.Drawing.Point(12, 142);
            this.cajaRFC.Name = "cajaRFC";
            this.cajaRFC.Size = new System.Drawing.Size(163, 20);
            this.cajaRFC.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "RFC";
            // 
            // botonCrearProvedor
            // 
            this.botonCrearProvedor.Location = new System.Drawing.Point(15, 176);
            this.botonCrearProvedor.Name = "botonCrearProvedor";
            this.botonCrearProvedor.Size = new System.Drawing.Size(95, 23);
            this.botonCrearProvedor.TabIndex = 8;
            this.botonCrearProvedor.Text = "Crear Proveedor";
            this.botonCrearProvedor.UseVisualStyleBackColor = true;
            this.botonCrearProvedor.Click += new System.EventHandler(this.botonCrearProvedor_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // moduloComprasCrearProvedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 208);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.botonCrearProvedor);
            this.Controls.Add(this.cajaRFC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cajaTelefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cajaDireccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cajaNombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "moduloComprasCrearProvedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Proveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cajaNombre;
        private System.Windows.Forms.TextBox cajaDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cajaTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cajaRFC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button botonCrearProvedor;
        private System.Windows.Forms.Button button1;
    }
}