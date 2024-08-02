using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ConexionDB
    {
        private static ConexionDB instancia;

        private SqlConnection conexion;


        private ConexionDB()
        {
            this.conexion = new SqlConnection(@"Data Source = DESKTOP-ILB9T5B\SQLEXPRESS;
                                Database = PRODUCTOS_DB;
                                Trusted_Connection = True;");

            // Ejemplo con credenciales.
            //string cadenaConexion = $"Data Source={servidor};Initial Catalog={baseDatos};User Id={usuario};Password={contrasena}";
        }

        public static ConexionDB GetInstancia()
        {
            if (ConexionDB.instancia == null)
            {
                ConexionDB.instancia = new ConexionDB();
            }

            return instancia;
        }

        public SqlConnection GetConeccion()
        {
            return this.conexion;
        }

    }
}
