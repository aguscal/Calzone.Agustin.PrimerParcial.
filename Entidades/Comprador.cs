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
        Dictionary<Producto, int> dictCarrito;
        int idComprador;
        public Comprador()
        {
            dictCarrito = new Dictionary<Producto, int>();
        }

        public Comprador(int idComprador,string mail,string pass,string nombre,string apellido) :base(mail,pass,nombre, apellido)
        {
            this.idComprador = idComprador;
            dictCarrito = new Dictionary<Producto, int>();
        }

        public Dictionary<Producto, int> DictCarrito
        {
            get { return dictCarrito; }
            set { dictCarrito = value; }
        }

        public int IdComprador
        {
            get { return idComprador; }
            set { idComprador = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ToString());
            sb.AppendLine($"Lista carrito: {dictCarrito}");

            return sb.ToString();
        }

        public bool AgregarProductoAlCarrito(Producto productoSeleccionado, Negocio negocioStock)
        {
            if (negocioStock == productoSeleccionado)//el producto seleccionado esta en el negocio
            {
                if (dictCarrito.ContainsKey(productoSeleccionado))//verifica si el producto ya esta en el carrito
                { 
                    dictCarrito[productoSeleccionado] += 1;//aumenta la cantidad del producto
                }
                else
                {
                    dictCarrito.Add(productoSeleccionado, 1);//agrega el producto al diccionario y le da valor de 1
                }                                
            }
            else
            {
                return false;
            }

            return true;
        }


        public void DisminuirQuitarProductoDelCarrito(Producto productoSeleccionado)//el producto seleccionado esta en el carrito, por lo cual tiene qeu ser mas de 0 unidades
        {
            dictCarrito[productoSeleccionado] -= 1;//disminuye en uno la cantidad del producto en el carrito
                
            if(dictCarrito[productoSeleccionado] == 0)//si la cantidad del producto en carrito pasa a ser 0 se elimina del carrito
            {
                dictCarrito.Remove(productoSeleccionado);
            }
        }
    }
}
