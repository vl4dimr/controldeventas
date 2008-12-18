namespace Control_Inventario
{
    partial class moduloFactura
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
            this.cajaNombre = new System.Windows.Forms.TextBox();
            this.cajaImporte = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cajaFecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txCambiarImporte = new System.Windows.Forms.Label();
            this.txCambiarFecha = new System.Windows.Forms.Label();
            this.ejecutarFactura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Cliente";
            // 
            // cajaNombre
            // 
            this.cajaNombre.Location = new System.Drawing.Point(12, 25);
            this.cajaNombre.Name = "cajaNombre";
            this.cajaNombre.Size = new System.Drawing.Size(220, 20);
            this.cajaNombre.TabIndex = 1;
            this.cajaNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cajaImporte
            // 
            this.cajaImporte.Enabled = false;
            this.cajaImporte.Location = new System.Drawing.Point(12, 78);
            this.cajaImporte.Name = "cajaImporte";
            this.cajaImporte.Size = new System.Drawing.Size(169, 20);
            this.cajaImporte.TabIndex = 3;
            this.cajaImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Importe";
            // 
            // cajaFecha
            // 
            this.cajaFecha.Enabled = false;
            this.cajaFecha.Location = new System.Drawing.Point(12, 135);
            this.cajaFecha.Name = "cajaFecha";
            this.cajaFecha.Size = new System.Drawing.Size(169, 20);
            this.cajaFecha.TabIndex = 5;
            this.cajaFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cajaFecha.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cajaFecha_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha";
            // 
            // txCambiarImporte
            // 
            this.txCambiarImporte.AutoSize = true;
            this.txCambiarImporte.ForeColor = System.Drawing.Color.Red;
            this.txCambiarImporte.Location = new System.Drawing.Point(187, 81);
            this.txCambiarImporte.Name = "txCambiarImporte";
            this.txCambiarImporte.Size = new System.Drawing.Size(45, 13);
            this.txCambiarImporte.TabIndex = 6;
            this.txCambiarImporte.Text = "Cambiar";
            this.txCambiarImporte.Click += new System.EventHandler(this.txCambiarImporte_Click);
            // 
            // txCambiarFecha
            // 
            this.txCambiarFecha.AutoSize = true;
            this.txCambiarFecha.ForeColor = System.Drawing.Color.Red;
            this.txCambiarFecha.Location = new System.Drawing.Point(187, 138);
            this.txCambiarFecha.Name = "txCambiarFecha";
            this.txCambiarFecha.Size = new System.Drawing.Size(45, 13);
            this.txCambiarFecha.TabIndex = 7;
            this.txCambiarFecha.Text = "Cambiar";
            this.txCambiarFecha.Click += new System.EventHandler(this.txCambiarFecha_Click);
            // 
            // ejecutarFactura
            // 
            this.ejecutarFactura.Location = new System.Drawing.Point(142, 178);
            this.ejecutarFactura.Name = "ejecutarFactura";
            this.ejecutarFactura.Size = new System.Drawing.Size(90, 23);
            this.ejecutarFactura.TabIndex = 8;
            this.ejecutarFactura.Text = "Facturar";
            this.ejecutarFactura.UseVisualStyleBackColor = true;
            this.ejecutarFactura.Click += new System.EventHandler(this.ejecutarFactura_Click);
            // 
            // moduloFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 213);
            this.Controls.Add(this.ejecutarFactura);
            this.Controls.Add(this.txCambiarFecha);
            this.Controls.Add(this.txCambiarImporte);
            this.Controls.Add(this.cajaFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cajaImporte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cajaNombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "moduloFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Factura";
            this.Load += new System.EventHandler(this.moduloFactura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cajaNombre;
        private System.Windows.Forms.TextBox cajaImporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cajaFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txCambiarImporte;
        private System.Windows.Forms.Label txCambiarFecha;
        private System.Windows.Forms.Button ejecutarFactura;
    }
}