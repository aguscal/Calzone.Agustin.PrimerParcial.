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
    public partial class FrmCrearProductoAuricular : Form
    {
        Negocio negocioStock;
        public FrmCrearProductoAuricular()
        {
            negocioStock = Negocio.Instancia;
            InitializeComponent();
        }

        private void checkBInalambrico_CheckedChanged(object sender, EventArgs e)
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

        private void btnAgregar_Click(object sender, EventArgs e)
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

            db = (int)this.nUDDb.Value;
            hz = (int)this.nUDHz.Value;
            precio = (float)this.nUDPrecio.Value;
            tiempoCarga = (int)this.nUDTiempoCarga.Value;
            duracionBateria = (int)this.nUDHorasBateria.Value;

            if (this.checkBInalambrico.Checked) { inalabrico = true; }

            if (inalabrico)
            {
                if (duracionBateria == 0 || tiempoCarga == 0)
                {
                    MessageBox.Show("No se cargo la duracion de bateria o el tiempo de carga");
                    return;
                }
            }

            if (precio <= 0)
            {
                MessageBox.Show("No se cargo el precio");
                return;
            }

            if (db <= 0 || hz <= 0)
            {
                MessageBox.Show("No se cargo db o hz");
                return;
            }

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
            MessageBox.Show(auricularNuevo.ToString());

            if (negocioStock + auricularNuevo)
            {
                MessageBox.Show("El producto se agrego correctamente");
            }
            else
            {
                MessageBox.Show("El producto no se agrego correctamente porque supero el limite de stock");
            }
            //negocioStock.ListaProductos.Add(auricularNuevo);

        }

        private void FrmCrearProductoAuricular_Load(object sender, EventArgs e)
        {
            foreach (var marcas in Enum.GetValues(typeof(EMarcasAuricular)))
            {
                this.cmbMarcas.Items.Add(marcas);
            }

            foreach (var color in Enum.GetValues(typeof(EColores)))
            {
                this.cmbColores.Items.Add(color);
            }
        }

        private void cmbMarcas_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
