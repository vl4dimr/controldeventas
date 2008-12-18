namespace Control_Inventario
{
    partial class moduloReportes
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
            this.boxVentas = new System.Windows.Forms.GroupBox();
            this.cajaFecha3 = new System.Windows.Forms.MaskedTextBox();
            this.cajaFecha2 = new System.Windows.Forms.MaskedTextBox();
            this.cajaFecha1 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.boxCompras = new System.Windows.Forms.GroupBox();
            this.cajaFecha6 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cajaFecha5 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cajaFecha4 = new System.Windows.Forms.MaskedTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cajaFecha12 = new System.Windows.Forms.MaskedTextBox();
            this.cajaFecha11 = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.comboProvedores2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboProvedores1 = new System.Windows.Forms.ComboBox();
            this.cajaFecha10 = new System.Windows.Forms.MaskedTextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cajaFecha9 = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cajaFecha8 = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cajaFecha7 = new System.Windows.Forms.MaskedTextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.checkTexto = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.boxVentas.SuspendLayout();
            this.boxCompras.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxVentas
            // 
            this.boxVentas.Controls.Add(this.cajaFecha3);
            this.boxVentas.Controls.Add(this.cajaFecha2);
            this.boxVentas.Controls.Add(this.cajaFecha1);
            this.boxVentas.Controls.Add(this.label3);
            this.boxVentas.Controls.Add(this.button2);
            this.boxVentas.Controls.Add(this.label2);
            this.boxVentas.Controls.Add(this.button1);
            this.boxVentas.Controls.Add(this.label1);
            this.boxVentas.Location = new System.Drawing.Point(12, 12);
            this.boxVentas.Name = "boxVentas";
            this.boxVentas.Size = new System.Drawing.Size(665, 83);
            this.boxVentas.TabIndex = 4;
            this.boxVentas.TabStop = false;
            this.boxVentas.Text = "Reporte de Ventas";
            this.boxVentas.Enter += new System.EventHandler(this.boxVentas_Enter);
            // 
            // cajaFecha3
            // 
            this.cajaFecha3.Location = new System.Drawing.Point(302, 48);
            this.cajaFecha3.Mask = "0000-00-00";
            this.cajaFecha3.Name = "cajaFecha3";
            this.cajaFecha3.Size = new System.Drawing.Size(80, 20);
            this.cajaFecha3.TabIndex = 3;
            this.cajaFecha3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cajaFecha2
            // 
            this.cajaFecha2.Location = new System.Drawing.Point(202, 48);
            this.cajaFecha2.Mask = "0000-00-00";
            this.cajaFecha2.Name = "cajaFecha2";
            this.cajaFecha2.Size = new System.Drawing.Size(80, 20);
            this.cajaFecha2.TabIndex = 2;
            this.cajaFecha2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cajaFecha1
            // 
            this.cajaFecha1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cajaFecha1.Location = new System.Drawing.Point(202, 13);
            this.cajaFecha1.Mask = "0000-00-00";
            this.cajaFecha1.Name = "cajaFecha1";
            this.cajaFecha1.Size = new System.Drawing.Size(80, 20);
            this.cajaFecha1.TabIndex = 0;
            this.cajaFecha1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "y";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(388, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Ejecutar Reporte";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ver las Ventas entre dos fechas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ejecutar Reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ver las Ventas de un dia especifico";
            // 
            // boxCompras
            // 
            this.boxCompras.Controls.Add(this.cajaFecha6);
            this.boxCompras.Controls.Add(this.label5);
            this.boxCompras.Controls.Add(this.cajaFecha5);
            this.boxCompras.Controls.Add(this.label6);
            this.boxCompras.Controls.Add(this.cajaFecha4);
            this.boxCompras.Controls.Add(this.button4);
            this.boxCompras.Controls.Add(this.label4);
            this.boxCompras.Controls.Add(this.button3);
            this.boxCompras.Location = new System.Drawing.Point(13, 112);
            this.boxCompras.Name = "boxCompras";
            this.boxCompras.Size = new System.Drawing.Size(664, 87);
            this.boxCompras.TabIndex = 6;
            this.boxCompras.TabStop = false;
            this.boxCompras.Text = "Reporte de Ingresos";
            // 
            // cajaFecha6
            // 
            this.cajaFecha6.Location = new System.Drawing.Point(284, 47);
            this.cajaFecha6.Mask = "0000-00-00";
            this.cajaFecha6.Name = "cajaFecha6";
            this.cajaFecha6.Size = new System.Drawing.Size(80, 20);
            this.cajaFecha6.TabIndex = 8;
            this.cajaFecha6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ver los Ingresos entre dos fechas";
            // 
            // cajaFecha5
            // 
            this.cajaFecha5.Location = new System.Drawing.Point(184, 47);
            this.cajaFecha5.Mask = "0000-00-00";
            this.cajaFecha5.Name = "cajaFecha5";
            this.cajaFecha5.Size = new System.Drawing.Size(80, 20);
            this.cajaFecha5.TabIndex = 7;
            this.cajaFecha5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "y";
            // 
            // cajaFecha4
            // 
            this.cajaFecha4.Location = new System.Drawing.Point(201, 13);
            this.cajaFecha4.Mask = "0000-00-00";
            this.cajaFecha4.Name = "cajaFecha4";
            this.cajaFecha4.Size = new System.Drawing.Size(80, 20);
            this.cajaFecha4.TabIndex = 5;
            this.cajaFecha4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(370, 45);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Ejecutar Reporte";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ver los Ingresos de un dia especifico";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(289, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Ejecutar Reporte";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cajaFecha12);
            this.groupBox1.Controls.Add(this.cajaFecha11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.comboProvedores2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.comboProvedores1);
            this.groupBox1.Controls.Add(this.cajaFecha10);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cajaFecha9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cajaFecha8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cajaFecha7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 149);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reporte de Compras";
            // 
            // cajaFecha12
            // 
            this.cajaFecha12.Location = new System.Drawing.Point(477, 109);
            this.cajaFecha12.Mask = "0000-00-00";
            this.cajaFecha12.Name = "cajaFecha12";
            this.cajaFecha12.Size = new System.Drawing.Size(80, 20);
            this.cajaFecha12.TabIndex = 21;
            this.cajaFecha12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cajaFecha11
            // 
            this.cajaFecha11.Location = new System.Drawing.Point(379, 109);
            this.cajaFecha11.Mask = "0000-00-00";
            this.cajaFecha11.Name = "cajaFecha11";
            this.cajaFecha11.Size = new System.Drawing.Size(80, 20);
            this.cajaFecha11.TabIndex = 20;
            this.cajaFecha11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(463, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "y";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(563, 107);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(96, 23);
            this.button8.TabIndex = 22;
            this.button8.Text = "Ejecutar Reporte";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // comboProvedores2
            // 
            this.comboProvedores2.FormattingEnabled = true;
            this.comboProvedores2.Location = new System.Drawing.Point(258, 109);
            this.comboProvedores2.Name = "comboProvedores2";
            this.comboProvedores2.Size = new System.Drawing.Size(115, 21);
            this.comboProvedores2.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(251, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Compras a un Provedor especifico entre dos fechas";
            // 
            // comboProvedores1
            // 
            this.comboProvedores1.FormattingEnabled = true;
            this.comboProvedores1.Location = new System.Drawing.Point(299, 77);
            this.comboProvedores1.Name = "comboProvedores1";
            this.comboProvedores1.Size = new System.Drawing.Size(121, 21);
            this.comboProvedores1.TabIndex = 16;
            // 
            // cajaFecha10
            // 
            this.cajaFecha10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cajaFecha10.Location = new System.Drawing.Point(426, 77);
            this.cajaFecha10.Mask = "0000-00-00";
            this.cajaFecha10.Name = "cajaFecha10";
            this.cajaFecha10.Size = new System.Drawing.Size(80, 20);
            this.cajaFecha10.TabIndex = 17;
            this.cajaFecha10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(514, 75);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(102, 23);
            this.button7.TabIndex = 18;
            this.button7.Text = "Ejecutar Reporte";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(286, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Compras a un Provedor especifico en una fecha especifica";
            // 
            // cajaFecha9
            // 
            this.cajaFecha9.Location = new System.Drawing.Point(309, 44);
            this.cajaFecha9.Mask = "0000-00-00";
            this.cajaFecha9.Name = "cajaFecha9";
            this.cajaFecha9.Size = new System.Drawing.Size(80, 20);
            this.cajaFecha9.TabIndex = 14;
            this.cajaFecha9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Compras a Provedores entre dos fechas";
            // 
            // cajaFecha8
            // 
            this.cajaFecha8.Location = new System.Drawing.Point(209, 44);
            this.cajaFecha8.Mask = "0000-00-00";
            this.cajaFecha8.Name = "cajaFecha8";
            this.cajaFecha8.Size = new System.Drawing.Size(80, 20);
            this.cajaFecha8.TabIndex = 13;
            this.cajaFecha8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(295, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "y";
            // 
            // cajaFecha7
            // 
            this.cajaFecha7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cajaFecha7.Location = new System.Drawing.Point(231, 13);
            this.cajaFecha7.Mask = "0000-00-00";
            this.cajaFecha7.Name = "cajaFecha7";
            this.cajaFecha7.Size = new System.Drawing.Size(80, 20);
            this.cajaFecha7.TabIndex = 10;
            this.cajaFecha7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(395, 42);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 23);
            this.button6.TabIndex = 15;
            this.button6.Text = "Ejecutar Reporte";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(319, 11);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Ejecutar Reporte";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Compras a Provedores en un dia especifico";
            // 
            // checkTexto
            // 
            this.checkTexto.AutoSize = true;
            this.checkTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTexto.Location = new System.Drawing.Point(451, 378);
            this.checkTexto.Name = "checkTexto";
            this.checkTexto.Size = new System.Drawing.Size(224, 17);
            this.checkTexto.TabIndex = 8;
            this.checkTexto.Text = "Crear Reporte en Archivo de Texto";
            this.checkTexto.UseVisualStyleBackColor = true;
            this.checkTexto.CheckedChanged += new System.EventHandler(this.checkTexto_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkRed;
            this.label13.Location = new System.Drawing.Point(12, 373);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 25);
            this.label13.TabIndex = 13;
            this.label13.Text = "AAAA/MM/DD";
            // 
            // moduloReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 407);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.checkTexto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.boxCompras);
            this.Controls.Add(this.boxVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "moduloReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulo de Reportes";
            this.Load += new System.EventHandler(this.moduloReportes_Load);
            this.boxVentas.ResumeLayout(false);
            this.boxVentas.PerformLayout();
            this.boxCompras.ResumeLayout(false);
            this.boxCompras.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox boxVentas;
        private System.Windows.Forms.GroupBox boxCompras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox cajaFecha1;
        private System.Windows.Forms.MaskedTextBox cajaFecha3;
        private System.Windows.Forms.MaskedTextBox cajaFecha2;
        private System.Windows.Forms.MaskedTextBox cajaFecha4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MaskedTextBox cajaFecha6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox cajaFecha5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox cajaFecha7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox cajaFecha9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox cajaFecha8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox comboProvedores1;
        private System.Windows.Forms.MaskedTextBox cajaFecha10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox cajaFecha12;
        private System.Windows.Forms.MaskedTextBox cajaFecha11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox comboProvedores2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkTexto;
        private System.Windows.Forms.Label label13;
    }
}