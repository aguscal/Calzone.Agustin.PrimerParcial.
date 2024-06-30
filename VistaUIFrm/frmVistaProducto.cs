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
    public partial class FrmVistaProducto : FrmComprador
    {
        Producto productoSeleccionado;
        Negocio negocioStock;
        int cantidadStock;

        public FrmVistaProducto(Producto productoSeleccionado, Usuario usuarioRegistrado, Negocio negocioStock) : base(usuarioRegistrado)
        {
            InitializeComponent();
            this.usuarioRegistrado = usuarioRegistrado;
            this.productoSeleccionado = productoSeleccionado;
            this.negocioStock = negocioStock;

            this.lblTituloProducto.Text = productoSeleccionado.MostrarInfo();
            this.lblPrecioProducto.Text = $"${productoSeleccionado.Precio}";
            this.rtbDescripcionProducto.Text = productoSeleccionado.MostrarDescripcion();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {                
            DialogResult confirmacion = MessageBox.Show("Seguro de que quiere comprar?", "Comprar producto", MessageBoxButtons.YesNo);

            if (confirmacion == DialogResult.Yes)
            {
                bool retornoSePudoVender = miNegocio.VenderProducto(productoSeleccionado);

                if (retornoSePudoVender == true)
                {
                    //((Comprador)usuarioRegistrado).ListaCarrito.Remove(productoSeleccionado);
                    cantidadStock = negocioStock.ObtenerCantidadProductosEncontrados(negocioStock, productoSeleccionado);
                    this.lblStock.Text = $"Stock: {cantidadStock}";
                    MessageBox.Show("Venta exitosa!");
                }
                else
                {
                    MessageBox.Show("No se pudo vender. El producto ya no se encuentra disponible para la venta");
                }
            }                       
        }

        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            //aca si deberia haber un metodo que agregue el producto a la lista del carrito del usuario
            if (usuarioRegistrado is Comprador)
            {
                Comprador comprador = (Comprador)usuarioRegistrado;

                int cantidadProductosIgualesAlSeleccionadoCarrito = negocioStock.ObtenerCantidadDelProductoIgualesEnLista(comprador.ListaCarrito, productoSeleccionado);

                if (cantidadProductosIgualesAlSeleccionadoCarrito < cantidadStock)
                {
                    bool retornoAgregar = comprador.AgregarProductoAlCarrito(productoSeleccionado, negocioStock);
                    if (retornoAgregar)
                    {
                        MessageBox.Show("Se agrego el producto al carrito");
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error. No se puedo agregar el producto al carrito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ocurrio un error. No se agrego el producto al carrito porque no hay suficiente stock del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        protected void FrmVistaProducto_Load(object sender, EventArgs e)
        {
            this.dgvProductos.Visible = false;
            this.cmbFiltrarListaPrecio.Visible = false;
            this.lblFiltrar.Visible = false;
            cantidadStock = negocioStock.ObtenerCantidadProductosEncontrados(negocioStock, productoSeleccionado);
            this.lblStock.Text = $"Stock: {cantidadStock}";
        }

        protected void FrmVistaProducto_Activated(object sender, EventArgs e)
        {
            cantidadStock = negocioStock.ObtenerCantidadProductosEncontrados(negocioStock, productoSeleccionado);
            this.lblStock.Text = $"Stock: {cantidadStock}";
        }
    }
}
