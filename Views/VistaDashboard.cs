using System;
using System.Windows.Forms;
using NutricionEnTusManos_1.Controllers;
using NutricionEnTusManos_1.Models;

namespace NutricionEnTusManos_1.Views
{
    public partial class VistaDashboard : Form
    {
        private readonly ControladorDashboard _controlador;
        private Usuario _usuarioActual;

        public VistaDashboard(Usuario usuario)
        {
            InitializeComponent();
            _usuarioActual = usuario;
            _controlador = new ControladorDashboard(_usuarioActual);

            // Esto pondrá el nombre del usuario en la barra superior de la ventana
            this.Text = "Dashboard Nutricional - " + _usuarioActual.NombreUsuario;
        }

        private void VistaDashboard_Load(object sender, EventArgs e)
        {
            // Aquí programaremos que se llenen los datos apenas abra la ventana
        }
    }
}