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
    public partial class moduloEmpleados : Form
    {
        mysql sql = new mysql();

        public moduloEmpleados()
        {
            InitializeComponent();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }

            return base.ProcessDialogKey(keyData);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sql.open();

            if (cajaUsuario.Text != "" && cajaNombre.Text != "")
                if (cajaContrasena.Text == cajaContrasena2.Text && cajaContrasena.Text != "")
                {
                    if (!sql.verificarSiExisteUsuario(cajaUsuario.Text))
                    {
                        sql.crearNuevoUsuario(cajaUsuario.Text, cajaContrasena.Text, cajaNombre.Text, "0");
                        MessageBox.Show("Nuevo Empleado Creado Con Exito!", "Creacion de Empleado");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ususario Ya Registrado!", "Error");
                        cajaUsuario.Clear();
                        cajaUsuario.Focus();
                        //Nombre Usuario Invalido
                    }
                }
                else if (cajaContrasena.Text != cajaContrasena2.Text)
                {
                    MessageBox.Show("Las contraseñas no son iguales");
                }

            sql.close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cajaUsuario.Clear();
            cajaNombre.Clear();
            cajaContrasena.Clear();
            cajaContrasena2.Clear();
            cajaNombre.Focus();
        }

        private void moduloEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void cajaNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }
    }
}
