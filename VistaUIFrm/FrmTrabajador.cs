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
    public partial class FrmTrabajador : Form
    {
        protected Negocio miNegocio = Negocio.Instancia;
        protected Usuario usuarioRegistrado;
        protected bool formClosingActivado = false;

        public FrmTrabajador()
        {
            InitializeComponent();
        }

        public FrmTrabajador(Usuario usuarioRegistrado) : this()
        {
            this.usuarioRegistrado = usuarioRegistrado;
        }

        private void FrmTrabajador_Load(object sender, EventArgs e)
        {
            if (this.cmbFiltrarListaPrecio.Items.Count < 2)
            {
                this.cmbFiltrarListaPrecio.Items.Add("Menor precio");
                this.cmbFiltrarListaPrecio.Items.Add("Mayor precio");
            }

            if(this.cmbCategoriaProductoCrear.Items.Count < 2)
            {
                this.cmbCategoriaProductoCrear.Items.Add("Auricular");
                this.cmbCategoriaProductoCrear.Items.Add("Monitor");
                this.cmbCategoriaProductoCrear.Items.Add("SmartPhone");
            }

            this.dgvProductos.DataSource = miNegocio.ObtenerListaProductosSinRepetir();

            OcultarColumnasDgVYActualizarControles();

            if (usuarioRegistrado is not null)
            {
                this.lblUsuarioRegistrado.Text = $"Hola {usuarioRegistrado.Nombre}!\n {(DateTime.Today).ToString("dd/MM/yyyy")}";
            }
        }

        protected void OcultarColumnasDgVYActualizarControles()
        {
            if (this.dgvProductos.Columns.Contains("Id"))
            {
                this.dgvProductos.Columns["Id"].Visible = false;
            }
            if (this.dgvProductos.Columns.Contains("NombreCompleto"))
            {
                this.dgvProductos.Columns["NombreCompleto"].Visible = false;
            }
            if (this.dgvProductos.Columns.Contains("SiguienteId"))
            {
                this.dgvProductos.Columns["SiguienteId"].Visible = false;
            }
            if (this.dgvProductos.Columns.Contains("Tipo"))
            {
                this.dgvProductos.Columns["Tipo"].Visible = false;
            }

            if (miNegocio.ListaProductos.Count == 0)
            {
                this.lblNoHayProductosEnStock.Visible = true;
            }
            else
            {
                this.lblNoHayProductosEnStock.Visible = false;
            }
        }

        protected void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Producto productoClickeado = (Producto)dgvProductos.Rows[e.RowIndex].DataBoundItem;

                this.Hide();
                FrmVistaProductoTrabajador frmVistaProductoTrabajador = new FrmVistaProductoTrabajador(productoClickeado, usuarioRegistrado, miNegocio);
                frmVistaProductoTrabajador.ShowDialog();
                if (frmVistaProductoTrabajador.DialogResult == DialogResult.Ignore)
                {
                    frmVistaProductoTrabajador.Close();
                    this.Show();
                }
                else
                {
                    formClosingActivado = true;
                    this.Close();
                }
            }
        }

        protected void smartPhonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OcultarYMostrarFrmCategoriaProductosTrabajador("SmartPhone");
        }

        protected void auricularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OcultarYMostrarFrmCategoriaProductosTrabajador("Auricular");
        }

        protected void monitoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OcultarYMostrarFrmCategoriaProductosTrabajador("Monitor");
        }

        private void verLogsUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVisualizadorLog frmVisualizador = new FrmVisualizadorLog();
            frmVisualizador.ShowDialog();
        }

        private void cmbFiltrarListaPrecio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltrarListaPrecio.SelectedItem != null)
            {
                if (cmbFiltrarListaPrecio.SelectedItem.ToString() == "Menor precio")
                {
                    this.dgvProductos.DataSource = miNegocio.OrdenarProductosPorPrecio((List<Producto>)this.dgvProductos.DataSource);

                }
                else if (cmbFiltrarListaPrecio.SelectedItem.ToString() == "Mayor precio")
                {
                    this.dgvProductos.DataSource = miNegocio.OrdenarProductosPorPrecio((List<Producto>)this.dgvProductos.DataSource, false);
                }
            }
        }

        protected void FiltrarListaPrecioDesdeFormDerivado()
        {
            cmbFiltrarListaPrecio_SelectedIndexChanged(this.cmbFiltrarListaPrecio, EventArgs.Empty);
        }

        protected void OcultarYMostrarFrmCategoriaProductosTrabajador(string categoria)
        {
            this.Hide();
            FrmCategoriaProductosTrabajador frmCategoriaProductosTrabajador = new FrmCategoriaProductosTrabajador(usuarioRegistrado, categoria);
            frmCategoriaProductosTrabajador.ShowDialog();

            if (frmCategoriaProductosTrabajador.DialogResult == DialogResult.Ignore)
            {
                frmCategoriaProductosTrabajador.Close();
                this.Show();
            }
            else
            {
                formClosingActivado = true;
                this.Close();
            }
        }


        protected void FrmTrabajador_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.Ignore)
            {
                return;
            }
            else
            {
                if (formClosingActivado)
                {
                    formClosingActivado = false;
                    return;
                }

                DialogResult resultado = MessageBox.Show("¿Esta seguro de que desea cerrar sesion?", "Confirmar cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        protected void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Ignore;
        }

        private void btnCrearNuevoProducto_Click(object sender, EventArgs e)
        {
            if (this.cmbCategoriaProductoCrear.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una categoria si quiere crear un producto");
            }
            else
            {
                if (this.cmbCategoriaProductoCrear.SelectedItem.ToString() == "Auricular")
                {
                    FrmCrearProductoAuricular frmCrearProductoAuricular = new FrmCrearProductoAuricular();
                    DialogResult resultadoFrmCrearProductoAuricular = frmCrearProductoAuricular.ShowDialog();
                    if (resultadoFrmCrearProductoAuricular == DialogResult.Cancel)
                    {
                        OcultarColumnasDgVYActualizarControles();
                    }

                }
                else if (this.cmbCategoriaProductoCrear.SelectedItem.ToString() == "SmartPhone")
                {
                    FrmCrearProductoSmartPhone frmCrearProductoSmartPhone = new FrmCrearProductoSmartPhone();
                    DialogResult resultadoFrmCrearProductoSmartPhone = frmCrearProductoSmartPhone.ShowDialog();
                    if (resultadoFrmCrearProductoSmartPhone == DialogResult.Cancel)
                    {
                        OcultarColumnasDgVYActualizarControles();
                    }
                }
                else if (this.cmbCategoriaProductoCrear.SelectedItem.ToString() == "Monitor")
                {
                    FrmCrearProductoMonitor frmCrearProductoMonitor = new FrmCrearProductoMonitor();
                    DialogResult resultadoFrmCrearProductoMonitor = frmCrearProductoMonitor.ShowDialog();
                    if (resultadoFrmCrearProductoMonitor == DialogResult.Cancel)
                    {
                        OcultarColumnasDgVYActualizarControles();
                    }
                }
            }          
        }

        private void FrmTrabajador_Activated(object sender, EventArgs e)
        {
            this.dgvProductos.DataSource = null;
            this.dgvProductos.DataSource = miNegocio.ObtenerListaProductosSinRepetir();
            OcultarColumnasDgVYActualizarControles();
        }
    }
}
