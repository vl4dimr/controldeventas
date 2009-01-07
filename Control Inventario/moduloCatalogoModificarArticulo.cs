using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Control_Inventario
{
    public partial class moduloCatalogoModificarArticulo : Form
    {
        mysql sql = new mysql();
        int ID;

        public moduloCatalogoModificarArticulo()
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

        private void moduloCatalogoModificarArticulo_Load(object sender, EventArgs e)
        {
            cajaBusqueda.Focus();
        }



        private void bCrearArticulo_Click(object sender, EventArgs e)
        {
            if (tNombre.Text != "")
            {
                sql.open();
                sql.actualizarArticulo(tNombre.Text, float.Parse(tPrecio.Text), tDescripcion.Text, ID);
                MessageBox.Show("Articulo modificado con exito!","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
                sql.close();
                this.Close();
            }
        }

        private void cArticulos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void cajaBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                sql.open();
                List<Articulo> articulos = new List<Articulo>();
                articulos = sql.buscarArticulo(cajaBusqueda.Text);
                seleccionarArticuloCompra compra = new seleccionarArticuloCompra(articulos);
                compra.ShowDialog();
                Articulo art = sql.getArticulo(compra.nombreArticuloFinal);
                sql.close();
                tNombre.Text = art.nombre;
                tPrecio.Text = art.precio.ToString();
                tDescripcion.Text = art.descripcion;
                ID = art.id;
                bCrearArticulo.Visible = true;
                cajaBusqueda.Clear();
                compra.Dispose();

                tNombre.Enabled = true;
                tPrecio.Enabled = true;
                tDescripcion.Enabled = true;
                bCrearArticulo.Enabled = true; // Modificar Articulo
            }
        }
    }
}
