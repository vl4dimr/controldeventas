#define SEGURIDAD_

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Control_Inventario
{
    public partial class Form1 : Form
    {
        public int ID = 0;
        mysql sql = new mysql();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

#if SEGURIDAD_
            try
            {
                this.Hide();

                moduloLogin moduloSeguridad = new moduloLogin();
                moduloSeguridad.frm = this;
                moduloSeguridad.ShowDialog();
                this.Text = "Comercializadora y Distribuidora \"El Sol\" S.A. de C.V. - " + sql.getNombreUsuario(ID);

                desabilitarTodosBotones();
                sql.CheckIn(ID);


                if (sql.getTipoUsuario(ID) == 1)
                {
                    botonModuloEmpleados.Enabled = true;
                    botonModuloCatalogo.Enabled = true;
                    botonModuloVentas.Enabled = true;
                    botonModuloCompras.Enabled = true;
                    botonModuloReportes.Enabled = true;
                    botonCerrarSesion.Enabled = true;
                }
                else
                {
                    botonModuloCatalogo.Enabled = true;
                    botonModuloVentas.Enabled = true;
                    botonCerrarSesion.Enabled = true;
                }

                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("(" + ex.Source + "): " + ex.Message, "Error");
            } 
#else
            botonModuloEmpleados.Enabled = true;
            botonModuloCatalogo.Enabled = true;
            botonModuloVentas.Enabled = true;
            botonModuloCompras.Enabled = true;
            botonModuloReportes.Enabled = true;
            botonCerrarSesion.Visible = false;
            this.Text += " - Modo Admin";
#endif            
        }

        private void desabilitarTodosBotones()
        {
            botonModuloEmpleados.Enabled = false;
            botonModuloCatalogo.Enabled = false;
            botonModuloVentas.Enabled = false;
            botonModuloCompras.Enabled = false;
            botonModuloReportes.Enabled = false;
            botonCerrarSesion.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Modulo de Compras
            moduloCompras compras = new moduloCompras();
            compras.ShowDialog();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
#if SEGURIDAD_
                    cerrarSesion();
#endif
                    break;
            }

            return base.ProcessDialogKey(keyData);
        }

        private void botonModuloEmpleados_Click(object sender, EventArgs e)
        {
            moduloEmpleados empleados = new moduloEmpleados();
            empleados.ShowDialog();
        }

        private void botonModuloCatalogo_Click(object sender, EventArgs e)
        {
            moduloCatalogo catalogo = new moduloCatalogo();
            catalogo.ShowDialog();
        }

        private void botonModuloVentas_Click(object sender, EventArgs e)
        {
            ModuloVentas ventas = new ModuloVentas();
            ventas.ShowDialog();
        }

        private void botonModuloReportes_Click(object sender, EventArgs e)
        {
            moduloReportes2 reportes = new moduloReportes2();
            reportes.ShowDialog();
            reportes.Dispose();
        }

        private void botonCerrarSesion_Click(object sender, EventArgs e)
        {
#if SEGURIDAD_
            cerrarSesion();          
#endif
        }

        private void cerrarSesion()
        {
            string verificarSalida = MessageBox.Show("Deseas salir del sistema?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
            if (verificarSalida == "Yes")
            {
                try
                {
                    sql.CheckOut(ID);
                    this.Hide();

                    moduloLogin moduloSeguridad = new moduloLogin();
                    moduloSeguridad.frm = this;
                    moduloSeguridad.ShowDialog();
                    this.Text = "Comercializadora y Distribuidora \"El Sol\" S.A. de C.V. - " + sql.getNombreUsuario(ID);

                    desabilitarTodosBotones();
                    sql.CheckIn(ID);

                    if (sql.getTipoUsuario(ID) == 1)
                    {
                        botonModuloEmpleados.Enabled = true;
                        botonModuloCatalogo.Enabled = true;
                        botonModuloVentas.Enabled = true;
                        botonModuloCompras.Enabled = true;
                        botonModuloReportes.Enabled = true;
                        botonCerrarSesion.Enabled = true;
                    }
                    else
                    {
                        botonModuloCatalogo.Enabled = true;
                        botonModuloVentas.Enabled = true;
                        botonCerrarSesion.Enabled = true;
                    }

                    this.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("(" + ex.Source + "): " + ex.Message, "Error");
                }

            }
            else
            {
                // No hacer nada
            }            
        }
    }
}
