using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistaUIFrm
{
    public interface IFormsCrearProductos
    {
        void btnCancelar_Click(object sender, EventArgs e);

        void cmbMarcas_SelectedIndexChanged(object sender, EventArgs e);

        void btnAgregar_Click(object sender, EventArgs e);

        void MostrarError(string mensaje);
    }
}
