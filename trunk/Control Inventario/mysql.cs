#define SISTEMA_FACTURAS_

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Control_Inventario
{
    class mysql
    {
        public MySqlConnection sqlCon;
        public MySqlConnection sqlCon2;

        public mysql()
        {
            string host = "localhost";
            string database = "inventario";
            string user = "root";
            string password = "";

            string strProvider = "Data Source=" + host + ";Database=" + database + ";User ID=" + user + ";Password=" + password + ";pooling=false;";
            sqlCon = new MySqlConnection(strProvider);
        }

        public void open()
        {
            try
            {
                if (sqlCon != null)
                {
                    if (sqlCon.State == System.Data.ConnectionState.Closed)
                        sqlCon.Open();
                    //MessageBox.Show("Open -> sqlCon");
                }

                if (sqlCon2 != null)
                {
                    if (sqlCon2.State == System.Data.ConnectionState.Closed)
                        sqlCon2.Open();
                    //MessageBox.Show("Open -> sqlCon2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error MySql -> " + ex.Message);
            }
        }

        public void close()
        {
            try
            {
                if (sqlCon != null)
                {
                    sqlCon.Close();
                    sqlCon.Dispose();
                    //MessageBox.Show("Kill -> sqlCon");
                }

                if (sqlCon2 != null)
                {
                    sqlCon2.Close();
                    sqlCon2.Dispose();
                    //MessageBox.Show("Kill -> sqlCon2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CheckIn(int id)
        {
            string query = "INSERT INTO asistencia(idUsuario,fecha,hora,tipo) VALUES (" + id + ",CURDATE(),CURTIME(),1)";
            MySqlCommand sqlCom = new MySqlCommand(query, sqlCon);
            sqlCom.ExecuteNonQuery();
        }

        public void CheckOut(int id)
        {
            string query = "INSERT INTO asistencia(idUsuario,fecha,hora,tipo) VALUES (" + id + ",CURDATE(),CURTIME(),2)";
            MySqlCommand sqlCom = new MySqlCommand(query, sqlCon);
            sqlCom.ExecuteNonQuery();
        }

        private void conexionAlternativa()
        {
            string host = "localhost";
            string database = "inventario";
            string user = "root";
            string password = "";

            string strProvider = "Data Source=" + host + ";Database=" + database + ";User ID=" + user + ";Password=" + password;
            sqlCon2 = new MySqlConnection(strProvider);
            try
            {
                this.open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el servidor SQL, favor de verificar conexion.\r\rError MySQL:\r" + ex.Message);
            }
        }

        public MySqlDataReader query(string strQuery)
        {
            try
            {
                MySqlCommand sqlCom = new MySqlCommand(strQuery, sqlCon);
                MySqlDataReader sqlRead = sqlCom.ExecuteReader();
                sqlCom.Dispose();
                return sqlRead;                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
                return null;
            }
        }        

        public int validarUsuario(string user, string pass)
        {
            MySqlDataReader sqlRead = this.query("SELECT id FROM usuarios WHERE user = '" + user + "' AND password = '" + pass + "'");
            if (sqlRead.HasRows == true)
            {
                sqlRead.Read();
                int id = sqlRead.GetInt32(0);
                sqlRead.Close();
                return id;
            }
            else
            {
                return 0;
            }
        }

        public string getNombreUsuario(int id)
        {
            MySqlDataReader sqlRead = this.query("SELECT nombre FROM usuarios WHERE id = " + id.ToString());
            if (sqlRead.HasRows == true)
            {
                sqlRead.Read();
                string nombre = sqlRead.GetString(0);
                sqlRead.Close();
                
                return nombre;
            }
            else
            {
                sqlRead.Close();
                return "";
            }
        }

        public int getIdUsuario(String nombre)
        {
            MySqlDataReader sqlRead = this.query("SELECT id FROM usuarios WHERE nombre LIKE '%" + nombre + "%'");
            if (sqlRead.HasRows == true)
            {
                sqlRead.Read();
                int id = sqlRead.GetUInt16(0);
                sqlRead.Close();
                
                return id;
            }
            else
            {
                sqlRead.Close();
                return 0;
            }
        }

        public string getNombreProvedor(int id)
        {
            try
            {
                conexionAlternativa();
                MySqlCommand sqlCom = new MySqlCommand("SELECT nombre FROM provedores WHERE id = " + id.ToString(), sqlCon2);
                MySqlDataReader sqlRead = sqlCom.ExecuteReader();

                if (sqlRead.HasRows == true)
                {
                    sqlRead.Read();
                    string nombre = sqlRead.GetString(0);
                    sqlRead.Close();
                    return nombre;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public List<Provedor> getListaProvedores()
        {
            List<Provedor> listaProvedores = new List<Provedor>();

            MySqlDataReader sqlRead = this.query("SELECT * FROM provedores");

            if (sqlRead.HasRows)
            {
                while (sqlRead.Read())
                {
                    Provedor provedor = new Provedor();
                    provedor.id = sqlRead.GetInt32(0);
                    provedor.nombre = sqlRead.GetString(1);
                    listaProvedores.Add(provedor);
                }

                sqlRead.Close();
                return listaProvedores;
            }
            else
            {
                sqlRead.Close();
                return null;
            }
            
        }

        public Articulo getArticulo(string busqueda)
        {
            List<Articulo> Articulos = new List<Articulo>();

            MySqlDataReader sqlRead = this.query("SELECT * FROM articulos WHERE nombre LIKE '%" + busqueda + "%'");

            if (sqlRead.HasRows)
            {
                sqlRead.Read();

                Articulo articulo = new Articulo();
                articulo.id = sqlRead.GetInt32(0);
                articulo.nombre = sqlRead.GetString(1);
                articulo.precio = sqlRead.GetFloat(2);
                articulo.descripcion = sqlRead.GetString(3);
                articulo.existencia = sqlRead.GetInt32(4);
                Articulos.Add(articulo);

                sqlRead.Close();
                return articulo;
            }
            else
            {
                sqlRead.Close();
                return null;
            }
        }

        public int getIDProvedor(string busqueda)
        {
            MySqlDataReader sqlRead = this.query("SELECT id FROM provedores WHERE nombre LIKE '%" + busqueda + "%'");

            if (sqlRead.HasRows)
            {
                sqlRead.Read();
                int id = int.Parse(sqlRead.GetString(0));
                sqlRead.Close();
                return id;
            }
            else
            {
                sqlRead.Close();
                return 0;
            }
        }

        public Provedor getProvedor(string busqueda)
        {
            MySqlDataReader sqlRead = this.query("SELECT * FROM provedores WHERE nombre LIKE '%" + busqueda + "%'");

            if (sqlRead.HasRows)
            {
                sqlRead.Read();
                Provedor provedor = new Provedor();
                provedor.id = sqlRead.GetInt32(0);
                provedor.nombre = sqlRead.GetString(1);
                sqlRead.Close();
                return provedor;
            }
            else
            {
                sqlRead.Close();
                return null;
            }
        }

        public bool existenArticulosPreventa()
        {
            MySqlDataReader sqlRead = this.query("SELECT * FROM preventa");

            if (sqlRead.HasRows)
            {
                sqlRead.Close();
                return true;
            }
            else
            {
                sqlRead.Close();
                return false;
            }
        }
        
        public void agregarPreventa(string nomArticulo, int cantidad)
        {
            Articulo articulo;
            articulo = this.getArticulo(nomArticulo);
            articulo.cantidadVenta = cantidad;

            string query = "INSERT INTO preventa(idArticulo,cantidad) VALUES (" + articulo.id.ToString() + "," + articulo.cantidadVenta.ToString() + ")";
            MySqlCommand sqlCom = new MySqlCommand(query, sqlCon);
            sqlCom.ExecuteNonQuery();
        }

        public List<Articulo> buscarArticulo(string busqueda)
        {
            
            List<Articulo> Articulos = new List<Articulo>();
            string[] busquedaSplit;

            if (busqueda.Contains('*'))
            {
                busquedaSplit = busqueda.Split('*');

                
                MySqlDataReader sqlRead = this.query("SELECT * FROM articulos WHERE nombre LIKE '%" + busquedaSplit[1] + "%'");

                if (sqlRead.HasRows)
                {
                    while (sqlRead.Read())
                    {
                        Articulo articulo = new Articulo();
                        articulo.id = sqlRead.GetInt32(0);
                        articulo.nombre = sqlRead.GetString(1);
                        articulo.precio = sqlRead.GetFloat(2);
                        articulo.descripcion = sqlRead.GetString(3);
                        articulo.existencia = sqlRead.GetInt32(4);
                        try { articulo.cantidadVenta = int.Parse(busquedaSplit[0]); }
                        catch {}                        
                        Articulos.Add(articulo);
                    }

                    sqlRead.Close();
                    
                    return Articulos;
                }
                else
                {
                    
                    sqlRead.Close();
                    return null;
                }
            }
            else
            {
                MySqlDataReader sqlRead = this.query("SELECT * FROM articulos WHERE nombre LIKE '%" + busqueda + "%'");

                if (sqlRead.HasRows)
                {
                    while (sqlRead.Read())
                    {
                        Articulo articulo = new Articulo();
                        articulo.id = sqlRead.GetInt32(0);
                        articulo.nombre = sqlRead.GetString(1);
                        articulo.precio = sqlRead.GetFloat(2);
                        articulo.descripcion = sqlRead.GetString(3);
                        articulo.existencia = sqlRead.GetInt32(4);
                        articulo.cantidadVenta = 1;
                        Articulos.Add(articulo);
                    }

                    sqlRead.Close();
                    
                    return Articulos;
                }
                else
                {
                    
                    sqlRead.Close();
                    return null;
                }
            }
        }

        public List<Articulo> getArticulosPreventa()
        {
            
        List<Articulo> Articulos = new List<Articulo>();

            MySqlDataReader sqlRead = this.query("SELECT * FROM preventa");

            if (sqlRead.HasRows)
            {
                while (sqlRead.Read())
                {
                    Articulo articulo = new Articulo(sqlRead.GetInt32(1));
                    articulo.cantidadVenta = sqlRead.GetInt32(2);                    
                    Articulos.Add(articulo);
                }

                sqlRead.Close();
                
                return Articulos;
            }
            else
            {
                
                sqlRead.Close();
                return null;
            }            
        }

        public void cancelarVenta()
        {
            string query = "TRUNCATE TABLE preventa";
            MySqlCommand sqlCom = new MySqlCommand(query, sqlCon);
            sqlCom.ExecuteNonQuery();
        }

        public int getTipoUsuario(int id)
        {
            MySqlDataReader sqlRead = this.query("SELECT tipousuario FROM usuarios WHERE id = " + id.ToString());
            if (sqlRead.HasRows == true)
            {
                sqlRead.Read();
                int tipo = sqlRead.GetInt16(0);
                sqlRead.Close();
                return tipo;
            }
            else
            {
                sqlRead.Close();
                return 0;
            }
        }

        public bool verificarSiExisteUsuario(string usuario)
        {
            MySqlDataReader sqlRead = this.query("SELECT user FROM usuarios WHERE user = '" + usuario + "'");
            if (sqlRead.HasRows == true)
            {
                sqlRead.Close();
                return true;
            }
            else
            {
                sqlRead.Close();
                return false;
            }
        }

        public void crearNuevoUsuario(string usuario, string password, string nombre, string tipo)
        {
            string query = "INSERT INTO usuarios (user,password,nombre,tipousuario) VALUES('" + usuario + "','" + password + "','" + nombre + "','" + tipo + "')";       
            MySqlCommand sqlCom = new MySqlCommand(query, sqlCon);
            sqlCom.ExecuteNonQuery();
        }

        public void crearNuevoProvedor(string nombre, string direccion, string telefono, string rfc)
        {
            string query = "INSERT INTO provedores (nombre,direccion,telefono,rfc) VALUES('" + nombre + "','" + direccion + "','" + telefono + "','" + rfc + "')";
            MySqlCommand sqlCom = new MySqlCommand(query, sqlCon);
            sqlCom.ExecuteNonQuery();
        }

        public void crearNuevoArticulo(string nombre, float precio, string descripcion, string existencia)
        {
            string query = "INSERT INTO articulos (nombre,precio,descripcion,existencia) VALUES('" + nombre + "'," + precio + ",'" + descripcion + "','" + existencia + "')";
            MySqlCommand sqlCom = new MySqlCommand(query, sqlCon);
            sqlCom.ExecuteNonQuery();
        }

        public List<string> llenarListaArticulos()
        {
            MySqlDataReader sqlRead = this.query("SELECT nombre FROM articulos");
            if (sqlRead.HasRows)
            {
                List<string> articulos = new List<string>();                

                while (sqlRead.Read())
                {
                    articulos.Add(sqlRead.GetString(0));
                }

                sqlRead.Close();
                return articulos;
            }
            else
            {
                sqlRead.Close();
                return null;
            }
        }

        public void actualizarArticulo(string nombre, float precio, string descripcion, int id)
        {
            string query = "UPDATE articulos SET ";
            query += "nombre = '" + nombre + "',";
            query += "precio = '" + precio + "',";
            query += "descripcion = '" + descripcion + "' ";
            query += "WHERE id = " + id.ToString();

            MySqlCommand sqlCom = new MySqlCommand(query, sqlCon);
            sqlCom.ExecuteNonQuery();
        }

        public void eliminarArticulo(int id)
        {
            string query = "DELETE FROM articulos WHERE id = " + id.ToString();
            MySqlCommand sqlCom = new MySqlCommand(query, sqlCon);
            sqlCom.ExecuteNonQuery();
        }

        public void eliminarProvedor(string nombre)
        {
            string query = "DELETE FROM provedores WHERE nombre = '" + nombre + "'";
            MySqlCommand sqlCom = new MySqlCommand(query, sqlCon);
            sqlCom.ExecuteNonQuery();
        }

        public void eliminarArticuloPreventa(int id, int cant)
        {
            string query = "DELETE FROM preventa WHERE idArticulo = " + id.ToString() + " and cantidad = " + cant.ToString();
            conexionAlternativa();
            MySqlCommand sqlCom = new MySqlCommand(query, sqlCon2);
            sqlCom.ExecuteNonQuery();
            sqlCom.Dispose();
        }

        public List<Articulo> completarVenta()
        {
            MySqlDataReader sqlRead = this.query("SELECT * FROM preventa");
            List<Articulo> ArticulosVendidos = new List<Articulo>();

            if (sqlRead.HasRows)
            {
                while (sqlRead.Read())
                {
                    int idArt = sqlRead.GetInt32(1);
                    int cantArt = sqlRead.GetInt32(2);
                    reducirInventarioArticulo(idArt, cantArt);
                    registrarVenta(idArt, cantArt);                    
                    eliminarArticuloPreventa(idArt, cantArt);
                    Articulo articulo = new Articulo(idArt);
                    articulo.cantidadVenta = cantArt;
                    ArticulosVendidos.Add(articulo);
                }

                sqlRead.Close();
                return ArticulosVendidos;
            }
            else
            {
                sqlRead.Close();
                return null;
            }
        }

        private void reducirInventarioArticulo(int id, int cant)
        {
            string query = "UPDATE articulos SET ";
            query += "existencia = existencia - " + cant.ToString();
            query += " WHERE id = " + id.ToString();

            conexionAlternativa();
            MySqlCommand sqlCom = new MySqlCommand(query, sqlCon2);
            sqlCom.ExecuteNonQuery();
            sqlCom.Dispose();
        }

        private void aumentarInventarioArticulo(int id, int cant)
        {
            string query = "UPDATE articulos SET ";
            query += "existencia = existencia + " + cant.ToString();
            query += " WHERE id = " + id.ToString();

            conexionAlternativa();
            MySqlCommand sqlCom = new MySqlCommand(query, sqlCon2);
            sqlCom.ExecuteNonQuery();
            sqlCom.Dispose();
        }

        private void registrarVenta(int id, int cant)
        {
            DateTime date = DateTime.Now;
            string fecha = date.Year + "-" + date.Month + "-" + date.Day;

            string query = "INSERT INTO ventas (idArticulo,cantidad,fecha) VALUES(" + id.ToString() + "," + cant.ToString() + ",'" + fecha + "')";
            conexionAlternativa();
            MySqlCommand sqlCom = new MySqlCommand(query, sqlCon2);
            sqlCom.ExecuteNonQuery();
            sqlCom.Dispose();
        }

        public void registrarCompra(int idProv, int idArt, int cant)
        {
            DateTime date = DateTime.Now;
            string fecha = date.Year + "-" + date.Month + "-" + date.Day;

            aumentarInventarioArticulo(idArt, cant);
            string query = "INSERT INTO compras (idProvedor,idArticulo,cantidad,fecha) VALUES(" + idProv.ToString() + "," + idArt.ToString() + "," + cant.ToString() + ",'" + fecha + "')";
            MySqlCommand sqlCom = new MySqlCommand(query, sqlCon);
            sqlCom.ExecuteNonQuery();
            sqlCom.Dispose();
        }

        public void registrarGanancia(float total)
        {
            DateTime date = DateTime.Now;
            string fecha = date.Year + "-" + date.Month + "-" + date.Day;

            string query = "INSERT INTO ganancias (monto,fecha) VALUES(" + total.ToString() + ",'" + fecha + "')";
            conexionAlternativa();
            MySqlCommand sqlCom = new MySqlCommand(query, sqlCon2);
            sqlCom.ExecuteNonQuery();
            sqlCom.Dispose();
        }

        public List<String> getlistaUsuarios()
        {
            List<String> listaUsuarios = new List<String>();

            MySqlDataReader sqlRead = this.query("SELECT nombre FROM usuarios");

            if (sqlRead.HasRows)
            {
                while (sqlRead.Read())
                {
                    listaUsuarios.Add(sqlRead.GetString(0));
                }

                sqlRead.Close();
                return listaUsuarios;
            }
            else
            {
                sqlRead.Close();
                return null;
            }

        }

        // Funciones de Reportes 

        public List<registroEntradasSalidas> rep_entradasysalidas(string fecha1, string fecha2, string nombre)
        {
            List<registroEntradasSalidas> datos = new List<registroEntradasSalidas>();
            
            
            int id = this.getIdUsuario(nombre);

            MySqlDataReader sqlRead = this.query("select fecha, hora, tipo from asistencia where fecha between '" + fecha1 + "' and '" + fecha2 + "' and idUsuario = " + id.ToString());

            if (sqlRead.HasRows)
            {               
                while (sqlRead.Read())
                {
                    registroEntradasSalidas dat = new registroEntradasSalidas();
                    dat.fecha = sqlRead.GetMySqlDateTime(0).ToString();
                    dat.hora = sqlRead.GetString(1);
                    dat.tipo = sqlRead.GetInt16(2);
                    datos.Add(dat);
                }
            }
            else
            {
                sqlRead.Close();
                return null;
            }

            return datos;
        }

        public List<datosReporte> rep_ventasPorArticulo(string fecha1, string fecha2)
        {
            MySqlDataReader sqlRead = this.query("SELECT idArticulo, sum(cantidad) FROM ventas WHERE fecha between '" + fecha1 + "' and '" + fecha2 + "' group by idArticulo order by sum(cantidad) DESC;");

            if (sqlRead.HasRows)
            {
                List<datosReporte> ListaDatos = new List<datosReporte>();
                while (sqlRead.Read())
                {
                    datosReporte reporte = new datosReporte(int.Parse(sqlRead.GetString(0)));
                    reporte.cantidad = sqlRead.GetString(1);
                    ListaDatos.Add(reporte);
                }

                sqlRead.Close();
                return ListaDatos;
            }
            else
            {
                sqlRead.Close();
                return null;
            }
        }

        public double rep_GananciasPorFechas(string fecha1, string fecha2)
        {
            MySqlDataReader sqlRead = this.query("select sum(monto) from ganancias where fecha between '" + fecha1 + "' and '" + fecha2 + "'");

            if (sqlRead.HasRows)
            {
                sqlRead.Read();
                double ganancia = double.Parse(sqlRead.GetString(0));
                return ganancia;                
            }
            else
            {
                sqlRead.Close();
                return 0;
            }
        }

        public List<datosReporte> rep_ComprasPorProvedor(string fecha1, string fecha2, string provedor)
        {
            int idProvedor;

            idProvedor = getIDProvedor(provedor);
            MySqlDataReader sqlRead = this.query("SELECT idProvedor, idArticulo, cantidad FROM compras WHERE fecha between '" + fecha1 + "' and '" + fecha2 + "' and idProvedor = " + idProvedor.ToString());

            if (sqlRead.HasRows)
            {
                List<datosReporte> ListaDatos = new List<datosReporte>();
                while (sqlRead.Read())
                {
                    datosReporte reporte = new datosReporte(int.Parse(sqlRead.GetString(1)));
                    reporte.idProvedor = sqlRead.GetString(0);
                    reporte.nombreProvedor = getNombreProvedor(int.Parse(reporte.idProvedor));
                    reporte.cantidad = sqlRead.GetString(2);
                    ListaDatos.Add(reporte);
                }

                sqlRead.Close();
                return ListaDatos;
            }
            else
            {
                sqlRead.Close();
                return null;
            }
        }

        public List<datosReporte> rep_ComprasPorProvedorGenerales(string fecha1, string fecha2)
        {
            MySqlDataReader sqlRead = this.query("SELECT idProvedor, idArticulo, cantidad FROM compras WHERE fecha between '" + fecha1 + "' and '" + fecha2 + "'");

            if (sqlRead.HasRows)
            {
                List<datosReporte> ListaDatos = new List<datosReporte>();
                while (sqlRead.Read())
                {
                    datosReporte reporte = new datosReporte(int.Parse(sqlRead.GetString(1)));
                    reporte.idProvedor = sqlRead.GetString(0);
                    reporte.nombreProvedor = getNombreProvedor(int.Parse(reporte.idProvedor));
                    reporte.cantidad = sqlRead.GetString(2);
                    if (reporte.idProvedor != "1") { ListaDatos.Add(reporte); }
                }

                sqlRead.Close();
                return ListaDatos;
            }
            else
            {
                sqlRead.Close();
                return null;
            }
        }

        public List<datosReporte> rep_articulos()
        {
            MySqlDataReader sqlRead = this.query("SELECT id, convert(existencia,decimal) FROM articulos ORDER BY convert(existencia,decimal) ASC");

            if (sqlRead.HasRows)
            {
                List<datosReporte> ListaDatos = new List<datosReporte>();
                while (sqlRead.Read())
                {
                    datosReporte reporte = new datosReporte(int.Parse(sqlRead.GetString(0)));
                    reporte.cantidad = sqlRead.GetInt32(1).ToString();
                    ListaDatos.Add(reporte);
                }

                sqlRead.Close();
                return ListaDatos;
            }
            else
            {
                sqlRead.Close();
                return null;
            }
        }

#if SISTEMA_FACTURAS_
        public void crearFactura(string cliente, double importe, string fecha)
        {
            string query = "INSERT INTO facturas(cliente,importe,fecha) VALUES ('" + cliente + "'," + importe.ToString() + ",'" + fecha + "')";
            MySqlCommand sqlCom = new MySqlCommand(query, sqlCon);
            sqlCom.ExecuteNonQuery();
        }
#endif
            
    }
}
