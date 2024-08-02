using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaUIFrm
{
    public partial class FrmCrearProductoSmartPhone : Form,IFormsCrearProductos
    {
        Negocio negocioStock;
        SmartPhoneDAO smartPhoneDAO;
        public FrmCrearProductoSmartPhone()
        {
            InitializeComponent();
            try
            {
                negocioStock = Negocio.Instancia;
            }
            catch (Exception)
            {
                MostrarError("Error grave de conexion");
            }
        }

        public void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FrmCrearProductoSmartPhone_Load(object sender, EventArgs e)
        {
            //cargar opciones de los combobox
            foreach (var marcas in Enum.GetValues(typeof(EMarcasSmartPhone)))
            {
                this.cmbMarcas.Items.Add(marcas);
            }

            foreach (var color in Enum.GetValues(typeof(EColores)))
            {
                this.cmbColores.Items.Add(color);
            }

            this.cmbCapBateria.Items.Add(3500);
            this.cmbCapBateria.Items.Add(4000);
            this.cmbCapBateria.Items.Add(4500);
            this.cmbCapBateria.Items.Add(5000);

            this.cmbAlmacenamiento.Items.Add(64);
            this.cmbAlmacenamiento.Items.Add(120);
            this.cmbAlmacenamiento.Items.Add(240);

            this.cmbMemRam.Items.Add(4);
            this.cmbMemRam.Items.Add(6);
            this.cmbMemRam.Items.Add(8);

            this.cmbPixelesCamara.Items.Add(15);
            this.cmbPixelesCamara.Items.Add(30);
            this.cmbPixelesCamara.Items.Add(50);

            this.cmbPulgadas.Items.Add(5);
            this.cmbPulgadas.Items.Add(6);
            this.cmbPulgadas.Items.Add(7);

        }

        public void cmbMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbMarcas.SelectedItem != null)
            {
                if (this.cmbMarcas.SelectedItem.ToString() == "Samsung")
                {
                    this.cmbModelos.Items.Clear();
                    this.cmbModelos.Refresh();
                    foreach (var modelo in Enum.GetValues(typeof(EModeloSmartPhoneSamsung)))
                    {
                        this.cmbModelos.Items.Add(modelo);
                    }

                }
                else if (this.cmbMarcas.SelectedItem.ToString() == "Motorola")
                {
                    this.cmbModelos.Items.Clear();
                    this.cmbModelos.Refresh();
                    foreach (var modelo in Enum.GetValues(typeof(EModeloSmartPhoneMotorola)))
                    {
                        this.cmbModelos.Items.Add(modelo);
                    }

                }
                else if (this.cmbMarcas.SelectedItem.ToString() == "Xiaomi")
                {
                    this.cmbModelos.Items.Clear();
                    this.cmbModelos.Refresh();
                    foreach (var modelo in Enum.GetValues(typeof(EModeloSmartPhoneXiaomi)))
                    {
                        this.cmbModelos.Items.Add(modelo);
                    }
                }
                else if (this.cmbMarcas.SelectedItem.ToString() == "Apple")
                {
                    this.cmbModelos.Items.Clear();
                    this.cmbModelos.Refresh();
                    foreach (var modelo in Enum.GetValues(typeof(EModeloSmartPhoneApple)))
                    {
                        this.cmbModelos.Items.Add(modelo);
                    }
                }
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
                int almacenamiento;
                int memoriaRam;
                float pulgadasPantalla;
                int pixelesCamara;
                int capacidadBateria;
                bool dualSim = false;
                bool incluyeCargador = false;
                bool flagError = false;


                if (this.cmbMarcas.SelectedItem == null) { throw new ExcepcionDatosIncompletos("No se cargó una marca"); }
                marca = this.cmbMarcas.SelectedItem.ToString();

                if (this.cmbModelos.SelectedItem == null) { throw new ExcepcionDatosIncompletos("No se cargó un modelo"); }
                modelo = this.cmbModelos.SelectedItem.ToString();

                if (this.cmbColores.SelectedItem == null) { throw new ExcepcionDatosIncompletos("No se cargó un color"); }
                color = this.cmbColores.SelectedItem.ToString();

                precio = (float)this.nUDPrecio.Value;
                if (precio <= 0) { throw new ExcepcionDatosIncompletos("No se cargó el precio"); }


                if (this.cmbMemRam.SelectedItem == null) { throw new ExcepcionDatosIncompletos("No se cargo la cantidad de memoria ram"); }
                memoriaRam = (int)this.cmbMemRam.SelectedItem;

                if (this.cmbAlmacenamiento.SelectedItem == null) { throw new ExcepcionDatosIncompletos("No se cargo la cantidad de almacenamiento"); }
                almacenamiento = (int)cmbAlmacenamiento.SelectedItem;

                if (this.cmbPulgadas.SelectedItem == null) { throw new ExcepcionDatosIncompletos("No se cargo la cantidad de pulgadas"); }
                pulgadasPantalla = (int)cmbPulgadas.SelectedItem;

                if (this.cmbPixelesCamara.SelectedItem == null) { throw new ExcepcionDatosIncompletos("No se cargo la cantidad de pixeles de la camara"); }
                pixelesCamara = (int)cmbPixelesCamara.SelectedItem;

                if (this.cmbCapBateria.SelectedItem == null) { throw new ExcepcionDatosIncompletos("No se cargo la cantidad de capacidad de la bateria"); }
                capacidadBateria = (int)cmbCapBateria.SelectedItem;

                if (this.checkBDualSim.Checked) { dualSim = true; }
                if (this.checkBIncluyeCargador.Checked) { incluyeCargador = true; }

                SmartPhone smartPhoneNuevo = new SmartPhone(modelo, marca, color, precio, almacenamiento, pulgadasPantalla, pixelesCamara, capacidadBateria, memoriaRam, dualSim, incluyeCargador);

                try
                {
                    SmartPhone smartPhoneEnLista = (SmartPhone)negocioStock.ObtenerBuscarProductoCoincidente(smartPhoneNuevo);

                    if(smartPhoneEnLista is not null)
                    {
                        float precioEnLista = negocioStock.ObtenerPrecioProductoEnLista(smartPhoneEnLista);

                        if (precioEnLista > 0 && precioEnLista != precio)
                        {
                            DialogResult opcion = MessageBox.Show($"El precio ingresado no coincide con el precio en lista, presione Si para cambiar el precio de stock" +
                                $" o presione No para mantenerlo al precio de lista ${precioEnLista}, Cancel para cancelar", "Confirmacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                            if (opcion == DialogResult.Cancel) { return; }
                            else if (opcion == DialogResult.No)
                            {
                                smartPhoneNuevo = new SmartPhone(modelo, marca, color, precioEnLista, almacenamiento, pulgadasPantalla, pixelesCamara, capacidadBateria, memoriaRam, dualSim, incluyeCargador);
                            }
                            else
                            {
                                negocioStock.ModificarPrecioProducto(smartPhoneEnLista, precio);
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
                        if (negocioStock + smartPhoneNuevo)
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

        public void MostrarError(string mensaje)
        {
            MessageBox.Show($"{mensaje}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
