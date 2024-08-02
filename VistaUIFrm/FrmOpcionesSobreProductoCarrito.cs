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
    public partial class FrmOpcionesSobreProductoCarrito : Form
    {
        KeyValuePair<Producto, int> productoSeleccionado;
        Usuario usuarioRegistrado;
        Negocio negocioStock;

        public FrmOpcionesSobreProductoCarrito(KeyValuePair<Producto, int> productoSeleccionado, Usuario usuarioRegistrado)
        {
            InitializeComponent();
            this.productoSeleccionado = productoSeleccionado;
            this.usuarioRegistrado = usuarioRegistrado;
            try
            {
                negocioStock = Negocio.Instancia;
            }
            catch (Exception)
            {
                MessageBox.Show("Error grave de conexion");
            }
        }

        private void FrmOpcionesSobreProductoCarrito_Load(object sender, EventArgs e)
        {
            this.lblTituloProducto.Text = productoSeleccionado.Key.MostrarInfo();
            this.nupdDisminuirCantidad.Value = productoSeleccionado.Value;
            this.nupdDisminuirCantidad.Maximum = productoSeleccionado.Value;
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
                        dictSeleccionCompra.Add(productoSeleccionado.Key, ((Comprador)usuarioRegistrado).DictCarrito[productoSeleccionado.Key]);
                        

                        if (negocioStock.VerificarDisponibilidadProductosSeleccionados(dictSeleccionCompra, out productoSinStock))
                        {
                            FormDatosComprobante frmComprobante = new FormDatosComprobante(dictSeleccionCompra, (Comprador)usuarioRegistrado);

                            DialogResult resultado = frmComprobante.ShowDialog();

                            if (resultado == DialogResult.Cancel || resultado == DialogResult.Yes)
                            {
                                this.Refresh();
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
                    MostrarError($"Error.No se pudo vender los productos: {ex.Message}");
                }
                catch (Exception)
                {
                    MostrarError("Error.No se pudo vender los productos");
                }

            }
        }

        private void btnEliminarProductoCarrito_Click(object sender, EventArgs e)
        {

            DialogResult confirmacion = MessageBox.Show("Seguro de que quiere quitar el producto del carrito?", "Quitar producto", MessageBoxButtons.YesNo);

            if (confirmacion == DialogResult.Yes)
            {
                ((Comprador)usuarioRegistrado).DictCarrito.Remove(productoSeleccionado.Key);
                
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void MostrarError(string mensaje)
        {
            MessageBox.Show($"{mensaje}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDisminuirCantidad_Click(object sender, EventArgs e)
        {
            ((Comprador)usuarioRegistrado).DictCarrito[productoSeleccionado.Key] = (int)nupdDisminuirCantidad.Value;

            MessageBox.Show($"Se disminuyo la cantidad correctamente a: {((Comprador)usuarioRegistrado).DictCarrito[productoSeleccionado.Key]}");
        }
    }
}
