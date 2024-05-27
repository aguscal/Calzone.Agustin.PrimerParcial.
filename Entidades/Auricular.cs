using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auricular:Producto
    {
        bool cancelacionDeSonido;
        int dB;
        int hZ;
        bool esInalambrico;
        int horasBateria;
        int tiempoDeCarga;
        bool esGamer;
        bool conMicrofono;
        bool inEar;

        public Auricular(string modelo, string marca, string color,float precio,bool cancelacionDeSonido,int dB,int hZ,
            bool conMicrofono,bool inEar)
            : base(marca, modelo, color,precio)
        {
            this.cancelacionDeSonido = cancelacionDeSonido;
            this.dB = dB;
            this.hZ = hZ;
            this.conMicrofono = conMicrofono;
            this.inEar = inEar;
            esInalambrico = false;
            horasBateria = 0;
            tiempoDeCarga = 0;
            esGamer = false;
        }

        public Auricular(string modelo, string marca, string color, float precio, bool cancelacionDeSonido, int dB, int hZ,
            bool conMicrofono,bool inEar,bool esGamer)
            :this(modelo,marca,color,precio,cancelacionDeSonido,dB,hZ,conMicrofono,inEar)
        {
            this.esGamer = esGamer;
        }

        public Auricular(string modelo, string marca, string color, float precio, bool cancelacionDeSonido, int dB, int hZ,
            bool conMicrofono,bool inEar, bool esGamer,bool esInalambrico,int horasBateria,int tiempoDeCarga)
            : this(marca, modelo, color, precio,cancelacionDeSonido,dB,hZ, conMicrofono,inEar,esGamer)
        {
            this.esInalambrico = esInalambrico;
            this.horasBateria = horasBateria;
            this.tiempoDeCarga = tiempoDeCarga;          
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}";
        }

        public override bool Equals(object? obj)
        {
            if (obj != null && obj is Auricular)
            {
                if (((Auricular)obj).Id == this.Id)
                {
                    return true;
                }
            }
            return false;
        }


        public static bool operator ==(Auricular a1, Auricular a2)
        {
            if (a1.Equals(a2))
            {
                return true;
            }

            if (a1.Marca == a2.Marca && a1.Modelo == a2.Modelo && a1.color == a2.color && a1.esInalambrico == a2.esInalambrico)//tienen la misma caracteristicas de producto
            {
                if (a1.conMicrofono == a2.conMicrofono && a1.inEar == a2.inEar && a1.esGamer == a2.esGamer)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Auricular a1, Auricular a2)
        {
            return !(a1 == a2);
        }

        public override string MostrarInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.ToString());

            if (esGamer)
            {
                sb.Append($" Gamer");
            }

            if (esInalambrico)
            {
                sb.Append($" Inalambricos");
            }

            if (inEar)
            {
                sb.Append($" In ear");
            }
            else
            {
                sb.Append($" Vincha");
            }
            
            sb.Append($" {base.MostrarInfo()}");
            sb.Append($" {color}");
            sb.AppendLine($" ${Precio}");

            return sb.ToString();
        }

        public override string MostrarDescripcion()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(MostrarInfo());

            if (cancelacionDeSonido)
            {
                sb.AppendLine($"Cancelacion de sonido: Si");
            }
            else
            {
                sb.AppendLine("Cancelacion de sonido: No");
            }

            if (conMicrofono)
            {
                sb.AppendLine($"Con microfono: Si");
            }
            else
            {
                sb.AppendLine("Con microfono: No");
            }

            if (esInalambrico)
            {
                sb.AppendLine($"Horas de bateria: {horasBateria}");
                sb.AppendLine($"Tiempo de carga: {tiempoDeCarga}");
            }

            sb.AppendLine($"dB: {dB}");
            sb.AppendLine($"hZ: {hZ}");

            return sb.ToString();
        }
    }
}
