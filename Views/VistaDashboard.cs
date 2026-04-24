using System;
using System.Collections.Generic;
using System.Drawing; // Necesario para Pen, Brushes y Color
using System.Linq;
using System.Windows.Forms;
using NutricionEnTusManos_1.Controllers;
using NutricionEnTusManos_1.Models;

namespace NutricionEnTusManos_1.Views
{
    public partial class VistaDashboard : Form
    {
        private readonly ControladorDashboard _controlador;
        private Usuario _usuarioActual;

        // --- CONSTRUCTOR ÚNICO ---
        public VistaDashboard(Usuario usuario)
        {
            InitializeComponent();
            _usuarioActual = usuario;
            _controlador = new ControladorDashboard(_usuarioActual);

            this.Text = "Dashboard Nutricional - " + _usuarioActual.NombreUsuario;

            // Carga los datos apenas se crea la ventana
            CargarDatosDashboard();
        }

        // --- MÉTODO DE CARGA DE DATOS ---
        private void CargarDatosDashboard()
        {
            try
            {
                // 1. Datos del Perfil (Bloque izquierdo superior)
                lblNombre.Text = $"Usuario: {_usuarioActual.NombreUsuario}";
                lblPeso.Text = $"Peso: {_usuarioActual.Peso} kg";
                lblObjetivo.Text = $"Objetivo: {_usuarioActual.Objetivo}";
                lblDieta.Text = $"Plan: {_usuarioActual.TipoDieta}";

                // 2. Cálculo de Calorías y Macros
                var totales = _controlador.CalcularTotalesHoy();
                lblCaloriasCirculo.Text = $"{totales.cal}\n/ 2000 kcal";

                // Barras de progreso
                pbProteinas.Value = (int)Math.Min(totales.prot, 100);
                pbCarbohidratos.Value = (int)Math.Min(totales.carb, 100);
                pbGrasas.Value = (int)Math.Min(totales.grasa, 100);

                // 3. Tabla de consumidos (DataGridView)
                var consumidos = _controlador.ObtenerConsumoHoy();
                dgvMenuHoy.DataSource = null;
                dgvMenuHoy.DataSource = consumidos.SelectMany(m => m.Alimentos).ToList();

                // 4. CARGA DE LA LISTA DE SELECCIÓN (Estilo mejorado)
                var todosLosProductos = _controlador.BuscarAlimentos("");

                lstAlimentos.DataSource = null;

                if (todosLosProductos != null && todosLosProductos.Count > 0)
                {
                    lstAlimentos.DisplayMember = "Nombre";
                    lstAlimentos.ValueMember = "Nombre";
                    lstAlimentos.DataSource = todosLosProductos;

                    lstAlimentos.SelectedIndex = -1;
                    lstAlimentos.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos en el Dashboard: " + ex.Message);
            }
        }

        // --- DIBUJO PERSONALIZADO DE LA LISTA (Estilo App Moderna) ---
        private void lstAlimentos_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            // Dibujamos el fondo (cambia de color al seleccionar)
            e.DrawBackground();

            // Color de la línea divisoria sutil
            Pen pen = new Pen(Color.LightGray, 1);

            // Dibujamos el texto del alimento
            // Usamos un pequeño margen (X + 5, Y + 5) para que no esté pegado al borde
            string texto = ((Producto)lstAlimentos.Items[e.Index]).Nombre;
            e.Graphics.DrawString(texto, e.Font, Brushes.Black, e.Bounds.X + 5, e.Bounds.Y + 5);

            // Dibujamos la línea al fondo de cada celda para crear las divisiones
            e.Graphics.DrawLine(pen, e.Bounds.Left, e.Bounds.Bottom - 1, e.Bounds.Right, e.Bounds.Bottom - 1);

            e.DrawFocusRectangle();
        }

        // --- EVENTOS DE LA INTERFAZ ---
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
                CargarDatosDashboard();
                MessageBox.Show($"{alimentoSeleccionado.Nombre} añadido correctamente.");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un alimento de la lista primero.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
        }

        // Métodos auxiliares
        private void panelGestion_Paint(object sender, PaintEventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void VistaDashboard_Load(object sender, EventArgs e) { }
    }
}