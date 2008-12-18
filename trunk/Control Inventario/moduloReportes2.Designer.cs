namespace Control_Inventario
{
    partial class moduloReportes2
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
            this.tipoReporte = new System.Windows.Forms.GroupBox();
            this.checkGeneral = new System.Windows.Forms.CheckBox();
            this.check2fechas = new System.Windows.Forms.CheckBox();
            this.check1fecha = new System.Windows.Forms.CheckBox();
            this.group1fecha = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cajafecha1 = new System.Windows.Forms.TextBox();
            this.group2fechas = new System.Windows.Forms.GroupBox();
            this.cajafecha22 = new System.Windows.Forms.TextBox();
            this.cajafecha21 = new System.Windows.Forms.TextBox();
            this.grupoClaseReporte = new System.Windows.Forms.GroupBox();
            this.comboUsuarios = new System.Windows.Forms.ComboBox();
            this.rasistencia = new System.Windows.Forms.RadioButton();
            this.rArticulos = new System.Windows.Forms.RadioButton();
            this.rprovedoresGen = new System.Windows.Forms.RadioButton();
            this.comboProvedor = new System.Windows.Forms.ComboBox();
            this.rcomprasProvedor = new System.Windows.Forms.RadioButton();
            this.rdevoluciones = new System.Windows.Forms.RadioButton();
            this.ejecutarReporte = new System.Windows.Forms.Button();
            this.rventas = new System.Windows.Forms.RadioButton();
            this.grupoCajaReporte = new System.Windows.Forms.GroupBox();
            this.copyClipBoard = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.cajaReporte = new System.Windows.Forms.TextBox();
            this.tipoReporte.SuspendLayout();
            this.group1fecha.SuspendLayout();
            this.group2fechas.SuspendLayout();
            this.grupoClaseReporte.SuspendLayout();
            this.grupoCajaReporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // tipoReporte
            // 
            this.tipoReporte.Controls.Add(this.checkGeneral);
            this.tipoReporte.Controls.Add(this.check2fechas);
            this.tipoReporte.Controls.Add(this.check1fecha);
            this.tipoReporte.Location = new System.Drawing.Point(12, 12);
            this.tipoReporte.Name = "tipoReporte";
            this.tipoReporte.Size = new System.Drawing.Size(250, 91);
            this.tipoReporte.TabIndex = 0;
            this.tipoReporte.TabStop = false;
            this.tipoReporte.Text = "Selecciona el tipo de reporte (Fechas)";
            // 
            // checkGeneral
            // 
            this.checkGeneral.AutoSize = true;
            this.checkGeneral.Location = new System.Drawing.Point(6, 65);
            this.checkGeneral.Name = "checkGeneral";
            this.checkGeneral.Size = new System.Drawing.Size(104, 17);
            this.checkGeneral.TabIndex = 2;
            this.checkGeneral.Text = "Reporte General";
            this.checkGeneral.UseVisualStyleBackColor = true;
            this.checkGeneral.CheckedChanged += new System.EventHandler(this.checkGeneral_CheckedChanged);
            // 
            // check2fechas
            // 
            this.check2fechas.AutoSize = true;
            this.check2fechas.Location = new System.Drawing.Point(6, 42);
            this.check2fechas.Name = "check2fechas";
            this.check2fechas.Size = new System.Drawing.Size(202, 17);
            this.check2fechas.TabIndex = 1;
            this.check2fechas.Text = "Reporte entre dos fechas especificas";
            this.check2fechas.UseVisualStyleBackColor = true;
            this.check2fechas.CheckedChanged += new System.EventHandler(this.check2fechas_CheckedChanged);
            // 
            // check1fecha
            // 
            this.check1fecha.AutoSize = true;
            this.check1fecha.Location = new System.Drawing.Point(6, 19);
            this.check1fecha.Name = "check1fecha";
            this.check1fecha.Size = new System.Drawing.Size(181, 17);
            this.check1fecha.TabIndex = 0;
            this.check1fecha.Text = "Reporte de una fecha especifica";
            this.check1fecha.UseVisualStyleBackColor = true;
            this.check1fecha.CheckedChanged += new System.EventHandler(this.check1fecha_CheckedChanged);
            // 
            // group1fecha
            // 
            this.group1fecha.Controls.Add(this.label1);
            this.group1fecha.Controls.Add(this.cajafecha1);
            this.group1fecha.Enabled = false;
            this.group1fecha.Location = new System.Drawing.Point(12, 122);
            this.group1fecha.Name = "group1fecha";
            this.group1fecha.Size = new System.Drawing.Size(111, 70);
            this.group1fecha.TabIndex = 1;
            this.group1fecha.TabStop = false;
            this.group1fecha.Text = "Fecha Espeficica";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(9, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Formato dd/mm/aaaa";
            // 
            // cajafecha1
            // 
            this.cajafecha1.Location = new System.Drawing.Point(6, 19);
            this.cajafecha1.Name = "cajafecha1";
            this.cajafecha1.Size = new System.Drawing.Size(99, 20);
            this.cajafecha1.TabIndex = 0;
            this.cajafecha1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cajafecha1.TextChanged += new System.EventHandler(this.fecha1_TextChanged);
            this.cajafecha1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cajafecha1_MouseClick);
            // 
            // group2fechas
            // 
            this.group2fechas.Controls.Add(this.cajafecha22);
            this.group2fechas.Controls.Add(this.cajafecha21);
            this.group2fechas.Enabled = false;
            this.group2fechas.Location = new System.Drawing.Point(129, 122);
            this.group2fechas.Name = "group2fechas";
            this.group2fechas.Size = new System.Drawing.Size(133, 70);
            this.group2fechas.TabIndex = 2;
            this.group2fechas.TabStop = false;
            this.group2fechas.Text = "Fecha Inicio y Fin";
            // 
            // cajafecha22
            // 
            this.cajafecha22.Location = new System.Drawing.Point(6, 44);
            this.cajafecha22.Name = "cajafecha22";
            this.cajafecha22.Size = new System.Drawing.Size(121, 20);
            this.cajafecha22.TabIndex = 2;
            this.cajafecha22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cajafecha22.TextChanged += new System.EventHandler(this.cajafecha22_TextChanged);
            this.cajafecha22.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cajafecha22_MouseClick);
            // 
            // cajafecha21
            // 
            this.cajafecha21.Location = new System.Drawing.Point(6, 19);
            this.cajafecha21.Name = "cajafecha21";
            this.cajafecha21.Size = new System.Drawing.Size(121, 20);
            this.cajafecha21.TabIndex = 1;
            this.cajafecha21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cajafecha21.TextChanged += new System.EventHandler(this.cajafecha21_TextChanged);
            this.cajafecha21.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cajafecha21_MouseClick);
            // 
            // grupoClaseReporte
            // 
            this.grupoClaseReporte.Controls.Add(this.comboUsuarios);
            this.grupoClaseReporte.Controls.Add(this.rasistencia);
            this.grupoClaseReporte.Controls.Add(this.rArticulos);
            this.grupoClaseReporte.Controls.Add(this.rprovedoresGen);
            this.grupoClaseReporte.Controls.Add(this.comboProvedor);
            this.grupoClaseReporte.Controls.Add(this.rcomprasProvedor);
            this.grupoClaseReporte.Controls.Add(this.rdevoluciones);
            this.grupoClaseReporte.Controls.Add(this.rventas);
            this.grupoClaseReporte.Enabled = false;
            this.grupoClaseReporte.Location = new System.Drawing.Point(12, 198);
            this.grupoClaseReporte.Name = "grupoClaseReporte";
            this.grupoClaseReporte.Size = new System.Drawing.Size(250, 192);
            this.grupoClaseReporte.TabIndex = 3;
            this.grupoClaseReporte.TabStop = false;
            this.grupoClaseReporte.Text = "Clase de Reporte";
            // 
            // comboUsuarios
            // 
            this.comboUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUsuarios.FormattingEnabled = true;
            this.comboUsuarios.Location = new System.Drawing.Point(123, 163);
            this.comboUsuarios.Name = "comboUsuarios";
            this.comboUsuarios.Size = new System.Drawing.Size(121, 21);
            this.comboUsuarios.TabIndex = 9;
            this.comboUsuarios.Visible = false;
            // 
            // rasistencia
            // 
            this.rasistencia.AutoSize = true;
            this.rasistencia.Location = new System.Drawing.Point(6, 164);
            this.rasistencia.Name = "rasistencia";
            this.rasistencia.Size = new System.Drawing.Size(124, 17);
            this.rasistencia.TabIndex = 8;
            this.rasistencia.TabStop = true;
            this.rasistencia.Text = "Entradas y Salidas ->";
            this.rasistencia.UseVisualStyleBackColor = true;
            this.rasistencia.CheckedChanged += new System.EventHandler(this.rasistencia_CheckedChanged);
            // 
            // rArticulos
            // 
            this.rArticulos.AutoSize = true;
            this.rArticulos.Location = new System.Drawing.Point(6, 106);
            this.rArticulos.Name = "rArticulos";
            this.rArticulos.Size = new System.Drawing.Size(86, 17);
            this.rArticulos.TabIndex = 7;
            this.rArticulos.TabStop = true;
            this.rArticulos.Text = "Inv. Articulos";
            this.rArticulos.UseVisualStyleBackColor = true;
            this.rArticulos.CheckedChanged += new System.EventHandler(this.rArticulos_CheckedChanged);
            // 
            // rprovedoresGen
            // 
            this.rprovedoresGen.AutoSize = true;
            this.rprovedoresGen.Location = new System.Drawing.Point(6, 79);
            this.rprovedoresGen.Name = "rprovedoresGen";
            this.rprovedoresGen.Size = new System.Drawing.Size(66, 17);
            this.rprovedoresGen.TabIndex = 6;
            this.rprovedoresGen.TabStop = true;
            this.rprovedoresGen.Text = "Compras";
            this.rprovedoresGen.UseVisualStyleBackColor = true;
            this.rprovedoresGen.CheckedChanged += new System.EventHandler(this.rprovedoresGen_CheckedChanged);
            // 
            // comboProvedor
            // 
            this.comboProvedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProvedor.FormattingEnabled = true;
            this.comboProvedor.Location = new System.Drawing.Point(123, 134);
            this.comboProvedor.Name = "comboProvedor";
            this.comboProvedor.Size = new System.Drawing.Size(121, 21);
            this.comboProvedor.TabIndex = 5;
            this.comboProvedor.Visible = false;
            this.comboProvedor.SelectedIndexChanged += new System.EventHandler(this.comboProvedor_SelectedIndexChanged);
            // 
            // rcomprasProvedor
            // 
            this.rcomprasProvedor.AutoSize = true;
            this.rcomprasProvedor.Location = new System.Drawing.Point(6, 135);
            this.rcomprasProvedor.Name = "rcomprasProvedor";
            this.rcomprasProvedor.Size = new System.Drawing.Size(124, 17);
            this.rcomprasProvedor.TabIndex = 4;
            this.rcomprasProvedor.TabStop = true;
            this.rcomprasProvedor.Text = "Compras Provedor ->";
            this.rcomprasProvedor.UseVisualStyleBackColor = true;
            this.rcomprasProvedor.CheckedChanged += new System.EventHandler(this.rcomprasProvedor_CheckedChanged);
            // 
            // rdevoluciones
            // 
            this.rdevoluciones.AutoSize = true;
            this.rdevoluciones.Location = new System.Drawing.Point(6, 52);
            this.rdevoluciones.Name = "rdevoluciones";
            this.rdevoluciones.Size = new System.Drawing.Size(90, 17);
            this.rdevoluciones.TabIndex = 2;
            this.rdevoluciones.TabStop = true;
            this.rdevoluciones.Text = "Devoluciones";
            this.rdevoluciones.UseVisualStyleBackColor = true;
            this.rdevoluciones.CheckedChanged += new System.EventHandler(this.rdevoluciones_CheckedChanged);
            // 
            // ejecutarReporte
            // 
            this.ejecutarReporte.Location = new System.Drawing.Point(283, 333);
            this.ejecutarReporte.Name = "ejecutarReporte";
            this.ejecutarReporte.Size = new System.Drawing.Size(138, 52);
            this.ejecutarReporte.TabIndex = 4;
            this.ejecutarReporte.Text = "Correr Reporte";
            this.ejecutarReporte.UseVisualStyleBackColor = true;
            this.ejecutarReporte.Visible = false;
            this.ejecutarReporte.Click += new System.EventHandler(this.ejecutarReporte_Click);
            // 
            // rventas
            // 
            this.rventas.AutoSize = true;
            this.rventas.Location = new System.Drawing.Point(6, 23);
            this.rventas.Name = "rventas";
            this.rventas.Size = new System.Drawing.Size(107, 17);
            this.rventas.TabIndex = 0;
            this.rventas.TabStop = true;
            this.rventas.Text = "Ventas (Articulos)";
            this.rventas.UseVisualStyleBackColor = true;
            this.rventas.CheckedChanged += new System.EventHandler(this.rventas_CheckedChanged);
            // 
            // grupoCajaReporte
            // 
            this.grupoCajaReporte.Controls.Add(this.cajaReporte);
            this.grupoCajaReporte.Location = new System.Drawing.Point(283, 12);
            this.grupoCajaReporte.Name = "grupoCajaReporte";
            this.grupoCajaReporte.Size = new System.Drawing.Size(357, 315);
            this.grupoCajaReporte.TabIndex = 5;
            this.grupoCajaReporte.TabStop = false;
            this.grupoCajaReporte.Text = "Resultados del Reporte";
            this.grupoCajaReporte.Visible = false;
            // 
            // copyClipBoard
            // 
            this.copyClipBoard.Location = new System.Drawing.Point(427, 333);
            this.copyClipBoard.Name = "copyClipBoard";
            this.copyClipBoard.Size = new System.Drawing.Size(213, 23);
            this.copyClipBoard.TabIndex = 6;
            this.copyClipBoard.Text = "Copiar al Porta Papeles";
            this.copyClipBoard.UseVisualStyleBackColor = true;
            this.copyClipBoard.Visible = false;
            this.copyClipBoard.Click += new System.EventHandler(this.copyClipBoard_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(427, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Salvar reporte en un archivo de texto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cajaReporte
            // 
            this.cajaReporte.BackColor = System.Drawing.SystemColors.Control;
            this.cajaReporte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cajaReporte.Location = new System.Drawing.Point(6, 19);
            this.cajaReporte.Multiline = true;
            this.cajaReporte.Name = "cajaReporte";
            this.cajaReporte.ReadOnly = true;
            this.cajaReporte.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cajaReporte.Size = new System.Drawing.Size(345, 290);
            this.cajaReporte.TabIndex = 0;
            // 
            // moduloReportes2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 397);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.copyClipBoard);
            this.Controls.Add(this.grupoCajaReporte);
            this.Controls.Add(this.grupoClaseReporte);
            this.Controls.Add(this.group2fechas);
            this.Controls.Add(this.group1fecha);
            this.Controls.Add(this.tipoReporte);
            this.Controls.Add(this.ejecutarReporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "moduloReportes2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.moduloReportes2_Load);
            this.tipoReporte.ResumeLayout(false);
            this.tipoReporte.PerformLayout();
            this.group1fecha.ResumeLayout(false);
            this.group1fecha.PerformLayout();
            this.group2fechas.ResumeLayout(false);
            this.group2fechas.PerformLayout();
            this.grupoClaseReporte.ResumeLayout(false);
            this.grupoClaseReporte.PerformLayout();
            this.grupoCajaReporte.ResumeLayout(false);
            this.grupoCajaReporte.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox tipoReporte;
        private System.Windows.Forms.CheckBox check2fechas;
        private System.Windows.Forms.CheckBox check1fecha;
        private System.Windows.Forms.GroupBox group1fecha;
        private System.Windows.Forms.TextBox cajafecha1;
        private System.Windows.Forms.GroupBox group2fechas;
        private System.Windows.Forms.TextBox cajafecha22;
        private System.Windows.Forms.TextBox cajafecha21;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grupoClaseReporte;
        private System.Windows.Forms.RadioButton rdevoluciones;
        private System.Windows.Forms.RadioButton rventas;
        private System.Windows.Forms.ComboBox comboProvedor;
        private System.Windows.Forms.RadioButton rcomprasProvedor;
        private System.Windows.Forms.Button ejecutarReporte;
        private System.Windows.Forms.CheckBox checkGeneral;
        private System.Windows.Forms.GroupBox grupoCajaReporte;
        private System.Windows.Forms.Button copyClipBoard;
        private System.Windows.Forms.RadioButton rprovedoresGen;
        private System.Windows.Forms.RadioButton rArticulos;
        private System.Windows.Forms.RadioButton rasistencia;
        private System.Windows.Forms.ComboBox comboUsuarios;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cajaReporte;
    }
}