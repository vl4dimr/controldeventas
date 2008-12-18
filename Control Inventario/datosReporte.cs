using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Control_Inventario
{
    class datosReporte
    {
        private mysql sql = new mysql();

        public string idArticulo { get; set; }
        public string nombreArticulo { get; set; }
        public string cantidad { get; set; }
        public string idProvedor { get; set; }
        public string nombreProvedor { get; set; }
        public string precioArticulo { get; set; }

        public datosReporte(int idArticulo)
        {
            Articulo articulo = new Articulo(idArticulo);
            nombreArticulo = articulo.nombre;
            idArticulo = articulo.id;
            precioArticulo = articulo.precio.ToString();
        }
        
        public datosReporte()
        {
        }

    }
}
