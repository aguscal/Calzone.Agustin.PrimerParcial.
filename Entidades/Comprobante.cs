using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum MetodosDePago
    {
        Transferencia,
        Tarjeta
    }

    public class Comprobante
    {
        int idComprobante;
        int idComprador;
        string nombreComprador;
        string apellidoComprador;
        string emailComprador;
        string nombreCalle;
        decimal numeroCalle;
        DateTime fechaDeEmision;
        string resumenDeCompra;
        float montoTotal;
        decimal dni;
        string metodoDePago;
        decimal? numeroDeCuotas;
        decimal? numeroTarjeta;
        decimal? numeroSeguridadTarjeta;
        decimal? numeroDeCuentaTransferencia;

        public Comprobante(int idComprador, string nombreComprador, string apellidoComprador, string emailComprador,
            string nombreCalle, decimal numeroCalle, DateTime fechaDeEmision, string resumenDeCompra,
            float montoTotal, decimal dni, string metodoDePago, decimal? numeroDeCuotas = null, decimal? numeroTarjeta = null, decimal? numeroSeguridadTarjeta = null,
            decimal? numeroDeCuentaTransferencia = null)
        {
            this.idComprador = idComprador;
            this.nombreComprador = nombreComprador;
            this.apellidoComprador = apellidoComprador;
            this.emailComprador = emailComprador;
            this.nombreCalle = nombreCalle;
            this.numeroCalle = numeroCalle;
            this.fechaDeEmision = fechaDeEmision;
            this.resumenDeCompra = resumenDeCompra;
            this.montoTotal = montoTotal;
            this.dni = dni;
            this.metodoDePago = metodoDePago;
            this.numeroDeCuotas = numeroDeCuotas;
            this.numeroTarjeta = numeroTarjeta;
            this.numeroSeguridadTarjeta = numeroSeguridadTarjeta;
            this.numeroDeCuentaTransferencia = numeroDeCuentaTransferencia;
        }

        public string NombreComprador { get => nombreComprador; set => nombreComprador = value; }
        public string ApellidoComprador { get => apellidoComprador; set => apellidoComprador = value; }
        public string EmailComprador { get => emailComprador; set => emailComprador = value; }
        public string NombreCalle { get => nombreCalle; set => nombreCalle = value; }
        public decimal NumeroCalle { get => numeroCalle; set => numeroCalle = value; }
        public DateTime FechaDeEmision { get => fechaDeEmision; set => fechaDeEmision = value; }
        public string ResumenDeCompra { get => resumenDeCompra; set => resumenDeCompra = value; }
        public float MontoTotal { get => montoTotal; set => montoTotal = value; }
        public decimal Dni { get => dni; set => dni = value; }
        public string MetodoDePago { get => metodoDePago; set => metodoDePago = value; }
        public decimal? NumeroDeCuotas { get => numeroDeCuotas; set => numeroDeCuotas = value; }
        public decimal? NumeroTarjeta { get => numeroTarjeta; set => numeroTarjeta = value; }
        public decimal? NumeroSeguridadTarjeta { get => numeroSeguridadTarjeta; set => numeroSeguridadTarjeta = value; }
        public decimal? NumeroDeCuentaTransferencia { get => numeroDeCuentaTransferencia; set => numeroDeCuentaTransferencia = value; }
        public int IdComprobante { get => idComprobante; set => idComprobante = value; }
        public int IdComprador { get => idComprador; set => idComprador = value; }
    }
}
