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
            CargarDatosDashboard();
        }

        private void CargarDatosDashboard()
        {
            try
            {
                // Datos del perfil
                label1.Text = $"Nombre del Usuario: {_usuarioActual.NombreUsuario}";
                label2.Text = $"ID Usuario: {_usuarioActual.Id}";

                // Datos físicos
                label3.Text = $"PESO ACTUAL: {_usuarioActual.Peso} kg";
                label4.Text = $"ESTATURA: {_usuarioActual.Altura} cm";
                label5.Text = $"EDAD: {_usuarioActual.Edad} años";

                // IMC
                double imc = _controlador.CalcularIMC();
                label6.Text = $"IMC: {imc:F1}";
                lblSemaforoIMC.Text = $"{imc:F0}"; // sin decimales en el semáforo

                // Estado del IMC
                string estado = _controlador.ObtenerEstadoIMC(imc);
                label7.Text = $"({estado})";
                lblEstadoTexto.Text = $"Estado: {estado}";

                // Color del semáforo
                lblSemaforoIMC.BackColor = _controlador.ObtenerColorIMC(imc);

                // Barra de calorías
                double porcentaje = _controlador.ObtenerPorcentajeCaloriasHoy();
                pbCaloriasDiarias.Value = (int)Math.Min(porcentaje, 100);
                lblPorcentajeCalorias.Text = $"{porcentaje:F0}% DE TU META DIARIA CONSUMIDA";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        // --- BOTONES DEL MENÚ LATERAL ---
        private void button2_Click(object sender, EventArgs e)
        {
            // MI PERFIL - por ahora muestra datos en un MessageBox
            MessageBox.Show(
                $"Nombre: {_usuarioActual.NombreCompleto}\n" +
                $"Usuario: {_usuarioActual.NombreUsuario}\n" +
                $"Peso: {_usuarioActual.Peso} kg\n" +
                $"Altura: {_usuarioActual.Altura} cm\n" +
                $"Edad: {_usuarioActual.Edad} años\n" +
                $"Sexo: {_usuarioActual.Sexo}\n" +
                $"Objetivo: {_usuarioActual.Objetivo}\n" +
                $"Dieta: {_usuarioActual.TipoDieta}\n" +
                $"Nivel de actividad: {_usuarioActual.NivelActividad}",
                "Mi Perfil");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // PLAN ALIMENTICIO
            VistaPlanAlimenticio plan = new VistaPlanAlimenticio(_usuarioActual);
            plan.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // LISTA DE ALIMENTOS
            VistaListaAlimentos lista = new VistaListaAlimentos();
            lista.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // MI PROGRESO
            VistaProgreso progreso = new VistaProgreso(_usuarioActual);
            progreso.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // CERRAR SESIÓN
            var confirmar = MessageBox.Show("¿Seguro que deseas cerrar sesión?",
                "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void VistaDashboard_Load(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
    }
}