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
    public partial class seleccionadorFecha : Form
    {
        public string fecha;

        public seleccionadorFecha()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            fecha = monthCalendar1.SelectionStart.Day.ToString() + "/";
            fecha += monthCalendar1.SelectionStart.Month.ToString() + "/";
            fecha += monthCalendar1.SelectionStart.Year.ToString();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    this.Close();
                    break;

                case Keys.Enter:
                    fecha = monthCalendar1.SelectionStart.Day.ToString() + "/";
                    fecha += monthCalendar1.SelectionStart.Month.ToString() + "/";
                    fecha += monthCalendar1.SelectionStart.Year.ToString();
                    this.Close();
                    break;
            }

            return base.ProcessDialogKey(keyData);
        }

        private void seleccionadorFecha_Load(object sender, EventArgs e)
        {

        }
    }
}
