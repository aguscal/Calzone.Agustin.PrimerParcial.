using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaUIFrm
{
    public partial class FrmCrearProductoAuricular : Form,IFormsCrearProductos
    {
        Negocio negocioStock;
        AuricularDAO auricularDAO;
        public FrmCrearProductoAuricular()
        {
            InitializeComponent();
            try
            {
                negocioStock = Negocio.Instancia;
            }
            catch(Exception)
            {
                MostrarError("Error grave de conexion");
            }
        }

        public void checkBInalambrico_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBInalambrico.Checked)
            {
                this.panelTiempoCarga.Visible = true;
                this.panelBateria.Visible = true;
            }
            else
            {
                this.panelTiempoCarga.Visible = false;
                this.panelBateria.Visible = false;
            }
        }

        
        public void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string marca;
                string modelo;
                string color;
                float precio;
                int db;
                int hz;
                int tiempoCarga;
                int duracionBateria;
                bool esGamer = false;
                bool conMicrofono = false;
                bool inEar = false;
                bool inalabrico = false;
                bool cancelacion = false;
                Auricular auricularNuevo;
                bool flagError = false;

                if (this.cmbMarcas.SelectedItem == null) { throw new ExcepcionDatosIncompletos("No se cargó una marca"); } 
                marca = this.cmbMarcas.SelectedItem.ToString();

                if (this.cmbModelos.SelectedItem == null) { throw new ExcepcionDatosIncompletos("No se cargó un modelo"); }
                modelo = this.cmbModelos.SelectedItem.ToString();

                if (this.cmbColores.SelectedItem == null) { throw new ExcepcionDatosIncompletos("No se cargó un color"); }                    
                color = this.cmbColores.SelectedItem.ToString();

                db = (int)this.nUDDb.Value;
                hz = (int)this.nUDHz.Value;
                precio = (float)this.nUDPrecio.Value;
                tiempoCarga = (int)this.nUDTiempoCarga.Value;
                duracionBateria = (int)this.nUDHorasBateria.Value;

                if (this.checkBInalambrico.Checked) { inalabrico = true; }                   

                if (inalabrico)
                {
                    if (duracionBateria == 0 || tiempoCarga == 0) { throw new ExcepcionDatosIncompletos("No se cargó la duración de batería o el tiempo de carga"); }                       
                }

                if (precio <= 0) { throw new ExcepcionDatosIncompletos("No se cargó el precio"); }                    

                if (db <= 0 || hz <= 0) { throw new ExcepcionDatosIncompletos("No se cargó dB o Hz"); }                   

                if (this.checkBCancelacion.Checked) { cancelacion = true; }

                if (this.checkBConMic.Checked) { conMicrofono = true; }

                if (this.checkBEsGamer.Checked) { esGamer = true; }

                if (this.checkBInEar.Checked) { inEar = true; }

                if (inalabrico)
                {
                    auricularNuevo = new Auricular(modelo, marca, color, precio, cancelacion, db, hz, conMicrofono, inEar, esGamer, inalabrico, duracionBateria, tiempoCarga);
                }
                else
                {
                    auricularNuevo = new Auricular(modelo, marca, color, precio, cancelacion, db, hz, conMicrofono, inEar, esGamer);
                }

                try
                {
                    Auricular auricularEnLista = (Auricular)negocioStock.ObtenerBuscarProductoCoincidente(auricularNuevo);

                    if (auricularEnLista is not null)
                    {
                        float precioEnLista = negocioStock.ObtenerPrecioProductoEnLista(auricularEnLista);

                        if (precioEnLista > 0 && precioEnLista != precio)
                        {
                            DialogResult opcion = MessageBox.Show($"El precio ingresado no coincide con el precio en lista, presione Si para cambiar el precio de stock" +
                                $" o presione No para mantenerlo al precio de lista ${precioEnLista}, Cancel para cancelar", "Confirmacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                            if (opcion == DialogResult.Cancel) { return; }
                            else if (opcion == DialogResult.No)
                            {
                                if (inalabrico)
                                {
                                    auricularNuevo = new Auricular(modelo, marca, color, precioEnLista, cancelacion, db, hz, conMicrofono, inEar, esGamer, inalabrico, duracionBateria, tiempoCarga);
                                }
                                else
                                {
                                    auricularNuevo = new Auricular(modelo, marca, color, precioEnLista, cancelacion, db, hz, conMicrofono, inEar, esGamer);
                                }
                            }
                            else
                            {
                                negocioStock.ModificarPrecioProducto(auricularEnLista, precio);
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
                        if (negocioStock + auricularNuevo)
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
                }else
                {
                    if (negocioStock is null || flagError == true)
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

        private void FrmCrearProductoAuricular_Load(object sender, EventArgs e)
        {
            this.panelTiempoCarga.Visible = false;
            this.panelBateria.Visible = false;

            foreach (var marcas in Enum.GetValues(typeof(EMarcasAuricular)))
            {
                this.cmbMarcas.Items.Add(marcas);
            }

            foreach (var color in Enum.GetValues(typeof(EColores)))
            {
                this.cmbColores.Items.Add(color);
            }
        }

        public void cmbMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbMarcas.SelectedItem != null)
            {
                if (this.cmbMarcas.SelectedItem.ToString() == "Samsung")
                {
                    this.cmbModelos.Items.Clear();
                    this.cmbModelos.Refresh();
                    foreach (var modelo in Enum.GetValues(typeof(EModelosAurSamsung)))
                    {
                        this.cmbModelos.Items.Add(modelo);
                    }

                }
                else if (this.cmbMarcas.SelectedItem.ToString() == "Jbl")
                {
                    this.cmbModelos.Items.Clear();
                    this.cmbModelos.Refresh();
                    foreach (var modelo in Enum.GetValues(typeof(EModelosAurJbl)))
                    {
                        this.cmbModelos.Items.Add(modelo);
                    }

                }
                else if (this.cmbMarcas.SelectedItem.ToString() == "Sony")
                {
                    this.cmbModelos.Items.Clear();
                    this.cmbModelos.Refresh();
                    foreach (var modelo in Enum.GetValues(typeof(EModelosAurSony)))
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

        public void MostrarError(string mensaje)
        {
            MessageBox.Show($"{mensaje}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
