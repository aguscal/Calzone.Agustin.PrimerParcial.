using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MonitorDAO:IDao<Monitor>
    {
        private SqlConnection sqlConeccion;
        public MonitorDAO()
        {
            ConexionDB singletonInstance = ConexionDB.GetInstancia();
            this.sqlConeccion = singletonInstance.GetConeccion();
        }

        public void Agregar(Monitor monitor)
        {
            try
            {
                sqlConeccion.Open();
                string comando = "INSERT INTO Monitor(Marca,Modelo,Color,Precio,Pulgadas,EsCurvo,TipoPanel,TazaDeRefresco,TipoPuerto," +
                    "Resolucion,EsGamer,TieneAltavoz,Cantidad) " + $"VALUES(@Marca,@Modelo,@Color,@Precio,@Pulgadas,@EsCurvo,@TipoPanel,@TazaDeRefresco,@TipoPuerto,@Resolucion,@EsGamer,@TieneAltavoz,@Cantidad)";

                SqlCommand sqlComando = new SqlCommand(comando, this.sqlConeccion);
                sqlComando.Parameters.AddWithValue("@Marca", monitor.Marca);
                sqlComando.Parameters.AddWithValue("@Modelo", monitor.Modelo);
                sqlComando.Parameters.AddWithValue("@Color", monitor.Color);
                sqlComando.Parameters.AddWithValue("@Precio", monitor.Precio);
                sqlComando.Parameters.AddWithValue("@Pulgadas", monitor.Pulgadas);
                sqlComando.Parameters.AddWithValue("@EsCurvo", monitor.EsCurvo ? (byte)1 : (byte)0);
                sqlComando.Parameters.AddWithValue("@TipoPanel", monitor.TipoPanel);
                sqlComando.Parameters.AddWithValue("@TazaDeRefresco", monitor.TazaDeRefresco);
                sqlComando.Parameters.AddWithValue("@TipoPuerto", monitor.TipoPuerto);
                sqlComando.Parameters.AddWithValue("@Resolucion", monitor.Resolucion);
                sqlComando.Parameters.AddWithValue("@EsGamer", monitor.EsGamer ? (byte)1 : (byte)0);
                sqlComando.Parameters.AddWithValue("@TieneAltavoz", monitor.TieneAltavoz ? (byte)1 : (byte)0);
                sqlComando.Parameters.AddWithValue("@Cantidad", monitor.Cantidad);

                sqlComando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ExcepcionConeccion();
            }
            finally
            {
                if (this.sqlConeccion != null && this.sqlConeccion.State == System.Data.ConnectionState.Open)
                {
                    this.sqlConeccion.Close();
                }
            }

        }


        public void Eliminar(Monitor monitor)
        {
            try
            {
                sqlConeccion.Open();

                string comando = "DELETE FROM Monitor WHERE Id = @Id";

                SqlCommand sqlComando = new SqlCommand(comando, this.sqlConeccion);
                sqlComando.Parameters.AddWithValue("@Id", monitor.Id);

                sqlComando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ExcepcionConeccion();
            }
            finally
            {
                if (this.sqlConeccion != null && this.sqlConeccion.State == System.Data.ConnectionState.Open)
                {
                    this.sqlConeccion.Close();
                }
            }
        }

        public void ActualizarCantidad(Monitor monitor, bool aumentarODisminuir = true)
        {
            try
            {
                sqlConeccion.Open();

                string comando = @"UPDATE Monitor
                    SET Cantidad = @NuevaCantidad
                    WHERE Id = @Id";


                SqlCommand sqlComando = new SqlCommand(comando, this.sqlConeccion);
                if (aumentarODisminuir)
                {
                    int nuevaCantidad = monitor.Cantidad + 1;
                    sqlComando.Parameters.AddWithValue("@NuevaCantidad", nuevaCantidad);
                }
                else
                {
                    if (monitor.Cantidad > 0)
                    {
                        int nuevaCantidad = monitor.Cantidad - 1;
                        sqlComando.Parameters.AddWithValue("@NuevaCantidad", nuevaCantidad);
                    }
                }

                sqlComando.Parameters.AddWithValue("@Id", monitor.Id);

                sqlComando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ExcepcionConeccion();
            }
            finally
            {
                if (this.sqlConeccion != null && this.sqlConeccion.State == System.Data.ConnectionState.Open)
                {
                    this.sqlConeccion.Close();
                }
            }
        }

        public void ActualizarPrecio(Monitor monitor, float nuevoPrecio)
        {
            try
            {
                sqlConeccion.Open();

                string comando = @"UPDATE Monitor
                    SET Precio = @NuevoPrecio
                    WHERE Id = @Id";


                SqlCommand sqlComando = new SqlCommand(comando, this.sqlConeccion);
                sqlComando.Parameters.AddWithValue("@NuevoPrecio", nuevoPrecio);
                sqlComando.Parameters.AddWithValue("@Id", monitor.Id);

                sqlComando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ExcepcionConeccion();
            }
            finally
            {
                if (this.sqlConeccion != null && this.sqlConeccion.State == System.Data.ConnectionState.Open)
                {
                    this.sqlConeccion.Close();
                }
            }
        }


        public int ObtenerCantidad(Monitor monitor)
        {
            int cantidadProducto = 0;

            try
            {
                sqlConeccion.Open();
                string comando = @"
                    SELECT Cantidad
                    FROM Monitor
                    WHERE Id = @Id";

                SqlCommand sqlComando = new SqlCommand(comando, this.sqlConeccion);
                sqlComando.Parameters.AddWithValue("@Id", monitor.Id);

                using (SqlDataReader dataReader = sqlComando.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        cantidadProducto = dataReader.GetInt32("Cantidad");
                    }
                }

                return cantidadProducto;
            }
            catch (Exception ex)
            {
                throw new ExcepcionConeccion();
            }
            finally
            {
                this.sqlConeccion.Close();

            }
        }


        public float ObtenerPrecio(Monitor monitor)
        {
            float precioProducto = 0;

            try
            {
                sqlConeccion.Open();
                string comando = @"
                    SELECT Precio
                    FROM Monitor
                    WHERE Id = @Id";

                SqlCommand sqlComando = new SqlCommand(comando, this.sqlConeccion);
                sqlComando.Parameters.AddWithValue("@Id", monitor.Id);

                using (SqlDataReader dataReader = sqlComando.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        precioProducto = Convert.ToSingle(dataReader.GetValue("Precio"));
                    }
                }

                return precioProducto;
            }
            catch (Exception ex)
            {
                throw new ExcepcionConeccion();
            }
            finally
            {
                this.sqlConeccion.Close();

            }
        }
    }
}
