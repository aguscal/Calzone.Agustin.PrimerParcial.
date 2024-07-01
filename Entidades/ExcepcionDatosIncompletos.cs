using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ExcepcionDatosIncompletos:Exception
    {
        public ExcepcionDatosIncompletos(string mensaje):this(mensaje,null)
        {
        
        }

        public ExcepcionDatosIncompletos(string mensaje,Exception inner):base(mensaje,inner)
        {

        }
    }
}
