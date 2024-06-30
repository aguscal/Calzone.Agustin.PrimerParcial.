using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace Entidades
{
    public class Monitor:Producto
    {
        int pulgadas;
        bool esCurvo;
        string tipoPanel; 
        int tazaDeRefresco;
        string tipoPuerto;
        string resolucion;
        bool esGamer;
        bool tieneAltavoz;

        public Monitor()
        {

        }
        public Monitor(string marca, string modelo, string color, float precio, int pulgadas, bool esCurvo, string tipoPanel,
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

        public Monitor(string marca, string modelo, string color, float precio, int pulgadas, bool esCurvo, string tipoPanel,
            int tazaRefresco, string tipoPuerto, string resolucion,bool esGamer)
            : this(marca, modelo, color, precio,pulgadas,esCurvo,tipoPanel,tazaRefresco,tipoPuerto,resolucion)
        {
            this.esGamer = esGamer;
        }

        public Monitor(string marca, string modelo, string color, float precio, int pulgadas, bool esCurvo, string tipoPanel,
            int tazaRefresco, string tipoPuerto, string resolucion, bool esGamer,bool tieneAltavoz)
            : this(marca, modelo, color, precio, pulgadas, esCurvo, tipoPanel, tazaRefresco, tipoPuerto, resolucion,esGamer)
        {
            this.tieneAltavoz = tieneAltavoz;
        }

        public string TipoPanel { get { return tipoPanel; } set { tipoPanel = value; } }
        public string TipoPuerto { get { return tipoPuerto; } set { tipoPuerto = value; } }
        public string Resolucion { get { return resolucion; } set { resolucion = value; } }
        public int Pulgadas { get { return pulgadas; } set { pulgadas = value; } }
        public int TazaDeRefresco { get { return tazaDeRefresco; } set { tazaDeRefresco = value; } }
        public bool EsCurvo { get { return esCurvo; } set { esCurvo = value; } }
        public bool EsGamer { get { return esGamer; } set { esGamer = value; } }
        public bool TieneAltavoz { get { return tieneAltavoz; } set { tieneAltavoz = value; } }
        public override string ToString()
        {
            return MostrarInfo();
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

        /// <summary>
        /// Este método verifica si dos productos son iguales.
        /// Primero compara por id mediante la sobrecarga del equals.
        /// Luego de no ser asi verifica si los atributos clave de cada objeto son iguales entre si
        /// </summary>
        /// <param name="m1">Primer Monitor.</param>
        /// <param name="m2">Segundo Monitor.</param>
        /// <returns>Retorna bool si son iguales,false de lo contrario.</returns>
        public static bool operator ==(Monitor m1, Monitor m2)
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
            sb.Append(this.GetType().Name);
            sb.Append($"{base.MostrarInfo()}");
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
    }
}
