using System;
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
                label1.Text = $"Nombre del Usuario: {_usuarioActual.NombreUsuario}";
                label2.Text = $"ID Usuario: {_usuarioActual.Id}";
                label3.Text = $"PESO ACTUAL: {_usuarioActual.Peso} kg";
                label4.Text = $"ESTATURA: {_usuarioActual.Altura} cm";
                label5.Text = $"EDAD: {_usuarioActual.Edad} años";

                double imc = _controlador.CalcularIMC();
                label6.Text = $"IMC: {imc:F1}";
                lblSemaforoIMC.Text = $"{imc:F0}";

                string estado = _controlador.ObtenerEstadoIMC(imc);
                label7.Text = $"({estado})";
                lblEstadoTexto.Text = $"Estado: {estado}";

                lblSemaforoIMC.BackColor = _controlador.ObtenerColorIMC(imc);

                double porcentaje = _controlador.ObtenerPorcentajeCaloriasHoy();
                pbCaloriasDiarias.Value = (int)Math.Min(porcentaje, 100);
                lblPorcentajeCalorias.Text = $"{porcentaje:F0}% DE TU META DIARIA CONSUMIDA";

                // Meta calórica dinámica según perfil del usuario
                label9.Text = $"META DIARIA: {_controlador.ObtenerMetaCaloriasDiaria():F0} KCAL";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frmPerfil = new Form
            {
                Text = "Actualizar Perfil",
                Size = new System.Drawing.Size(400, 560),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false
            };

            var lblPeso = new Label { Text = "Peso actual (kg):", Location = new System.Drawing.Point(20, 20), AutoSize = true };
            var numPeso = new NumericUpDown { Location = new System.Drawing.Point(20, 45), Size = new System.Drawing.Size(340, 30), Minimum = 30, Maximum = 300, DecimalPlaces = 1, Value = (decimal)_usuarioActual.Peso };
            var lblAltura = new Label { Text = "Altura (cm):", Location = new System.Drawing.Point(20, 85), AutoSize = true };
            var numAltura = new NumericUpDown { Location = new System.Drawing.Point(20, 110), Size = new System.Drawing.Size(340, 30), Minimum = 100, Maximum = 250, Value = (decimal)_usuarioActual.Altura };
            var lblObjetivo = new Label { Text = "Objetivo:", Location = new System.Drawing.Point(20, 150), AutoSize = true };
            var cmbObjetivo = new ComboBox { Location = new System.Drawing.Point(20, 175), Size = new System.Drawing.Size(340, 30) };
            cmbObjetivo.Items.AddRange(new object[] { "Ganar Masa", "Perder Peso", "Mantener" });
            cmbObjetivo.SelectedItem = _usuarioActual.Objetivo;
            var lblDieta = new Label { Text = "Tipo de dieta:", Location = new System.Drawing.Point(20, 215), AutoSize = true };
            var cmbDieta = new ComboBox { Location = new System.Drawing.Point(20, 240), Size = new System.Drawing.Size(340, 30) };
            cmbDieta.Items.AddRange(new object[] { "Estándar", "Vegetariana", "Keto" });
            cmbDieta.SelectedItem = _usuarioActual.TipoDieta;
            var lblNivel = new Label { Text = "Nivel de actividad:", Location = new System.Drawing.Point(20, 280), AutoSize = true };
            var cmbNivel = new ComboBox { Location = new System.Drawing.Point(20, 305), Size = new System.Drawing.Size(340, 30) };
            cmbNivel.Items.AddRange(new object[] { "Sedentario", "Ligero (1-3 días/semana)", "Moderado (3-5 días/semana)", "Activo (6-7 días/semana)", "Muy activo (atleta)" });
            cmbNivel.SelectedItem = _usuarioActual.NivelActividad;
            var lblPesoMeta = new Label { Text = "Peso meta (kg):", Location = new System.Drawing.Point(20, 345), AutoSize = true };
            var numPesoMeta = new NumericUpDown { Location = new System.Drawing.Point(20, 370), Size = new System.Drawing.Size(340, 30), Minimum = 30, Maximum = 300, DecimalPlaces = 1, Value = (decimal)(_usuarioActual.PesoMeta > 0 ? _usuarioActual.PesoMeta : _usuarioActual.Peso) };
            var btnGuardar = new Button { Text = "GUARDAR CAMBIOS", Location = new System.Drawing.Point(100, 430), Size = new System.Drawing.Size(200, 40) };

            btnGuardar.Click += (s, ev) =>
            {
                _usuarioActual.Peso = (double)numPeso.Value;
                _usuarioActual.Altura = (double)numAltura.Value;
                _usuarioActual.Objetivo = cmbObjetivo.SelectedItem?.ToString() ?? _usuarioActual.Objetivo;
                _usuarioActual.TipoDieta = cmbDieta.SelectedItem?.ToString() ?? _usuarioActual.TipoDieta;
                _usuarioActual.NivelActividad = cmbNivel.SelectedItem?.ToString() ?? _usuarioActual.NivelActividad;
                _usuarioActual.PesoMeta = (double)numPesoMeta.Value;

                var controladorUsuario = new ControladorUsuario();
                controladorUsuario.ActualizarUsuario(_usuarioActual);

                MessageBox.Show("Perfil actualizado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmPerfil.Close();
                CargarDatosDashboard();
            };

            frmPerfil.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                lblPeso, numPeso, lblAltura, numAltura,
                lblObjetivo, cmbObjetivo, lblDieta, cmbDieta,
                lblNivel, cmbNivel, lblPesoMeta, numPesoMeta, btnGuardar
            });

            frmPerfil.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                $"Nombre: {_usuarioActual.NombreCompleto}\n" +
                $"Usuario: {_usuarioActual.NombreUsuario}\n" +
                $"Peso: {_usuarioActual.Peso} kg\n" +
                $"Peso meta: {_usuarioActual.PesoMeta} kg\n" +
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
            VistaPlanAlimenticio plan = new VistaPlanAlimenticio(_usuarioActual);
            plan.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VistaListaAlimentos lista = new VistaListaAlimentos();
            lista.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VistaProgreso progreso = new VistaProgreso(_usuarioActual);
            progreso.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var confirmar = MessageBox.Show("¿Seguro que deseas cerrar sesión?",
                "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmar == DialogResult.Yes)
                this.Close();
        }

        private void VistaDashboard_Load(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
    }
}