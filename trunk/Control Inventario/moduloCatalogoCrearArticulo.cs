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
    public partial class moduloCatalogoCrearArticulo : Form
    {
        mysql sql = new mysql();

        public moduloCatalogoCrearArticulo()
        {
            InitializeComponent();
        }

        private void bCrearArticulo_Click(object sender, EventArgs e)
        {
            if (tNombre.Text != "")
            {
                sql.open();
                sql.crearNuevoArticulo(tNombre.Text, float.Parse(tPrecio.Text), tDescripcion.Text, tExistencia.Text);
                MessageBox.Show("Articulo creado con exito!");
                tNombre.Clear();
                tExistencia.Clear();
                tPrecio.Clear();
                tDescripcion.Clear();
                sql.close();
                this.Close();
            }
        }

        private void tNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void moduloCatalogoCrearArticulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void moduloCatalogoCrearArticulo_Load(object sender, EventArgs e)
        {

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
    }
}
