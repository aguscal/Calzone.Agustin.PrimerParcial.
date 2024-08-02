using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AuricularDAO:IDao<Auricular>
    {
        private SqlConnection sqlConeccion;
        public AuricularDAO()
        {
            ConexionDB singletonInstance = ConexionDB.GetInstancia();
            this.sqlConeccion = singletonInstance.GetConeccion();
        }

        public void Agregar(Auricular auricular)
        {
            try
            {
                sqlConeccion.Open();
                string comando = "INSERT INTO Auricular(Marca,Modelo,Color,Precio,CancelacionDeSonido,Db,Hz,EsInalambrico,HorasBateria,TiempoDeCarga,EsGamer,ConMicrofono," +
                    "InEar,Cantidad) " + $"VALUES(@Marca,@Modelo,@Color,@Precio,@CancelacionDeSonido,@Db,@Hz,@EsInalambrico,@HorasBateria,@TiempoDeCarga,@EsGamer,@ConMicrofono,@InEar,@Cantidad)";

                SqlCommand sqlComando = new SqlCommand(comando, this.sqlConeccion);
                sqlComando.Parameters.AddWithValue("@Marca", auricular.Marca);
                sqlComando.Parameters.AddWithValue("@Modelo", auricular.Modelo);
                sqlComando.Parameters.AddWithValue("@Color", auricular.Color);
                sqlComando.Parameters.AddWithValue("@Precio", auricular.Precio);
                sqlComando.Parameters.AddWithValue("@CancelacionDeSonido", auricular.CancelacionDeSonido ? (byte)1 : (byte)0);
                sqlComando.Parameters.AddWithValue("@Db", auricular.Db);
                sqlComando.Parameters.AddWithValue("@Hz", auricular.Hz);
                sqlComando.Parameters.AddWithValue("@EsInalambrico", auricular.EsInalambrico ? (byte)1 : (byte)0);
                sqlComando.Parameters.AddWithValue("@HorasBateria", auricular.HorasBateria);
                sqlComando.Parameters.AddWithValue("@TiempoDeCarga", auricular.TiempoDeCarga);
                sqlComando.Parameters.AddWithValue("@EsGamer", auricular.EsGamer ? (byte)1 : (byte)0);
                sqlComando.Parameters.AddWithValue("@ConMicrofono", auricular.ConMicrofono ? (byte)1 : (byte)0);
                sqlComando.Parameters.AddWithValue("@InEar", auricular.InEar ? (byte)1 : (byte)0);
                sqlComando.Parameters.AddWithValue("@Cantidad", auricular.Cantidad);

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


        public void Eliminar(Auricular auricular)
        {
            try
            {
                sqlConeccion.Open();

                string comando = "DELETE FROM Auricular WHERE Id = @Id";

                SqlCommand sqlComando = new SqlCommand(comando, this.sqlConeccion);
                sqlComando.Parameters.AddWithValue("@Id", auricular.Id);

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


        public void ActualizarPrecio(Auricular auricular,float nuevoPrecio)
        {
            try
            {
                sqlConeccion.Open();

                string comando = @"UPDATE Auricular
                    SET Precio = @NuevoPrecio
                    WHERE Id = @Id";


                SqlCommand sqlComando = new SqlCommand(comando, this.sqlConeccion);
                sqlComando.Parameters.AddWithValue("@NuevoPrecio", nuevoPrecio);
                sqlComando.Parameters.AddWithValue("@Id", auricular.Id);

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

        /*
         * si el atributo aumentarodisminuir esta como defecto es true y suma , si es false disminuye uno en la cantidad
         * */
        public void ActualizarCantidad(Auricular auricular,bool aumentarODisminuir = true)
        {
            try
            {
                sqlConeccion.Open();

                string comando = @"UPDATE Auricular
                    SET Cantidad = @NuevaCantidad
                    WHERE Id = @Id";


                SqlCommand sqlComando = new SqlCommand(comando, this.sqlConeccion);
                if (aumentarODisminuir)
                {
                    int nuevaCantidad = auricular.Cantidad + 1;
                    sqlComando.Parameters.AddWithValue("@NuevaCantidad", nuevaCantidad);
                }
                else
                {
                    if(auricular.Cantidad > 0)
                    {
                        int nuevaCantidad = auricular.Cantidad - 1;
                        sqlComando.Parameters.AddWithValue("@NuevaCantidad", nuevaCantidad);
                    }                    
                }
                
                sqlComando.Parameters.AddWithValue("@Id", auricular.Id);

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


        public int ObtenerCantidad(Auricular auricular)
        {
            int cantidadProducto = 0;

            try
            {
                sqlConeccion.Open();
                string comando = @"
                    SELECT Cantidad
                    FROM Auricular
                    WHERE Id = @Id";

                SqlCommand sqlComando = new SqlCommand(comando, this.sqlConeccion);
                sqlComando.Parameters.AddWithValue("@Id", auricular.Id);

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


        public float ObtenerPrecio(Auricular auricular)
        {
            float precioProducto = 0;

            try
            {
                sqlConeccion.Open();
                string comando = @"
                    SELECT Precio
                    FROM Auricular
                    WHERE Id = @Id";

                SqlCommand sqlComando = new SqlCommand(comando, this.sqlConeccion);
                sqlComando.Parameters.AddWithValue("@Id", auricular.Id);

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
