using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NutricionEnTusManos_1.Controllers;
using NutricionEnTusManos_1.Models;

namespace NutricionEnTusManos_1.Views
{
    public partial class VistaPlanAlimenticio : Form
    {
        private readonly ControladorAlimentos _controladorAlimentos;
        private readonly ControladorMenu _controladorMenu;
        private Usuario _usuarioActual;
        private string _tiempoSeleccionado = "Desayuno";
        private List<Producto> _resultadosBusqueda = new List<Producto>();

        // ListBox para sugerencias en tiempo real
        private ListBox _listaSugerencias;

        public VistaPlanAlimenticio(Usuario usuario)
        {
            InitializeComponent();
            _usuarioActual = usuario;
            _controladorAlimentos = new ControladorAlimentos();
            _controladorMenu = new ControladorMenu(_usuarioActual);
            dtpFechaPlan.Value = DateTime.Today;
            SeleccionarTiempo("Desayuno");
            CargarPlanDelDia();
            ConfigurarBusquedaEnTiempoReal();
        }

        /// <summary>
        /// Configura el ListBox de sugerencias flotante debajo del TextBox
        /// </summary>
        private void ConfigurarBusquedaEnTiempoReal()
        {
            _listaSugerencias = new ListBox
            {
                Location = new System.Drawing.Point(
                    txtBuscarAlimento.Left + gbBusqueda.Left,
                    txtBuscarAlimento.Bottom + gbBusqueda.Top + 30),
                Size = new System.Drawing.Size(txtBuscarAlimento.Width, 150),
                Visible = false,
                Font = new System.Drawing.Font("Segoe UI", 9F)
            };

            this.Controls.Add(_listaSugerencias);
            _listaSugerencias.BringToFront();

            // Evento mientras escribe
            txtBuscarAlimento.TextChanged += (s, e) =>
            {
                string texto = txtBuscarAlimento.Text.Trim();
                if (string.IsNullOrWhiteSpace(texto))
                {
                    _listaSugerencias.Visible = false;
                    return;
                }

                var resultados = _controladorAlimentos.Buscar(texto);
                _listaSugerencias.Items.Clear();

                foreach (var p in resultados.Take(8))
                    _listaSugerencias.Items.Add(p.Nombre);

                _listaSugerencias.Visible = _listaSugerencias.Items.Count > 0;
            };

            // Al seleccionar una sugerencia
            _listaSugerencias.Click += (s, e) =>
            {
                if (_listaSugerencias.SelectedItem == null) return;
                txtBuscarAlimento.Text = _listaSugerencias.SelectedItem.ToString();
                _listaSugerencias.Visible = false;
            };
        }

        private void SeleccionarTiempo(string tiempo)
        {
            _tiempoSeleccionado = tiempo;
            btnDesayuno.BackColor = tiempo == "Desayuno" ? System.Drawing.Color.LightGreen : System.Drawing.SystemColors.Control;
            btnAlmuerzo.BackColor = tiempo == "Almuerzo" ? System.Drawing.Color.LightGreen : System.Drawing.SystemColors.Control;
            btnCena.BackColor = tiempo == "Cena" ? System.Drawing.Color.LightGreen : System.Drawing.SystemColors.Control;
            btnMeriendas.BackColor = tiempo == "Merienda" ? System.Drawing.Color.LightGreen : System.Drawing.SystemColors.Control;
            CargarPlanDelDia();
        }

        private void CargarPlanDelDia()
        {
            try
            {
                var alimentos = _controladorMenu.ObtenerAlimentosPorTiempo(
                    dtpFechaPlan.Value.Date, _tiempoSeleccionado);

                dgvPlan.Rows.Clear();
                foreach (var p in alimentos)
                {
                    dgvPlan.Rows.Add(p.Nombre, $"{p.Cantidad} {p.UnidadMedida}", $"{p.Calorias * p.Cantidad:F0} kcal");
                }

                double total = alimentos.Sum(a => a.Calorias * a.Cantidad);
                lblTotalCalorias.Text = $"TOTAL CALORÍAS {_tiempoSeleccionado.ToUpper()}: {total:F0} kcal";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el plan: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string filtro = txtBuscarAlimento.Text.Trim();
                if (string.IsNullOrWhiteSpace(filtro))
                {
                    MessageBox.Show("Ingresa un nombre para buscar.", "Búsqueda",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                _resultadosBusqueda = _controladorAlimentos.Buscar(filtro);
                _listaSugerencias.Visible = false;

                if (_resultadosBusqueda.Count == 0)
                {
                    MessageBox.Show("No se encontraron alimentos.", "Sin resultados",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                MostrarResultadosBusqueda(_resultadosBusqueda);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void MostrarResultadosBusqueda(List<Producto> resultados)
        {
            Form frmResultados = new Form
            {
                Text = "Selecciona un alimento",
                Size = new System.Drawing.Size(700, 400),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false
            };

            var dgv = new DataGridView
            {
                Location = new System.Drawing.Point(10, 10),
                Size = new System.Drawing.Size(660, 280),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                AllowUserToAddRows = false,
                RowHeadersVisible = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false
            };

            dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre", DataPropertyName = "Nombre" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Medida", DataPropertyName = "UnidadMedida" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "kcal", DataPropertyName = "Calorias" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Proteínas", DataPropertyName = "Proteinas" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Carbos", DataPropertyName = "Carbohidratos" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Grasas", DataPropertyName = "Grasas" });
            dgv.DataSource = resultados;

            var btnAgregar = new Button
            {
                Text = "AGREGAR AL PLAN",
                Location = new System.Drawing.Point(250, 310),
                Size = new System.Drawing.Size(200, 40)
            };

            btnAgregar.Click += (s, ev) =>
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    var productoSeleccionado = resultados[dgv.SelectedRows[0].Index];

                    Form frmCantidad = new Form
                    {
                        Text = "Cantidad",
                        Size = new System.Drawing.Size(300, 150),
                        StartPosition = FormStartPosition.CenterParent,
                        FormBorderStyle = FormBorderStyle.FixedDialog,
                        MaximizeBox = false
                    };
                    var lblCant = new Label { Text = $"¿Cuántas unidades de {productoSeleccionado.Nombre}?", Location = new System.Drawing.Point(20, 15), AutoSize = true };
                    var numCant = new NumericUpDown { Location = new System.Drawing.Point(20, 45), Size = new System.Drawing.Size(100, 30), Minimum = 1, Maximum = 20, Value = 1 };
                    var btnOk = new Button { Text = "OK", Location = new System.Drawing.Point(130, 45), Size = new System.Drawing.Size(80, 30) };
                    btnOk.Click += (sb, eb) => frmCantidad.Close();
                    frmCantidad.Controls.AddRange(new System.Windows.Forms.Control[] { lblCant, numCant, btnOk });
                    frmCantidad.ShowDialog();

                    productoSeleccionado.Cantidad = (double)numCant.Value;

                    _controladorMenu.AgregarAlimento(
                        dtpFechaPlan.Value.Date,
                        _tiempoSeleccionado,
                        productoSeleccionado);

                    MessageBox.Show($"{productoSeleccionado.Nombre} x{productoSeleccionado.Cantidad} agregado al {_tiempoSeleccionado}.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmResultados.Close();
                    CargarPlanDelDia();
                }
                else
                {
                    MessageBox.Show("Selecciona un alimento de la lista.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };

            frmResultados.Controls.Add(dgv);
            frmResultados.Controls.Add(btnAgregar);
            frmResultados.ShowDialog();
        }

        private void dgvPlan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPlan.Columns["colAccion"].Index && e.RowIndex >= 0)
            {
                string nombreAlimento = dgvPlan.Rows[e.RowIndex].Cells["colAlimento"].Value?.ToString();
                if (string.IsNullOrEmpty(nombreAlimento)) return;

                var opcion = MessageBox.Show(
                    $"¿Qué deseas hacer con {nombreAlimento}?\n\nSí = Editar cantidad\nNo = Eliminar",
                    "Acción", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (opcion == DialogResult.Yes)
                {
                    Form frmEditar = new Form
                    {
                        Text = "Editar cantidad",
                        Size = new System.Drawing.Size(300, 150),
                        StartPosition = FormStartPosition.CenterParent,
                        FormBorderStyle = FormBorderStyle.FixedDialog,
                        MaximizeBox = false
                    };

                    var lbl = new Label { Text = $"Nueva cantidad para {nombreAlimento}:", Location = new System.Drawing.Point(20, 15), AutoSize = true };
                    var numCant = new NumericUpDown { Location = new System.Drawing.Point(20, 45), Size = new System.Drawing.Size(100, 30), Minimum = 1, Maximum = 50, Value = 1 };
                    var btnOk = new Button { Text = "GUARDAR", Location = new System.Drawing.Point(130, 45), Size = new System.Drawing.Size(100, 30) };

                    btnOk.Click += (s, ev) =>
                    {
                        _controladorMenu.ActualizarCantidadAlimento(
                            dtpFechaPlan.Value.Date,
                            _tiempoSeleccionado,
                            nombreAlimento,
                            (double)numCant.Value);

                        frmEditar.Close();
                        CargarPlanDelDia();
                    };

                    frmEditar.Controls.AddRange(new System.Windows.Forms.Control[] { lbl, numCant, btnOk });
                    frmEditar.ShowDialog();
                }
                else if (opcion == DialogResult.No)
                {
                    var confirmar = MessageBox.Show($"¿Eliminar {nombreAlimento} del plan?",
                        "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmar == DialogResult.Yes)
                    {
                        _controladorMenu.EliminarAlimento(
                            dtpFechaPlan.Value.Date, _tiempoSeleccionado, nombreAlimento);
                        CargarPlanDelDia();
                    }
                }
            }
        }

        private void btnDesayuno_Click(object sender, EventArgs e) => SeleccionarTiempo("Desayuno");
        private void btnAlmuerzo_Click(object sender, EventArgs e) => SeleccionarTiempo("Almuerzo");
        private void btnCena_Click(object sender, EventArgs e) => SeleccionarTiempo("Cena");
        private void btnMeriendas_Click(object sender, EventArgs e) => SeleccionarTiempo("Merienda");
        private void dtpFechaPlan_ValueChanged(object sender, EventArgs e) => CargarPlanDelDia();
        private void btnVolver_Click(object sender, EventArgs e) => this.Close();
        private void label1_Click(object sender, EventArgs e) { }
    }
}