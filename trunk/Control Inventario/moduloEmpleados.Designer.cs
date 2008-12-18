namespace Control_Inventario
{
    partial class moduloEmpleados
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cajaContrasena2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cajaContrasena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cajaUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cajaNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cajaContrasena2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cajaContrasena);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cajaUsuario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cajaNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear nuevo empleado";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(98, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Crear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cajaContrasena2
            // 
            this.cajaContrasena2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cajaContrasena2.Location = new System.Drawing.Point(98, 102);
            this.cajaContrasena2.Name = "cajaContrasena2";
            this.cajaContrasena2.PasswordChar = 'X';
            this.cajaContrasena2.Size = new System.Drawing.Size(170, 20);
            this.cajaContrasena2.TabIndex = 4;
            this.cajaContrasena2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Confirmar";
            // 
            // cajaContrasena
            // 
            this.cajaContrasena.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cajaContrasena.Location = new System.Drawing.Point(98, 76);
            this.cajaContrasena.Name = "cajaContrasena";
            this.cajaContrasena.PasswordChar = 'X';
            this.cajaContrasena.Size = new System.Drawing.Size(170, 20);
            this.cajaContrasena.TabIndex = 3;
            this.cajaContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña";
            // 
            // cajaUsuario
            // 
            this.cajaUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cajaUsuario.Location = new System.Drawing.Point(98, 50);
            this.cajaUsuario.Name = "cajaUsuario";
            this.cajaUsuario.Size = new System.Drawing.Size(170, 20);
            this.cajaUsuario.TabIndex = 2;
            this.cajaUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario";
            // 
            // cajaNombre
            // 
            this.cajaNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cajaNombre.Location = new System.Drawing.Point(98, 24);
            this.cajaNombre.Name = "cajaNombre";
            this.cajaNombre.Size = new System.Drawing.Size(170, 20);
            this.cajaNombre.TabIndex = 1;
            this.cajaNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cajaNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cajaNombre_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // moduloEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 191);
            this.Controls.Add(this.groupBox1);
            this.Name = "moduloEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Empleados";
            this.Load += new System.EventHandler(this.moduloEmpleados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox cajaContrasena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cajaUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cajaNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cajaContrasena2;
        private System.Windows.Forms.Label label4;
    }
}