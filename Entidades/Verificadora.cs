using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Verificadora
    {
        public static bool VerificarEscrituraEmail(string email)
        {
            //se verifica si el mail es vacio o nulo , la cantidad de caracteres
            if (email.Contains(" "))
            {
                return false;
            }

            if (string.IsNullOrEmpty(email.Trim()))
            {
                return false;
            }

            if (email.Length < 6 || email.Length > 50)
            {
                return false;                
            }

            //se separa el mail por el arroba
            string[] partesEmail = email.Split('@');
            if (partesEmail.Length != 2)
            {
                return false;
            }

            //parte nombre del email , y parte dominio del email
            string nombreUsuario = partesEmail[0];
            string dominio = partesEmail[1];

            //verificar parte  nombre mail
            foreach (char caracter in nombreUsuario)
            {
                if (!(char.IsLetterOrDigit(caracter) || caracter == '_' || caracter == '.'))
                {
                    return false;
                }
            }

            //verificar parte dominio del mail
            //se separa el dominio por el punto
            string[] partesDominio = dominio.Split('.');
            
            if(partesDominio.Length != 2)
            {
                return false;
            }

            if (partesDominio[0].Length < 2 || partesDominio[1].Length < 2)
            {
                return false;
            }

            return true;

        }

        public static bool VerificarEscrituraContrasenia(string contrasenia)
        {
            if (string.IsNullOrEmpty(contrasenia))
            {
                return false;
            }

            if (contrasenia.Length < 6 || contrasenia.Length > 30)
            {
                return false;
            }

            if(contrasenia.Contains(" "))
            {
                return false;
            }

            return true;
        }
        

        // si el usuario esta registrado lo retorna , cosao contrario retorna null
        public static Usuario VerificarUsuarioRegistrado(string email,string contrasenia)
        {
            if(!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(contrasenia)) 
            {
                List<Usuario> listaUsuarios = ClaseSerializadora.LeerListaUsuariosJson("Usuarios.json");

                foreach (var usuario in listaUsuarios)
                {
                    if (usuario.Email == email && usuario.Contrasenia == contrasenia)
                    {
                        return usuario;
                    }
                }
            }            

            return null;
        }
    }
}
