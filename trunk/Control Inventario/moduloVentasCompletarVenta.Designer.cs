namespace Control_Inventario
{
    partial class moduloVentasCompletarVenta
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
            this.lbCambio = new System.Windows.Forms.Label();
            this.cantidadPagar = new System.Windows.Forms.Label();
            this.lbCantidadRecibida = new System.Windows.Forms.Label();
            this.cajaCantidadRecibida = new System.Windows.Forms.TextBox();
            this.botonFinalizar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ticket = new System.Windows.Forms.Panel();
            this.ticketTexto = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ticketEmpresaInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ticket.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCambio
            // 
            this.lbCambio.AutoSize = true;
            this.lbCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCambio.Location = new System.Drawing.Point(44, 85);
            this.lbCambio.Name = "lbCambio";
            this.lbCambio.Size = new System.Drawing.Size(153, 24);
            this.lbCambio.TabIndex = 0;
            this.lbCambio.Text = "Cantidad a Pagar";
            // 
            // cantidadPagar
            // 
            this.cantidadPagar.AutoSize = true;
            this.cantidadPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadPagar.ForeColor = System.Drawing.Color.Blue;
            this.cantidadPagar.Location = new System.Drawing.Point(44, 109);
            this.cantidadPagar.Name = "cantidadPagar";
            this.cantidadPagar.Size = new System.Drawing.Size(55, 24);
            this.cantidadPagar.TabIndex = 1;
            this.cantidadPagar.Text = "$0.00";
            // 
            // lbCantidadRecibida
            // 
            this.lbCantidadRecibida.AutoSize = true;
            this.lbCantidadRecibida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidadRecibida.Location = new System.Drawing.Point(44, 137);
            this.lbCantidadRecibida.Name = "lbCantidadRecibida";
            this.lbCantidadRecibida.Size = new System.Drawing.Size(163, 24);
            this.lbCantidadRecibida.TabIndex = 2;
            this.lbCantidadRecibida.Text = "Cantidad Recibida";
            // 
            // cajaCantidadRecibida
            // 
            this.cajaCantidadRecibida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaCantidadRecibida.Location = new System.Drawing.Point(48, 164);
            this.cajaCantidadRecibida.Name = "cajaCantidadRecibida";
            this.cajaCantidadRecibida.Size = new System.Drawing.Size(149, 29);
            this.cajaCantidadRecibida.TabIndex = 3;
            this.cajaCantidadRecibida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cajaCantidadRecibida.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cajaCantidadRecibida_KeyDown);
            // 
            // botonFinalizar
            // 
            this.botonFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonFinalizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.botonFinalizar.Location = new System.Drawing.Point(48, 210);
            this.botonFinalizar.Name = "botonFinalizar";
            this.botonFinalizar.Size = new System.Drawing.Size(149, 25);
            this.botonFinalizar.TabIndex = 6;
            this.botonFinalizar.Text = "Finalizar Venta";
            this.botonFinalizar.UseVisualStyleBackColor = true;
            this.botonFinalizar.Click += new System.EventHandler(this.botonFinalizar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelar.ForeColor = System.Drawing.Color.Red;
            this.botonCancelar.Location = new System.Drawing.Point(48, 241);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(149, 25);
            this.botonCancelar.TabIndex = 7;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Control_Inventario.Properties.Resources.Dibujoa;
            this.pictureBox1.Location = new System.Drawing.Point(16, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // ticket
            // 
            this.ticket.Controls.Add(this.ticketEmpresaInfo);
            this.ticket.Controls.Add(this.ticketTexto);
            this.ticket.Controls.Add(this.pictureBox1);
            this.ticket.Location = new System.Drawing.Point(9, 12);
            this.ticket.Name = "ticket";
            this.ticket.Size = new System.Drawing.Size(260, 365);
            this.ticket.TabIndex = 10;
            this.ticket.Visible = false;
            // 
            // ticketTexto
            // 
            this.ticketTexto.AutoSize = true;
            this.ticketTexto.Location = new System.Drawing.Point(13, 123);
            this.ticketTexto.Name = "ticketTexto";
            this.ticketTexto.Size = new System.Drawing.Size(10, 13);
            this.ticketTexto.TabIndex = 11;
            this.ticketTexto.Text = ".";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbCambio);
            this.groupBox1.Controls.Add(this.cantidadPagar);
            this.groupBox1.Controls.Add(this.botonCancelar);
            this.groupBox1.Controls.Add(this.lbCantidadRecibida);
            this.groupBox1.Controls.Add(this.botonFinalizar);
            this.groupBox1.Controls.Add(this.cajaCantidadRecibida);
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 365);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // ticketEmpresaInfo
            // 
            this.ticketEmpresaInfo.AutoSize = true;
            this.ticketEmpresaInfo.Location = new System.Drawing.Point(124, 29);
            this.ticketEmpresaInfo.Name = "ticketEmpresaInfo";
            this.ticketEmpresaInfo.Size = new System.Drawing.Size(10, 13);
            this.ticketEmpresaInfo.TabIndex = 12;
            this.ticketEmpresaInfo.Text = ".";
            // 
            // moduloVentasCompletarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(285, 392);
            this.Controls.Add(this.ticket);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "moduloVentasCompletarVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Completar la venta";
            this.Load += new System.EventHandler(this.moduloVentasCompletarVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ticket.ResumeLayout(false);
            this.ticket.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbCambio;
        private System.Windows.Forms.Label cantidadPagar;
        private System.Windows.Forms.Label lbCantidadRecibida;
        private System.Windows.Forms.TextBox cajaCantidadRecibida;
        private System.Windows.Forms.Button botonFinalizar;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel ticket;
        private System.Windows.Forms.Label ticketTexto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ticketEmpresaInfo;
    }
}