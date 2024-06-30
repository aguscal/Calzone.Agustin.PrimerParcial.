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
    public partial class FrmCategoriaProductosTrabajador : FrmTrabajador
    {
        string nombreTipoCategoria;
        public FrmCategoriaProductosTrabajador(Usuario user, string nombreCategoria) : base(user)
        {
            InitializeComponent();
            this.nombreTipoCategoria = nombreCategoria;
            this.dgvProductos.DataSource = miNegocio.ObtenerListaProductosSinRepetir();
        }

        private void FrmCategoriaProductosTrabajador_Load(object sender, EventArgs e)
        {
            this.dgvProductos.DataSource = miNegocio.ObtenerListaproductosFiltrados(nombreTipoCategoria);

            foreach (var marca in miNegocio.ObtenerMarcasSegunCategoria(nombreTipoCategoria))
            {
                this.cmbMarcasOpciones.Items.Add(marca);
            }

            OcultarColumnasDgVYActualizarControles();
        }

        private void cmbMarcasOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcionMarcaSeleccionada = this.cmbMarcasOpciones.SelectedItem.ToString();

            if (string.IsNullOrEmpty(opcionMarcaSeleccionada) == false)
            {
                this.dgvProductos.DataSource = miNegocio.ObtenerListaproductosFiltrados(nombreTipoCategoria, opcionMarcaSeleccionada);
                base.FiltrarListaPrecioDesdeFormDerivado();
            }
        }

        private void FrmCategoriaProductosTrabajador_Activated(object sender, EventArgs e)
        {
            this.cmbFiltrarListaPrecio.Items.Clear();
            if (this.cmbFiltrarListaPrecio.Items.Count < 2)
            {
                this.cmbFiltrarListaPrecio.Items.Add("Menor precio");
                this.cmbFiltrarListaPrecio.Items.Add("Mayor precio");
            }
            this.dgvProductos.DataSource = miNegocio.ObtenerListaproductosFiltrados(nombreTipoCategoria);
            OcultarColumnasDgVYActualizarControles();
            
        }
    }
}
