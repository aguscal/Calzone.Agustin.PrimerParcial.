using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductosDAO
    {
        private SqlConnection sqlConeccion;
        public ProductosDAO()
        {
            ConexionDB singletonInstance = ConexionDB.GetInstancia();
            this.sqlConeccion = singletonInstance.GetConeccion();
        }

        /*public int ObtenerUltimoIdAgregado()
        {
            int ultimoId = 0;

            try
            {
                sqlConeccion.Open();
                string comando = "SELECT MAX(MaxId) AS MaxId FROM (" +
                 "SELECT MAX(Id) AS MaxId FROM Auricular " +
                 "UNION ALL " +
                 "SELECT MAX(Id) AS MaxId FROM Monitor " +
                 "UNION ALL " +
                 "SELECT MAX(Id) AS MaxId FROM SmartPhone) AS MaxIds";

                SqlCommand sqlComando = new SqlCommand(comando, this.sqlConeccion);

                using (SqlDataReader dataReader = sqlComando.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        if (dataReader["MaxId"] != DBNull.Value)
                        {
                            ultimoId = Convert.ToInt32(dataReader["MaxId"]);
                        }
                    }

                    return ultimoId;
                }

                return ultimoId;
            }
            finally
            {
                sqlConeccion.Close();
            }
        }*/

        public List<Producto> ObtenerListaProductos()
        {
            List<Producto> listaProductosDb = new List<Producto>();

            try
            {
                List<Auricular> auriculares = ObtenerListaAuriculares();
                listaProductosDb.AddRange(auriculares);

                List<Monitor> monitores = ObtenerListaMonitores();
                listaProductosDb.AddRange(monitores);

                List<SmartPhone> smartphones = ObtenerListaSmartPhones();
                listaProductosDb.AddRange(smartphones);

                return listaProductosDb;
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


        public List<Auricular> ObtenerListaAuriculares()
        {
            List<Auricular> listaAuriculares = new List<Auricular>();
            Auricular auricularNuevo;

            try
            {
                sqlConeccion.Open();
                string comando = @"
                    SELECT Marca,Modelo,Color,Precio,CancelacionDeSonido,Db,Hz,EsInalambrico,HorasBateria,TiempoDeCarga,EsGamer,ConMicrofono,InEar,Id,Cantidad
                    FROM Auricular";

                SqlCommand sqlComando = new SqlCommand(comando, this.sqlConeccion);

                using (SqlDataReader dataReader = sqlComando.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        float precio = Convert.ToSingle(dataReader.GetValue("Precio"));

                        auricularNuevo = new Auricular(dataReader["Modelo"].ToString(), dataReader["Marca"].ToString(), dataReader["Color"].ToString(),
                            precio, dataReader.GetBoolean("CancelacionDeSonido"), dataReader.GetInt32("Db"), dataReader.GetInt32("Hz"),
                            dataReader.GetBoolean("ConMicrofono"), dataReader.GetBoolean("InEar"), dataReader.GetBoolean("EsGamer"),
                            dataReader.GetBoolean("EsInalambrico"), dataReader.GetInt32("HorasBateria"), dataReader.GetInt32("TiempoDeCarga"));

                        auricularNuevo.Id = dataReader.GetInt32("Id");
                        auricularNuevo.Cantidad = dataReader.GetInt32("Cantidad");
                        listaAuriculares.Add(auricularNuevo);
                    }
                }
                
                return listaAuriculares;
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


        public List<Monitor> ObtenerListaMonitores()
        {
            List<Monitor> listaMonitores = new List<Monitor>();

            try
            {
                sqlConeccion.Open();
                string comando = @"
                    SELECT Marca,Modelo,Color,Precio,Pulgadas,EsCurvo,TipoPanel,TazaDeRefresco,TipoPuerto,Resolucion,EsGamer,TieneAltavoz,Id,Cantidad
                    FROM Monitor";

                SqlCommand sqlComando = new SqlCommand(comando, this.sqlConeccion);

                using (SqlDataReader dataReader = sqlComando.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        float precio = Convert.ToSingle(dataReader.GetValue("Precio"));

                        Monitor monitorNuevo = new Monitor(dataReader["Marca"].ToString(), dataReader["Modelo"].ToString(), dataReader["Color"].ToString(),
                                    precio, dataReader.GetInt32("Pulgadas"), dataReader.GetBoolean("EsCurvo"), dataReader["TipoPanel"].ToString(), dataReader.GetInt32("TazaDeRefresco"),
                                    dataReader["TipoPuerto"].ToString(), dataReader["Resolucion"].ToString(), dataReader.GetBoolean("EsGamer"), dataReader.GetBoolean("TieneAltavoz"));


                        monitorNuevo.Id = dataReader.GetInt32("Id");
                        monitorNuevo.Cantidad = dataReader.GetInt32("Cantidad");

                        listaMonitores.Add(monitorNuevo);
                    }
                }

                return listaMonitores;
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

        public List<SmartPhone> ObtenerListaSmartPhones()
        {
            List<SmartPhone> listaSmartPhones = new List<SmartPhone>();

            try
            {
                sqlConeccion.Open();
                string comando = @"
                    SELECT Marca,Modelo,Color,Precio,Almacenamiento,MemoriaRam,PulgadasPantalla,PixelesCamara,CapacidadBateria,DualSim,IncluyeCargador,Id,Cantidad
                    FROM SmartPhone";

                SqlCommand sqlComando = new SqlCommand(comando, this.sqlConeccion);

                using (SqlDataReader dataReader = sqlComando.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        float precio = Convert.ToSingle(dataReader.GetValue("Precio"));

                        SmartPhone smartPhoneNuevo = new SmartPhone(dataReader["Modelo"].ToString(), dataReader["Marca"].ToString(), dataReader["Color"].ToString(),
                                    precio, dataReader.GetInt32("Almacenamiento"), Convert.ToSingle(dataReader.GetValue("PulgadasPantalla")), dataReader.GetInt32("PixelesCamara"),
                                    dataReader.GetInt32("CapacidadBateria"), dataReader.GetInt32("MemoriaRam"), dataReader.GetBoolean("DualSim"), dataReader.GetBoolean("IncluyeCargador"));


                        smartPhoneNuevo.Id = dataReader.GetInt32("Id");
                        smartPhoneNuevo.Cantidad = dataReader.GetInt32("Cantidad");

                        listaSmartPhones.Add(smartPhoneNuevo);
                    }
                }

                return listaSmartPhones;
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
