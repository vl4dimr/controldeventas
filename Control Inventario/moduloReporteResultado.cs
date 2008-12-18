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
using System.IO;

namespace Control_Inventario
{
    public partial class moduloReporteResultado : Form
    {
        string fecha1;
        string fecha2;
        string tipoReporte;
        string provedor;

        #region Declaracion Archivos de Texto
        bool archivoTexto = true;
        StreamWriter SW;
        string pathCompleto = "Reportes";
        int sumatoriaArticulos = 0;
        #endregion

        public moduloReporteResultado(string tipo, string fechaInicial, string fechaFinal, bool txt)
        {
            tipoReporte = tipo;
            fecha1 = fechaInicial;
            fecha2 = fechaFinal;
            archivoTexto = txt;
            InitializeComponent();
        }

        public moduloReporteResultado(string tipo, string fechaInicial, string fechaFinal, string prov, bool txt)
        {
            tipoReporte = tipo;
            fecha1 = fechaInicial;
            fecha2 = fechaFinal;
            provedor = prov;
            archivoTexto = txt;
            InitializeComponent();
        }

        private void moduloReporteResultado_Load(object sender, EventArgs e)
        {
            if (archivoTexto)
            {
                try
                {
                    DateTime dt = DateTime.Now;
                    string fecha = dt.Day + "-" + dt.Month + "-" + dt.Year;

                    pathCompleto = "Reportes\\Reporte " + fecha + ".txt";

                    SW = File.CreateText(pathCompleto);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (tipoReporte == "1")
            {
                mysql sql = new mysql();
                List<datosReporte> ListaDeDatos = sql.rep_ventasPorArticulo(fecha1, fecha2);

                DataTable dataTable1 = new DataTable("Articulos");
                dataTable1.Columns.Add("Nombre Articulo", typeof(string));
                dataTable1.Columns.Add("Cantidad Vendida", typeof(string));

                foreach (datosReporte dato in ListaDeDatos)
                {
                    DataRow dataRow = dataTable1.NewRow();
                    dataRow["Nombre Articulo"] = dato.nombreArticulo;
                    dataRow["Cantidad Vendida"] = dato.cantidad;
                    dataTable1.Rows.Add(dataRow);
                    dataTable1.AcceptChanges();

                    #region Creacion de Reporte en Texto
                    if (archivoTexto)
                    {
                        SW.WriteLine(dato.nombreArticulo + "(" + dato.cantidad + ")");
                        sumatoriaArticulos += int.Parse(dato.cantidad);
                    }
                    #endregion
                }

                #region Escribir Totales de Articulos
                if (archivoTexto)
                {
                    SW.WriteLine("");
                    SW.WriteLine("La cantidad total de Articulos vendidos fue: " + sumatoriaArticulos.ToString());
                }
                #endregion

                dataGridView1.DataSource = dataTable1;
            }
            if (tipoReporte == "2")
            {
                mysql sql = new mysql();
                double ganancia = sql.rep_GananciasPorFechas(fecha1, fecha2);

                DataTable dataTable1 = new DataTable("Articulos");
                dataTable1.Columns.Add("Total de Ganancias", typeof(string));

                DataRow dataRow = dataTable1.NewRow();
                dataRow["Total de Ganancias"] = "$" + ganancia.ToString();
                dataTable1.Rows.Add(dataRow);
                dataTable1.AcceptChanges();

                dataGridView1.DataSource = dataTable1;

                #region Escribir total de Ganancias en Texto
                if (archivoTexto)
                {
                    SW.WriteLine("Total de Ganancias: " + ganancia.ToString());
                }
                #endregion
            }

            if (tipoReporte == "3")
            {
                mysql sql = new mysql();
                List<datosReporte> datos = sql.rep_ComprasPorProvedorGenerales(fecha1, fecha2);

                DataTable dataTable1 = new DataTable("Articulos");
                dataTable1.Columns.Add("Provedor", typeof(string));
                dataTable1.Columns.Add("Articulo", typeof(string));
                dataTable1.Columns.Add("Cantidad", typeof(string));

                foreach (datosReporte dato in datos)
                {
                    DataRow dataRow = dataTable1.NewRow();
                    dataRow["Provedor"] = dato.nombreProvedor;
                    dataRow["Articulo"] = dato.nombreArticulo;
                    dataRow["Cantidad"] = dato.cantidad;
                    dataTable1.Rows.Add(dataRow);
                    dataTable1.AcceptChanges();

                    #region Compra de Articulos por provedor
                    if (archivoTexto)
                    {
                        SW.WriteLine(dato.nombreProvedor + " -> " + dato.nombreArticulo + "(" + dato.cantidad + ")");
                    }
                    #endregion
                }               

                dataGridView1.DataSource = dataTable1;
            }
            if (tipoReporte == "4")
            {
                mysql sql = new mysql();
                List<datosReporte> datos = sql.rep_ComprasPorProvedor(fecha1, fecha2, provedor);

                DataTable dataTable1 = new DataTable("Articulos");
                dataTable1.Columns.Add("Provedor", typeof(string));
                dataTable1.Columns.Add("Articulo", typeof(string));
                dataTable1.Columns.Add("Cantidad", typeof(string));

                foreach (datosReporte dato in datos)
                {
                    DataRow dataRow = dataTable1.NewRow();
                    dataRow["Provedor"] = dato.nombreProvedor;
                    dataRow["Articulo"] = dato.nombreArticulo;
                    dataRow["Cantidad"] = dato.cantidad;
                    dataTable1.Rows.Add(dataRow);
                    dataTable1.AcceptChanges();

                    #region Compra de Articulos por provedor
                    if (archivoTexto)
                    {
                        SW.WriteLine(dato.nombreProvedor + " -> " + dato.nombreArticulo + "(" + dato.cantidad + ")");
                    }
                    #endregion
                }

                dataGridView1.DataSource = dataTable1;
            }

            if (archivoTexto)
            {                
                SW.Close();
                System.Diagnostics.Process.Start(pathCompleto);
                this.Close();
            }
        }
    }
}
