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
        Producto productoSeleccionado;
        Usuario usuarioRegistrado;
        Negocio negocioStock;
        public FrmOpcionesSobreProductoCarrito(Producto productoSeleccionado, Usuario usuarioRegistrado)
        {
            InitializeComponent();
            this.productoSeleccionado = productoSeleccionado;
            this.usuarioRegistrado = usuarioRegistrado;
            negocioStock = Negocio.Instancia;
        }

        private void FrmOpcionesSobreProductoCarrito_Load(object sender, EventArgs e)
        {
            this.lblTituloProducto.Text = productoSeleccionado.MostrarInfo();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("Seguro de que quiere comprar?", "Comprar producto", MessageBoxButtons.YesNo);

            if (confirmacion == DialogResult.Yes)
            {
                bool retornoSePudoVender = negocioStock.VenderProducto(productoSeleccionado);

                if (retornoSePudoVender == true)
                {
                    ((Comprador)usuarioRegistrado).ListaCarrito.Remove(productoSeleccionado);
                    MessageBox.Show("Venta exitosa!");
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo vender. El producto ya no se encuentra disponible para la venta");
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }
        }

        private void btnEliminarProductoCarrito_Click(object sender, EventArgs e)
        {

            DialogResult confirmacion = MessageBox.Show("Seguro de que quiere quitar el producto del carrito?", "Quitar producto", MessageBoxButtons.YesNo);

            if (confirmacion == DialogResult.Yes)
            {
                ((Comprador)usuarioRegistrado).ListaCarrito.Remove(productoSeleccionado);
                StringBuilder sb = new StringBuilder();
                
                foreach(var item in ((Comprador)usuarioRegistrado).ListaCarrito)
                {
                    sb.Append(item.ToString());
                }
                
                MessageBox.Show(sb.ToString());
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
