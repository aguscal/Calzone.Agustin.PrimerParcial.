using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IDao<T>where T : Producto
    {
        void Agregar(T producto);

        void Eliminar(T producto);

        void ActualizarPrecio(T producto, float nuevoPrecio);

        void ActualizarCantidad(T producto, bool aumentarODisminuir = true);

        int ObtenerCantidad(T producto);

        float ObtenerPrecio(T producto);
    }
}
