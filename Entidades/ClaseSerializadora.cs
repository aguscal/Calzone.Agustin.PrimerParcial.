using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft;
using Newtonsoft.Json.Serialization;

namespace Entidades
{
    public static class ClaseSerializadora
    {
        //ESTE METODO VENDRIA A SER PARA GUARDAR EL CARRITO DE LOS USUARIOS CADA VEZ QEU SE REALIZA UN CAMBIO EN EL MISMO
        public static void GuardarCarrito(Comprador comprador, string nombreArchivo)
        {
            List<Usuario> usuarios = LeerListaUsuariosJson(nombreArchivo);
            for (int i = 0; i < usuarios.Count; i++)
            {
                if (usuarios[i].Email == comprador.Email)
                {
                    if (usuarios[i] is Comprador)
                    {
                        ((Comprador)usuarios[i]).DictCarrito = comprador.DictCarrito;
                    }
                    break;
                }
            }
            EscribirUsuariosJson(usuarios,nombreArchivo);
        }
        static public void EscribirUsuariosJson(List<Usuario> listaUsuarios, string nombreArchivo)
        {
            using (StreamWriter sw = new StreamWriter(nombreArchivo))
            {
                JsonSerializerSettings configuracionesJson = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
                string listaSerializada = JsonConvert.SerializeObject(listaUsuarios, Newtonsoft.Json.Formatting.Indented,configuracionesJson);

                sw.Write(listaSerializada);
            }
        }

        static public void EscribirListaProductosJson(List<Producto> listaProductos, string nombreArchivo)
        {
            using (StreamWriter sw = new StreamWriter(nombreArchivo))
            {
                JsonSerializerSettings configuracionesJson = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
                string listaSerializada = JsonConvert.SerializeObject(listaProductos, Newtonsoft.Json.Formatting.Indented, configuracionesJson);

                sw.Write(listaSerializada);
            }
        }


        static public List<Usuario> LeerListaUsuariosJson(string nombreArchivo)
        {
            using (StreamReader sr = new StreamReader(nombreArchivo))
            {
                string archivoLeido = sr.ReadToEnd();
                JsonSerializerSettings configuracionesJson = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };

                List<Usuario> listaDeSerializada = JsonConvert.DeserializeObject<List<Usuario>>(archivoLeido,configuracionesJson);
                
                return listaDeSerializada;
            }
        }

        static public List<Producto> LeerListaProductosJson(string nombreArchivo)
        {
            using (StreamReader sr = new StreamReader(nombreArchivo))
            {
                string archivoLeido = sr.ReadToEnd();
                JsonSerializerSettings configuracionesJson = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };

                List<Producto> listaDeSerializada = JsonConvert.DeserializeObject<List<Producto>>(archivoLeido, configuracionesJson);

                return listaDeSerializada;
            }
        }

        static public void EscribirArchivoLog(string lineaLog)
        {
            using (StreamWriter escribirArchivo = new StreamWriter("usuarios.log",true))
            {
                escribirArchivo.WriteLine(lineaLog);
            }
        }


        /*static public int ObtenerSiguienteId()
        {
            int ultimoId = 0;

            using (StreamReader sr = new StreamReader("ListaProductos.json"))
            {
                string archivoLeido = sr.ReadToEnd();
                JsonSerializerSettings configuracionesJson = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };

                List<Producto> listaDeSerializada = JsonConvert.DeserializeObject<List<Producto>>(archivoLeido, configuracionesJson);

                if(listaDeSerializada.Count > 0)
                {
                    Producto ultimoProducto = listaDeSerializada[listaDeSerializada.Count - 1];
                    ultimoId = ultimoProducto.Id;
                }

                return ultimoId;
            }
        }*/

        /*static public int ObtenerSiguienteId()
        {
            int ultimoId = 0;

            if (!File.Exists("ListaProductos.json"))
            {
                File.Create("ListaProductos.json");
            }

            using (StreamReader sr = new StreamReader("ListaProductos.json"))
            {
                try
                {
                    string archivoLeido = sr.ReadToEnd();
                    JsonSerializerSettings configuracionesJson = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };

                    List<Producto> listaDeSerializada = JsonConvert.DeserializeObject<List<Producto>>(archivoLeido, configuracionesJson);

                    if (listaDeSerializada.Count > 0)
                    {
                        Producto ultimoProducto = listaDeSerializada[listaDeSerializada.Count - 1];
                        ultimoId = ultimoProducto.Id;
                    }
                }
                catch (FileNotFoundException e)
                {
                    File.Create("ListaProductos.json");

                    return ultimoId;
                }
            }

            return ultimoId;
        }*/


        static public void EscribirUsuariosXml(List<Usuario> listaUsuarios,string nombreArchivo)
        {           
            using (StreamWriter sw = new StreamWriter(nombreArchivo))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Usuario>));
                xmlSerializer.Serialize(sw,listaUsuarios);
            }                          
        }

        static public List<Usuario> LeerListaUsuariosXml(string nombreArchivo)
        {               
            using (StreamReader sr = new StreamReader(nombreArchivo))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Usuario>));
                List<Usuario> listaDeSerializada = xmlSerializer.Deserialize(sr) as List<Usuario>;             

                return listaDeSerializada;
            }
        }


        static public void EscribirXmlListaProductos(List<Producto>listaStockProductos, string nombreArchivo)
        {
            using (StreamWriter sw = new StreamWriter(nombreArchivo))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Producto>));
                xmlSerializer.Serialize(sw,listaStockProductos);
            }
        }

        static public List<Producto> LeerXmlListaProductos(string nombreArchivo)
        {
            using (StreamReader sr = new StreamReader(nombreArchivo))
            {                
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Usuario>));
                List<Producto> listaDeSerializada = xmlSerializer.Deserialize(sr) as List<Producto>;

                return listaDeSerializada;
            }
        }


    }
}
