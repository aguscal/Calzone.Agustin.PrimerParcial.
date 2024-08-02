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
            this.productoSeleccionado = productoSeleccionado;
            this.negocioStock = negocioStock;
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("Seguro de que quiere comprar?", "Comprar producto", MessageBoxButtons.YesNo);

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    if (negocioStock is not null)
                    {
                        Producto productoSinStock;

                        Dictionary<Producto, int> dictSeleccionCompra = new Dictionary<Producto, int>();
                        dictSeleccionCompra.Add(productoSeleccionado, 1);


                        if (negocioStock.VerificarDisponibilidadProductosSeleccionados(dictSeleccionCompra, out productoSinStock))
                        {
                            FormDatosComprobante frmComprobante = new FormDatosComprobante(dictSeleccionCompra, (Comprador)usuarioRegistrado);

                            this.Hide();
                            DialogResult resultado = frmComprobante.ShowDialog();

                            if (resultado == DialogResult.Cancel || resultado == DialogResult.Yes)
                            {
                                this.Refresh();
                                this.Show();
                            }

                        }
                        else
                        {
                            MessageBox.Show($"No se avanzo con la compra ya que no hay suficiente cantidad del producto {productoSinStock.MostrarInfo()} en stock hay disponibles {negocioStock.ObtenerCantidadProductoBuscado(negocioStock, productoSinStock)} unidades");
                        }

                    }

                }
                catch (ExcepcionConeccion ex)
                {
                    MostrarError($"Error.No se pudo vender el producto: {ex.Message}");
                }
                catch (Exception)
                {
                    MostrarError("Error.No se pudo vender el producto");
                }

            }
        }

        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            if (usuarioRegistrado is Comprador)
            {
                Comprador comprador = (Comprador)usuarioRegistrado;

                int cantidadProductosIgualesAlSeleccionadoCarrito = 0;

                if (comprador.DictCarrito.ContainsKey(productoSeleccionado))
                {
                    cantidadProductosIgualesAlSeleccionadoCarrito = comprador.DictCarrito[productoSeleccionado];
                }

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
            this.lblTituloProducto.Text = productoSeleccionado.MostrarInfo();
            this.lblPrecioProducto.Text = $"${productoSeleccionado.Precio}";
            this.rtbDescripcionProducto.Text = productoSeleccionado.MostrarDescripcion();

            this.dgvProductos.Visible = false;
            this.cmbFiltrarListaPrecio.Visible = false;
            this.lblFiltrar.Visible = false;
            this.lblMarcas.Visible = false;
            this.cmbMarcas.Visible = false;
            this.mStripCategorias.Visible = false;

            try
            {
                cantidadStock = negocioStock.ObtenerCantidadProductoBuscado(negocioStock, productoSeleccionado);
                this.lblStock.Text = $"Stock: {cantidadStock}";
            }
            catch (ExcepcionConeccion ex)
            {
                MostrarError($"Error.No se pudo cargar la cantidad del producto: {ex.Message}");
            }
            catch (Exception)
            {
                MostrarError("Error.No se pudo cargar la cantidad del producto");
            }

            if(productoSeleccionado.Cantidad == 0)
            {
                this.btnAgregarCarrito.Enabled = false;
                this.btnComprar.Enabled = false;
            }
        }

        private void MostrarError(string mensaje)
        {
            MessageBox.Show($"{mensaje}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FrmVistaProducto_Activated(object sender, EventArgs e)
        {
            try
            {
                cantidadStock = negocioStock.ObtenerCantidadProductoBuscado(negocioStock, productoSeleccionado);
                this.lblStock.Text = $"Stock: {cantidadStock}";
                if (cantidadStock == 0)
                {
                    this.btnAgregarCarrito.Enabled = false;
                    this.btnComprar.Enabled = false;
                }
            }
            catch (ExcepcionConeccion ex)
            {
                MostrarError($"Error.No se pudo cargar la cantidad del producto: {ex.Message}");
            }
            catch (Exception)
            {
                MostrarError("Error.No se pudo cargar la cantidad del producto");
            }
        }
    }
}
