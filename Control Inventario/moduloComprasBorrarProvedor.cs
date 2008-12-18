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
    public partial class moduloComprasBorrarProvedor : Form
    {
        mysql sql = new mysql();

        public moduloComprasBorrarProvedor()
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

        private void moduloComprasBorrarProvedor_Load(object sender, EventArgs e)
        {
            comboProvedores.Items.Clear();
            sql.open();
            List<Provedor> listaProvedores = new List<Provedor>();
            listaProvedores = sql.getListaProvedores();

            foreach (Provedor provedor in listaProvedores)
            {
                if (provedor.nombre != "Cliente")
                {
                    comboProvedores.Items.Add(provedor.nombre);
                }
            }
            sql.close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql.open();
            sql.eliminarProvedor(comboProvedores.SelectedItem.ToString());
            MessageBox.Show("El provedor " + comboProvedores.SelectedItem.ToString() + " fue eliminado con exito!");
            sql.close();
            this.Close();
        }

        private void comboProvedores_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }
    }
}
