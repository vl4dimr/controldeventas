#define DEBUG_

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
    public partial class ModuloVentas : Form
    {
        mysql sql = new mysql();
        float precio = 0;

        public ModuloVentas()
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

                case Keys.F1:
                    moduloCatalogo catalogo = new moduloCatalogo();
                    catalogo.ShowDialog();
                    catalogo.Dispose();
                    break;

                case Keys.F2:
                    registrarDevolucionCliente();
                    break;
            }

            return base.ProcessDialogKey(keyData);
        }

        private void registrarDevolucionCliente()
        {
            try
            {
                mysql sql = new mysql();
                Articulo articulo = sql.getArticulo(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                int cantidad = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                Provedor provedor = sql.getProvedor("Cliente");

                string verificarInfo = MessageBox.Show("Articulo: " + articulo.nombre + Environment.NewLine + "Cantidad: " + cantidad.ToString(), "Confirmar devolucion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();

                if (verificarInfo == "OK")
                {
                    sql.registrarCompra(provedor.id, articulo.id, cantidad);
                    sql.cancelarVenta();
                    actualizarTabla();
                    cajaBusqueda.Focus();
                }                
            }
            catch (Exception ex)
            {
#if DEBUG_
                MessageBox.Show("Error: " + ex.Message + Environment.NewLine + Environment.NewLine + "Posible Causa: No existen articulos a regresar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private void cajaBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            List<Articulo> Articulos = new List<Articulo>();
            //MessageBox.Show(e.KeyValue.ToString());

            if (e.KeyValue == 13) // Enter
            {
                Articulos = sql.buscarArticulo(cajaBusqueda.Text);

                if (Articulos != null)
                {
                    seleccionarArticuloVenta seleccionar = new seleccionarArticuloVenta(Articulos);
                    seleccionar.ventas = this;
                    seleccionar.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No existe ningun articulo con ese nombre");
                }


                cajaBusqueda.Clear();
                cajaBusqueda.Focus();
            }

            if (e.KeyValue == 27) // Esc
            {
                this.Close();
            }

            if (e.KeyValue == 46) // Delete
            {
                string confirmar = MessageBox.Show("Deseas cancelar la venta?", "Cancelar Venta", MessageBoxButtons.YesNo,MessageBoxIcon.Question).ToString();
                if (confirmar == "Yes")
                {
                    sql.cancelarVenta();
                    actualizarTabla();
                    cajaBusqueda.Focus();
                }
            }

            if (e.KeyValue == 45) // Insert
            {
                if (sql.existenArticulosPreventa())
                {
                    moduloVentasCompletarVenta completarVenta = new moduloVentasCompletarVenta();
                    completarVenta.precioPagar = precio;
                    completarVenta.modVenta = this;
                    completarVenta.ShowDialog();
                }
            }
        }

        private void ModuloVentas_Load(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ModuloVentas_Enter(object sender, EventArgs e)
        {
        }

        private void botonRefresh_Click(object sender, EventArgs e)
        {
            sql.cancelarVenta();
            actualizarTabla();
            cajaBusqueda.Focus();
        }

        public void actualizarTabla()
        {
            precio = 0;
            List<Articulo> Articulos;
            Articulos = sql.getArticulosPreventa();

            DataTable dataTable1 = new DataTable("Articulos");
            dataTable1.Columns.Add("Cant", typeof(string));
            dataTable1.Columns.Add("Nombre", typeof(string));
            dataTable1.Columns.Add("Precio", typeof(string));  

            if (Articulos != null)
            {
                foreach (Articulo articulo in Articulos)
                {
                    DataRow dataRow = dataTable1.NewRow();
                    dataRow["Cant"] = articulo.cantidadVenta.ToString();
                    dataRow["Nombre"] = articulo.nombre;
                    dataRow["Precio"] = string.Format("{0:C}", articulo.precio);
                    precio += articulo.precio * articulo.cantidadVenta;
                    dataTable1.Rows.Add(dataRow);
                    dataTable1.AcceptChanges();
                }                
            }

            if (precio == 0) cajaPrecio.Text = "$0.00";
            else cajaPrecio.Text = string.Format("{0:C}",precio);
            dataGridView1.DataSource = dataTable1;
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 46)
            {
                try
                {
                    string nombreArticulo = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    int cantidadVenta = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    Articulo articulo = sql.getArticulo(nombreArticulo);
                    sql.eliminarArticuloPreventa(articulo.id, cantidadVenta);
                    actualizarTabla();
                }
                catch (Exception ex)
                {
#if DEBUG_
                    MessageBox.Show("Error: " + ex.Message + Environment.NewLine + Environment.NewLine + "Posible Causa: No existen articulos a eliminar.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
#endif
                }
            }

            if (e.KeyValue == 113)
            {
                registrarDevolucionCliente();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sql.existenArticulosPreventa())
            {
                moduloVentasCompletarVenta completarVenta = new moduloVentasCompletarVenta();
                completarVenta.precioPagar = precio;
                completarVenta.modVenta = this;
                completarVenta.ShowDialog();
            }
        }
    }
}
