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
    public partial class FrmVistaProductoTrabajador : FrmTrabajador
    {

        Producto productoSeleccionado;
        Negocio negocioStock;
        int cantidadStock;
        public FrmVistaProductoTrabajador(Producto productoSeleccionado, Usuario usuarioRegistrado, Negocio miNegocio) : base(usuarioRegistrado)
        {
            InitializeComponent();

            this.usuarioRegistrado = usuarioRegistrado;
            this.productoSeleccionado = productoSeleccionado;
            this.negocioStock = miNegocio;


            this.lblTituloProducto.Text = productoSeleccionado.MostrarInfo();
            this.lblPrecioProducto.Text = $"${productoSeleccionado.Precio}";
            this.rtbDescripcionProducto.Text = productoSeleccionado.MostrarDescripcion();
        }

        private void FrmVistaProductoTrabajador_Load(object sender, EventArgs e)
        {
            this.lblInfoOpciones.Visible = false;
            this.dgvProductos.Visible = false;
            this.lblFiltrar.Visible = false;
            this.cmbFiltrarListaPrecio.Visible = false;
            cantidadStock = negocioStock.ObtenerCantidadProductosEncontrados(negocioStock, productoSeleccionado);
            this.lblStock.Text = $"Stock: {cantidadStock}";
        }

        private void FrmVistaProductoTrabajador_Activated(object sender, EventArgs e)
        {
            cantidadStock = negocioStock.ObtenerCantidadProductosEncontrados(negocioStock, productoSeleccionado);
            this.lblStock.Text = $"Stock: {cantidadStock}";
            this.lblPrecioProducto.Text = $"${productoSeleccionado.Precio}";
        }

        private void btnModificarPrecioProducto_Click(object sender, EventArgs e)
        {
            FrmModificarPrecioProducto frmModificarPrecioProducto = new FrmModificarPrecioProducto(productoSeleccionado, negocioStock);
            DialogResult resultadoDialog = frmModificarPrecioProducto.ShowDialog();
            if (resultadoDialog == DialogResult.Cancel)
            {
                float precio = negocioStock.ObtenerPrecioProductoEnLista(productoSeleccionado);
                this.lblPrecioProducto.Text = $"${precio}";
            }

        }

        private void btnEliminarProductoStock_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show($"Confirma que quiere eliminar todo el stock de este producto?", "Eliminar producto", MessageBoxButtons.YesNo);

            if (confirmacion == DialogResult.Yes)
            {
                if (negocioStock.EliminarTodoElStockProductosCoincidentes(productoSeleccionado))
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
        }
    }
}
