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
    public partial class seleccionarArticuloVenta : Form
    {
        List<Articulo> Articulos;
        mysql sql = new mysql();
        public ModuloVentas ventas;

        public seleccionarArticuloVenta(List<Articulo> ListaArticulos)
        {
            Articulos = ListaArticulos;
            InitializeComponent();
        }

        private void seleccionarArticuloVenta_Load(object sender, EventArgs e)
        {
            DataTable dataTable1 = new DataTable("Articulos");
            dataTable1.Columns.Add("Cant", typeof(string));
            dataTable1.Columns.Add("Nombre", typeof(string));
            dataTable1.Columns.Add("Precio", typeof(string));
            dataTable1.Columns.Add("Existencias", typeof(string));
            dataTable1.Columns.Add("Descripcion", typeof(string));

            foreach (Articulo articulo in Articulos)
            {
                DataRow dataRow = dataTable1.NewRow();
                dataRow["Cant"] = articulo.cantidadVenta.ToString();
                dataRow["Nombre"] = articulo.nombre;
                dataRow["Precio"] = "$" + articulo.precio;
                dataRow["Existencias"] = articulo.existencia.ToString();
                dataRow["Descripcion"] = articulo.descripcion;
                dataTable1.Rows.Add(dataRow);
                dataTable1.AcceptChanges();
            }

            dataGrid.DataSource = dataTable1;
        }

        private void dataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                string nombreArticulo = dataGrid.CurrentRow.Cells[1].Value.ToString();
                int cantidadVenta = int.Parse(dataGrid.CurrentRow.Cells[0].Value.ToString());
                Articulo articulo = sql.getArticulo(nombreArticulo);

                if (cantidadVenta > articulo.existencia)
                {
                    string precaucion = MessageBox.Show("La cantidad solicitada excede la cantidad existente en el inventario.\rDeseas realizar la venta?", "Precaucion", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                    if (precaucion == "Yes")
                    {
                        sql.agregarPreventa(nombreArticulo, cantidadVenta);
                        ventas.actualizarTabla();
                        this.Close();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    sql.agregarPreventa(nombreArticulo, cantidadVenta);
                    ventas.actualizarTabla();
                    this.Close();
                }                
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
    }
}
