using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace Entidades
{
    [JsonDerivedType(typeof(Producto))]
    [JsonDerivedType(typeof(Auricular))]
    [JsonDerivedType(typeof(SmartPhone))]
    [JsonDerivedType(typeof(Monitor))]
    /// <summary>
    /// Esta es la clase base de los tipos derivados: Monitor,Auricular,Smartphone
    /// Establece atributos base, tiene una serie de constructores
    /// Maneja los numeros de id de todos los productos que se creen
    /// </summary>
    public abstract class Producto
    {
        private string marca;
        private int id;
        static int siguienteId;
        private string modelo;
        protected string color;
        private float precio;

        public int Id { get { return id; } set { id = value; } }
        public int SiguienteId { get { return siguienteId; } set { siguienteId = value; } }
        public string Tipo { get { return this.GetType().Name; } }
        public string Marca { get { return marca; } set { marca = value; } }
        public string Modelo { get { return modelo; } set { modelo = value; } }
        public string Color { get { return color; } set { color = value; } }
        public float Precio { get { return precio; } set { precio = value; } }
        

        public string NombreCompleto
        {
            get { return $"{marca} {modelo}"; }
        }

        static Producto()
        {
            siguienteId = 0;
        }

        public Producto()
        {

        }

        public Producto(string marca, string modelo, string color, float precio):this()
        {
            this.marca = marca;
            this.modelo = modelo;
            this.color = color;
            this.precio = precio;
            id = ++siguienteId;            
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} {NombreCompleto}";
        }

        //Compara si son el objeto tiene el mismo id, si son iguales true , else false
        public override bool Equals(object? obj)
        {
            if (obj != null && obj is Producto)
            {
                if (((Producto)obj).Id == this.Id)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            if (p1.Equals(p2))//tienen mismo id, son iguales
            {
                return true;
            }
            else if (p1.marca == p2.marca && p1.modelo == p2.modelo && p1.color == p2.color)//tienen la misma caracteristicas de producto
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public virtual string MostrarInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($" {NombreCompleto}");

            return sb.ToString();
        }

        public abstract string MostrarDescripcion();// cada producto tiene sus propias cosas a mostrar como descripcion

    }
}
