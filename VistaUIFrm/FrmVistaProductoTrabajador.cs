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
    public partial class FrmVistaProductoTrabajador : FormTrabajador
    {

        Producto productoSeleccionado;
        Negocio negocioStock;
        public FrmVistaProductoTrabajador(Producto productoSeleccionado, Usuario usuarioRegistrado, Negocio miNegocio) : base((Trabajador)usuarioRegistrado)
        {
            InitializeComponent();

            this.productoSeleccionado = productoSeleccionado;
            this.negocioStock = miNegocio;
        }

        protected void FrmVistaProductoTrabajador_Load(object sender, EventArgs e)
        {
            if (((Trabajador)usuarioRegistrado).Rol.ToString() == "Vendedor")
            {
                this.btnEliminarProductoStock.Visible = false;
                this.btnModificarPrecioProducto.Visible = false;
            }
            else if (((Trabajador)usuarioRegistrado).Rol.ToString() == "Supervisor")
            {
                this.btnEliminarProductoStock.Visible = false;
            }

            this.lblInfoOpciones.Visible = false;
            this.dgvProductos.Visible = false;
            this.lblFiltrar.Visible = false;
            this.cmbFiltrarListaPrecio.Visible = false;
            this.lblMarcas.Visible = false;
            this.cmbMarcas.Visible = false;
            this.mStripCategorias.Visible = false;

            this.lblTituloProducto.Text = productoSeleccionado.MostrarInfo();
            this.lblPrecioProducto.Text = $"${productoSeleccionado.Precio}";
            this.rtbDescripcionProducto.Text = productoSeleccionado.MostrarDescripcion();
            this.lblStock.Text = $"Stock: {productoSeleccionado.Cantidad}";
        }

        private void btnModificarPrecioProducto_Click(object sender, EventArgs e)
        {
            FrmModificarPrecioProducto frmModificarPrecioProducto = new FrmModificarPrecioProducto(productoSeleccionado, negocioStock);
            DialogResult resultadoDialog = frmModificarPrecioProducto.ShowDialog();
            if (resultadoDialog == DialogResult.Cancel)
            {
                try
                {
                    float precio = negocioStock.ObtenerPrecioProductoEnLista(productoSeleccionado);
                    this.lblPrecioProducto.Text = $"${precio}";
                }
                catch (ExcepcionConeccion ex)
                {
                    MostrarError($"Error.No se pudo cargar el precio del producto: {ex.Message}");
                }
                catch (Exception)
                {
                    MostrarError("Error.No se pudo cargar el precio del producto");
                }
            }

        }

        private void btnEliminarProductoStock_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show($"Confirma que quiere eliminar todo el stock de este producto?", "Eliminar producto", MessageBoxButtons.YesNo);

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    if (negocioStock.EliminarStockProducto(productoSeleccionado))
                    {
                        MessageBox.Show("Se elimino todo el stock del producto seleccionado");
                        this.DialogResult = DialogResult.Ignore;
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error. No se elimino todo el stock del producto seleccionado");
                        this.DialogResult = DialogResult.Ignore;
                    }
                }
                catch (ExcepcionConeccion ex)
                {
                    MostrarError($"Error.No se pudo eliminar el producto: {ex.Message}");
                }
                catch (Exception)
                {
                    MostrarError("Error.No se pudo eliminar el producto");
                }

            }
        }

        private void MostrarError(string mensaje)
        {
            MessageBox.Show($"{mensaje}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
