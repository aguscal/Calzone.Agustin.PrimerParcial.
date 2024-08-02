using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades
{
    public enum RolTrabajador
    {
        Vendedor,
        Supervisor,
        Administrador
    }
    public class Trabajador : Usuario
    {
        RolTrabajador rolTrabajador;
        public Trabajador()
        {

        }
        public Trabajador(string mail, string pass, string nombre, string apellido,RolTrabajador rolTrabajador) : base(mail, pass, nombre, apellido)
        {
            this.rolTrabajador = rolTrabajador;
        }
        public RolTrabajador Rol {get { return rolTrabajador; }set { rolTrabajador = value; } }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ToString());

            return sb.ToString();
        }
    }
}
