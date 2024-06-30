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
    public partial class FrmCrearProductoMonitor : Form
    {
        Negocio negocioStock;
        public FrmCrearProductoMonitor()
        {
            negocioStock = Negocio.Instancia;
            InitializeComponent();
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

        private void cmbMarcas_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
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
            if (precio <= 0)
            {
                MessageBox.Show("No se cargo el precio");
                return;
            }

            if(this.cmbPulgadas.SelectedItem != null)
            {
                pulgadas = (int)this.cmbPulgadas.SelectedItem;
            }
            else
            {
                MessageBox.Show("No se cargo las pulgadas");
                return;
            }

            if (this.checkBEsCurvo.Checked) { esCurvo = true; }
            if (this.checkBEsGamer.Checked) { esGamer = true; }
            if (this.checkBTieneAltavoz.Checked) { tieneAltavoz = true; }

            if (this.comboBTipoPanel.SelectedItem != null)
            {
                tipoPanel = this.comboBTipoPanel.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("No se cargo el tipo de panel");
                return;
            }

            if (this.comboBTazaRefresco.SelectedItem != null)
            {
                tazaRefresco = (int)this.comboBTazaRefresco.SelectedItem;
            }
            else
            {
                MessageBox.Show("No se cargo el tipo de taza de refresco");
                return;
            }

            if (this.comboBTipoPuerto.SelectedItem != null)
            {
                tipoPuerto = this.comboBTipoPuerto.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("No se cargo el tipo de puerto");
                return;
            }

            if (this.comboBResolucion.SelectedItem != null)
            {
                resolucion = this.comboBResolucion.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("No se cargo el tipo de resolucion");
                return;
            }

            Entidades.Monitor monitorNuevo = new Entidades.Monitor(marca,modelo,color,precio,pulgadas,esCurvo,tipoPanel,tazaRefresco,tipoPuerto,resolucion,esGamer,tieneAltavoz);

            MessageBox.Show(monitorNuevo.ToString());

            if (negocioStock + monitorNuevo)
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
