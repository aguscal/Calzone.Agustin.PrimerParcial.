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
            this.menuStrip1.Visible = false;
            this.dgvProductos.Size = new System.Drawing.Size(500, 300);
            this.dgvProductos.Location = new System.Drawing.Point(10, 140);
            this.dgvProductos.Anchor = AnchorStyles.Left | AnchorStyles.Right;

            this.dgvProductos.DataSource = null;
            this.dgvProductos.DataSource = ((Comprador)usuarioRegistrado).ListaCarrito;

            this.cmbFiltrarListaPrecio.Items.Clear();
            if (this.cmbFiltrarListaPrecio.Items.Count < 2)
            {
                this.cmbFiltrarListaPrecio.Items.Add("Menor precio");
                this.cmbFiltrarListaPrecio.Items.Add("Mayor precio");
            }

            OcultarColumnasDgVYActualizarControles();
        }

        private void FrmGestionListaCarritoUsuario_Activated(object sender, EventArgs e)
        {
            this.dgvProductos.DataSource = null;
            this.dgvProductos.DataSource = ((Comprador)usuarioRegistrado).ListaCarrito;
            
            OcultarColumnasDgVYActualizarControles();
        }

        protected override void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Producto productoSeleccionado = (Producto)dgvProductos.Rows[e.RowIndex].DataBoundItem;
                this.Hide();
                FrmOpcionesSobreProductoCarrito frmOpcionesproducto = new FrmOpcionesSobreProductoCarrito(productoSeleccionado, usuarioRegistrado);
                frmOpcionesproducto.ShowDialog();

                if (frmOpcionesproducto.DialogResult == DialogResult.Cancel)
                {
                    frmOpcionesproducto.Close();
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
            ((Comprador)usuarioRegistrado).ListaCarrito.Clear();

            this.dgvProductos.DataSource = ((Comprador)usuarioRegistrado).ListaCarrito;
            //ClaseSerializadora.EscribirUsuariosJson(lis)
            OcultarColumnasDgVYActualizarControles();
            //this.Refresh();
        }

        private void OcultarColumnasDgVYActualizarControles()
        {
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

            if (((Comprador)usuarioRegistrado).ListaCarrito.Count == 0)
            {
                this.lblNoHayProductosCarrito.Visible = true;
            }
            else
            {
                this.lblNoHayProductosCarrito.Visible = false;
            }
        }
    }
}
