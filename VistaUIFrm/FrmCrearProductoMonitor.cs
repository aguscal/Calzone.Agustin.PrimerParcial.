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
    public partial class FrmCrearProductoMonitor : Form,IFormsCrearProductos
    {
        Negocio negocioStock;
        MonitorDAO monitorDAO;
        public FrmCrearProductoMonitor()
        {
            InitializeComponent();
            try
            {
                negocioStock = Negocio.Instancia;
            }catch(Exception)
            {
                MostrarError("Error grave de conexion");
            }
        }

        private void FrmCrearProductoMonitor_Load(object sender, EventArgs e)
        {
            foreach (var marcas in Enum.GetValues(typeof(EMarcasMonitor)))
            {
                this.cmbMarcas.Items.Add(marcas);
            }

            foreach (var color in Enum.GetValues(typeof(EColores)))
            {
                this.cmbColores.Items.Add(color);
            }

            foreach (var panel in Enum.GetValues(typeof(EPanelMonitor)))
            {
                this.comboBTipoPanel.Items.Add(panel);
            }

            this.comboBTazaRefresco.Items.Add(60);
            this.comboBTazaRefresco.Items.Add(120);
            this.comboBTazaRefresco.Items.Add(144);
            this.comboBTazaRefresco.Items.Add(200);
            this.comboBTazaRefresco.Items.Add(240);

            this.cmbPulgadas.Items.Add(20);
            this.cmbPulgadas.Items.Add(22);
            this.cmbPulgadas.Items.Add(24);

            foreach (var puerto in Enum.GetValues(typeof(ETipoPuerto)))
            {
                this.comboBTipoPuerto.Items.Add(puerto);
            }

            foreach (var resolucion in Enum.GetValues(typeof(EResolucionesMonitor)))
            {
                this.comboBResolucion.Items.Add(resolucion);
            }
        }

        public void cmbMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbMarcas.SelectedItem != null)
            {
                if (this.cmbMarcas.SelectedItem.ToString() == "Asus")
                {
                    this.cmbModelos.Items.Clear();
                    this.cmbModelos.Refresh();
                    foreach (var modelo in Enum.GetValues(typeof(EModelosMonitorAsus)))
                    {
                        this.cmbModelos.Items.Add(modelo);
                    }

                }
                else if (this.cmbMarcas.SelectedItem.ToString() == "Lg")
                {
                    this.cmbModelos.Items.Clear();
                    this.cmbModelos.Refresh();
                    foreach (var modelo in Enum.GetValues(typeof(EModelosMonitorLg)))
                    {
                        this.cmbModelos.Items.Add(modelo);
                    }

                }
                else if (this.cmbMarcas.SelectedItem.ToString() == "Philips")
                {
                    this.cmbModelos.Items.Clear();
                    this.cmbModelos.Refresh();
                    foreach (var modelo in Enum.GetValues(typeof(EModelosMonitorPhilips)))
                    {
                        this.cmbModelos.Items.Add(modelo);
                    }
                }
                else if (this.cmbMarcas.SelectedItem.ToString() == "Samsung")
                {
                    this.cmbModelos.Items.Clear();
                    this.cmbModelos.Refresh();
                    foreach (var modelo in Enum.GetValues(typeof(EModelosMonitorSamsung)))
                    {
                        this.cmbModelos.Items.Add(modelo);
                    }
                }
            }


        }

        public void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string marca;
                string modelo;
                string color;
                float precio;
                int pulgadas;
                bool esCurvo = false;
                string tipoPanel;
                int tazaRefresco;
                string tipoPuerto;
                string resolucion;
                bool esGamer = false;
                bool tieneAltavoz = false;
                bool flagError = false;

                if (this.cmbMarcas.SelectedItem == null) { throw new ExcepcionDatosIncompletos("No se cargó una marca"); }
                marca = this.cmbMarcas.SelectedItem.ToString();

                if (this.cmbModelos.SelectedItem == null) { throw new ExcepcionDatosIncompletos("No se cargó un modelo"); }
                modelo = this.cmbModelos.SelectedItem.ToString();

                if (this.cmbColores.SelectedItem == null) { throw new ExcepcionDatosIncompletos("No se cargó un color"); }
                color = this.cmbColores.SelectedItem.ToString();

                precio = (float)this.nUDPrecio.Value;
                if (precio <= 0) { throw new ExcepcionDatosIncompletos("No se cargó el precio"); }

                if (this.cmbPulgadas.SelectedItem == null) { throw new ExcepcionDatosIncompletos("No se cargo las pulgadas"); }
                pulgadas = (int)this.cmbPulgadas.SelectedItem;

                if (this.checkBEsCurvo.Checked) { esCurvo = true; }
                if (this.checkBEsGamer.Checked) { esGamer = true; }
                if (this.checkBTieneAltavoz.Checked) { tieneAltavoz = true; }

                if (this.comboBTipoPanel.SelectedItem == null) { throw new ExcepcionDatosIncompletos("No se cargo el tipo de panel"); }
                tipoPanel = this.comboBTipoPanel.SelectedItem.ToString();

                if (this.comboBTazaRefresco.SelectedItem == null) { throw new ExcepcionDatosIncompletos("No se cargo el tipo de taza de refresco"); }
                tazaRefresco = (int)this.comboBTazaRefresco.SelectedItem;

                if (this.comboBTipoPuerto.SelectedItem == null) { throw new ExcepcionDatosIncompletos("No se cargo el tipo de puerto"); }
                tipoPuerto = this.comboBTipoPuerto.SelectedItem.ToString();

                if (this.comboBResolucion.SelectedItem == null) { throw new ExcepcionDatosIncompletos("No se cargo el tipo de resolucion"); }
                resolucion = this.comboBResolucion.SelectedItem.ToString();

                Entidades.Monitor monitorNuevo = new Entidades.Monitor(marca, modelo, color, precio, pulgadas, esCurvo, tipoPanel, tazaRefresco, tipoPuerto, resolucion, esGamer, tieneAltavoz);

                try
                {
                    Entidades.Monitor monitorEnLista = (Entidades.Monitor)negocioStock.ObtenerBuscarProductoCoincidente(monitorNuevo);

                    if (monitorEnLista is not null)
                    {
                        float precioEnLista = negocioStock.ObtenerPrecioProductoEnLista(monitorEnLista);

                        if (precioEnLista > 0 && precioEnLista != precio)
                        {
                            DialogResult opcion = MessageBox.Show($"El precio ingresado no coincide con el precio en lista, presione Si para cambiar el precio de stock" +
                                $" o presione No para mantenerlo al precio de lista ${precioEnLista}, Cancel para cancelar", "Confirmacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                            if (opcion == DialogResult.Cancel) { return; }
                            else if (opcion == DialogResult.No)
                            {
                                monitorNuevo = new Entidades.Monitor(marca, modelo, color, precioEnLista, pulgadas, esCurvo, tipoPanel, tazaRefresco, tipoPuerto, resolucion, esGamer, tieneAltavoz);
                            }
                            else
                            {
                                negocioStock.ModificarPrecioProducto(monitorEnLista, precio);
                                MessageBox.Show("El precio de stock del producto se ha actualizado!");
                            }
                        }
                    }
                }
                catch (ExcepcionConeccion ex)
                {
                    flagError = true;
                    MostrarError($"Error al obtener datos de los productos: {ex.Message}");
                }
                catch (Exception)
                {
                    flagError = true;
                    MostrarError("Error al obtener datos de los productos");
                }


                int cantidadACrear = (int)this.nUDCantidadCrear.Value;
                int cantidadProductosCreados = 0;

                try
                {
                    for (int i = 0; i < cantidadACrear; i++)
                    {
                        if (negocioStock + monitorNuevo)
                        {
                            cantidadProductosCreados++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                catch (ExcepcionConeccion ex)
                {
                    flagError = true;
                    MostrarError($"Error al agregar los productos: {ex.Message}");
                }
                catch (Exception)
                {
                    flagError = true;
                    MostrarError("Error al agregar los productos");
                }
                

                if (cantidadProductosCreados == cantidadACrear)
                {
                    MessageBox.Show($"Se agregaron correctamente los {cantidadProductosCreados} productos");
                }
                else
                {
                    if(negocioStock is null || flagError == true)
                    {
                        MessageBox.Show($"Se agregaron {cantidadProductosCreados} productos , {cantidadACrear - cantidadProductosCreados} productos no se agregaron correctamente porque hay un problema de conexion");
                    }
                    else
                    {
                        MessageBox.Show($"Se agregaron {cantidadProductosCreados} productos , {cantidadACrear - cantidadProductosCreados} productos no se agregaron correctamente porque superó el límite de stock");
                    }
                    
                }

            }
            catch (ExcepcionDatosIncompletos ex)
            {
                MessageBox.Show(ex.Message, "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void MostrarError(string mensaje)
        {
            MessageBox.Show($"{mensaje}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
    }
}
