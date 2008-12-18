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
    public partial class seleccionarArticuloCompra : Form
    {
        List<Articulo> Articulos;
        mysql sql = new mysql();
        public moduloCompras compras;

        public seleccionarArticuloCompra(List<Articulo> ListaArticulos)
        {
            Articulos = ListaArticulos;
            InitializeComponent();
        }

        private void seleccionarArticuloCompra_Load(object sender, EventArgs e)
        {
            DataTable dataTable1 = new DataTable("Articulos");
            dataTable1.Columns.Add("Nombre", typeof(string));
            dataTable1.Columns.Add("Descripcion", typeof(string));

            foreach (Articulo articulo in Articulos)
            {
                DataRow dataRow = dataTable1.NewRow();
                dataRow["Nombre"] = articulo.nombre;
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
                sql.open();
                string nombreArticulo = dataGrid.CurrentRow.Cells[0].Value.ToString();
                Articulo articulo = sql.getArticulo(nombreArticulo);
                compras.setArticulo(articulo.nombre);
                sql.close();
                this.Close();

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
