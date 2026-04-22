using System;
using System.Windows.Forms;
using NutricionEnTusManos_1.Controllers; // Importante para reconocer el controlador

namespace NutricionEnTusManos_1.Views
{
    public partial class VistaNutricion : Form
    {
        // AQUÍ ES DONDE SE AGREGA LA LÍNEA:
        // Creamos una instancia del controlador para usarla en toda la ventana
        private readonly ControladorNutricion _controlador = new ControladorNutricion();

        public VistaNutricion()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validaciones básicas
                if (string.IsNullOrWhiteSpace(txtPeso.Text) || string.IsNullOrWhiteSpace(txtEdad.Text))
                {
                    MessageBox.Show("Por favor, complete peso y edad.");
                    return;
                }

                if (cmbObjetivo.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, seleccione un objetivo.");
                    return;
                }

                // 2. Captura de datos
                double peso = double.Parse(txtPeso.Text);
                int edad = int.Parse(txtEdad.Text);

                // Index 0 + 1 = 1 (Mantener)
                // Index 1 + 1 = 2 (Perder)
                // Index 2 + 1 = 3 (Ganar)
                int opcion = cmbObjetivo.SelectedIndex + 1;

                // 3. Llamada al controlador (aquí usamos la variable _controlador)
                string resultado = _controlador.ObtenerPlan(opcion, peso, edad);

                // 4. Mostrar resultado
                lblResultado.Text = resultado;
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese números válidos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}