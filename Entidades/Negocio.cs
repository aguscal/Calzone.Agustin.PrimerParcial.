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
        private List<Producto> listaProductos = new List<Producto>();
        const int cantidadMaximaStock = 10;

        static Negocio()
        {
            
            Monitor monitor1 = new Monitor(EMarcas.Asus.ToString(),EModelosMonitorAsus.Tuf1.ToString(),EColores.Negro.ToString(),100000, 17.5F, false,EPanelMonitor.Led.ToString(),120,ETipoPuerto.Hdmi.ToString(),EResolucionesMonitor.FullHd.ToString());
            Monitor monitor2 = new Monitor(EMarcas.Asus.ToString(),EModelosMonitorAsus.Tuf1.ToString(),EColores.Negro.ToString(),100000, 17.5F, false,EPanelMonitor.Led.ToString(),120,ETipoPuerto.Hdmi.ToString(),EResolucionesMonitor.FullHd.ToString());
            Monitor monitor3 = new Monitor(EMarcas.Asus.ToString(),EModelosMonitorAsus.Tuf1.ToString(),EColores.Negro.ToString(),100000, 17.5F, false,EPanelMonitor.Led.ToString(),120,ETipoPuerto.Hdmi.ToString(),EResolucionesMonitor.FullHd.ToString());
            Monitor monitor4 = new Monitor(EMarcas.Asus.ToString(),EModelosMonitorAsus.Tuf1.ToString(),EColores.Negro.ToString(),100000, 17.5F, false,EPanelMonitor.Led.ToString(),120,ETipoPuerto.Hdmi.ToString(),EResolucionesMonitor.FullHd.ToString());

            Monitor monitor5 = new Monitor(EMarcas.Philips.ToString() ,EModelosMonitorPhilips.PhilipsKlga.ToString(),EColores.Negro.ToString(),80000, 22, false,EPanelMonitor.Led.ToString(),120,ETipoPuerto.Hdmi.ToString(),EResolucionesMonitor.Hd.ToString());
            Monitor monitor6 = new Monitor(EMarcas.Philips.ToString() ,EModelosMonitorPhilips.PhilipsKlga.ToString(),EColores.Negro.ToString(),80000, 22, false,EPanelMonitor.Led.ToString(),120,ETipoPuerto.Hdmi.ToString(),EResolucionesMonitor.Hd.ToString());
            Monitor monitor7 = new Monitor(EMarcas.Philips.ToString() ,EModelosMonitorPhilips.PhilipsKlga.ToString(),EColores.Negro.ToString(),80000, 22, false,EPanelMonitor.Led.ToString(),120,ETipoPuerto.Hdmi.ToString(),EResolucionesMonitor.Hd.ToString());
            Monitor monitor8 = new Monitor(EMarcas.Philips.ToString() ,EModelosMonitorPhilips.PhilipsKlga.ToString(),EColores.Negro.ToString(),80000, 20, false,EPanelMonitor.Led.ToString(),120,ETipoPuerto.Hdmi.ToString(),EResolucionesMonitor.Hd.ToString());


            Auricular auricular1 = new Auricular(EModelosAurJbl.tune110.ToString(),EMarcas.Jbl.ToString(),EColores.Blanco.ToString(),8000,true,20,60,true,true);
            Auricular auricular2 = new Auricular(EModelosAurJbl.tune110.ToString(),EMarcas.Jbl.ToString(),EColores.Blanco.ToString(),8000,true,20,60,true,true);
            Auricular auricular3 = new Auricular(EModelosAurJbl.tune110.ToString(),EMarcas.Jbl.ToString(),EColores.Blanco.ToString(),8000,true,20,60,true,true);
            Auricular auricular4 = new Auricular(EModelosAurJbl.tune110.ToString(),EMarcas.Jbl.ToString(),EColores.Blanco.ToString(),8000,true,20,60,true,true);

            Auricular auricular5 = new Auricular(EModelosAurSony.Sony150.ToString(),EMarcas.Sony.ToString(),EColores.Negro.ToString(),15000,true,40,80,true,true);
            Auricular auricular6 = new Auricular(EModelosAurSony.Sony150.ToString(),EMarcas.Sony.ToString(),EColores.Negro.ToString(),15000,true,40,80,true,true);
            
            SmartPhone smartPhone1 = new SmartPhone(EModeloSmartPhoneSamsung.GalaxyA34.ToString(),EMarcas.Samsung.ToString(),EColores.Gris.ToString(),300000,128,7,50,4500,6);
            SmartPhone smartPhone2 = new SmartPhone(EModeloSmartPhoneSamsung.GalaxyA34.ToString(),EMarcas.Samsung.ToString(),EColores.Gris.ToString(),300000,128,7,50,4500,6);

            SmartPhone smartPhone3 = new SmartPhone(EModeloSmartPhoneMotorola.Edge40.ToString(),EMarcas.Motorola.ToString(),EColores.Celeste.ToString(),450000,240,9,80,5500,8);
            SmartPhone smartPhone4 = new SmartPhone(EModeloSmartPhoneSamsung.GalaxyA34.ToString(),EMarcas.Samsung.ToString(),EColores.Gris.ToString(),300000,128,7,50,4500,8);
            
            /*
             + 
            listaProductos.Add(monitor1);
            listaProductos.Add(monitor1);//3 monitores1
            listaProductos.Add(monitor1);
            listaProductos.Add(monitor2);
            listaProductos.Add(monitor2);
            listaProductos.Add(monitor2);
            listaProductos.Add(monitor2);
            listaProductos.Add(auricular1);
            listaProductos.Add(auricular2);
            listaProductos.Add(auricular3);
            listaProductos.Add(auricular1);
            listaProductos.Add(auricular1);
            listaProductos.Add(auricular4);
            listaProductos.Add(auricular11);
            listaProductos.Add(auricular111);
            */
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

        private int ObtenerCantidadProductosEncontrados(Negocio n, Producto p)
        {
            int contadorProductosEncontrados = 0;

            if (n is not null && p is not null)
            {
                foreach (var item in n.listaProductos)
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

            return contadorProductosEncontrados;// si retorna 0 quiere decir que no habia ese producto en la lista
                                                // si retorna  > 0 entonces esta retornando la cantidad de ese producto
                                                //la cantidad de ese producto la necesito para despues en la sobrecarga del + y -
                                                //saber que si no esta no puede restar y si esta comparar con el limite de stock para poder agregar
                                                //porque de lo contrario solo podria agregar uno de cada producto
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
                        return true;
                    }
                }
                else
                {
                    n.listaProductos.Add(p);//si no esta en la lista lo agrega
                    return true;
                }

                return false;
            }

            return false;
        }

        public static bool operator -(Negocio n, Producto p)
        {
            if (n is not null && p is not null)
            {
                foreach (var item in n.listaProductos)
                {
                    if (item.Equals(p))
                    {
                        n.listaProductos.Remove(p);
                        return true;
                    }
                }
            }
            else
            {
                return false;
            }

            return false;
        }

        /*
        private List<Producto> CopiarLista(List<Producto> listaOriginal)
        {
            List<Producto> listaAux = new List<Producto>();

            foreach(var item in listaOriginal)
            {
                listaAux.Add(item);    
            }

            return listaAux;
        }

        public void AgregarProductosAlStock(Negocio n,Producto p,int cantidadProductos)
        {
            int cantidadProductosParaAgregar = cantidadMaximaStock - ObtenerCantidadProductosEncontrados(n,p) ;
            List<Producto> listaAux = CopiarLista(listaProductos);

            for (int i = 0; i < cantidadProductosParaAgregar; i++)
            {
                Producto producto = new Producto();
                listaAux.Add()
            }
        }
        */

        public List<Producto> ObtenerListaproductosFiltrados(string categoria)//las opciones que se pueden
                                                                              //ingresar son solo las que ser el toString() de
                                                                              //las derivadas
        {
            List<Producto> auxListProductos = new List<Producto>();

            foreach (var producto in listaProductos)
            {
                if (producto.ToString() == categoria)
                {
                    auxListProductos.Add(producto);
                }
            }

            return auxListProductos;
        }



        public List<Producto> ObtenerListaproductosFiltrados(string categoria, string marca)
        {

            List<Producto> auxListProductos = new List<Producto>();

            foreach (var producto in listaProductos)
            {
                if (producto.ToString() == categoria && producto.Marca == marca)
                {
                    auxListProductos.Add(producto);
                }
            }

            return auxListProductos;
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

        //Aca tengo que poder hacer el agregar y quitarle objetos a la lista de productos u coleccion

        //para crear un objeto , osea agregar un nuevo producto no habra restriccion , ya que los estoy creando 
        //solo me dan las caracteristicas del producto y creo esa cantidad de productos y los agrego a la lista

        //para vender productos o consultar stock , si tengo que tener un metodo o algo qeu me diga cuanto hay de ese producto
        //que es un producto que voy a buscar si es que tengo en el stock mediante esos parametros que me pasan
        //otra opcion es tener un diccionario donde operar con esos valores constantemente

        //un metodo va a ser para vende ya que implica disminuir ese producto de la lista 
        //intentar hacer el metodo consultar stock


        public bool Venderproducto(string tipoproducto, string marca, string modelo, string color, Producto auxProducto)
        {
            bool sePudoVender = false;

            foreach (var item in listaProductos)
            {
                if (item.Marca == marca && item.Modelo == modelo && item.Color == color)
                {
                    auxProducto = item;
                    sePudoVender = true;
                    break;
                }
            }

            return sePudoVender;
        }
    }
}
