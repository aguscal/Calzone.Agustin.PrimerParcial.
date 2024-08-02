using System;
using System.Collections;
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

        const int cantidadMaximaStock = 10;

        static ProductosDAO productosDAO = new ProductosDAO();
        static AuricularDAO auricularDAO = new AuricularDAO();
        static MonitorDAO monitorDAO = new MonitorDAO();
        static SmartPhoneDAO smartPhoneDAO = new SmartPhoneDAO();

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

        private Negocio()
        {

        }

        public List<Producto> ListaProductos
        {
            get {return productosDAO.ObtenerListaProductos();}
        }       
       
        public static bool operator ==(Negocio n, Producto p)
        {
            if (n.ObtenerBuscarProductoCoincidente(p) is not null)
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
        public int ObtenerCantidadProductoBuscado(Negocio n, Producto p)*/
        /*public int ObtenerCantidadProductoBuscado(Negocio n, Producto p)
        {
            int cantidadProductoBuscado = 0;

            if (n is not null && p is not null)
            {
                foreach (var item in n.ListaProductos)
                {
                    if (p is Auricular && item is Auricular)
                    {
                        if ((Auricular)item == (Auricular)p)
                        {
                            //cantidadProductoBuscado += 1;
                            cantidadProductoBuscado = ((Auricular)item).Cantidad;
                            break;
                        }
                    }
                    else if (p is Monitor && item is Monitor)
                    {
                        if ((Monitor)item == (Monitor)p)
                        {
                            cantidadProductoBuscado = ((Monitor)item).Cantidad;
                            break;
                        }
                    }
                    else if (p is SmartPhone && item is SmartPhone)
                    {
                        if ((SmartPhone)item == (SmartPhone)p)
                        {
                            cantidadProductoBuscado = ((SmartPhone)item).Cantidad;
                            break;
                        }
                    }
                }
            }

            return cantidadProductoBuscado;
        }*/

        public int ObtenerCantidadProductoBuscado<T>(Negocio n, T producto)where T : Producto
        {
            int cantidadProductoBuscado = 0;

            if (n is not null && producto is not null)
            {
                foreach (var item in n.ListaProductos)
                {
                    if (producto is T productoT && item is T itemT)
                    {
                        if (productoT == itemT)
                        {
                            cantidadProductoBuscado = ((T)item).Cantidad;
                            break;
                        }
                    }
                }
            }

            return cantidadProductoBuscado;
        }

        public static bool operator +(Negocio n, Producto p)
        {
            if (n is not null && p is not null)
            {
                Producto productoBuscado = n.ObtenerBuscarProductoCoincidente(p);
                
                if (productoBuscado is not null)//esta en la lista
                {
                    if (productoBuscado.Cantidad < cantidadMaximaStock)//verificar que no supere el maximo
                    {
                        if (p is Auricular) {
                            auricularDAO.ActualizarCantidad((Auricular)productoBuscado);
                            return true;
                        }
                        else if (p is Monitor)
                        {
                            monitorDAO.ActualizarCantidad((Monitor)productoBuscado);
                            return true;
                        }
                        else if (p is SmartPhone) 
                        { 
                            smartPhoneDAO.ActualizarCantidad((SmartPhone)productoBuscado);
                            return true;
                        }                        
                    }
                }
                else
                {
                    if (p is Auricular)
                    {
                        auricularDAO.Agregar((Auricular)p);
                        return true;
                    }
                    else if (p is Monitor)
                    {
                        monitorDAO.Agregar((Monitor)p);
                        return true;
                    }
                    else if (p is SmartPhone)
                    {
                        smartPhoneDAO.Agregar((SmartPhone)p);
                        return true;
                    }

                }

                return false;
            }

            return false;
        }


        public static bool operator -(Negocio n, Producto p)
        {
            if (n is not null && p is not null)
            {
                if (n != p)
                {
                    //el producto no esta en el negocio
                    return false;
                }
                else
                {           
                    //el producto esta en el negocio
                    Producto productoBuscado = n.ObtenerBuscarProductoCoincidente(p);

                    if (productoBuscado is not null)
                    {
                        if (p is Auricular)
                        {
                            if(auricularDAO.ObtenerCantidad((Auricular)productoBuscado) > 0)
                            {
                                auricularDAO.ActualizarCantidad((Auricular)productoBuscado, false);
                                return true;
                            }
                        }
                        else if (p is Monitor)
                        {
                            if(monitorDAO.ObtenerCantidad((Monitor)productoBuscado) > 0)
                            {
                                monitorDAO.ActualizarCantidad((Monitor)productoBuscado, false);
                                return true;
                            }
                        }
                        else if (p is SmartPhone)
                        {
                            if(smartPhoneDAO.ObtenerCantidad((SmartPhone)productoBuscado) > 0)
                            {
                                smartPhoneDAO.ActualizarCantidad((SmartPhone)productoBuscado, false);
                                return true;
                            }
                        }

                        return false;                                           
                    }
                    else
                    {
                        return false;
                    }                                                     
                }                
            }
            else
            {               
                return false;
            }
        }

        public Producto ObtenerBuscarProductoCoincidente<T>(T p)where T : Producto
        {
            foreach (var producto in ListaProductos)
            {
                if (p is T && producto is T)
                {
                    if ((T)producto == (T)p)
                    {
                        return producto;
                    }
                }
            }

            return null;
        }

        public List<Producto> ObtenerListaproductosFiltrados(string categoria)                                                                              
        {
            List<Producto> auxListProductos = new List<Producto>();

            foreach (var producto in ListaProductos)
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

            foreach (var producto in ListaProductos)
            {
                if (producto.GetType().Name == categoria && producto.Marca == marca)
                {
                    auxListProductos.Add(producto);
                }
            }

            return auxListProductos;
        }

        public List<Producto> ObtenerListaproductosFiltradosPorMarca(string marca)
        {
            List<Producto> auxListProductos = new List<Producto>();

            foreach (var producto in ListaProductos)
            {
                if (producto.Marca == marca)
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


        //busca si esta el producto pasado por parametro y de ser asi , lo quita de la lista de stock y retorna true
        //caso contrario si no esta el producto retorna false
        //podria hacer una sobrecarga que reciba una cantidad por si quiere comprar varios  productos iguales
        public bool VenderProducto(Producto productoAVender)
        {
            //int cantidadStockProductoRecibido = ObtenerCantidadDelProductoEnLista(ListaProductos, productoAVender);
            bool sePudoVender = this - productoAVender;
            return sePudoVender;                                  
        }

        public float ObtenerPrecioProductoEnLista(Producto productoBuscado)
        {
            float precio = 0;

            if(productoBuscado is not null)
            {
                if(productoBuscado is Auricular){precio = auricularDAO.ObtenerPrecio((Auricular)productoBuscado);}
                else if (productoBuscado is Monitor) {precio = monitorDAO.ObtenerPrecio((Monitor)productoBuscado); }
                else if(productoBuscado is SmartPhone) {precio = smartPhoneDAO.ObtenerPrecio((SmartPhone)productoBuscado); }
            }           

            return precio;
        }


        public bool ModificarPrecioProducto(Producto productoAModificar,float nuevoPrecio)
        {
            if (productoAModificar is not null && nuevoPrecio > 0)
            {
                if(productoAModificar is Auricular)
                {
                    auricularDAO.ActualizarPrecio((Auricular)productoAModificar,nuevoPrecio);
                    return true;
                }else if(productoAModificar is Monitor)
                {
                    monitorDAO.ActualizarPrecio((Monitor)productoAModificar, nuevoPrecio);
                    return true;

                }else if(productoAModificar is SmartPhone)
                {
                    smartPhoneDAO.ActualizarPrecio((SmartPhone)productoAModificar, nuevoPrecio);
                    return true;
                }
            }
           
            
            return false;
            
        }


        public bool EliminarStockProducto(Producto productoAEliminar)
        {
            if(productoAEliminar is Auricular)
            {
                auricularDAO.Eliminar((Auricular)productoAEliminar);
                return true;
            }else if(productoAEliminar is Monitor)
            {
                monitorDAO.Eliminar((Monitor)productoAEliminar);
                return true;
            }else if(productoAEliminar is SmartPhone)
            {
                smartPhoneDAO.Eliminar((SmartPhone)productoAEliminar);
                return true;
            }

            return false;
        }


        public List<String> ObtenerTodasLasMarcas()
        {
            List<string> listaTodasLasMarcas = new List<string>();

            foreach (var marca in Enum.GetValues(typeof(EMarcas)))
            {
                listaTodasLasMarcas.Add(marca.ToString());
            }

            return listaTodasLasMarcas;
        }

        
        public bool VerificarDisponibilidadProductosSeleccionados(Dictionary<Producto,int> dictCarrito,out Producto productoSinStock)
        {
            foreach (var producto in dictCarrito)
            {
                int cantidadStock = ObtenerCantidadProductoBuscado(Instancia,producto.Key);
                
                if (cantidadStock == 0)
                {
                    productoSinStock = producto.Key;
                    return false;
                }
                else if(cantidadStock < producto.Value)
                {
                    productoSinStock = producto.Key;
                    return false;
                }
            }

            productoSinStock = null;

            return true;
        }
    }
}
