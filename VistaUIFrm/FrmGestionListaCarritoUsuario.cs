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
    public partial class FrmGestionListaCarritoUsuario : FrmComprador
    {
        public FrmGestionListaCarritoUsuario(Usuario usuarioRegistrado) : base(usuarioRegistrado)
        {
            InitializeComponent();
        }

        private void FrmGestionListaCarritoUsuario_Load(object sender, EventArgs e)
        {
            this.mStripCategorias.Visible = false;
            this.btnCarrito.Visible = false;
            this.lblMarcas.Visible = false;
            this.cmbMarcas.Visible = false;
            this.dgvProductos.Size = new System.Drawing.Size(500, 300);
            this.dgvProductos.Location = new System.Drawing.Point(10, 140);
            this.dgvProductos.Anchor = AnchorStyles.Left | AnchorStyles.Right;

            this.dgvProductos.DataSource = null;
            this.dgvProductos.DataSource = new BindingSource(((Comprador)usuarioRegistrado).DictCarrito, null);

            if ((((Comprador)usuarioRegistrado).DictCarrito).Count == 0)
            {
                this.dgvProductos.Columns.Clear();
            }

            this.cmbFiltrarListaPrecio.Items.Clear();
            if (this.cmbFiltrarListaPrecio.Items.Count < 2)
            {
                this.cmbFiltrarListaPrecio.Items.Add("Menor precio");
                this.cmbFiltrarListaPrecio.Items.Add("Mayor precio");
            }

            OcultarColumnasDgVCompradorYActualizarControles();
        }

        private void FrmGestionListaCarritoUsuario_Activated(object sender, EventArgs e)
        {
            this.dgvProductos.DataSource = null;
            this.dgvProductos.DataSource = new BindingSource(((Comprador)usuarioRegistrado).DictCarrito, null);

            if ((((Comprador)usuarioRegistrado).DictCarrito).Count == 0)
            {
                this.dgvProductos.Columns.Clear();
            }

            OcultarColumnasDgVCompradorYActualizarControles();
        }

        protected override void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                KeyValuePair<Producto, int> claveValorSeleccionado = (KeyValuePair<Producto, int>)dgvProductos.Rows[e.RowIndex].DataBoundItem;
                //Producto productoSeleccionado = claveValorSeleccionado.Key;

                this.Hide();
                FrmOpcionesSobreProductoCarrito frmOpcionesproducto = new FrmOpcionesSobreProductoCarrito(claveValorSeleccionado, usuarioRegistrado);
                frmOpcionesproducto.ShowDialog();

                if (frmOpcionesproducto.DialogResult == DialogResult.Cancel)
                {
                    frmOpcionesproducto.Close();

                    this.dgvProductos.DataSource = null;
                    this.dgvProductos.DataSource = new BindingSource(((Comprador)usuarioRegistrado).DictCarrito, null);

                    if ((((Comprador)usuarioRegistrado).DictCarrito).Count == 0)
                    {
                        this.dgvProductos.Columns.Clear();
                    }

                    OcultarColumnasDgVCompradorYActualizarControles();

                    this.Show();
                }
                else
                {
                    formClosingActivado = true;
                    this.Close();
                }
            }
        }

        private void btnVaciarCarrito_Click(object sender, EventArgs e)
        {
            this.dgvProductos.DataSource = null;

            ((Comprador)usuarioRegistrado).DictCarrito.Clear();

            this.dgvProductos.DataSource = new BindingSource(((Comprador)usuarioRegistrado).DictCarrito, null);

            if ((((Comprador)usuarioRegistrado).DictCarrito).Count == 0)
            {
                this.dgvProductos.Columns.Clear();
            }

            OcultarColumnasDgVCompradorYActualizarControles();
        }

        private void OcultarColumnasDgVCompradorYActualizarControles()
        {
            if (this.dgvProductos.Columns.Count > 1)
            {
                dgvProductos.Columns[0].Width = 350;
                dgvProductos.Columns[0].HeaderText = "Producto";
                dgvProductos.Columns[1].HeaderText = "Cantidad";
            }

            if (this.dgvProductos.Columns.Contains("Keys"))
            {
                this.dgvProductos.Columns["Keys"].Visible = false;
            }
            if (this.dgvProductos.Columns.Contains("Values"))
            {
                this.dgvProductos.Columns["Values"].Visible = false;
            }

            if (((Comprador)usuarioRegistrado).DictCarrito.Count == 0)
            {
                this.lblNoHayProductosCarrito.Visible = true;
            }
            else
            {
                this.lblNoHayProductosCarrito.Visible = false;
            }
        }

        private void btnComprarTodo_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("Seguro de que quiere comprar?", "Comprar producto", MessageBoxButtons.YesNo);

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    if (miNegocio is not null)
                    {
                        Producto productoSinStock;

                        if (miNegocio.VerificarDisponibilidadProductosSeleccionados(((Comprador)usuarioRegistrado).DictCarrito, out productoSinStock))
                        {
                            FormDatosComprobante frmComprobante = new FormDatosComprobante(((Comprador)usuarioRegistrado).DictCarrito, (Comprador)usuarioRegistrado);

                            DialogResult resultado = frmComprobante.ShowDialog();

                            if (resultado == DialogResult.Cancel || resultado == DialogResult.Yes)
                            {
                                this.DialogResult = DialogResult.Cancel;
                                this.Close();
                            }

                        }
                        else
                        {
                            MessageBox.Show($"No se avanzo con la compra ya que no hay suficiente cantidad del producto {productoSinStock.MostrarInfo()} en stock hay disponibles {miNegocio.ObtenerCantidadProductoBuscado(miNegocio, productoSinStock)} unidades");
                        }

                    }
                }
                catch (ExcepcionConeccion ex)
                {
                    MessageBox.Show($"Error.No se pudo vender los productos: {ex.Message}");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error.No se pudo vender los productos");
                }
            }
        }
    }
}
