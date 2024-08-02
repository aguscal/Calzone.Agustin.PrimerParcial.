using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaUIFrm
{
    public partial class FrmVisualizadorComprobante : Form
    {
        ComprobanteDAO comprobanteDAO = new ComprobanteDAO();
        int? id;
        public FrmVisualizadorComprobante()
        {
            InitializeComponent();
        }

        public FrmVisualizadorComprobante(int id)
        {
            this.id = id;
            InitializeComponent();
        }
        private void FrmVisualizadorComprobante_Load(object sender, EventArgs e)
        {
            try
            {
                if (id.HasValue)
                {
                    List<Comprobante> listaComprobantesEncontrados = comprobanteDAO.ObtenerListaComprobantes(id.Value);
                    this.rTBComprobantesEncontrados.Text = FormatearComprobantes(listaComprobantesEncontrados);
                }
                else
                {
                    List<Comprobante> listaComprobantesEncontrados = comprobanteDAO.ObtenerListaComprobantes();
                    this.rTBComprobantesEncontrados.Text = FormatearComprobantes(listaComprobantesEncontrados);
                }                
            }
            catch (ExcepcionConeccion ex)
            {
                MessageBox.Show($"Error.No se pudieron cargar los comprobantes: {ex.Message}");
            }
            catch (Exception)
            {
                MessageBox.Show("Error.No se pudieron cargar los comprobantes");
            }
        }

        private string FormatearComprobantes(List<Comprobante> comprobantes)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var comprobante in comprobantes)
            {
                sb.AppendLine($"ID Comprador: {comprobante.IdComprador}");
                sb.AppendLine($"Nombre: {comprobante.NombreComprador} {comprobante.ApellidoComprador}");
                sb.AppendLine($"Email: {comprobante.EmailComprador}");
                sb.AppendLine($"Dirección: {comprobante.NombreCalle} {comprobante.NumeroCalle}");
                sb.AppendLine($"Fecha: {comprobante.FechaDeEmision.ToShortDateString()}");
                sb.AppendLine($"Resumen de compra: {comprobante.ResumenDeCompra}");
                sb.AppendLine($"Monto total: ${comprobante.MontoTotal}");
                sb.AppendLine($"DNI: {comprobante.Dni}");
                sb.AppendLine($"Método de pago: {comprobante.MetodoDePago}");

                if (comprobante.NumeroDeCuotas.HasValue)
                {
                    sb.AppendLine($"Número de cuotas: {comprobante.NumeroDeCuotas.Value}");
                }
                if (comprobante.NumeroTarjeta.HasValue)
                {
                    sb.AppendLine($"Número de tarjeta: {comprobante.NumeroTarjeta.Value}");
                }
                if (comprobante.NumeroSeguridadTarjeta.HasValue)
                {
                    sb.AppendLine($"Número de seguridad de tarjeta: {comprobante.NumeroSeguridadTarjeta.Value}");
                }
                if (comprobante.NumeroDeCuentaTransferencia.HasValue)
                {
                    sb.AppendLine($"Número de cuenta de transferencia: {comprobante.NumeroDeCuentaTransferencia.Value}");
                }

                sb.AppendLine(new string('-', 40));
            }

            return sb.ToString();
        }

    }
}
