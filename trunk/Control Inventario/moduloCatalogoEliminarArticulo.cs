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
    public partial class moduloCatalogoEliminarArticulo : Form
    {
        mysql sql = new mysql();

        public moduloCatalogoEliminarArticulo()
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

        private void moduloCatalogoEliminarArticulo_Load(object sender, EventArgs e)
        {
            cajaBusqueda.Focus();
        }

        private void bCrearArticulo_Click(object sender, EventArgs e)
        {
            sql.open();
            Articulo articulo = sql.getArticulo(cajaArticulo.Text);
            sql.eliminarArticulo(articulo.id);
            MessageBox.Show("Articulo Eliminado con Exito!");
            sql.close();
            this.Close();
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
                sql.close();
                compra.ShowDialog();
                cajaArticulo.Text = compra.nombreArticuloFinal;
                bCrearArticulo.Visible = true;
                cajaBusqueda.Clear();
                compra.Dispose();
            }
        }
    }
}
