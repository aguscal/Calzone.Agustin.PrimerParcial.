using Entidades;

namespace VistaUIFrm
{
    public partial class FormIngreso : Form
    {
        List<Usuario> listaUsuariosRegistrados;
        public FormIngreso()
        {
            InitializeComponent();
        }

        private void FormIngreso_Load(object sender, EventArgs e)
        {
            //esto no esta bien tal vez hacelo asi , encontrar una mejor manera
            /*List<Usuario> listaUsuariosRegistrados;
            string nombreArchivoUsuarios = "Usuarios.json";


            listaUsuariosRegistrados = new List<Usuario>();
            listaUsuariosRegistrados.Add(new Comprador("laraine0@gmail.com", "laraine123", "Laraine", "Steade"));
            listaUsuariosRegistrados.Add(new Comprador("abdelttiero1@gmail.com", "abdel123", "Abdel", "Savattiero"));
            listaUsuariosRegistrados.Add(new Comprador("denny2@gmail.com", "denny123", "Denny", "Chug"));
            listaUsuariosRegistrados.Add(new Comprador("emmetf3@gmail.com", "Emet123", "Emmet", "Rolf"));

            listaUsuariosRegistrados.Add(new Trabajador("rodrigo9@gmail.com", "rodri123", "Rodrigo", "Conibere", 129929));
            listaUsuariosRegistrados.Add(new Trabajador("denysesnib@gmail.com", "denyse123", "Denyse", "Snibson", 197857));
            listaUsuariosRegistrados.Add(new Trabajador("jarviseale@gmail.com", "jarvis123", "Jarvis", "Seale", 210080));

            //serializar a json
            ClaseSerializadora.EscribirUsuariosJson(listaUsuariosRegistrados, nombreArchivoUsuarios);*/
            listaUsuariosRegistrados = ClaseSerializadora.LeerListaUsuariosJson("Usuarios.json");
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string lineaLog;

            if (Verificadora.VerificarEscrituraEmail(txbEmail.Text) && Verificadora.VerificarEscrituraContrasenia(txbContrasenia.Text))
            {
                //analizo si se encuentra registrado en el json
                Usuario usurioRegistrado = Verificadora.VerificarUsuarioRegistrado(this.txbEmail.Text, this.txbContrasenia.Text);

                if (usurioRegistrado is not null)
                {
                    MessageBox.Show("El ingreso coincide con un registro");
                    if(usurioRegistrado is Comprador)
                    {
                        DateTime fechaActual = DateTime.Now;
                        string fechaFormateada = fechaActual.ToString("yyyy-MM-dd HH:mm:ss");
                        lineaLog = $"El comprador llamado: {usurioRegistrado.Nombre} {usurioRegistrado.Apellido}, con mail: {usurioRegistrado.Email} ,accedio al sistema a las: {fechaFormateada}";
                        ClaseSerializadora.EscribirArchivoLog(lineaLog);

                        FrmComprador frmComprador = new FrmComprador(usurioRegistrado);
                        frmComprador.ShowDialog();

                        if (frmComprador.DialogResult == DialogResult.Cancel)
                        {
                            this.DialogResult = DialogResult.Cancel;
                        }
                    }else if (usurioRegistrado is Trabajador)
                    {
                        DateTime fechaActual = DateTime.Now;
                        string fechaFormateada = fechaActual.ToString("yyyy-MM-dd HH:mm:ss");
                        lineaLog = $"El trabajador llamado: {usurioRegistrado.Nombre} {usurioRegistrado.Apellido}, con mail: {usurioRegistrado.Email} ,accedio al sistema a las: {fechaFormateada}";
                        ClaseSerializadora.EscribirArchivoLog(lineaLog);

                        FrmTrabajador frmComprador = new FrmTrabajador(usurioRegistrado);
                        frmComprador.ShowDialog();

                        if (frmComprador.DialogResult == DialogResult.Cancel)
                        {
                            this.DialogResult = DialogResult.Cancel;
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Usuario no registrado");
                }
            }
            else
            {
                MessageBox.Show("Error de formato en el ingreso del email o contrasenia");
            }
        }
        private void btnComprador_Click(object sender, EventArgs e)
        {
            this.txbEmail.Text = "laraine0@gmail.com";
            this.txbContrasenia.Text = "laraine123";
            //controlar que cada vez que se haga click no duplicar forms
        }
        private void btnTrabajador_Click(object sender, EventArgs e)
        {
            this.txbEmail.Text = "rodrigo9@gmail.com";
            this.txbContrasenia.Text = "rodri123";
        }

        private void FormIngreso_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Esta seguro de que desea cerrar la aplicacion?", "Confirmar cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
            
        }
    }
}
