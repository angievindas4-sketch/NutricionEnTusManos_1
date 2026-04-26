using System;
using System.Windows.Forms;
using NutricionEnTusManos_1.Models;

namespace NutricionEnTusManos_1.Views
{
    public partial class VistaProgreso : Form
    {
        private Usuario _usuarioActual;

        public VistaProgreso(Usuario usuario)
        {
            InitializeComponent();
            _usuarioActual = usuario;
        }

        private void gbEvolucion_Enter(object sender, EventArgs e) { }
    }
}