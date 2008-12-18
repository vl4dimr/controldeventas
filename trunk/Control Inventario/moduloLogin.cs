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
    public partial class moduloLogin : Form
    {
        public Form1 frm;

        public moduloLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            validarInformacion();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cajaContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                validarInformacion();
        }

        private void validarInformacion()
        {
            try
            {
                mysql sql = new mysql();
                sql.open();
                int id = sql.validarUsuario(cajaUsuario.Text, cajaContrasena.Text);

                if (id != 0)
                {
                    frm.ID = id;
                    sql.close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El nombre de usuario o contraseña es incorrecto.", "Usuario Invalido");
                    cajaContrasena.Clear();
                    cajaUsuario.Clear();
                    cajaUsuario.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("(" + ex.Source + "): " + ex.Message, "Error");
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    Application.Exit();
                    break;
            }

            return base.ProcessDialogKey(keyData);
        }

        private void moduloLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
