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
    public partial class moduloReportes : Form
    {
        public moduloReportes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {         
            moduloReporteResultado reporte = new moduloReporteResultado("1", cajaFecha1.Text, cajaFecha1.Text, checkTexto.Checked);
            reporte.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            moduloReporteResultado reporte = new moduloReporteResultado("1", cajaFecha2.Text, cajaFecha3.Text, checkTexto.Checked);
            reporte.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            moduloReporteResultado reporte = new moduloReporteResultado("2", cajaFecha4.Text, cajaFecha4.Text, checkTexto.Checked);
            reporte.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            moduloReporteResultado reporte = new moduloReporteResultado("2", cajaFecha5.Text, cajaFecha6.Text, checkTexto.Checked);
            reporte.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            moduloReporteResultado reporte = new moduloReporteResultado("3", cajaFecha7.Text, cajaFecha7.Text, "", checkTexto.Checked);
            reporte.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            moduloReporteResultado reporte = new moduloReporteResultado("3", cajaFecha8.Text, cajaFecha9.Text, "", checkTexto.Checked);
            reporte.ShowDialog();
        }

        private void moduloReportes_Load(object sender, EventArgs e)
        {
            comboProvedores1.Items.Clear();
            mysql sql = new mysql();
            List<Provedor> listaProvedores = new List<Provedor>();
            listaProvedores = sql.getListaProvedores();

            foreach (Provedor provedor in listaProvedores)
            {
                comboProvedores1.Items.Add(provedor.nombre);
                comboProvedores2.Items.Add(provedor.nombre);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            moduloReporteResultado reporte = new moduloReporteResultado("4", cajaFecha10.Text, cajaFecha10.Text, comboProvedores1.SelectedItem.ToString(), checkTexto.Checked);
            reporte.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            moduloReporteResultado reporte = new moduloReporteResultado("4", cajaFecha11.Text, cajaFecha12.Text, comboProvedores2.SelectedItem.ToString(), checkTexto.Checked);
            reporte.ShowDialog();
        }

        private void boxVentas_Enter(object sender, EventArgs e)
        {

        }

        private void checkTexto_CheckedChanged(object sender, EventArgs e)
        {

        }    

   

 
    }
}
