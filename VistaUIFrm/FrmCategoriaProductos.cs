using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaUIFrm
{
    public partial class FrmCategoriaProductos : VistaUIFrm.FrmComprador
    {
        string nombreTipoCategoria;
        public FrmCategoriaProductos(Usuario user, string nombreCategoria) : base(user)
        {
            InitializeComponent();
            this.nombreTipoCategoria = nombreCategoria;
            this.dgvProductos.DataSource = miNegocio.ObtenerListaProductosSinRepetir();
            this.dgvProductos.Size = new System.Drawing.Size(700, 345);
            this.dgvProductos.Location = new System.Drawing.Point(85, 93);
            this.dgvProductos.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        }

        private void FrmCategoriaProductos_Load(object sender, EventArgs e)
        {
            this.dgvProductos.DataSource = miNegocio.ObtenerListaproductosFiltrados(nombreTipoCategoria);

            foreach (var marca in miNegocio.ObtenerMarcasSegunCategoria(nombreTipoCategoria))
            {
                this.cmbMarcasOpciones.Items.Add(marca);
            }
        }

        private void cmbMarcasOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcionMarcaSeleccionada = this.cmbMarcasOpciones.SelectedItem.ToString();

            if(string.IsNullOrEmpty(opcionMarcaSeleccionada) == false)
            {
                this.dgvProductos.DataSource = miNegocio.ObtenerListaproductosFiltrados(nombreTipoCategoria, opcionMarcaSeleccionada);
                base.FiltrarListaPrecioDesdeFormDerivado();                      
            }         
        }
    }
}
