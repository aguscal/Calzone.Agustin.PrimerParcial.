using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Serialization;
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

        public Auricular()
        {

        }
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
        public bool CancelacionDeSonido { get { return cancelacionDeSonido; } set { cancelacionDeSonido = value; } }
        public bool EsInalambrico { get { return esInalambrico; } set { esInalambrico = value; } }
        public bool EsGamer { get { return esGamer; } set { esGamer = value; } }
        public bool ConMicrofono { get { return conMicrofono; } set { conMicrofono = value; } }
        public bool InEar { get { return inEar; } set { inEar = value; } }
        public int Db { get { return dB; } set { dB = value; } }
        public int Hz { get { return hZ; } set { hZ = value; } }
        public int HorasBateria { get { return horasBateria; } set { horasBateria = value; } }
        public int TiempoDeCarga { get { return tiempoDeCarga; } set { tiempoDeCarga = value; } }

        public override string ToString()
        {
            return MostrarInfo();
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

        /// <summary>
        /// Este método verifica si dos productos son iguales.
        /// Primero compara por id mediante la sobrecarga del equals.
        /// Luego de no ser asi verifica si los atributos clave de cada objeto son iguales entre si
        /// </summary>
        /// <param name="a1">Primer Auricular.</param>
        /// <param name="a2">Segundo Auricular.</param>
        /// <returns>Retorna bool si son iguales,false de lo contrario.</returns>
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
            sb.Append(this.GetType().Name);

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
            
            sb.Append($"{base.MostrarInfo()}");
            sb.Append($" {color}");
            sb.Append($" \n${Precio}");

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
