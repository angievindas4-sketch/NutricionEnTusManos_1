using System;
using System.Windows.Forms;
using NutricionEnTusManos_1.Controllers;
using NutricionEnTusManos_1.Models;

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
                string user = txtUsuario.Text.Trim();
                string pass = txtPassword.Text;

                if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
                {
                    MessageBox.Show("Por favor complete todos los campos.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Usuario usuarioLogueado = _controlador.ObtenerUsuario(user, pass);

                if (usuarioLogueado != null)
                {
                    this.Hide();
                    VistaDashboard dash = new VistaDashboard(usuarioLogueado);
                    dash.FormClosed += (s, args) => this.Close();
                    dash.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error de autenticación",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar ingresar: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            // Abre el formulario de registro completo
            VistaRegistro registro = new VistaRegistro();
            registro.ShowDialog();
        }
    }
}