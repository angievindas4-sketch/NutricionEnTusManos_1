using System;
using System;
using System.Windows.Forms;
using NutricionEnTusManos_1.Controllers;
using NutricionEnTusManos_1.Models;

namespace NutricionEnTusManos_1.Views
{
    public partial class VistaRegistro : Form
    {
        private readonly ControladorLogin _controlador = new ControladorLogin();

        public string NivelActividad => comboNivelActividad.SelectedItem?.ToString() ?? "";

        public VistaRegistro()
        {
            InitializeComponent();
        }

        private void btnFinalizarRegistro_Click(object sender, EventArgs e)
        {
            // Validaciones de campos vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor ingresa tu nombre completo.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Por favor ingresa un nombre de usuario.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Por favor ingresa una contraseña.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor selecciona tu objetivo.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor selecciona tu tipo de dieta.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboNivelActividad.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor selecciona tu nivel de actividad física.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Determinar género seleccionado
            string genero = "No especificado";
            if (radioButton1.Checked) genero = "Masculino";
            else if (radioButton2.Checked) genero = "Femenino";
            else if (radioButton3.Checked) genero = "Otro";

            // Construir el objeto Usuario con todos los datos
            Usuario nuevoUsuario = new Usuario(
                txtUsuario.Text.Trim(),
                txtPassword.Text,
                (double)numPeso.Value,
                (double)numAltura.Value,
                (int)nunEdad.Value,
                comboNivelActividad.SelectedItem.ToString(),
                comboBox1.SelectedItem.ToString(),
                comboBox2.SelectedItem.ToString()
            );

            // Agregar campos adicionales
            nuevoUsuario.Sexo = genero;
            nuevoUsuario.NombreCompleto = txtNombre.Text.Trim();

            // Intentar registrar
            bool registrado = _controlador.Registrar(nuevoUsuario);

            if (registrado)
            {
                MessageBox.Show($"¡Registro exitoso! Bienvenido, {txtUsuario.Text}.",
                    "Registro completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("El nombre de usuario ya está en uso. Por favor elige otro.",
                    "Usuario existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void VistaRegistro_Load(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void groupBox4_Enter(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
