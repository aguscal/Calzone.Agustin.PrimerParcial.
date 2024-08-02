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
    public partial class FormTrabajador : Form
    {
        protected Negocio miNegocio;
        protected Usuario usuarioRegistrado;
        protected bool formClosingActivado = false;
        string nombreCategoria = String.Empty;
        public FormTrabajador()
        {
            InitializeComponent();
            try
            {
                miNegocio = Negocio.Instancia;
            }
            catch (Exception)
            {
                MessageBox.Show("Error grave de conexion");
            }
        }

        public FormTrabajador(Usuario usuario) : this()
        {
            this.usuarioRegistrado = usuario;
        }

        private void FormTrabajador_Load(object sender, EventArgs e)
        {
            if (((Trabajador)usuarioRegistrado).Rol.ToString() == "Vendedor")
            {
                this.btnCrearNuevoProducto.Visible = false;
                this.cmbCategoriaProductoCrear.Visible = false;
                this.lblCategInfo.Visible = false;

                this.lblInfoOpciones.Text = "Info: Puede seleccionar el producto para ver informacion mas detallada del mismo.";
            }
            else if (((Trabajador)usuarioRegistrado).Rol.ToString() == "Supervisor")
            {
                this.lblInfoOpciones.Text = "Info: Puede seleccionar el producto para ver informacion mas detallada del mismo o para actualizarlo";
            }

            if (this.cmbFiltrarListaPrecio.Items.Count < 2)
            {
                this.cmbFiltrarListaPrecio.Items.Add("Menor precio");
                this.cmbFiltrarListaPrecio.Items.Add("Mayor precio");
            }

            if (this.cmbCategoriaProductoCrear.Items.Count < 2)
            {
                this.cmbCategoriaProductoCrear.Items.Add("Auricular");
                this.cmbCategoriaProductoCrear.Items.Add("Monitor");
                this.cmbCategoriaProductoCrear.Items.Add("SmartPhone");
            }

            if (miNegocio is not null)
            {
                this.cmbMarcas.Items.Clear();
                foreach (var marca in miNegocio.ObtenerTodasLasMarcas())
                {
                    this.cmbMarcas.Items.Add(marca);
                }
            }


            try
            {
                if (miNegocio is not null)
                {
                    this.dgvProductos.DataSource = miNegocio.ListaProductos;
                    OcultarColumnasDgVYActualizarControles();
                }
            }
            catch (ExcepcionConeccion ex)
            {
                this.lblNoHayProductosEnStock.Visible = true;
                MostrarError($"Error al mostrar los productos: {ex.Message}");
            }
            catch (Exception)
            {
                this.lblNoHayProductosEnStock.Visible = true;
                MostrarError("Error al mostrar los productos");
            }


            if (usuarioRegistrado is not null)
            {
                this.lblUsuarioRegistrado.Text = $"Hola {usuarioRegistrado.Nombre}!\n {(DateTime.Today).ToString("dd/MM/yyyy")}";
            }
        }

        protected void OcultarColumnasDgVYActualizarControles()
        {
            if (this.dgvProductos is not null && this.dgvProductos.DataSource is not null)
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
            }

            try
            {
                if (miNegocio is not null && miNegocio.ListaProductos.Count == 0)
                {
                    this.lblNoHayProductosEnStock.Visible = true;
                }
                else
                {
                    this.lblNoHayProductosEnStock.Visible = false;
                }
            }
            catch (ExcepcionConeccion ex)
            {
                this.lblNoHayProductosEnStock.Visible = true;
                MostrarError($"Error al mostrar los productos: {ex.Message}");
            }
            catch (Exception)
            {
                this.lblNoHayProductosEnStock.Visible = true;
                MostrarError("Error al mostrar los productos");
            }

        }

        private void ActualizarVistaProductos()
        {
            try
            {
                if (miNegocio is not null)
                {
                    this.dgvProductos.DataSource = miNegocio.ListaProductos;

                    this.cmbMarcas.Items.Clear();
                    this.cmbFiltrarListaPrecio.SelectedIndex = -1;
                    this.nombreCategoria = String.Empty;
                    foreach (var marca in miNegocio.ObtenerTodasLasMarcas())
                    {
                        this.cmbMarcas.Items.Add(marca);
                    }
                }
            }
            catch (ExcepcionConeccion ex)
            {
                MostrarError($"Error al mostrar los productos: {ex.Message}");
            }
            catch (Exception)
            {
                MostrarError("Error al mostrar los productos");
            }

        }

        private void MostrarError(string mensaje)
        {
            MessageBox.Show($"{mensaje}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Ignore;
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvProductos.Rows[e.RowIndex].DataBoundItem is Producto)
                {
                    Producto productoClickeado = (Producto)dgvProductos.Rows[e.RowIndex].DataBoundItem;

                    this.Hide();
                    FrmVistaProductoTrabajador frmVistaProductoTrabajador = new FrmVistaProductoTrabajador(productoClickeado, usuarioRegistrado, miNegocio);
                    frmVistaProductoTrabajador.ShowDialog();
                    if (frmVistaProductoTrabajador.DialogResult == DialogResult.Ignore)
                    {
                        frmVistaProductoTrabajador.Close();

                        ActualizarVistaProductos();

                        OcultarColumnasDgVYActualizarControles();

                        this.Show();
                    }
                    else
                    {
                        formClosingActivado = true;
                        this.Close();
                    }
                }
            }
        }

        private void cmbMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbFiltrarListaPrecio.SelectedIndex = -1;
            string opcionMarcaSeleccionada = string.Empty;

            if (this.cmbMarcas.SelectedItem is not null) { opcionMarcaSeleccionada = this.cmbMarcas.SelectedItem.ToString(); }

            if (string.IsNullOrEmpty(opcionMarcaSeleccionada) == false)
            {
                try
                {
                    if (nombreCategoria == String.Empty)
                    {
                        if (miNegocio is not null)
                        {
                            this.dgvProductos.DataSource = miNegocio.ObtenerListaproductosFiltradosPorMarca(opcionMarcaSeleccionada);
                        }
                    }
                    else
                    {
                        if (miNegocio is not null)
                        {
                            this.dgvProductos.DataSource = miNegocio.ObtenerListaproductosFiltrados(nombreCategoria, opcionMarcaSeleccionada);
                        }
                    }
                }
                catch (ExcepcionConeccion ex)
                {
                    MostrarError($"Error al mostrar los productos: {ex.Message}");
                }
                catch (Exception)
                {
                    MostrarError("Error al mostrar los productos");
                }

            }
        }

        private void cmbFiltrarListaPrecio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltrarListaPrecio.SelectedItem != null && this.dgvProductos.DataSource != null)
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

        private void smartPhonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (miNegocio is not null)
                {
                    this.dgvProductos.DataSource = miNegocio.ObtenerListaproductosFiltrados("SmartPhone");

                    this.nombreCategoria = "SmartPhone";
                    this.cmbMarcas.Items.Clear();
                    this.cmbFiltrarListaPrecio.SelectedIndex = -1;
                    foreach (var marca in miNegocio.ObtenerMarcasSegunCategoria("SmartPhone"))
                    {
                        this.cmbMarcas.Items.Add(marca);
                    }
                }
            }
            catch (ExcepcionConeccion ex)
            {
                MostrarError($"Error al mostrar los productos: {ex.Message}");
            }
            catch (Exception)
            {
                MostrarError("Error al mostrar los productos");
            }
        }

        private void auricularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (miNegocio is not null)
                {
                    this.dgvProductos.DataSource = miNegocio.ObtenerListaproductosFiltrados("Auricular");

                    this.nombreCategoria = "Auricular";
                    this.cmbMarcas.Items.Clear();
                    this.cmbFiltrarListaPrecio.SelectedIndex = -1;
                    foreach (var marca in miNegocio.ObtenerMarcasSegunCategoria("Auricular"))
                    {
                        this.cmbMarcas.Items.Add(marca);
                    }
                }
            }
            catch (ExcepcionConeccion ex)
            {
                MostrarError($"Error al mostrar los productos: {ex.Message}");
            }
            catch (Exception)
            {
                MostrarError("Error al mostrar los productos");
            }
        }

        private void monitoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (miNegocio is not null)
                {
                    this.dgvProductos.DataSource = miNegocio.ObtenerListaproductosFiltrados("Monitor");

                    this.nombreCategoria = "Monitor";
                    this.cmbMarcas.Items.Clear();
                    this.cmbFiltrarListaPrecio.SelectedIndex = -1;
                    foreach (var marca in miNegocio.ObtenerMarcasSegunCategoria("Monitor"))
                    {
                        this.cmbMarcas.Items.Add(marca);
                    }
                }
            }
            catch (ExcepcionConeccion ex)
            {
                MostrarError($"Error al mostrar los productos: {ex.Message}");
            }
            catch (Exception)
            {
                MostrarError("Error al mostrar los productos");
            }
        }

        private void verLogsUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVisualizadorLog frmVisualizador = new FrmVisualizadorLog();
            frmVisualizador.ShowDialog();
        }

        private void TodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarVistaProductos();
        }

        protected void FormTrabajador_FormClosing(object sender, FormClosingEventArgs e)
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
                        ActualizarVistaProductos();
                        OcultarColumnasDgVYActualizarControles();
                    }

                }
                else if (this.cmbCategoriaProductoCrear.SelectedItem.ToString() == "SmartPhone")
                {
                    FrmCrearProductoSmartPhone frmCrearProductoSmartPhone = new FrmCrearProductoSmartPhone();
                    DialogResult resultadoFrmCrearProductoSmartPhone = frmCrearProductoSmartPhone.ShowDialog();
                    if (resultadoFrmCrearProductoSmartPhone == DialogResult.Cancel)
                    {
                        ActualizarVistaProductos();
                        OcultarColumnasDgVYActualizarControles();
                    }
                }
                else if (this.cmbCategoriaProductoCrear.SelectedItem.ToString() == "Monitor")
                {
                    FrmCrearProductoMonitor frmCrearProductoMonitor = new FrmCrearProductoMonitor();
                    DialogResult resultadoFrmCrearProductoMonitor = frmCrearProductoMonitor.ShowDialog();
                    if (resultadoFrmCrearProductoMonitor == DialogResult.Cancel)
                    {
                        ActualizarVistaProductos();
                        OcultarColumnasDgVYActualizarControles();
                    }
                }
            }
        }

        private void btnComprobantes_Click(object sender, EventArgs e)
        {
            FrmVisualizadorComprobante frmVisualizadorComprobante= new FrmVisualizadorComprobante();
            frmVisualizadorComprobante.ShowDialog();
        }
    }
}
