using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ComprobanteDAO
    {
        private SqlConnection sqlConeccion;
        public ComprobanteDAO()
        {
            ConexionDB singletonInstance = ConexionDB.GetInstancia();
            this.sqlConeccion = singletonInstance.GetConeccion();
        }

        public void Agregar(Comprobante comprobante)
        {
            try
            {
                sqlConeccion.Open();
                string comando = "INSERT INTO Comprobante(IdComprador,NombreComprador,ApellidoComprador,EmailComprador,NombreCalle,NumeroCalle,FechaDeEmision,ResumenDeCompra,MontoTotal," +
                    "Dni,MetodoDePago,NumeroDeCuotas,NumeroTarjeta,NumeroSeguridadTarjeta,NumeroDeCuentaTransferencia) " + $"VALUES(@IdComprador,@NombreComprador,@ApellidoComprador,@EmailComprador,@NombreCalle,@NumeroCalle,@FechaDeEmision,@ResumenDeCompra,@MontoTotal,@Dni,@MetodoDePago,@NumeroDeCuotas,@NumeroTarjeta,@NumeroSeguridadTarjeta,@NumeroDeCuentaTransferencia)";

                SqlCommand sqlComando = new SqlCommand(comando, this.sqlConeccion);
                sqlComando.Parameters.AddWithValue("@IdComprador", comprobante.IdComprador);
                sqlComando.Parameters.AddWithValue("@NombreComprador", comprobante.NombreComprador);
                sqlComando.Parameters.AddWithValue("@ApellidoComprador", comprobante.ApellidoComprador);
                sqlComando.Parameters.AddWithValue("@EmailComprador", comprobante.EmailComprador);
                sqlComando.Parameters.AddWithValue("@NombreCalle", comprobante.NombreCalle);
                sqlComando.Parameters.AddWithValue("@NumeroCalle", comprobante.NumeroCalle);
                sqlComando.Parameters.AddWithValue("@FechaDeEmision", comprobante.FechaDeEmision);
                sqlComando.Parameters.AddWithValue("@ResumenDeCompra", comprobante.ResumenDeCompra);
                sqlComando.Parameters.AddWithValue("@MontoTotal", comprobante.MontoTotal);
                sqlComando.Parameters.AddWithValue("@Dni", comprobante.Dni);
                sqlComando.Parameters.AddWithValue("@MetodoDePago", comprobante.MetodoDePago);


                sqlComando.Parameters.AddWithValue("@NumeroDeCuotas", comprobante.NumeroDeCuotas.HasValue ? (object)comprobante.NumeroDeCuotas.Value : DBNull.Value);
                sqlComando.Parameters.AddWithValue("@NumeroTarjeta", comprobante.NumeroTarjeta.HasValue ? (object)comprobante.NumeroTarjeta.Value : DBNull.Value);
                sqlComando.Parameters.AddWithValue("@NumeroSeguridadTarjeta", comprobante.NumeroSeguridadTarjeta.HasValue ? (object)comprobante.NumeroSeguridadTarjeta.Value : DBNull.Value);
                sqlComando.Parameters.AddWithValue("@NumeroDeCuentaTransferencia", comprobante.NumeroDeCuentaTransferencia.HasValue ? (object)comprobante.NumeroDeCuentaTransferencia.Value : DBNull.Value);

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


        public List<Comprobante> ObtenerListaComprobantes()
        {
            List<Comprobante> listaComprobantes = new List<Comprobante>();

            try
            {
                sqlConeccion.Open();
                string comando = @"
                    SELECT IdComprador,NombreComprador,ApellidoComprador,EmailComprador,NombreCalle,NumeroCalle,FechaDeEmision,ResumenDeCompra,MontoTotal,Dni,MetodoDePago,NumeroDeCuotas,NumeroTarjeta,NumeroSeguridadTarjeta,NumeroDeCuentaTransferencia
                    FROM Comprobante";

                SqlCommand sqlComando = new SqlCommand(comando, this.sqlConeccion);

                using (SqlDataReader dataReader = sqlComando.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Comprobante comprobante = new Comprobante(
                            Convert.ToInt32(dataReader["IdComprador"]),
                            dataReader["NombreComprador"].ToString(),
                            dataReader["ApellidoComprador"].ToString(),
                            dataReader["EmailComprador"].ToString(),
                            dataReader["NombreCalle"].ToString(),
                            Convert.ToDecimal(dataReader["NumeroCalle"]),
                            Convert.ToDateTime(dataReader["FechaDeEmision"]),
                            dataReader["ResumenDeCompra"].ToString(),
                            Convert.ToSingle(dataReader["MontoTotal"]),
                            Convert.ToDecimal(dataReader["Dni"]),
                            dataReader["MetodoDePago"].ToString(),
                            dataReader["NumeroDeCuotas"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(dataReader["NumeroDeCuotas"]),
                            dataReader["NumeroTarjeta"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(dataReader["NumeroTarjeta"]),
                            dataReader["NumeroSeguridadTarjeta"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(dataReader["NumeroSeguridadTarjeta"]),
                            dataReader["NumeroDeCuentaTransferencia"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(dataReader["NumeroDeCuentaTransferencia"]));
                                                                         

                        listaComprobantes.Add(comprobante);
                    }
                }

                return listaComprobantes;
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


        public List<Comprobante> ObtenerListaComprobantes(int idCompradorBuscado)
        {
            List<Comprobante> listaComprobantes = new List<Comprobante>();

            try
            {
                sqlConeccion.Open();
                string comando = @"
                    SELECT IdComprador,NombreComprador,ApellidoComprador,EmailComprador,NombreCalle,NumeroCalle,FechaDeEmision,ResumenDeCompra,MontoTotal,Dni,MetodoDePago,NumeroDeCuotas,NumeroTarjeta,NumeroSeguridadTarjeta,NumeroDeCuentaTransferencia
                    FROM Comprobante
                    WHERE IdComprador = @IdCompradorBuscado";

                SqlCommand sqlComando = new SqlCommand(comando, this.sqlConeccion);
                sqlComando.Parameters.AddWithValue("@IdCompradorBuscado", idCompradorBuscado);

                using (SqlDataReader dataReader = sqlComando.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Comprobante comprobante = new Comprobante(
                            Convert.ToInt32(dataReader["IdComprador"]),
                            dataReader["NombreComprador"].ToString(),
                            dataReader["ApellidoComprador"].ToString(),
                            dataReader["EmailComprador"].ToString(),
                            dataReader["NombreCalle"].ToString(),
                            Convert.ToDecimal(dataReader["NumeroCalle"]),
                            Convert.ToDateTime(dataReader["FechaDeEmision"]),
                            dataReader["ResumenDeCompra"].ToString(),
                            Convert.ToSingle(dataReader["MontoTotal"]),
                            Convert.ToDecimal(dataReader["Dni"]),
                            dataReader["MetodoDePago"].ToString(),
                            dataReader["NumeroDeCuotas"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(dataReader["NumeroDeCuotas"]),
                            dataReader["NumeroTarjeta"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(dataReader["NumeroTarjeta"]),
                            dataReader["NumeroSeguridadTarjeta"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(dataReader["NumeroSeguridadTarjeta"]),
                            dataReader["NumeroDeCuentaTransferencia"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(dataReader["NumeroDeCuentaTransferencia"]));


                        listaComprobantes.Add(comprobante);
                    }
                }

                return listaComprobantes;
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
