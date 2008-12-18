using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Control_Inventario
{
    public partial class moduloReportes2 : Form
    {
        mysql sql = new mysql();

        public moduloReportes2()
        {
            InitializeComponent();
        }

        private void check1fecha_CheckedChanged(object sender, EventArgs e)
        {
            if (check1fecha.Checked)
            {
                checkGeneral.Checked = false;   
                check2fechas.Checked = false;
                group1fecha.Enabled = true;
            }
            else
            {
                group1fecha.Enabled = false;
            }
        }

        private void check2fechas_CheckedChanged(object sender, EventArgs e)
        {
            if (check2fechas.Checked)
            {
                checkGeneral.Checked = false;
                check1fecha.Checked = false;
                group2fechas.Enabled = true;
            }
            else
            {
                group2fechas.Enabled = false;
            }
        }

        private void fecha1_TextChanged(object sender, EventArgs e)
        {
            if (cajafecha1.Text != "" && cajafecha1.Text.Contains('/'))
            {
                grupoClaseReporte.Enabled = true;
            }
            else
            {
                grupoClaseReporte.Enabled = false;
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

        private void moduloReportes2_Load(object sender, EventArgs e)
        {
            comboProvedor.Items.Clear();
            comboUsuarios.Items.Clear();

            
            List<Provedor> listaProvedores = new List<Provedor>();
            listaProvedores = sql.getListaProvedores();

            foreach (Provedor provedor in listaProvedores)
            {
                if (provedor.nombre != "Cliente")
                {
                    comboProvedor.Items.Add(provedor.nombre);
                }
            }

            List<String> listaUsuarios = sql.getlistaUsuarios();
            foreach (String usuario in listaUsuarios)
            {
                comboUsuarios.Items.Add(usuario);
            }

        }

        private void rcomprasProvedor_CheckedChanged(object sender, EventArgs e)
        {
            if (rcomprasProvedor.Checked)
            {
                comboProvedor.Visible = true;
            }
            else
            {
                comboProvedor.Visible = false;
            }
        }

        private void comboProvedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ejecutarReporte.Visible = true;
        }

        private void checkGeneral_CheckedChanged(object sender, EventArgs e)
        {
            if (checkGeneral.Checked)
            {
                check1fecha.Checked = false;
                check2fechas.Checked = false;
                grupoClaseReporte.Enabled = true;
            }
            else
            {
                grupoClaseReporte.Enabled = false;
            }
        }

        private void rventas_CheckedChanged(object sender, EventArgs e)
        {
            ejecutarReporte.Visible = true;
        }

        private void ejecutarReporte_Click(object sender, EventArgs e)
        {
            // AAAA / MM / DD
            string dia = "";
            string mes = "";
            string ano = "";
            string[] preformato;
            cajaReporte.Text = "";

            int tipoFecha = 0; // 1 = 1 Fecha    2 = 2 Fechas   3 = General
            string fecha1 = "";
            string fecha2 = "";
            
            if (check1fecha.Checked) tipoFecha = 1;
            if (check2fechas.Checked) tipoFecha = 2;
            if (checkGeneral.Checked) tipoFecha = 3;

            switch (tipoFecha)
            {
                case 1:
                    fecha1 = cajafecha1.Text;
                    preformato = cajafecha1.Text.Split('/');
                    dia = preformato[0];
                    mes = preformato[1];
                    ano = preformato[2];
                    fecha1 = ano + "-" + mes + "-" + dia;
                    fecha2 = fecha1;
                    break;
                case 2:
                    fecha1 = cajafecha21.Text;
                    preformato = cajafecha21.Text.Split('/');
                    dia = preformato[0];
                    mes = preformato[1];
                    ano = preformato[2];
                    fecha1 = ano + "-" + mes + "-" + dia;

                    fecha2 = cajafecha22.Text;
                    preformato = cajafecha22.Text.Split('/');
                    dia = preformato[0];
                    mes = preformato[1];
                    ano = preformato[2];
                    fecha2 = ano + "-" + mes + "-" + dia;
                    break;
                case 3:
                    fecha1 = "1900-01-01";
                    fecha2 = "2090-12-30";
                    break;
            }

            grupoCajaReporte.Visible = true;
            copyClipBoard.Visible = true;
            button1.Visible = true; // Boton de grabar


            #region Reporte de Ventas Articulo
            if (rventas.Checked)
            {
                cajaReporte.Text = "Tipo de Reporte: Ventas por Articulo." + Environment.NewLine + Environment.NewLine;

                if (fecha1 == "1900-01-01")
                {
                    cajaReporte.Text += "Reporte General (Todo el Tiempo)." + Environment.NewLine + Environment.NewLine;
                }
                else
                {
                    if (fecha1 != fecha2)
                    {
                        cajaReporte.Text += "Reporte entre las Fechas: " + fecha1 + " y " + fecha2 + "." + Environment.NewLine + Environment.NewLine;
                    }
                    else
                    {
                        cajaReporte.Text += "Reporte de la fecha: " + fecha1 + "." + Environment.NewLine + Environment.NewLine;
                    }
                }

                cajaReporte.Text += "----------------------------------------------------------------------------------" + Environment.NewLine + Environment.NewLine;

                
                List<datosReporte> datos = sql.rep_ventasPorArticulo(fecha1, fecha2);

                if (datos != null)
                {
                    float totalGanancia = (float)0.0;
                    int totalArticulos = 0;

                    foreach (datosReporte dat in datos)
                    {
                        float precioTotal = float.Parse(dat.cantidad) * float.Parse(dat.precioArticulo);


                        if (dat.nombreArticulo.Length < 9)
                            cajaReporte.Text += dat.nombreArticulo + "\t\tCant. " + dat.cantidad + "\t\t" + String.Format("{0:C}", precioTotal) + Environment.NewLine;
                        else
                            cajaReporte.Text += dat.nombreArticulo + "\tCant. " + dat.cantidad + "\t\t" + String.Format("{0:C}", precioTotal) + Environment.NewLine;

                        totalGanancia += precioTotal;

                        totalArticulos += int.Parse(dat.cantidad);
                    }

                    cajaReporte.Text += Environment.NewLine + "----------------------------------------------------------------------------------" + Environment.NewLine + Environment.NewLine;

                    cajaReporte.Text += Environment.NewLine + "Total de Articulos Vendidos ----->  " + totalArticulos.ToString() + Environment.NewLine;
                    cajaReporte.Text += Environment.NewLine + "Ganancias Total de Ventas -------> " + String.Format("{0:C}", totalGanancia);
                }
                else
                {
                    cajaReporte.Text = "No existen datos para este reporte.";
                }
            }
            #endregion

            #region Reporte de Devoluciones (Clientes)
            if (rdevoluciones.Checked)
            {
                cajaReporte.Text = "Tipo de Reporte: Devoluciones de Clientes." + Environment.NewLine + Environment.NewLine;

                if (fecha1 == "1900-01-01")
                {
                    cajaReporte.Text += "Reporte General (Todo el Tiempo)." + Environment.NewLine + Environment.NewLine;
                }
                else
                {
                    if (fecha1 != fecha2)
                    {
                        cajaReporte.Text += "Reporte entre las Fechas: " + fecha1 + " y " + fecha2 + "." + Environment.NewLine + Environment.NewLine;
                    }
                    else
                    {
                        cajaReporte.Text += "Reporte de la fecha: " + fecha1 + "." + Environment.NewLine + Environment.NewLine;
                    }
                }

                cajaReporte.Text += "----------------------------------------------------------------------------------" + Environment.NewLine + Environment.NewLine;

                
                List<datosReporte> datos = sql.rep_ComprasPorProvedor(fecha1,fecha2,"Cliente");

                if (datos != null)
                {
                    float totalGanancia = (float)0.0;
                    int totalArticulos = 0;

                    foreach (datosReporte dat in datos)
                    {
                        float precioTotal = float.Parse(dat.cantidad) * float.Parse(dat.precioArticulo);

                        if (dat.nombreArticulo.Length < 9)
                            cajaReporte.Text += dat.nombreArticulo + "\t\tCant. " + dat.cantidad + "\t\t" + String.Format("{0:C}", precioTotal) + Environment.NewLine;
                        else
                            cajaReporte.Text += dat.nombreArticulo + "\tCant. " + dat.cantidad + "\t\t" + String.Format("{0:C}", precioTotal) + Environment.NewLine;

                        totalGanancia += precioTotal;

                        totalArticulos += int.Parse(dat.cantidad);
                    }

                    cajaReporte.Text += Environment.NewLine + "----------------------------------------------------------------------------------" + Environment.NewLine + Environment.NewLine;

                    cajaReporte.Text += Environment.NewLine + "Total de Articulos Devueltos --------->  " + totalArticulos.ToString() + Environment.NewLine;
                    cajaReporte.Text += Environment.NewLine + "Total de Pago de Devoluciones --------> " + String.Format("{0:C}", totalGanancia);
                }
                else
                {
                    cajaReporte.Text = "No existen datos para este reporte.";
                }
            }
            #endregion

            #region Reporte de Compras (Provedor Especifico)
            if (rcomprasProvedor.Checked)
            {
                cajaReporte.Text = "Tipo de Reporte: Compras a un Provedor (" + comboProvedor.SelectedItem.ToString() + ")" + Environment.NewLine + Environment.NewLine;

                if (fecha1 == "1900-01-01")
                {
                    cajaReporte.Text += "Reporte General (Todo el Tiempo)." + Environment.NewLine + Environment.NewLine;
                }
                else
                {
                    if (fecha1 != fecha2)
                    {
                        cajaReporte.Text += "Reporte entre las Fechas: " + fecha1 + " y " + fecha2 + "." + Environment.NewLine + Environment.NewLine;
                    }
                    else
                    {
                        cajaReporte.Text += "Reporte de la fecha: " + fecha1 + "." + Environment.NewLine + Environment.NewLine;
                    }
                }

                cajaReporte.Text += "----------------------------------------------------------------------------------" + Environment.NewLine + Environment.NewLine;

                
                List<datosReporte> datos = sql.rep_ComprasPorProvedor(fecha1, fecha2, comboProvedor.SelectedItem.ToString());

                if (datos != null)
                {
                    float totalGanancia = (float)0.0;
                    int totalArticulos = 0;

                    foreach (datosReporte dat in datos)
                    {
                        float precioTotal = float.Parse(dat.cantidad) * float.Parse(dat.precioArticulo);

                        if (dat.nombreArticulo.Length < 9)
                            cajaReporte.Text += dat.nombreArticulo + "\t\tCant. " + dat.cantidad + "\t\t" + String.Format("{0:C}", precioTotal) + Environment.NewLine;
                        else
                            cajaReporte.Text += dat.nombreArticulo + "\tCant. " + dat.cantidad + "\t\t" + String.Format("{0:C}", precioTotal) + Environment.NewLine;

                        totalGanancia += precioTotal;

                        totalArticulos += int.Parse(dat.cantidad);
                    }

                    cajaReporte.Text += Environment.NewLine + "----------------------------------------------------------------------------------" + Environment.NewLine + Environment.NewLine;

                    cajaReporte.Text += Environment.NewLine + "Total de Articulos Comprados --------->  " + totalArticulos.ToString() + Environment.NewLine;
                    cajaReporte.Text += Environment.NewLine + "Total de Pago por Compras ------------> " + String.Format("{0:C}", totalGanancia);
                }
                else
                {
                    cajaReporte.Text = "No existen datos para este reporte.";
                }
            }
            #endregion

            #region Reporte de Articulos (Cantidades)
            if (rArticulos.Checked)
            {
                cajaReporte.Text = "Tipo de Reporte: Existencias de Articulos." + Environment.NewLine + Environment.NewLine;

                
                List<datosReporte> datos = sql.rep_articulos();

                if (datos != null)
                {
                    float totalGanancia = (float)0.0;
                    int totalArticulos = 0;

                    foreach (datosReporte dat in datos)
                    {
                        float precioTotal = float.Parse(dat.cantidad) * float.Parse(dat.precioArticulo);


                        if (dat.nombreArticulo.Length < 9)
                            cajaReporte.Text += dat.nombreArticulo + "\t\tCant. " + dat.cantidad;
                        else
                            cajaReporte.Text += dat.nombreArticulo + "\tCant. " + dat.cantidad;


                        if (int.Parse(dat.cantidad) <= 0)
                            cajaReporte.Text += " (Agotado)";

                        cajaReporte.Text += Environment.NewLine;
                        totalGanancia += precioTotal;
                        totalArticulos += int.Parse(dat.cantidad);
                    }

                 }
                else
                {
                    cajaReporte.Text = "No existen datos para este reporte.";
                }
            }
            #endregion

            #region Reporte de Compras (Todos los Provedores)
            if (rprovedoresGen.Checked)
            {
                cajaReporte.Text = "Tipo de Reporte: Compras a Provedores" + Environment.NewLine + Environment.NewLine;

                if (fecha1 == "1900-01-01")
                {
                    cajaReporte.Text += "Reporte General (Todo el Tiempo)." + Environment.NewLine + Environment.NewLine;
                }
                else
                {
                    if (fecha1 != fecha2)
                    {
                        cajaReporte.Text += "Reporte entre las Fechas: " + fecha1 + " y " + fecha2 + "." + Environment.NewLine + Environment.NewLine;
                    }
                    else
                    {
                        cajaReporte.Text += "Reporte de la fecha: " + fecha1 + "." + Environment.NewLine + Environment.NewLine;
                    }
                }

                cajaReporte.Text += "----------------------------------------------------------------------------------" + Environment.NewLine + Environment.NewLine;

                
                List<datosReporte> datos = sql.rep_ComprasPorProvedorGenerales(fecha1, fecha2);

                if (datos != null)
                {
                    float totalGanancia = (float)0.0;
                    int totalArticulos = 0;

                    foreach (datosReporte dat in datos)
                    {
                        float precioTotal = float.Parse(dat.cantidad) * float.Parse(dat.precioArticulo);

                        if (dat.nombreArticulo.Length < 9)
                            cajaReporte.Text += dat.nombreArticulo + "\t\tCant. " + dat.cantidad + "\t\t" + String.Format("{0:C}", precioTotal) + Environment.NewLine;
                        else
                            cajaReporte.Text += dat.nombreArticulo + "\tCant. " + dat.cantidad + "\t\t" + String.Format("{0:C}", precioTotal) + Environment.NewLine;

                        totalGanancia += precioTotal;

                        totalArticulos += int.Parse(dat.cantidad);
                    }

                    cajaReporte.Text += Environment.NewLine + "----------------------------------------------------------------------------------" + Environment.NewLine + Environment.NewLine;

                    cajaReporte.Text += Environment.NewLine + "Total de Articulos Comprados --------->  " + totalArticulos.ToString() + Environment.NewLine;
                    cajaReporte.Text += Environment.NewLine + "Total de Pago por Compras ------------> " + String.Format("{0:C}", totalGanancia);
                }
                else
                {
                    cajaReporte.Text = "No existen datos para este reporte.";
                }
            }
            #endregion

            #region Reporte de Entradas y Salidas
            if (rasistencia.Checked)
            {
                cajaReporte.Text = "Tipo de Reporte: Entradas y Salidas de " + comboUsuarios.SelectedItem.ToString() + Environment.NewLine + Environment.NewLine;

                if (fecha1 == "1900-01-01")
                {
                    cajaReporte.Text += "Reporte General (Todo el Tiempo)." + Environment.NewLine + Environment.NewLine;
                }
                else
                {
                    if (fecha1 != fecha2)
                    {
                        cajaReporte.Text += "Reporte entre las Fechas: " + fecha1 + " y " + fecha2 + "." + Environment.NewLine + Environment.NewLine;
                    }
                    else
                    {
                        cajaReporte.Text += "Reporte de la fecha: " + fecha1 + "." + Environment.NewLine + Environment.NewLine;
                    }
                }

                cajaReporte.Text += "----------------------------------------------------------------------------------" + Environment.NewLine + Environment.NewLine;

                

                // CREAR TODO EL SISTEMA
                List<registroEntradasSalidas> datos = sql.rep_entradasysalidas(fecha1, fecha2, comboUsuarios.SelectedItem.ToString());

                if (datos != null)
                {
                    foreach (registroEntradasSalidas dat in datos)
                    {
                        if (dat.tipo == 1)
                            cajaReporte.Text += "Entrada:\t";
                        else
                            cajaReporte.Text += "Salida: \t";

                        cajaReporte.Text += dat.hora + "  ----- " + dat.fecha + Environment.NewLine;
                    }

                    cajaReporte.Text += Environment.NewLine + "----------------------------------------------------------------------------------" + Environment.NewLine + Environment.NewLine;
                }
                else
                {
                    cajaReporte.Text = "No existen datos para este reporte.";
                }

            }
            #endregion

            reiniciarReporte();
            copyClipBoard.Focus();
            ejecutarReporte.Visible = false;
            
        }

        private void reiniciarReporte()
        {
            check1fecha.Checked = false;
            check2fechas.Checked = false;
            checkGeneral.Checked = false;

            grupoClaseReporte.Enabled = false;

            cajafecha1.ResetText();
            cajafecha21.ResetText();
            cajafecha22.ResetText();

            rArticulos.Checked = false;
            rcomprasProvedor.Checked = false;
            rdevoluciones.Checked = false;
            rventas.Checked = false;
            rprovedoresGen.Checked = false;

            rasistencia.Checked = false;
            comboUsuarios.Visible = false;
            comboProvedor.Visible = false;
        }

        

        private void copyClipBoard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reporte copiado con exito al Porta Papeles.");
            Clipboard.SetText(cajaReporte.Text);
        }

        private void rdevoluciones_CheckedChanged(object sender, EventArgs e)
        {
            ejecutarReporte.Visible = true;
        }

        private void rprovedoresGen_CheckedChanged(object sender, EventArgs e)
        {
            ejecutarReporte.Visible = true;
        }

        private void rArticulos_CheckedChanged(object sender, EventArgs e)
        {
            ejecutarReporte.Visible = true;
        }

        private void cajafecha1_MouseClick(object sender, MouseEventArgs e)
        {
            seleccionadorFecha selectFecha = new seleccionadorFecha();
            selectFecha.ShowDialog();
            cajafecha1.Text = selectFecha.fecha;
            selectFecha.Dispose();
        }

        private void cajafecha21_MouseClick(object sender, MouseEventArgs e)
        {
            seleccionadorFecha selectFecha = new seleccionadorFecha();
            selectFecha.ShowDialog();
            cajafecha21.Text = selectFecha.fecha;
            selectFecha.Dispose();
        }

        private void cajafecha22_MouseClick(object sender, MouseEventArgs e)
        {
            seleccionadorFecha selectFecha = new seleccionadorFecha();
            selectFecha.ShowDialog();
            cajafecha22.Text = selectFecha.fecha;
            selectFecha.Dispose();
        }

        private void cajafecha21_TextChanged(object sender, EventArgs e)
        {
            if (cajafecha21.Text != "" && cajafecha21.Text.Contains('/'))
            {
                grupoClaseReporte.Enabled = true;
            }
            else
            {
                grupoClaseReporte.Enabled = false;
            }
        }

        private void cajafecha22_TextChanged(object sender, EventArgs e)
        {
            if (cajafecha22.Text != "" && cajafecha22.Text.Contains('/'))
            {
                grupoClaseReporte.Enabled = true;
            }
            else
            {
                grupoClaseReporte.Enabled = false;
            }
        }

        private void rasistencia_CheckedChanged(object sender, EventArgs e)
        {
            ejecutarReporte.Visible = true;
            comboUsuarios.Visible = true;
        }



        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefiledialog1 = new SaveFileDialog();
            savefiledialog1.Filter = "Archivo Reporte|*.txt";
            savefiledialog1.Title = "Crear archivo de Reporte";

            if (savefiledialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(@savefiledialog1.FileName))
                {
                    sw.Write(cajaReporte.Text);
                }
            } 
        }
    }
}
