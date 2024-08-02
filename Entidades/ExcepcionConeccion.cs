using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ExcepcionConeccion:Exception
    {
        public ExcepcionConeccion(string mensaje = "Ocurrio un error de coneccion!") : this(null,mensaje)
        {

        }

        public ExcepcionConeccion(Exception inner, string mensaje = "Ocurrio un error de coneccion!") : base(mensaje, inner)
        {

        }

    }
}
