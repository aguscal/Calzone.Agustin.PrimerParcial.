using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comprador:Usuario
    {
        List<Producto> listaCarritoProductos;
        public Comprador()
        {

        }

        public Comprador(string mail,string pass,string nombre,string apellido) :base(mail,pass,nombre, apellido)
        {
            listaCarritoProductos = new List<Producto>();
        }

        public List<Producto> ListaCarrito
        {
            get { return listaCarritoProductos; }
            set { listaCarritoProductos = value; }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ToString());
            sb.AppendLine($"Lista carrito: {listaCarritoProductos}");

            return sb.ToString();
        }


        public bool AgregarProductoAlCarrito(Producto productoSeleccionado,Negocio negocioStock)
        {
            if(negocioStock == productoSeleccionado)
            {
                listaCarritoProductos.Add(productoSeleccionado);
            }
            else
            {
                return false;
            }

            return true;
        }
    }
}
