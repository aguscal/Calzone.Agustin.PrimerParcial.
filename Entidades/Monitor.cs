using System.Text;

namespace Entidades
{
    public class Monitor:Producto
    {
        float pulgadas;
        bool esCurvo;
        string tipoPanel;//ips u oled , 
        int tazaDeRefresco;//60 Hz, 120 Hz, 144 Hz, 200 Hz y 240 Hz.
        string tipoPuerto;//vga o hdmi
        string resolucion;//hd , full hd , 4k , vga
        bool esGamer;
        bool tieneAltavoz;//si o no

        public Monitor(string marca, string modelo, string color, float precio, float pulgadas, bool esCurvo, string tipoPanel,
            int tazaRefresco, string tipoPuerto, string resolucion)
            : base(marca, modelo, color, precio)
        {
            this.pulgadas = pulgadas;
            this.esCurvo = esCurvo;
            this.tipoPanel = tipoPanel;
            this.tazaDeRefresco = tazaRefresco;
            this.tipoPuerto = tipoPuerto;
            this.resolucion = resolucion;
            this.esGamer = false;
            this.tieneAltavoz = false;
        }

        public Monitor(string marca, string modelo, string color, float precio, float pulgadas, bool esCurvo, string tipoPanel,
            int tazaRefresco, string tipoPuerto, string resolucion,bool esGamer)
            : this(marca, modelo, color, precio,pulgadas,esCurvo,tipoPanel,tazaRefresco,tipoPuerto,resolucion)
        {
            this.esGamer = esGamer;
        }

        public Monitor(string marca, string modelo, string color, float precio, float pulgadas, bool esCurvo, string tipoPanel,
            int tazaRefresco, string tipoPuerto, string resolucion, bool esGamer,bool tieneAltavoz)
            : this(marca, modelo, color, precio, pulgadas, esCurvo, tipoPanel, tazaRefresco, tipoPuerto, resolucion,esGamer)
        {
            this.tieneAltavoz = tieneAltavoz;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}";
        }
        public override bool Equals(object? obj)
        {
            if (obj != null && obj is Monitor)
            {
                if (((Monitor)obj).Id == this.Id)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator ==(Monitor m1, Monitor m2)//tambien podria crear un codigo unico para cada tipo de producto , y comparar solo eso, crearlo cuando no hay ninguno
        {
            if (m1.Equals(m2))//tienen mismo id, son iguales
            {
                return true;
            }
            
            if (m1.Marca == m2.Marca && m1.Modelo == m2.Modelo && m1.color == m2.color && m1.pulgadas == m2.pulgadas)//tienen la misma caracteristicas de producto
            {
                if(m1.resolucion == m2.resolucion && m1.esCurvo == m2.esCurvo && m1.tipoPanel == m2.tipoPanel && m1.tazaDeRefresco == m2.tazaDeRefresco && m1.tieneAltavoz == m2.tieneAltavoz)
                {
                    return true;
                }                
            }

            return false;
        }

        public static bool operator !=(Monitor m1, Monitor m2)
        {
            return !(m1 == m2);
        }

        public override string MostrarInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.ToString());
            sb.Append($" {base.MostrarInfo()}");
            sb.Append($" {pulgadas} Pulgadas");
            sb.Append($" {resolucion}");
            if (esGamer)
            {
                sb.Append($" Gamer");
            }
            sb.Append($" {tazaDeRefresco} Hz");
            if (esCurvo)
            {
                sb.Append($" Curvo");
            }

            sb.AppendLine($" ${Precio}");

            return sb.ToString();
        }

        public override string MostrarDescripcion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(MostrarInfo());
            sb.AppendLine($"Panel {tipoPanel}");
            sb.AppendLine($"Puerto {tipoPuerto}");
            if (tieneAltavoz)
            {
                sb.AppendLine($"Con altavoz");
            }

            return sb.ToString();
        }

        public override Producto copiarParametrosProducto()
        {
            Monitor auxMonitor = new Monitor(this.Marca,this.Modelo,this.color,this.Precio,this.pulgadas,this.)
        }

    }
}
