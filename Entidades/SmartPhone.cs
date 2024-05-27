using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SmartPhone:Producto
    {
        int almacenamiento;
        int memoriaRam;
        float pulgadasPantalla;
        int pixelesCamara;
        int capacidadBateria;
        bool dualSim;//opcional
        bool incluyeCargador;//opcional


        public SmartPhone(string modelo, string marca, string color,float precio,int almacenamiento,float pulgadasPantalla,int pixelesCamara,int bateria,int memoriaRam)
            : base(marca, modelo, color, precio)
        {
            this.almacenamiento = almacenamiento;
            this.pulgadasPantalla = pulgadasPantalla;
            this.pixelesCamara = pixelesCamara;
            this.capacidadBateria = bateria;
            this.memoriaRam = memoriaRam;

            this.dualSim = false;
            this.incluyeCargador = false;
        }

        public SmartPhone(string modelo, string marca, string color, float precio, int almacenamiento, float pulgadasPantalla,
            int pixelesCamara, int bateria, int memoriaRam,bool dualSim)
            : this(marca, modelo, color, precio,almacenamiento,pulgadasPantalla,pixelesCamara,bateria,memoriaRam)
        {
            this.dualSim = dualSim;
        }

        public SmartPhone(string modelo, string marca, string color, float precio, int almacenamiento, float pulgadasPantalla,
            int pixelesCamara, int bateria, int memoriaRam, bool dualSim, bool incluyeCargador)
            : this(marca, modelo, color, precio, almacenamiento, pulgadasPantalla, pixelesCamara, bateria, memoriaRam,dualSim)
        {
            this.incluyeCargador = incluyeCargador;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}";
        }

        public override bool Equals(object? obj)
        {
            if (obj != null && obj is SmartPhone)
            {
                if (((SmartPhone)obj).Id == this.Id)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator ==(SmartPhone s1, SmartPhone s2)
        {
            if (s1.Equals(s2))
            {
                return true;
            }

            if (s1.Marca == s2.Marca && s1.Modelo == s2.Modelo && s1.color == s2.color && s1.almacenamiento == s2.almacenamiento)//tienen la misma caracteristicas de producto
            {
                if (s1.memoriaRam == s2.memoriaRam && s1.pulgadasPantalla == s2.pulgadasPantalla && s1.pixelesCamara == s2.pixelesCamara)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(SmartPhone s1 , SmartPhone s2)
        {
            return !(s1 == s2);
        }

        public override string MostrarInfo()//este metodo podria ir dentro del ovewrride del tostring
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.ToString());
            sb.Append($" {base.MostrarInfo()}");
            sb.Append($" {almacenamiento} Gb");
            sb.Append($" {color}");
            sb.AppendLine($" ${Precio}");

            return sb.ToString();
        }

        public override string MostrarDescripcion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.MostrarInfo());

            sb.AppendLine($"Pantalla : {pulgadasPantalla} Pulgadas");
            sb.AppendLine($"Camara : {pixelesCamara} Pixeles");
            sb.AppendLine($"Bateria : {capacidadBateria} mAh");
            sb.AppendLine($"Mem.Ram : {memoriaRam} Gb");
            
            if (dualSim)
            {
                sb.AppendLine($"Dual sim : Si");
            }
            else
            {
                sb.AppendLine($"Dual sim : No");
            }

            if (incluyeCargador)
            {
                sb.AppendLine($"Incluye Cargador : Si");
            }
            else
            {
                sb.AppendLine($"Incluye Cargador : No");
            }

            return sb.ToString();
        }
    }
}
