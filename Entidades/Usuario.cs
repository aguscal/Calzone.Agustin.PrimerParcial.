using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{   
    [JsonDerivedType(typeof(Usuario))]
    [JsonDerivedType(typeof(Trabajador))]
    [JsonDerivedType(typeof(Comprador))]
    
    public abstract class Usuario
    {
        string contrasenia;
        string email;
        string nombre;
        string apellido;


        public string Contrasenia{ get { return contrasenia; } set { contrasenia = value; } }
        public string Email{ get { return email; } set { email = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }

        public Usuario()
        {

        }

        public Usuario(string email, string pass, string nombre,string apellido)
        {
            this.contrasenia = pass;
            this.email = email;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Apellido: {Apellido}");
            sb.AppendLine($"Email: {email}");

            return sb.ToString();
        }
    }
}
