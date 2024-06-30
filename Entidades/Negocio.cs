using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        private static Negocio instancia = null;

        private List<Producto> listaProductos;
        const int cantidadMaximaStock = 10;
        string nombreArchivoListaProductos;

        public static Negocio Instancia
        {
            get
            {
                if(instancia is null)
                {
                    instancia = new Negocio();
                }

                return instancia;
            }
        }
        public List<Producto> ListaProductos
        {
            get { return ClaseSerializadora.LeerListaProductosJson(nombreArchivoListaProductos); }
        }
        private Negocio()
        {
            nombreArchivoListaProductos = "ListaProductos.json";
            /*listaProductos = new List<Producto>();       
            ClaseSerializadora.EscribirListaProductosJson(listaProductos, nombreArchivoListaProductos);*/
            listaProductos = ClaseSerializadora.LeerListaProductosJson(nombreArchivoListaProductos);
        }

       
        public static bool operator ==(Negocio n, Producto p)
        {
            if (n.ObtenerCantidadProductosEncontrados(n, p) > 0)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Negocio n, Producto p)
        {
            return !(n == p);
        }

        /*Retorna la cantidad de un producto dado como parametro
        la cantidad de ese producto la necesito para despues en la sobrecarga del + y -
        saber que si no esta no puede restar y si esta comparar con el limite de stock para poder agregar
        porque de lo contrario solo podria agregar uno de cada producto
        si retorna 0 quiere decir que no habia ese producto en la lista
        si retorna  > 0 entonces esta retornando la cantidad de ese producto
        public int ObtenerCantidadProductosEncontrados(Negocio n, Producto p)*/
        public int ObtenerCantidadProductosEncontrados(Negocio n, Producto p)
        {
            int contadorProductosEncontrados = 0;

            if (n is not null && p is not null)
            {
                foreach (var item in n.ListaProductos)
                {
                    if (p is Auricular && item is Auricular)
                    {
                        if ((Auricular)item == (Auricular)p)
                        {
                            contadorProductosEncontrados += 1;
                        }
                    }
                    else if (p is Monitor && item is Monitor)
                    {
                        if ((Monitor)item == (Monitor)p)
                        {
                            contadorProductosEncontrados += 1;
                        }
                    }
                    else if (p is SmartPhone && item is SmartPhone)
                    {
                        if ((SmartPhone)item == (SmartPhone)p)
                        {
                            contadorProductosEncontrados += 1;
                        }
                    }
                }
            }

            return contadorProductosEncontrados;
        }


        public static bool operator +(Negocio n, Producto p)
        {
            if (n is not null && p is not null)
            {
                if (n == p)//esta en la lista
                {
                    if (n.ObtenerCantidadProductosEncontrados(n, p) < cantidadMaximaStock)//verificar que no supere el maximo
                    {
                        n.listaProductos.Add(p);//lo agrega
                        ClaseSerializadora.EscribirListaProductosJson(n.listaProductos, "ListaProductos.json");
                        return true;
                    }
                }
                else
                {
                    n.listaProductos.Add(p);//si no esta en la lista lo agrega
                    ClaseSerializadora.EscribirListaProductosJson(n.listaProductos, "ListaProductos.json");
                    return true;
                }

                return false;
            }

            return false;
        }


        //lo que hace ahora es priemero buscar un producto que coincida por id y eliminarlo,
        //si no puede elimina un coincidente o retorna false
        public static bool operator -(Negocio n, Producto p)
        {
            if (n is not null && p is not null)
            {
                if (n != p)
                {
                    return false;
                }
                else
                {                   
                    Producto productoBuscado;

                    productoBuscado = n.BuscarProductoPorId(p);
                    if(productoBuscado is not null)
                    {
                        Console.WriteLine(productoBuscado.Id);
                        n.listaProductos.Remove(productoBuscado);

                        ClaseSerializadora.EscribirListaProductosJson(n.listaProductos, "ListaProductos.json");
                        return true;
                    }
                    else
                    {
                        productoBuscado = n.ObtenerBuscarProductoCoincidente(p);

                        if (productoBuscado is not null)
                        {
                            Console.WriteLine(productoBuscado.Id);
                            n.listaProductos.Remove(productoBuscado);

                            ClaseSerializadora.EscribirListaProductosJson(n.listaProductos, "ListaProductos.json");
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }                                     
                }                
            }
            else
            {               
                return false;
            }
        }

        public Producto BuscarProductoPorId(Producto p)
        {
            foreach (var producto in ListaProductos)
            {
                if (p.Equals(producto))
                {
                    return producto;
                }
            }

            return null;
        }

        //retorna el primer producto coincidente
        public Producto ObtenerBuscarProductoCoincidente(Producto p)
        {
            foreach(var producto in ListaProductos)
            {
                if (p is Auricular && producto is Auricular)
                {
                    if ((Auricular)producto == (Auricular)p)
                    {
                        return producto;
                    }
                }
                else if (p is Monitor && producto is Monitor)
                {
                    if ((Monitor)producto == (Monitor)p)
                    {
                        return producto;
                    }
                }
                else if (p is SmartPhone && producto is SmartPhone)
                {
                    if ((SmartPhone)producto == (SmartPhone)p)
                    {
                        return producto;
                    }
                }
            }
            
            return null;
        }

        public List<Producto> ObtenerListaProductosCoincidentes(Producto productoABuscar)
        {
            List<Producto> listaAuxProducto = new List<Producto>();

            foreach (var producto in ListaProductos)
            {
                if (productoABuscar is Auricular && producto is Auricular)
                {
                    if ((Auricular)productoABuscar == (Auricular)producto)
                    {
                        listaAuxProducto.Add(producto);
                    }
                }
                else if (productoABuscar is Monitor && producto is Monitor)
                {
                    if ((Monitor)productoABuscar == (Monitor)producto)
                    {
                        listaAuxProducto.Add(producto);
                    }
                }
                else if (productoABuscar is SmartPhone && producto is SmartPhone)
                {
                    if ((SmartPhone)productoABuscar == (SmartPhone)producto)
                    {
                        listaAuxProducto.Add(producto);                       
                    }
                }
            }

            return listaAuxProducto;
        }
        public List<Producto> ObtenerListaproductosFiltrados(string categoria)//las opciones que se pueden
                                                                              //ingresar son solo las que ser el toString() de
                                                                              //las derivadas
        {
            List<Producto> auxListProductos = new List<Producto>();

            foreach (var producto in ObtenerListaProductosSinRepetir())
            {
                if (producto.GetType().Name == categoria)
                {
                    auxListProductos.Add(producto);
                }
            }

            return auxListProductos;
        }

        public List<Producto> ObtenerListaproductosFiltrados(string categoria, string marca)
        {

            List<Producto> auxListProductos = new List<Producto>();

            foreach (var producto in ObtenerListaProductosSinRepetir())
            {
                if (producto.GetType().Name == categoria && producto.Marca == marca)
                {
                    auxListProductos.Add(producto);
                }
            }

            return auxListProductos;
        }

        public List<string> ObtenerMarcasSegunCategoria(string categoria)
        {
            List<string> list = new List<string>();
            
            if (categoria == "Auricular")
            {
                foreach(var marca in Enum.GetValues(typeof (EMarcasAuricular)))
                {
                    list.Add(marca.ToString());
                }
            }else if(categoria == "Monitor")
            {
                foreach (var marca in Enum.GetValues(typeof(EMarcasMonitor)))
                {
                    list.Add(marca.ToString());
                }
            }
            else if (categoria == "SmartPhone")
            {
                foreach (var marca in Enum.GetValues(typeof(EMarcasSmartPhone)))
                {
                    list.Add(marca.ToString());
                }
            }

            return list;
        }

        //Este metodo recibe una lista que ya esta filtrada o solo por categoria o por marca 
        //y este metodo por defecto la ordena de manera ascendente
        //hay que pasarle como segundo parametro false para que lo haga descendente
        //y devuelve la lista ordenada segun el parametro, pero siempre por precio
        public List<Producto> OrdenarProductosPorPrecio(List<Producto> productos, bool ascendente = true)
        {
            if (ascendente)
            {
                return productos.OrderBy(p => p.Precio).ToList();
            }
            else
            {
                return productos.OrderByDescending(p => p.Precio).ToList();
            }
        }

        public List<Producto> ObtenerListaProductosSinRepetir()
        {
            List<Producto> auxListaProduct = new List<Producto>();

            foreach (var productoStock in ListaProductos)
            {
                bool encontrado = false;
                foreach (var productoUnico in auxListaProduct)
                {
                    if (productoStock is Auricular && productoUnico is Auricular)
                    {
                        if ((Auricular)productoUnico == (Auricular)productoStock)
                        {
                            encontrado = true;
                            break;
                        }
                    }
                    else if (productoStock is Monitor && productoUnico is Monitor)
                    {
                        if ((Monitor)productoUnico == (Monitor)productoStock)
                        {
                            encontrado = true;
                            break;
                        }
                    }
                    else if (productoStock is SmartPhone && productoUnico is SmartPhone)
                    {
                        if ((SmartPhone)productoUnico == (SmartPhone)productoStock)
                        {
                            encontrado = true;
                            break;
                        }
                    }
                }

                // Si no se encuentra, agregarlo a la lista de productos únicos
                if (!encontrado)
                {
                    auxListaProduct.Add(productoStock);
                }

            }

            return auxListaProduct;
        }


        public int ObtenerCantidadDelProductoIgualesEnLista(List<Producto> listaProductos, Producto producto)
        {
            int contadorProductosEncontrados = 0;

            if (listaProductos is not null && producto is not null)
            {
                foreach (var item in listaProductos)
                {
                    if (producto is Auricular && item is Auricular)
                    {
                        if ((Auricular)item == (Auricular)producto)
                        {
                            contadorProductosEncontrados += 1;
                        }
                    }
                    else if (producto is Monitor && item is Monitor)
                    {
                        if ((Monitor)item == (Monitor)producto)
                        {
                            contadorProductosEncontrados += 1;
                        }
                    }
                    else if (producto is SmartPhone && item is SmartPhone)
                    {
                        if ((SmartPhone)item == (SmartPhone)producto)
                        {
                            contadorProductosEncontrados += 1;
                        }
                    }
                }
            }

            return contadorProductosEncontrados;
        }

        //busca si esta el producto pasado por parametro y de ser asi , lo quita de la lista de stock y retorna true
        //caso contrario si no esta el producto retorna false
        //podria hacer una sobrecarga que reciba una cantidad por si quiere comprar varios  productos iguales
        public bool VenderProducto(Producto productoAVender)
        {
            int cantidadStockProductoRecibido = ObtenerCantidadDelProductoIgualesEnLista(ListaProductos, productoAVender);

            if(cantidadStockProductoRecibido > 0)
            {
                bool sePudoVender = this - productoAVender;

                return sePudoVender;
            }
            
            return false;            
        }

        public bool ModificarPrecioProductosCoincidentes(Producto productoACambiar,float precio)
        {
            if(ObtenerListaProductosCoincidentes(productoACambiar) is not null && ObtenerListaProductosCoincidentes(productoACambiar).Count > 0)
            {
                foreach(var producto in ObtenerListaProductosCoincidentes(productoACambiar))
                {
                    foreach(var productoEnLista in listaProductos)
                    {
                        if(producto == productoEnLista)
                        {
                            productoEnLista.Precio = precio;
                        }                       
                    }
                                 
                }
                ClaseSerializadora.EscribirListaProductosJson(listaProductos, nombreArchivoListaProductos);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EliminarTodoElStockProductosCoincidentes(Producto productoAEliminar)
        {
            List<Producto> listaProductosAEliminar = ObtenerListaProductosCoincidentes(productoAEliminar);

            foreach(var producto in listaProductosAEliminar)
            {
                bool retorno = this - producto;
                if(retorno == false)
                {
                    return false;
                }
            }

            ClaseSerializadora.EscribirListaProductosJson(listaProductos, nombreArchivoListaProductos);
            return true;
            
        }

        public float ObtenerPrecioProductoEnLista(Producto productoBuscado)
        {
            float precio = 0;

            foreach (var producto in listaProductos)
            {
                if(producto == productoBuscado)
                {
                    return producto.Precio;
                }
            }

            return precio;
        }

    }
}
