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
    public partial class FrmModificarPrecioProducto : Form
    {
        Producto productoActualizar;
        Negocio negocioStock;
        public FrmModificarPrecioProducto(Producto productoActualizar,Negocio stockNegocio)
        {
            InitializeComponent();
            this.productoActualizar = productoActualizar;
            this.negocioStock = stockNegocio;
        }

        private void FrmModificarPrecioProducto_Load(object sender, EventArgs e)
        {
            this.lblTituloProducto.Text = productoActualizar.MostrarInfo();
            this.lblPrecio.Text = $"$ {negocioStock.ObtenerPrecioProductoEnLista(productoActualizar)}";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //validar y cambiar a todos los coincidentes
            decimal nuevoPrecio = this.nUDPrecioNuevo.Value;

            if (nuevoPrecio == 0)
            {
                MessageBox.Show("Debe ingresar un nuevo precio antes de aceptar");
            }
            else
            {
                DialogResult confirmacion = MessageBox.Show($"Confirma el cambio de todo el stock de este producto a {nuevoPrecio}?", "Comprar producto", MessageBoxButtons.YesNo);

                if(confirmacion == DialogResult.Yes)
                {
                    if(negocioStock.ModificarPrecioProductosCoincidentes(productoActualizar, (int)nuevoPrecio))
                    {
                        MessageBox.Show($"Se actualizo el precio a {nuevoPrecio}");
                        this.lblPrecio.Text = $"$ {negocioStock.ObtenerPrecioProductoEnLista(productoActualizar)}";
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el precio");
                        this.Close();
                    }
                }
            }
        }
    }
}
