using System;
using System.Collections.Generic;
using System.Linq; // Necesario para SelectMany
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

            this.Text = "Dashboard Nutricional - " + _usuarioActual.NombreUsuario;

            // LLAMADA INICIAL: Carga los datos apenas se crea la ventana
            CargarDatosDashboard();
        }

        // ESTE ES EL MÉTODO QUE TE FALTABA
        private void CargarDatosDashboard()
        {
            try
            {
                // 1. Datos del Perfil (Bloque 1)
                lblNombre.Text = $"Usuario: {_usuarioActual.NombreUsuario}";
                lblPeso.Text = $"Peso: {_usuarioActual.Peso} kg";
                lblObjetivo.Text = $"Objetivo: {_usuarioActual.Objetivo}";
                lblDieta.Text = $"Plan: {_usuarioActual.TipoDieta}";

                // 2. Cálculo de Calorías y Macros (Bloque 2)
                var totales = _controlador.CalcularTotalesHoy();

                // Actualizamos el número central (Asumiendo meta de 2000)
                lblCaloriasCirculo.Text = $"{totales.cal}\n/ 2000 kcal";

                // Actualizamos las barras (Asegúrate que pbProteinas, etc., sean los nombres correctos)
                // Usamos 100 como meta base para el progreso de la barra
                pbProteinas.Value = (int)Math.Min(totales.prot, 100);
                pbCarbohidratos.Value = (int)Math.Min(totales.carb, 100);
                pbGrasas.Value = (int)Math.Min(totales.grasa, 100);

                // 3. Llenar la tabla de comidas (Bloque 3)
                var consumidos = _controlador.ObtenerConsumoHoy();
                dgvMenuHoy.DataSource = null;
                // SelectMany aplana la lista de productos de todos los menús de hoy
                dgvMenuHoy.DataSource = consumidos.SelectMany(m => m.Alimentos).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var resultados = _controlador.BuscarAlimentos(txtBuscar.Text);
                lstAlimentos.DataSource = null;
                lstAlimentos.DataSource = resultados;
                lstAlimentos.DisplayMember = "Nombre";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (lstAlimentos.SelectedItem is Producto alimentoSeleccionado)
            {
                _controlador.AgregarAlimentoAlMenu(alimentoSeleccionado);

                // Ahora sí, este método ya existe abajo y refrescará la pantalla
                CargarDatosDashboard();

                MessageBox.Show($"{alimentoSeleccionado.Nombre} añadido correctamente.");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un alimento de la lista primero.");
            }
        }

        private void panelGestion_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}