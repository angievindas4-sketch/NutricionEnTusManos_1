using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NutricionEnTusManos_1.Controllers;
using NutricionEnTusManos_1.Models;

namespace NutricionEnTusManos_1.Views
{
    public partial class VistaProgreso : Form
    {
        private Usuario _usuarioActual;
        private readonly ControladorDashboard _controladorDashboard;
        private readonly ControladorMenu _controladorMenu;

        public VistaProgreso(Usuario usuario)
        {
            InitializeComponent();
            _usuarioActual = usuario;
            _controladorDashboard = new ControladorDashboard(_usuarioActual);
            _controladorMenu = new ControladorMenu(_usuarioActual);
            ConfigurarTablaHistorial();
            CargarDatos();
        }

        private void ConfigurarTablaHistorial()
        {
            dgvHistorial.Columns.Clear();
            dgvHistorial.AutoGenerateColumns = false;
            dgvHistorial.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Fecha", Name = "colFecha", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvHistorial.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tiempo", Name = "colTiempo", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvHistorial.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Alimentos", Name = "colAlimentos", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvHistorial.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Calorías", Name = "colCalorias", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvHistorial.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Proteínas (g)", Name = "colProteinas", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvHistorial.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Carbos (g)", Name = "colCarbos", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvHistorial.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Grasas (g)", Name = "colGrasas", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvHistorial.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Meta cumplida", Name = "colMeta", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
        }

        private void CargarDatos()
        {
            try
            {
                lblPesoActual.Text = $"{_usuarioActual.Peso} kg";

                double pesoInicial = _usuarioActual.PesoInicial > 0
                    ? _usuarioActual.PesoInicial
                    : _usuarioActual.Peso;

                double cambioTotal = _usuarioActual.Peso - pesoInicial;

                lblLogroSemana.Text = cambioTotal <= 0
                    ? $"Logro: {cambioTotal:F1} kg"
                    : $"Logro: +{cambioTotal:F1} kg";
                lblLogroSemana.ForeColor = cambioTotal <= 0
                    ? System.Drawing.Color.ForestGreen
                    : System.Drawing.Color.OrangeRed;

                double pesoMeta = _usuarioActual.PesoMeta > 0
                    ? _usuarioActual.PesoMeta
                    : (_usuarioActual.Objetivo == "Perder Peso" ? _usuarioActual.Peso - 10 :
                       _usuarioActual.Objetivo == "Ganar Masa" ? _usuarioActual.Peso + 10 :
                       _usuarioActual.Peso);

                lblPesoMeta.Text = $"{pesoMeta:F1} kg";
                double faltan = Math.Abs(_usuarioActual.Peso - pesoMeta);

                if (Math.Abs(_usuarioActual.Peso - pesoMeta) < 0.5)
                {
                    lblFaltan.Text = "¡Meta alcanzada!";
                    lblFaltan.ForeColor = System.Drawing.Color.ForestGreen;
                }
                else
                {
                    lblFaltan.Text = $"Faltan: {faltan:F1} kg";
                    lblFaltan.ForeColor = System.Drawing.Color.DodgerBlue;
                }

                lblKilosTotales.Text = $"{cambioTotal:F1} kg";
                lblKilosTotales.ForeColor = cambioTotal <= 0
                    ? System.Drawing.Color.DarkGreen
                    : System.Drawing.Color.OrangeRed;
                lblDesdeInicio.Text = $"(desde Peso Inicial: {pesoInicial:F1} kg)";

                if (pesoInicial != pesoMeta)
                {
                    double totalKg = Math.Abs(pesoInicial - pesoMeta);
                    double progreso = Math.Abs(cambioTotal) / totalKg * 100;
                    pbProgresoMeta.Value = (int)Math.Min(progreso, 100);
                }
                else
                {
                    pbProgresoMeta.Value = 100;
                }

                var totalesHoy = _controladorDashboard.CalcularTotalesHoy();
                double metaCalorias = CalcularMetaCalorias();
                lblDetalleNutricion.Text =
                    $"Calorías hoy: {totalesHoy.cal:F0} kcal\n" +
                    $"Proteínas: {totalesHoy.prot:F1}g\n" +
                    $"Carbohidratos: {totalesHoy.carb:F1}g\n" +
                    $"Grasas: {totalesHoy.grasa:F1}g\n" +
                    $"Meta: {metaCalorias:F0} kcal\n" +
                    $"Faltan: {Math.Max(0, metaCalorias - totalesHoy.cal):F0} kcal";

                lblDetalleEjercicio.Text =
                    $"Nivel: {_usuarioActual.NivelActividad}\n" +
                    $"Objetivo: {_usuarioActual.Objetivo}\n" +
                    $"Dieta: {_usuarioActual.TipoDieta}\n\n" +
                    $"{ObtenerRecomendacion()}";

                lblDetalleAgua.Text =
                    $"Meta diaria: 8 vasos\n" +
                    $"Recuerda mantenerte\n" +
                    $"hidratado todo el día.\n\n" +
                    $"El agua ayuda a {(_usuarioActual.Objetivo == "Perder Peso" ? "quemar grasa" : _usuarioActual.Objetivo == "Ganar Masa" ? "recuperar músculo" : "mantener el metabolismo")}.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime desde = dtpDesde.Value.Date;
                DateTime hasta = dtpHasta.Value.Date;

                if (desde > hasta)
                {
                    MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha final.",
                        "Error de fechas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double metaCalorias = CalcularMetaCalorias();
                dgvHistorial.Rows.Clear();

                int diasCumplidos = 0;
                int totalDias = 0;

                for (DateTime fecha = desde; fecha <= hasta; fecha = fecha.AddDays(1))
                {
                    var menusDia = _controladorMenu.ObtenerMenuDelDia(fecha);
                    if (menusDia.Count == 0) continue;

                    totalDias++;
                    double calDia = 0, protDia = 0, carbDia = 0, grasaDia = 0;

                    foreach (var menu in menusDia)
                    {
                        string alimentos = string.Join(", ", menu.Alimentos.Select(a => a.Nombre));
                        double calMenu = menu.Alimentos.Sum(a => a.Calorias * a.Cantidad);
                        double protMenu = menu.Alimentos.Sum(a => a.Proteinas * a.Cantidad);
                        double carbMenu = menu.Alimentos.Sum(a => a.Carbohidratos * a.Cantidad);
                        double grasaMenu = menu.Alimentos.Sum(a => a.Grasas * a.Cantidad);

                        calDia += calMenu;
                        protDia += protMenu;
                        carbDia += carbMenu;
                        grasaDia += grasaMenu;

                        dgvHistorial.Rows.Add(
                            fecha.ToString("dd/MM/yyyy"),
                            menu.TiempoComida,
                            alimentos,
                            $"{calMenu:F0} kcal",
                            $"{protMenu:F1}g",
                            $"{carbMenu:F1}g",
                            $"{grasaMenu:F1}g",
                            ""
                        );
                    }

                    bool cumplioMeta = calDia >= metaCalorias * 0.9 && calDia <= metaCalorias * 1.1;
                    if (cumplioMeta) diasCumplidos++;

                    dgvHistorial.Rows.Add(
                        $"TOTAL {fecha:dd/MM}",
                        "---",
                        "---",
                        $"{calDia:F0} kcal",
                        $"{protDia:F1}g",
                        $"{carbDia:F1}g",
                        $"{grasaDia:F1}g",
                        cumplioMeta ? "✅ Sí" : "❌ No"
                    );

                    var ultimaFila = dgvHistorial.Rows[dgvHistorial.Rows.Count - 1];
                    ultimaFila.DefaultCellStyle.BackColor = cumplioMeta
                        ? System.Drawing.Color.LightGreen
                        : System.Drawing.Color.MistyRose;
                    ultimaFila.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
                }

                if (totalDias > 0)
                    lblResumenHistorial.Text =
                        $"Período: {desde:dd/MM/yyyy} — {hasta:dd/MM/yyyy} | " +
                        $"Días con registro: {totalDias} | " +
                        $"Días que cumpliste la meta: {diasCumplidos}/{totalDias} " +
                        $"({(double)diasCumplidos / totalDias * 100:F0}%)";
                else
                    lblResumenHistorial.Text = "No hay registros en ese período.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar historial: " + ex.Message);
            }
        }

        private double CalcularMetaCalorias()
        {
            double tmb;
            if (_usuarioActual.Sexo == "Masculino")
                tmb = 10 * _usuarioActual.Peso + 6.25 * _usuarioActual.Altura - 5 * _usuarioActual.Edad + 5;
            else
                tmb = 10 * _usuarioActual.Peso + 6.25 * _usuarioActual.Altura - 5 * _usuarioActual.Edad - 161;

            double factor = _usuarioActual.NivelActividad switch
            {
                "Sedentario" => 1.2,
                "Ligero (1-3 días/semana)" => 1.375,
                "Moderado (3-5 días/semana)" => 1.55,
                "Activo (6-7 días/semana)" => 1.725,
                "Muy activo (atleta)" => 1.9,
                _ => 1.2
            };

            double tdee = tmb * factor;

            return _usuarioActual.Objetivo switch
            {
                "Perder Peso" => tdee - 500,
                "Ganar Masa" => tdee + 300,
                _ => tdee
            };
        }

        private string ObtenerRecomendacion()
        {
            if (_usuarioActual.Objetivo == "Perder Peso")
                return "Tip: Combina cardio con\ndeficit calórico moderado.";
            if (_usuarioActual.Objetivo == "Ganar Masa")
                return "Tip: Prioriza proteína y\nentrenamiento de fuerza.";
            return "Tip: Mantén consistencia\nen tu alimentación.";
        }

        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            CargarDatos();
            MessageBox.Show("Datos actualizados correctamente.", "Actualizar",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVolver_Click(object sender, EventArgs e) => this.Close();
        private void gbEvolucion_Enter(object sender, EventArgs e) { }
    }
}