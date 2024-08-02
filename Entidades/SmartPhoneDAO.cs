using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SmartPhoneDAO:IDao<SmartPhone>
    {
        private SqlConnection sqlConeccion;
        public SmartPhoneDAO()
        {
            ConexionDB singletonInstance = ConexionDB.GetInstancia();
            this.sqlConeccion = singletonInstance.GetConeccion();
        }

        public void Agregar(SmartPhone smartPhone)
        {
            try
            {
                sqlConeccion.Open();
                string comando = "INSERT INTO SmartPhone(Marca,Modelo,Color,Precio,Almacenamiento,MemoriaRam,PulgadasPantalla,PixelesCamara,CapacidadBateria," +
                    "DualSim,IncluyeCargador,Cantidad) " + $"VALUES(@Marca,@Modelo,@Color,@Precio,@Almacenamiento,@MemoriaRam,@PulgadasPantalla,@PixelesCamara,@CapacidadBateria,@DualSim,@IncluyeCargador,@Cantidad)";

                SqlCommand sqlComando = new SqlCommand(comando, this.sqlConeccion);
                sqlComando.Parameters.AddWithValue("@Marca", smartPhone.Marca);
                sqlComando.Parameters.AddWithValue("@Modelo", smartPhone.Modelo);
                sqlComando.Parameters.AddWithValue("@Color", smartPhone.Color);
                sqlComando.Parameters.AddWithValue("@Precio", smartPhone.Precio);
                sqlComando.Parameters.AddWithValue("@Almacenamiento", smartPhone.Almacenamiento);
                sqlComando.Parameters.AddWithValue("@MemoriaRam", smartPhone.MemoriaRam);
                sqlComando.Parameters.AddWithValue("@PulgadasPantalla", smartPhone.PulgadasPantalla);
                sqlComando.Parameters.AddWithValue("@PixelesCamara", smartPhone.PixelesCamara);
                sqlComando.Parameters.AddWithValue("@CapacidadBateria", smartPhone.CapacidadBateria);
                sqlComando.Parameters.AddWithValue("@DualSim", smartPhone.DualSim ? (byte)1 : (byte)0);
                sqlComando.Parameters.AddWithValue("@IncluyeCargador", smartPhone.IncluyeCargador ? (byte)1 : (byte)0);
                sqlComando.Parameters.AddWithValue("@Cantidad", smartPhone.Cantidad);

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


        public void Eliminar(SmartPhone smartPhone)
        {
            try
            {
                sqlConeccion.Open();

                string comando = "DELETE FROM SmartPhone WHERE Id = @Id";

                SqlCommand sqlComando = new SqlCommand(comando, this.sqlConeccion);
                sqlComando.Parameters.AddWithValue("@Id", smartPhone.Id);

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

        public void ActualizarCantidad(SmartPhone smartphone, bool aumentarODisminuir = true)
        {
            try
            {
                sqlConeccion.Open();

                string comando = @"UPDATE SmartPhone
                    SET Cantidad = @NuevaCantidad
                    WHERE Id = @Id";


                SqlCommand sqlComando = new SqlCommand(comando, this.sqlConeccion);
                if (aumentarODisminuir)
                {
                    int nuevaCantidad = smartphone.Cantidad + 1;
                    sqlComando.Parameters.AddWithValue("@NuevaCantidad", nuevaCantidad);
                }
                else
                {
                    if (smartphone.Cantidad > 0)
                    {
                        int nuevaCantidad = smartphone.Cantidad - 1;
                        sqlComando.Parameters.AddWithValue("@NuevaCantidad", nuevaCantidad);
                    }
                }

                sqlComando.Parameters.AddWithValue("@Id", smartphone.Id);

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


        public void ActualizarPrecio(SmartPhone smartphone, float nuevoPrecio)
        {
            try
            {
                sqlConeccion.Open();

                string comando = @"UPDATE SmartPhone
                    SET Precio = @NuevoPrecio
                    WHERE Id = @Id";


                SqlCommand sqlComando = new SqlCommand(comando, this.sqlConeccion);
                sqlComando.Parameters.AddWithValue("@NuevoPrecio", nuevoPrecio);
                sqlComando.Parameters.AddWithValue("@Id", smartphone.Id);

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


        public int ObtenerCantidad(SmartPhone smartPhone)
        {
            int cantidadProducto = 0;

            try
            {
                sqlConeccion.Open();
                string comando = @"
                    SELECT Cantidad
                    FROM SmartPhone
                    WHERE Id = @Id";

                SqlCommand sqlComando = new SqlCommand(comando, this.sqlConeccion);
                sqlComando.Parameters.AddWithValue("@Id", smartPhone.Id);

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


        public float ObtenerPrecio(SmartPhone smartPhone)
        {
            float precioProducto = 0;

            try
            {
                sqlConeccion.Open();
                string comando = @"
                    SELECT Precio
                    FROM SmartPhone
                    WHERE Id = @Id";

                SqlCommand sqlComando = new SqlCommand(comando, this.sqlConeccion);
                sqlComando.Parameters.AddWithValue("@Id", smartPhone.Id);

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
