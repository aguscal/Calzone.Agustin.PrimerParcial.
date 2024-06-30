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

namespace Entidades
{
    public static class ClaseSerializadora
    {
        static ClaseSerializadora()
        {
            
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
