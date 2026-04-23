using NutricionEnTusManos_1.Controllers;
using NutricionEnTusManos_1.Models; // Agregamos esto para reconocer la clase Usuario

namespace NutricionEnTusManos_1.Views
{
    public partial class VistaLogin : Form
    {
        private readonly ControladorLogin _controlador = new ControladorLogin();

        public VistaLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string pass = txtPassword.Text;

            // 1. Buscamos el usuario en la base de datos (JSON)
            // Asumiremos que tu controlador tiene un método que devuelve el Usuario
            Usuario usuarioLogueado = _controlador.ObtenerUsuario(user, pass);

            if (usuarioLogueado != null)
            {
                MessageBox.Show($"¡Bienvenido {usuarioLogueado.NombreUsuario}!", "Nutrición en tus Manos");

                this.Hide();

                // 2. AQUÍ EL CAMBIO: Creamos el Dashboard y le pasamos el usuario
                VistaDashboard dash = new VistaDashboard(usuarioLogueado);
                dash.Show();
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