using System;
using System.Windows.Forms;
using NutricionEnTusManos_1.Controllers;
using NutricionEnTusManos_1.Models; // Necesario para reconocer la clase Usuario

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
            try
            {
                string user = txtUsuario.Text;
                string pass = txtPassword.Text;

                if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Atención");
                    return;
                }

                // 1. Buscamos el usuario a través del controlador
                Usuario usuarioLogueado = _controlador.ObtenerUsuario(user, pass);

                if (usuarioLogueado != null)
                {
                    MessageBox.Show($"¡Bienvenido {usuarioLogueado.NombreUsuario}!", "Nutrición en tus Manos");

                    // 2. Ocultamos el login para que no quede estorbando
                    this.Hide();

                    // --- CAMBIO CLAVE AQUÍ ---
                    // Reemplazamos VistaNutricion por VistaDashboard que es tu nueva ventana principal
                    VistaDashboard dash = new VistaDashboard(usuarioLogueado);

                    // Suscribirse al evento FormClosed para cerrar la app completa si cierran el dash
                    dash.FormClosed += (s, args) => this.Close();

                    dash.Show();
                    // -------------------------
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Autenticación");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar ingresar: " + ex.Message);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Debe ingresar un usuario y contraseña para registrarse.");
                return;
            }

            if (_controlador.Registrar(txtUsuario.Text, txtPassword.Text))
            {
                MessageBox.Show("Registrado correctamente. Ahora puede iniciar sesión.");
            }
            else
            {
                MessageBox.Show("El usuario ya existe o no se pudo guardar.");
            }
        }
    }
}