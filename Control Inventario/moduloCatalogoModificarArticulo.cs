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
            sql.open();
            List<string> listaArticulos = new List<string>();
            listaArticulos = sql.llenarListaArticulos();
            foreach(string nom in listaArticulos)
            {
                cArticulos.Items.Add(nom);
            }
            cArticulos.Sorted = true;
            sql.close();
        }

        private void cArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql.open();
            Articulo articulo;
            articulo = sql.getArticulo(cArticulos.SelectedItem.ToString());
            tNombre.Text = articulo.nombre;
            tPrecio.Text = articulo.precio.ToString();
            tDescripcion.Text = articulo.descripcion;
            ID = articulo.id;
            sql.close();
        }

        private void bCrearArticulo_Click(object sender, EventArgs e)
        {
            if (tNombre.Text != "")
            {
                sql.open();
                sql.actualizarArticulo(tNombre.Text, float.Parse(tPrecio.Text), tDescripcion.Text, ID);
                MessageBox.Show("Articulo modificado con exito!");
                sql.close();
                this.Close();
            }
        }

        private void cArticulos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }
    }
}
