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
    public partial class seleccionarArticulo : Form
    {
        List<Articulo> Articulos;

        public seleccionarArticulo(List<Articulo> ListaArticulos)
        {
            Articulos = ListaArticulos;
            InitializeComponent();
        }

        private void seleccionarArticulo_Load(object sender, EventArgs e)
        {
            DataTable dataTable1 = new DataTable("Articulos");
            dataTable1.Columns.Add("Nombre", typeof(string));
            dataTable1.Columns.Add("Precio", typeof(string));
            dataTable1.Columns.Add("Existencias", typeof(string));
            dataTable1.Columns.Add("Descripcion", typeof(string));

            foreach(Articulo articulo in Articulos)
            {
                DataRow dataRow = dataTable1.NewRow();
                dataRow["Nombre"] = articulo.nombre;
                dataRow["Precio"] = "$" + articulo.precio;
                dataRow["Existencias"] = articulo.existencia.ToString();
                dataRow["Descripcion"] = articulo.descripcion;
                dataTable1.Rows.Add(dataRow);
                dataTable1.AcceptChanges();
            }

            dataGrid.DataSource = dataTable1;
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGrid_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void dataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27 || e.KeyValue == 13)
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
