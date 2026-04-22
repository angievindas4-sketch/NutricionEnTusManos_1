using NutricionEnTusManos_1.Controllers;

namespace NutricionEnTusManos_1.Views
{
    public partial class VistaLogin : Form
    {
        // Conexión con el controlador (MVC)
        private readonly ControladorLogin _controlador = new ControladorLogin();

        public VistaLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Captura de datos de la vista
            string user = txtUsuario.Text;
            string pass = txtPassword.Text;

            // El controlador decide si es válido
            if (_controlador.ValidarLogin(user, pass))
            {
                MessageBox.Show("¡Ingreso Exitoso!", "Nutrición en tus Manos");
                this.Hide(); // Esconde esta ventana
                VistaNutricion formNutri = new VistaNutricion();
                formNutri.Show(); // Abre la siguiente
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error");
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (_controlador.Registrar(txtUsuario.Text, txtPassword.Text))
                MessageBox.Show("Registrado correctamente.");
            else
                MessageBox.Show("El usuario ya existe.");
        }
    }
}
