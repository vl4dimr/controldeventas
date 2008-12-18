using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Control_Inventario
{
    public class Articulo
    {
        private mysql sql = new mysql();

        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public float precio { get; set; }
        public int existencia { get; set; }
        public int cantidadVenta { get; set; }

        public Articulo(int idArticulo)
        {
            try
            {
                sql.open();
                MySqlDataReader sqlRead = sql.query("SELECT * FROM articulos WHERE id = " + idArticulo.ToString());
                if (sqlRead.HasRows)
                {
                    sqlRead.Read();

                    id = sqlRead.GetInt32(0);
                    nombre = sqlRead.GetString(1);
                    precio = sqlRead.GetFloat(2);
                    descripcion = sqlRead.GetString(3);
                    existencia = int.Parse(sqlRead.GetString(4));
                    cantidadVenta = 1;

                    sqlRead.Close();
                }
                sql.close();
            }
            catch
            {
                
            }
        }

        public Articulo()
        {
            cantidadVenta = 1;
        }
    }
}
