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
    public partial class moduloComprasCrearProvedor : Form
    {
        public moduloCompras compras;
        mysql sql = new mysql();

        public moduloComprasCrearProvedor()
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

        private void botonCrearProvedor_Click(object sender, EventArgs e)
        {
            if (cajaNombre.Text != "")
            {
                sql.open();
                sql.crearNuevoProvedor(cajaNombre.Text, cajaDireccion.Text, cajaTelefono.Text, cajaRFC.Text);
                MessageBox.Show("Proveedor Creado Con Exito!");
                compras.actualizarCombo();
                sql.close();
                this.Close();
            }
        }

        private void cajaNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cajaNombre.ResetText();
            cajaDireccion.ResetText();
            cajaRFC.ResetText();
            cajaTelefono.ResetText();
            cajaNombre.Focus();
        }

        private void moduloComprasCrearProvedor_Load(object sender, EventArgs e)
        {

        }
    }
}
