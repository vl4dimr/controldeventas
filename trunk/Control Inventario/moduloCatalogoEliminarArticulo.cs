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
            sql.open();
            List<string> listaArticulos = new List<string>();
            listaArticulos = sql.llenarListaArticulos();

            foreach (string nom in listaArticulos)
            {
                cArticulos.Items.Add(nom);
            }
            sql.close();
        }

        private void bCrearArticulo_Click(object sender, EventArgs e)
        {
            sql.open();
            Articulo articulo = sql.getArticulo(cArticulos.SelectedItem.ToString());
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
    }
}
