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
    public partial class moduloCatalogo : Form
    {
        mysql sql = new mysql();

        public moduloCatalogo()
        {
            InitializeComponent();
        }

        private void tBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            List<Articulo> Articulos = new List<Articulo>();

            if (e.KeyValue == 13)
            {
                Articulos = sql.buscarArticulo(tBusqueda.Text);

                if (Articulos != null)
                {
                    
                    seleccionarArticulo seleccionar = new seleccionarArticulo(Articulos);
                    seleccionar.ShowDialog(); 
                } 
                else
                {
                    MessageBox.Show("No Existe Ningun Articulo Con Ese Nombre");
                }


                tBusqueda.Clear();
                tBusqueda.Focus();
            }

            if (e.KeyValue == 27)
            {
                this.Close();
            }
                
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

        private void moduloCatalogo_Load(object sender, EventArgs e)
        {
            tBusqueda.Focus();
        }

        private void bCrearArticulo_Click(object sender, EventArgs e)
        {
            moduloCatalogoCrearArticulo crearArticulo = new moduloCatalogoCrearArticulo();
            crearArticulo.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            moduloCatalogoModificarArticulo modificarArticulo = new moduloCatalogoModificarArticulo();
            modificarArticulo.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            moduloCatalogoEliminarArticulo elminarArticulo = new moduloCatalogoEliminarArticulo();
            elminarArticulo.ShowDialog();
        }
    }
}
