using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaUIFrm
{
    public partial class FormDatosComprobante : Form
    {
        Dictionary<Producto, int> dictProductosSeleccionados;
        Comprador comprador;
        float montoTotal = 0;
        Negocio negocioStock = Negocio.Instancia;
        public event Action<Comprobante,bool> OnVentaInformadaRegistrada;
        ComprobanteDAO comprobanteDAO= new ComprobanteDAO();
        public FormDatosComprobante(Dictionary<Producto, int> dictProductosSeleccionados, Comprador comprador)
        {
            this.dictProductosSeleccionados = dictProductosSeleccionados;
            this.comprador = comprador;
            InitializeComponent();
        }

        private void FormDatosComprobante_Load(object sender, EventArgs e)
        {
            OnVentaInformadaRegistrada += InformarYRegistrarVenta;

            StringBuilder sb = new StringBuilder();

            this.lblCodigoTarjeta.Visible = false;
            this.lblNumCuotas.Visible = false;
            this.lblNumeroCuentaTransferencia.Visible = false;
            this.lblNumTarjeta.Visible = false;
            this.nupdCodigoTarjeta.Visible = false;
            this.nupdNumTarjeta.Visible = false;
            this.nupdCodigoTarjeta.Visible = false;
            this.nupdNumeroCBU.Visible = false;
            this.cmbNumCuotas.Visible = false;

            foreach (var item in Enum.GetValues(typeof(MetodosDePago)))
            {
                this.cmbMetodoPago.Items.Add(item);
            }

            this.cmbNumCuotas.Items.Add(3);
            this.cmbNumCuotas.Items.Add(6);
            this.cmbNumCuotas.Items.Add(9);

            foreach (var item in dictProductosSeleccionados)
            {
                sb.AppendLine($"{item.Key.MostrarInfo()}---{item.Value}");
                for (int i = 0; i < item.Value; i++)
                {
                    montoTotal += item.Key.Precio;
                }
            }

            this.rtbResumenCompra.Text = sb.ToString();
            this.txbMontoTotal.Text = $"${montoTotal}";
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {                                    
            try
            {
                if (negocioStock is not null)
                {
                    //validar el ingreso de datos
                    Comprobante comprobante;
                    bool flagNoSePudoVender;

                    comprobante = ValidarIngresoComprobanteParcial();

                    if(comprobante is not null)
                    {
                        //Vender y Generar Comrpobante final , ya el los datos los ingreso bien , ahora yo tengo que
                        //validar que yo tenga lo que quiere comprar
                        Comprobante comprobanteFinal = VenderYGenerarComprobanteFinal(comprobante, out flagNoSePudoVender);

                        if(comprobanteFinal is not null)
                        {

                            InformarYRegistrarVenta(comprobanteFinal,flagNoSePudoVender);

                            this.DialogResult = DialogResult.Yes;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show($"Ocurrio un error inesperado.No se pudieron vender ninguno de los productos ya que no estan disponibles de momento.");
                            this.DialogResult = DialogResult.Cancel;
                            this.Close();
                        }
                    }


                    /*
                        ACA YA despues de haber realizado todas estas verificaciones , lo que tengo que hacer es mediante las condiciones
                        invocar al evento y pasarle los parametros que necesita y lo qeu va a hacer es mostrarle el resumen de lo que
                        compro al usuario y ademas iniciar el hilo que lo hace es guardar el comprobante en la base de datos
                        Despues el como el trabajador va a ver todos los comprobantes es trayendo de la base la tabla, y formateandola de alguna
                        manera 
                        y para mostrarle solo las suyas al usuario es haciendo una consulta  y trayendo solo las que tienen su id comprador
                        pero usaria el mismo form para mostrarle las cosas
                        */

                }
            }
            catch (ExcepcionConeccion ex)
            {
                MostrarError($"No se pudo vender los productos: {ex.Message}");
            }
            catch (Exception)
            {
                MostrarError("No se pudo vender los productos");
            }
            
        }

        public void MostrarError(string mensaje)
        {
            MessageBox.Show($"{mensaje}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("Seguro de que quiere cancelar la operacion? ", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcion == DialogResult.Yes) { this.Close(); }
        }

        private void cmbMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbMetodoPago.SelectedItem != null)
            {
                if (this.cmbMetodoPago.SelectedItem.ToString() == "Transferencia")
                {
                    this.lblCodigoTarjeta.Visible = false;
                    this.lblNumCuotas.Visible = false;
                    this.lblNumeroCuentaTransferencia.Visible = true;
                    this.nupdNumeroCBU.Visible = true;
                    this.lblNumTarjeta.Visible = false;
                    this.nupdCodigoTarjeta.Visible = false;
                    this.nupdNumTarjeta.Visible = false;
                    this.nupdCodigoTarjeta.Visible = false;
                    this.cmbNumCuotas.Visible = false;
                    this.txbMontoTotal.Text = $"${montoTotal}";
                }
                else if (this.cmbMetodoPago.SelectedItem.ToString() == "Tarjeta")
                {
                    this.lblCodigoTarjeta.Visible = true;
                    this.lblNumCuotas.Visible = true;
                    this.lblNumeroCuentaTransferencia.Visible = false;
                    this.lblNumTarjeta.Visible = true;
                    this.nupdCodigoTarjeta.Visible = true;
                    this.nupdNumTarjeta.Visible = true;
                    this.nupdCodigoTarjeta.Visible = true;
                    this.cmbNumCuotas.Visible = true;
                    this.nupdNumeroCBU.Visible = false;
                }
            }
        }

        private float CalcularPrecioCuotas(float monto, int cuotas)
        {
            float porcentaje3Cuotas = 1.10F;
            float porcentaje6Cuotas = 1.20F;
            float porcentaje9Cuotas = 1.30F;

            if (cuotas == 3)
            {
                return monto * porcentaje3Cuotas;
            }
            else if (cuotas == 6)
            {
                return monto * porcentaje6Cuotas;
            }
            else if (cuotas == 9)
            {
                return monto * porcentaje9Cuotas;
            }

            return monto;
        }

        private Comprobante ValidarIngresoComprobanteParcial()
        {
            Comprobante comprobante = null;
            DateTime fecha = DateTime.Today;

            try
            {
                decimal dni;
                string direccionCalle;
                decimal numeroCalle;
                string metodoDePago;
                decimal numeroTarjeta = 0;
                decimal codigoTarjeta = 0;
                decimal numeroDeCuotas = 0;
                decimal numeroCbu = 0;


                if (this.nupdDni.Value.ToString().Length != 8) { throw new ExcepcionDatosIncompletos("No se cargó su DNI"); }
                dni = this.nupdDni.Value;

                if (this.txbDireccionCalle.Text.Length < 2) { throw new ExcepcionDatosIncompletos("No se cargó su direccion"); }
                direccionCalle = this.txbDireccionCalle.Text;

                if (this.nupdNumCalle.Value.ToString().Length < 2) { throw new ExcepcionDatosIncompletos("No se cargó su numero de calle"); }
                numeroCalle = this.nupdNumCalle.Value;

                if (this.cmbMetodoPago.SelectedIndex == -1) { throw new ExcepcionDatosIncompletos("No selecciono un metodo de pago"); }
                metodoDePago = cmbMetodoPago.SelectedItem.ToString();

                if (metodoDePago == MetodosDePago.Tarjeta.ToString())
                {
                    if (this.nupdNumTarjeta.Value.ToString().Length != 16) { throw new ExcepcionDatosIncompletos("No ingreso su numero de tarjeta"); }
                    numeroTarjeta = nupdNumTarjeta.Value;

                    if (this.nupdCodigoTarjeta.Value.ToString().Length != 3 && this.nupdCodigoTarjeta.Value.ToString().Length != 4) { throw new ExcepcionDatosIncompletos("No ingreso el codigo de seguridad de su tarjeta"); }
                    codigoTarjeta = nupdCodigoTarjeta.Value;

                    if (this.cmbNumCuotas.SelectedIndex == -1) { throw new ExcepcionDatosIncompletos("No selecciono el numero de cuotas"); }
                    numeroDeCuotas = (decimal)cmbNumCuotas.SelectedItem;
                }
                else
                {
                    if (this.nupdNumeroCBU.Value.ToString().Length != 22) { throw new ExcepcionDatosIncompletos("No ingreso su numero de CBU"); }
                    numeroCbu = nupdNumeroCBU.Value;
                }

                if (metodoDePago == MetodosDePago.Transferencia.ToString())
                {
                    comprobante = new Comprobante(comprador.IdComprador, comprador.Nombre, comprador.Apellido, comprador.Email, direccionCalle,
                        numeroCalle, fecha, this.rtbResumenCompra.Text, montoTotal, dni, metodoDePago, null, null, null, numeroCbu);

                    return comprobante;
                }
                else if (metodoDePago == MetodosDePago.Tarjeta.ToString())
                {
                    comprobante = new Comprobante(comprador.IdComprador, comprador.Nombre, comprador.Apellido, comprador.Email, direccionCalle,
                        numeroCalle, fecha, this.rtbResumenCompra.Text, CalcularPrecioCuotas(montoTotal, (int)cmbNumCuotas.SelectedItem), dni, metodoDePago, numeroDeCuotas, numeroTarjeta, codigoTarjeta, null);

                    return comprobante;
                }

                return comprobante;
            }
            catch (ExcepcionDatosIncompletos ex)
            {
                MessageBox.Show(ex.Message, "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return comprobante;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return comprobante;
            }
        }

        public Comprobante VenderYGenerarComprobanteFinal(Comprobante comprobanteParcial,out bool noSePudoVender)
        {
            try
            {
                if (negocioStock is not null)
                {
                    //validar el ingreso de datos
                    Comprobante comprobante;

                    bool huboVenta = false;
                    bool flagNoSePudoVender = false;

                    StringBuilder sbResumenFinal = new StringBuilder();
                    float montoFinal = 0;
                    //este for5m recibe un diccionario y esta bien , porque , el form opciones carrito es sobre un solo keyvalue
                    //pero cuando haga lo del boton comprar todo va a ser sobre todo el diccionario del comprador
                    foreach (var producto in dictProductosSeleccionados)
                    {
                        int cantidadVendidaProducto = 0;

                        for (int i = 0; i < producto.Value; i++)
                        {
                            bool retornoSePudoVender = negocioStock.VenderProducto(producto.Key);

                            if (retornoSePudoVender == true)
                            {
                                //este if podria ir en un hilo
                                if (comprador.DictCarrito.ContainsKey(producto.Key) && comprador.DictCarrito[producto.Key] > 0)
                                {
                                    (comprador).DisminuirQuitarProductoDelCarrito(producto.Key);
                                }

                                huboVenta = true;
                                cantidadVendidaProducto += 1;
                                montoFinal += producto.Key.Precio;
                            }
                            else
                            {
                                flagNoSePudoVender = true;
                            }
                        }

                        if (cantidadVendidaProducto > 0)
                        {
                            sbResumenFinal.AppendLine($"{producto.Key.MostrarInfo()}---{cantidadVendidaProducto}");
                        }
                    }


                    if (huboVenta == true && flagNoSePudoVender == false)
                    {
                        noSePudoVender = flagNoSePudoVender;
                        return comprobanteParcial;
                    }
                    else if (huboVenta == true && flagNoSePudoVender == true)
                    {
                        //los productos qeu si se vendieron sopn los que van a tener que reemplazar a los del comprobante ya que estaria mal calculado

                        if (comprobanteParcial.MetodoDePago == MetodosDePago.Transferencia.ToString())
                        {
                            comprobante = new Comprobante(comprador.IdComprador, comprador.Nombre, comprador.Apellido, comprador.Email, comprobanteParcial.NombreCalle,
                                comprobanteParcial.NumeroCalle, comprobanteParcial.FechaDeEmision, sbResumenFinal.ToString(), montoFinal, comprobanteParcial.Dni, comprobanteParcial.MetodoDePago, null, null, null, comprobanteParcial.NumeroDeCuentaTransferencia);
                            
                            noSePudoVender = flagNoSePudoVender;
                            return comprobante;
                        }
                        else if (comprobanteParcial.MetodoDePago == MetodosDePago.Tarjeta.ToString())
                        {
                            comprobante = new Comprobante(comprador.IdComprador, comprador.Nombre, comprador.Apellido, comprador.Email, comprobanteParcial.NombreCalle,
                                comprobanteParcial.NumeroCalle, comprobanteParcial.FechaDeEmision, sbResumenFinal.ToString(), CalcularPrecioCuotas(montoFinal, (int)cmbNumCuotas.SelectedItem), comprobanteParcial.Dni, comprobanteParcial.MetodoDePago, comprobanteParcial.NumeroDeCuotas,comprobanteParcial.NumeroTarjeta,comprobanteParcial.NumeroSeguridadTarjeta, null);

                            noSePudoVender = flagNoSePudoVender;
                            return comprobante;
                        }
                    }
                    else if (huboVenta == false)
                    {
                        noSePudoVender = flagNoSePudoVender;
                        return null;
                    }                    
                }
                
                noSePudoVender = true;
                return null;
            }
            catch (ExcepcionConeccion ex)
            {
                MostrarError($"No se pudo vender los productos: {ex.Message}");
                noSePudoVender = true;
                return null;
            }
            catch (Exception)
            {
                MostrarError("No se pudo vender los productos");
                noSePudoVender = true;
                return null;
            }
        }


        private void InformarYRegistrarVenta(Comprobante comprobante,bool noSePudoVender)
        {
            //comprobanteDAO.Agregar(comprobante);
            Task.Run(() => comprobanteDAO.Agregar(comprobante));

            if (noSePudoVender == false)//esto lo recibe como parametro el manejador del evento que va a hacer lo mismo que
                                            //este if , pero ademas de informar , guardarlo en la base
            {
                MessageBox.Show($"El comprobante se ha guardado, Venta exitosa! \n Los siguientes productos han sido comprados con exito! :\n\n{comprobante.ResumenDeCompra}");
            }
            else
            {
                MessageBox.Show($"Ocurrio un error inesperado.El comprobante se ha guardado, No todos los productos se pudieron vender ya que no estan disponibles de momento.\n Los siguientes productos han sido comprados con exito! : {comprobante.ResumenDeCompra}");
            }            
        }

        private void cmbNumCuotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txbMontoTotal.Text = $"${CalcularPrecioCuotas(montoTotal,(int)cmbNumCuotas.SelectedItem)}";
        }
    }
}
