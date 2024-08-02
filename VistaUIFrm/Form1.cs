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
            List<Usuario> listaUsuariosRegistrados;
            
            try
            {             
                string nombreArchivoUsuarios = "Usuarios.json";

                if (File.Exists(nombreArchivoUsuarios))
                {
                    listaUsuariosRegistrados = ClaseSerializadora.LeerListaUsuariosJson("Usuarios.json");
                }
                else
                {
                    listaUsuariosRegistrados = new List<Usuario>();
                    listaUsuariosRegistrados.Add(new Comprador(1,"laraine0@gmail.com", "laraine123", "Laraine", "Steade"));
                    listaUsuariosRegistrados.Add(new Comprador(2,"abdelttiero1@gmail.com", "abdel123", "Abdel", "Savattiero"));
                    listaUsuariosRegistrados.Add(new Comprador(3,"denny2@gmail.com", "denny123", "Denny", "Chug"));
                    listaUsuariosRegistrados.Add(new Comprador(4,"emmetf3@gmail.com", "Emet123", "Emmet", "Rolf"));

                    listaUsuariosRegistrados.Add(new Trabajador("rodrigo9@gmail.com", "rodri123", "Rodrigo", "Conibere", RolTrabajador.Administrador));
                    listaUsuariosRegistrados.Add(new Trabajador("denysesnib@gmail.com", "denyse123", "Denyse", "Snibson", RolTrabajador.Supervisor));
                    listaUsuariosRegistrados.Add(new Trabajador("jarviseale@gmail.com", "jarvis123", "Jarvis", "Seale", RolTrabajador.Vendedor));

                    //serializar a json
                    ClaseSerializadora.EscribirUsuariosJson(listaUsuariosRegistrados, nombreArchivoUsuarios);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al buscar el usuario.Intente mas tarde!");
            }
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string lineaLog;

            if (Verificadora.VerificarEscrituraEmail(txbEmail.Text) && Verificadora.VerificarEscrituraContrasenia(txbContrasenia.Text))
            {
                //analizo si se encuentra registrado en el json
                try
                {
                    Usuario usuarioRegistrado = Verificadora.VerificarUsuarioRegistrado(this.txbEmail.Text, this.txbContrasenia.Text);

                    if (usuarioRegistrado is not null)
                    {
                        if (usuarioRegistrado is Comprador)
                        {
                            DateTime fechaActual = DateTime.Now;
                            string fechaFormateada = fechaActual.ToString("yyyy-MM-dd HH:mm:ss");
                            lineaLog = $"El comprador llamado: {usuarioRegistrado.Nombre} {usuarioRegistrado.Apellido}, con mail: {usuarioRegistrado.Email} ,accedio al sistema a las: {fechaFormateada}";
                            try
                            {
                                ClaseSerializadora.EscribirArchivoLog(lineaLog);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Ocurrio un error al guardar el ingreso");
                            }
                            

                            FrmComprador frmComprador = new FrmComprador(usuarioRegistrado);
                            frmComprador.ShowDialog();

                            if (frmComprador.DialogResult == DialogResult.Cancel)
                            {
                                this.DialogResult = DialogResult.Cancel;
                            }
                        }
                        else if (usuarioRegistrado is Trabajador)
                        {
                            DateTime fechaActual = DateTime.Now;
                            string fechaFormateada = fechaActual.ToString("yyyy-MM-dd HH:mm:ss");
                            lineaLog = $"El trabajador {((Trabajador)usuarioRegistrado).Rol.ToString()} llamado: {usuarioRegistrado.Nombre} {usuarioRegistrado.Apellido}, con mail: {usuarioRegistrado.Email} ,accedio al sistema a las: {fechaFormateada}";
                            try
                            {
                                ClaseSerializadora.EscribirArchivoLog(lineaLog);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Ocurrio un error al guardar el ingreso");
                            }

                            FormTrabajador frmTrabajador = new FormTrabajador(usuarioRegistrado);
                            frmTrabajador.ShowDialog();

                            if (frmTrabajador.DialogResult == DialogResult.Cancel)
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
                catch (Exception)
                {
                    MessageBox.Show("Ocurrio un error al buscar el usuario.Intente mas tarde!");
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
