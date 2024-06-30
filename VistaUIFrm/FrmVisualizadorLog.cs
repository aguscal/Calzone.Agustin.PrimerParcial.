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
    public partial class FrmVisualizadorLog : Form
    {
        public FrmVisualizadorLog()
        {
            InitializeComponent();
        }

        private void FrmVisualizadorLog_Load(object sender, EventArgs e)
        {            
            try
            {
                using (StreamReader streamLeer = new StreamReader("usuarios.log"))
                {
                    this.rTBLogsUsuarios.Text = streamLeer.ReadToEnd();
                }
            }
            catch (FileNotFoundException ex)
            {
                this.rTBLogsUsuarios.Text = $"El archivo 'usuarios.log' no se encontró. Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                this.rTBLogsUsuarios.Text = $"Error al leer el archivo 'usuarios.log': {ex.Message}";
            }
        }
    }
}
