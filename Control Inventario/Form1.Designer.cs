namespace Control_Inventario
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.botonModuloCompras = new System.Windows.Forms.Button();
            this.botonModuloCatalogo = new System.Windows.Forms.Button();
            this.botonModuloVentas = new System.Windows.Forms.Button();
            this.botonModuloEmpleados = new System.Windows.Forms.Button();
            this.botonModuloReportes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botonCerrarSesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // botonModuloCompras
            // 
            this.botonModuloCompras.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonModuloCompras.Enabled = false;
            this.botonModuloCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonModuloCompras.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonModuloCompras.Location = new System.Drawing.Point(244, 82);
            this.botonModuloCompras.Name = "botonModuloCompras";
            this.botonModuloCompras.Size = new System.Drawing.Size(188, 29);
            this.botonModuloCompras.TabIndex = 2;
            this.botonModuloCompras.Text = "Compras | Devoluciones";
            this.botonModuloCompras.UseVisualStyleBackColor = false;
            this.botonModuloCompras.Click += new System.EventHandler(this.button1_Click);
            // 
            // botonModuloCatalogo
            // 
            this.botonModuloCatalogo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonModuloCatalogo.Enabled = false;
            this.botonModuloCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonModuloCatalogo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonModuloCatalogo.Location = new System.Drawing.Point(244, 12);
            this.botonModuloCatalogo.Name = "botonModuloCatalogo";
            this.botonModuloCatalogo.Size = new System.Drawing.Size(188, 29);
            this.botonModuloCatalogo.TabIndex = 0;
            this.botonModuloCatalogo.Text = "Catalogo de Articulos";
            this.botonModuloCatalogo.UseVisualStyleBackColor = false;
            this.botonModuloCatalogo.Click += new System.EventHandler(this.botonModuloCatalogo_Click);
            // 
            // botonModuloVentas
            // 
            this.botonModuloVentas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonModuloVentas.Enabled = false;
            this.botonModuloVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonModuloVentas.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonModuloVentas.Location = new System.Drawing.Point(244, 47);
            this.botonModuloVentas.Name = "botonModuloVentas";
            this.botonModuloVentas.Size = new System.Drawing.Size(188, 29);
            this.botonModuloVentas.TabIndex = 1;
            this.botonModuloVentas.Text = "Sistema de Ventas";
            this.botonModuloVentas.UseVisualStyleBackColor = false;
            this.botonModuloVentas.Click += new System.EventHandler(this.botonModuloVentas_Click);
            // 
            // botonModuloEmpleados
            // 
            this.botonModuloEmpleados.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonModuloEmpleados.Enabled = false;
            this.botonModuloEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonModuloEmpleados.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonModuloEmpleados.Location = new System.Drawing.Point(244, 117);
            this.botonModuloEmpleados.Name = "botonModuloEmpleados";
            this.botonModuloEmpleados.Size = new System.Drawing.Size(188, 29);
            this.botonModuloEmpleados.TabIndex = 3;
            this.botonModuloEmpleados.Text = "Control de Empleados";
            this.botonModuloEmpleados.UseVisualStyleBackColor = false;
            this.botonModuloEmpleados.Click += new System.EventHandler(this.botonModuloEmpleados_Click);
            // 
            // botonModuloReportes
            // 
            this.botonModuloReportes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonModuloReportes.Enabled = false;
            this.botonModuloReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonModuloReportes.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonModuloReportes.Location = new System.Drawing.Point(244, 152);
            this.botonModuloReportes.Name = "botonModuloReportes";
            this.botonModuloReportes.Size = new System.Drawing.Size(130, 29);
            this.botonModuloReportes.TabIndex = 4;
            this.botonModuloReportes.Text = "Reportes";
            this.botonModuloReportes.UseVisualStyleBackColor = false;
            this.botonModuloReportes.Click += new System.EventHandler(this.botonModuloReportes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // botonCerrarSesion
            // 
            this.botonCerrarSesion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCerrarSesion.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCerrarSesion.Location = new System.Drawing.Point(380, 152);
            this.botonCerrarSesion.Name = "botonCerrarSesion";
            this.botonCerrarSesion.Size = new System.Drawing.Size(52, 29);
            this.botonCerrarSesion.TabIndex = 7;
            this.botonCerrarSesion.Text = "Salir";
            this.botonCerrarSesion.UseVisualStyleBackColor = false;
            this.botonCerrarSesion.Click += new System.EventHandler(this.botonCerrarSesion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(447, 192);
            this.Controls.Add(this.botonCerrarSesion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.botonModuloReportes);
            this.Controls.Add(this.botonModuloEmpleados);
            this.Controls.Add(this.botonModuloVentas);
            this.Controls.Add(this.botonModuloCatalogo);
            this.Controls.Add(this.botonModuloCompras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comercializadora y Distribuidora \"El Sol\" S.A. de C.V.";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonModuloCompras;
        private System.Windows.Forms.Button botonModuloCatalogo;
        private System.Windows.Forms.Button botonModuloVentas;
        private System.Windows.Forms.Button botonModuloEmpleados;
        private System.Windows.Forms.Button botonModuloReportes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button botonCerrarSesion;
    }
}

