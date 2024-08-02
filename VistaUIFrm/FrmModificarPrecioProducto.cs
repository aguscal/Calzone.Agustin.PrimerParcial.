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
            try
            {
                this.lblPrecio.Text = $"$ {negocioStock.ObtenerPrecioProductoEnLista(productoActualizar)}";
            }
            catch (ExcepcionConeccion ex)
            {
                MostrarError($"Esta opcion no esta disponible.Error al obtener el precio del producto: {ex.Message}");
                this.Close();
            }
            catch (Exception)
            {
                MostrarError("Esta opcion no esta disponible.Error al obtener el precio del producto");
                this.Close();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            decimal nuevoPrecio = this.nUDPrecioNuevo.Value;

            if (nuevoPrecio == 0)
            {
                MessageBox.Show("Debe ingresar un nuevo precio antes de aceptar");
            }
            else
            {
                DialogResult confirmacion = MessageBox.Show($"Confirma el cambio del precio de este producto a {nuevoPrecio}?", "Cambiar precio producto", MessageBoxButtons.YesNo);

                if(confirmacion == DialogResult.Yes)
                {
                    try
                    {
                        if (negocioStock.ModificarPrecioProducto(productoActualizar, (float)nuevoPrecio))
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
                    catch (ExcepcionConeccion ex)
                    {
                        MostrarError($"Error al modificar el precio del producto: {ex.Message}");
                    }
                    catch (Exception)
                    {
                        MostrarError("Error al modificar el precio del producto");
                    }

                }
            }
        }

        private void MostrarError(string mensaje)
        {
            MessageBox.Show($"{mensaje}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
