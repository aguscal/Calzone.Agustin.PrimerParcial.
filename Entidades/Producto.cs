using System.Text;

namespace Entidades
{
    public abstract class Producto
    {
        private string marca;
        private int id;
        static int siguienteId;
        private string modelo;
        protected string color;
        private float precio;
        private bool enOferta;//

        public string Marca { get { return marca; } }
        public int Id { get { return id; } }
        public float Precio { get { return precio; } set{ precio = value; } }
        public string Modelo { get { return modelo; } }
        public string Color { get { return color; } }

        public string NombreCompleto
        {
            get { return $"{marca} {modelo}"; }
        }

        static Producto()
        {
            siguienteId = 0;
        }

        private Producto()
        {
            this.enOferta = false;
        }

        public Producto(string marca, string modelo, string color, float precio):this()
        {
            this.marca = marca;
            this.modelo = modelo;
            this.color = color;
            this.precio = precio;
            id = ++siguienteId;            
        }

        public Producto(string marca, string modelo, string color, float precio, bool enOferta)
            :this(marca,modelo,color,precio)
        {
            this.enOferta = enOferta;
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
            sb.Append($" Numero de Id: {Id}");// SACAR ESTO , esto es solo para ver si anda

            return sb.ToString();
        }

        public abstract string MostrarDescripcion();// cada producto tiene sus propias cosas a mostrar como descripcion

        public void ModificarOferta()
        {

        }

        public void MostrarOferta()
        {
            
        }
    }
}
