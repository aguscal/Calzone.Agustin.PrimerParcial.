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
    public partial class FrmComprador : Form
    {
        protected Negocio miNegocio;
        protected Usuario usuarioRegistrado;
        protected bool formClosingActivado = false;
        string nombreCategoria = String.Empty;
        public FrmComprador()
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
        public FrmComprador(Usuario usuarioRegistrado) : this()
        {
            this.usuarioRegistrado = usuarioRegistrado;
        }

        private void FormComprador_Load(object sender, EventArgs e)
        {
            if (this.cmbFiltrarListaPrecio.Items.Count < 2)
            {
                this.cmbFiltrarListaPrecio.Items.Add("Menor precio");
                this.cmbFiltrarListaPrecio.Items.Add("Mayor precio");
            }

            ActualizarVistaProductos();

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


            if (usuarioRegistrado is not null)
            {
                this.lblUsuarioRegistrado.Text = $"Hola {usuarioRegistrado.Nombre}!\n {(DateTime.Today).ToString("dd/MM/yyyy")}";
            }

        }


        protected virtual void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvProductos.Rows[e.RowIndex].DataBoundItem is Producto)
                {
                    Producto productoClickeado = (Producto)dgvProductos.Rows[e.RowIndex].DataBoundItem;

                    this.Hide();
                    FrmVistaProducto frmVistaProducto = new FrmVistaProducto(productoClickeado, usuarioRegistrado, miNegocio);
                    frmVistaProducto.ShowDialog();
                    if (frmVistaProducto.DialogResult == DialogResult.Ignore)
                    {
                        frmVistaProducto.Close();

                        ActualizarVistaProductos();
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

        protected void smartPhonesToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Ignore;
        }

        protected void FrmComprador_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmGestionListaCarritoUsuario frmGestionListaCarritoUsuario = new FrmGestionListaCarritoUsuario(usuarioRegistrado);
            frmGestionListaCarritoUsuario.ShowDialog();

            if (frmGestionListaCarritoUsuario.DialogResult == DialogResult.Ignore)
            {
                frmGestionListaCarritoUsuario.Close();

                ActualizarVistaProductos();
                this.Show();
            }
            else
            {
                formClosingActivado = true;
                this.Close();
            }
        }

        private void mostrarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarVistaProductos();
        }

        private void cmbMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbFiltrarListaPrecio.SelectedIndex = -1;
            string opcionMarcaSeleccionada = this.cmbMarcas.SelectedItem.ToString();

            if (string.IsNullOrEmpty(opcionMarcaSeleccionada) == false)
            {
                try
                {
                    if (nombreCategoria == String.Empty)
                    {
                        this.dgvProductos.DataSource = miNegocio.ObtenerListaproductosFiltradosPorMarca(opcionMarcaSeleccionada);
                    }
                    else
                    {
                        this.dgvProductos.DataSource = miNegocio.ObtenerListaproductosFiltrados(nombreCategoria, opcionMarcaSeleccionada);
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

        private void btnComprobantes_Click(object sender, EventArgs e)
        {
            FrmVisualizadorComprobante frmVisualizadorComprobante = new FrmVisualizadorComprobante(((Comprador)usuarioRegistrado).IdComprador);
            frmVisualizadorComprobante.ShowDialog();
        }
    }
}
