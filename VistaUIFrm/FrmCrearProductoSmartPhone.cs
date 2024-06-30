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
    public partial class FrmCrearProductoSmartPhone : Form
    {
        Negocio negocioStock;
        public FrmCrearProductoSmartPhone()
        {
            negocioStock = Negocio.Instancia;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
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

        private void cmbMarcas_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnAgregar_Click(object sender, EventArgs e)
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


            if (this.cmbMarcas.SelectedItem != null)
            {
                marca = this.cmbMarcas.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("No se cargo una marca");
                return;
            }

            if (this.cmbModelos.SelectedItem != null)
            {
                modelo = this.cmbModelos.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("No se cargo un modelo");
                return;
            }

            if (this.cmbColores.SelectedItem != null)
            {
                color = this.cmbColores.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("No se cargo un color");
                return;
            }

            precio = (float)this.nUDPrecio.Value;
            if(precio <= 0)
            {
                MessageBox.Show("No se cargo el precio");
                return;
            }

            if (this.cmbMemRam.SelectedItem != null)
            {
                memoriaRam = (int)cmbMemRam.SelectedItem;
            }
            else
            {
                MessageBox.Show("No se cargo la cantidad de memoria ram");
                return;
            }

            if (this.cmbAlmacenamiento.SelectedItem != null)
            {
                almacenamiento = (int)cmbAlmacenamiento.SelectedItem;
            }
            else
            {
                MessageBox.Show("No se cargo la cantidad de almacenamiento");
                return;
            }

            if (this.cmbPulgadas.SelectedItem != null)
            {
                pulgadasPantalla = (int)cmbPulgadas.SelectedItem;
            }
            else
            {
                MessageBox.Show("No se cargo la cantidad de pulgadas");
                return;
            }

            if (this.cmbPixelesCamara.SelectedItem != null)
            {
                pixelesCamara = (int)cmbPixelesCamara.SelectedItem;
            }
            else
            {
                MessageBox.Show("No se cargo la cantidad de pixeles de la camara");
                return;
            }

            if (this.cmbCapBateria.SelectedItem != null)
            {
                capacidadBateria = (int)cmbCapBateria.SelectedItem;
            }
            else
            {
                MessageBox.Show("No se cargo la cantidad de capacidad de la bateria");
                return;
            }

            if (this.checkBDualSim.Checked) { dualSim = true; }
            if (this.checkBIncluyeCargador.Checked) { incluyeCargador = true; }

            SmartPhone smartPhoneNuevo = new SmartPhone(modelo,marca,color,precio,almacenamiento,pulgadasPantalla,pixelesCamara,capacidadBateria,memoriaRam,dualSim,incluyeCargador);

            MessageBox.Show(smartPhoneNuevo.ToString());

            if (negocioStock + smartPhoneNuevo)
            {
                MessageBox.Show("El producto se agrego correctamente");
            }
            else
            {
                MessageBox.Show("El producto no se agrego correctamente porque supero el limite de stock");
            }
        }
    }
}
