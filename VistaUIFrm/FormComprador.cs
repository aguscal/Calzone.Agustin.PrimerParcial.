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
        protected Negocio miNegocio = Negocio.Instancia;
        protected Usuario usuarioRegistrado;
        protected bool formClosingActivado = false;

        public FrmComprador()
        {
            InitializeComponent();
        }
        public FrmComprador(Usuario usuarioRegistrado) : this()
        {
            this.usuarioRegistrado = usuarioRegistrado;
        }

        private void FormComprador_Load(object sender, EventArgs e)
        {
            if(this.cmbFiltrarListaPrecio.Items.Count < 2)
            {
                this.cmbFiltrarListaPrecio.Items.Add("Menor precio");
                this.cmbFiltrarListaPrecio.Items.Add("Mayor precio");
            }

            this.dgvProductos.DataSource = miNegocio.ObtenerListaProductosSinRepetir();

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
            //tengo que obtener el producto al que se le dio click
            //tengo que crear un formulario en el que se muestre mas info del producto
            //tengo que darle la oportunidad de cargarlo al carrito o comprarlo-1

            if (e.RowIndex >= 0)
            {               
                Producto productoClickeado = (Producto)dgvProductos.Rows[e.RowIndex].DataBoundItem;

                this.Hide();
                FrmVistaProducto frmVistaProducto = new FrmVistaProducto(productoClickeado, usuarioRegistrado, miNegocio);
                frmVistaProducto.ShowDialog();
                if (frmVistaProducto.DialogResult == DialogResult.Ignore)
                {
                    frmVistaProducto.Close();
                    this.Show();
                }
                else
                {
                    formClosingActivado = true;
                    this.Close();
                }
            }
            
        }

        protected void smartPhonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OcultarYMostrarFrmCategoriaProductos("SmartPhone");
        }

        private void auricularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OcultarYMostrarFrmCategoriaProductos("Auricular");
        }

        private void monitoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OcultarYMostrarFrmCategoriaProductos("Monitor");
        }

        private void cmbFiltrarListaPrecio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltrarListaPrecio.SelectedItem != null)
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

        protected void FiltrarListaPrecioDesdeFormDerivado()
        {
            cmbFiltrarListaPrecio_SelectedIndexChanged(this.cmbFiltrarListaPrecio, EventArgs.Empty);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Ignore;
        }

        protected void FrmComprador_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.DialogResult == DialogResult.Ignore)
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
                this.Show();
            }
            else
            {
                formClosingActivado = true;
                this.Close();
            }
        }

        private void OcultarYMostrarFrmCategoriaProductos(string categoria)
        {
            this.Hide();
            FrmCategoriaProductos frmCategoriaProductos = new FrmCategoriaProductos(usuarioRegistrado, categoria);
            frmCategoriaProductos.ShowDialog();

            if (frmCategoriaProductos.DialogResult == DialogResult.Ignore)
            {
                frmCategoriaProductos.Close();
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
