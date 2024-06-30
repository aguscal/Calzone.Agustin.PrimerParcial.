using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades
{
    public class Trabajador:Usuario
    {
        int salario;

        public int Salario { get { return salario; } set{ salario = value; } }

        public Trabajador()
        {

        }
        public Trabajador(string mail, string pass, string nombre, string apellido, int salario) : base(mail,pass,nombre, apellido)
        {
            this.salario = salario;
        }             
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ToString());
            sb.AppendLine($"Salario: {Salario}");

            return sb.ToString();
        }
    }
}
