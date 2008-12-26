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
    public partial class moduloCompras : Form
    {
        mysql sql = new mysql();

        public moduloCompras()
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
                cajaArticuloAComprar.Text = compra.nombreArticuloFinal;
                cajaCantidad.Enabled = true;
                cajaBusqueda.Clear();
                cajaCantidad.Focus();
            }
        }

        private void moduloCompras_Load(object sender, EventArgs e)
        {
            actualizarCombo();
        }

        public void actualizarCombo()
        {
            comboProvedores.Items.Clear();
            sql.open();
            List<Provedor> listaProvedores = new List<Provedor>();
            listaProvedores = sql.getListaProvedores();

            foreach (Provedor provedor in listaProvedores)
            {
                comboProvedores.Items.Add(provedor.nombre);
            }
            sql.close();
        }
        
        private void comboProvedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboProvedores.Enabled = false;
            cajaBusqueda.Enabled = true;
            cajaBusqueda.Focus();
        }

        private void botonComprar_Click(object sender, EventArgs e)
        {
            sql.open();
            Provedor provedor = sql.getProvedor(comboProvedores.SelectedItem.ToString());
            Articulo articulo = sql.getArticulo(cajaArticuloAComprar.Text);
            int cantidad = int.Parse(cajaCantidad.Text);

            sql.registrarCompra(provedor.id, articulo.id, cantidad);
            MessageBox.Show("Compra realizada!");
            cajaBusqueda.Clear();
            cajaArticuloAComprar.Clear();
            cajaCantidad.Clear();
            cajaBusqueda.Focus();
            sql.close();
        }
         
    
        private void botonBorrar_Click(object sender, EventArgs e)
        {
            cajaCantidad.Text = "";
            cajaArticuloAComprar.Text = "";

            cajaArticuloAComprar.Enabled = false;
            comboProvedores.Enabled = true;
            comboProvedores.ResetText();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            moduloComprasCrearProvedor crearProvedor = new moduloComprasCrearProvedor();
            crearProvedor.compras = this;
            crearProvedor.ShowDialog();
            
        }

        private void comboProvedores_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            moduloComprasBorrarProvedor borrarProvedor = new moduloComprasBorrarProvedor();
            borrarProvedor.ShowDialog();
        }
    }
}
