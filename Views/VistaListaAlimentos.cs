using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NutricionEnTusManos_1.Controllers;
using NutricionEnTusManos_1.Models;

namespace NutricionEnTusManos_1.Views
{
    public partial class VistaListaAlimentos : Form
    {
        private readonly ControladorAlimentos _controlador;
        private List<Producto> _todosLosProductos;

        public VistaListaAlimentos()
        {
            InitializeComponent();
            _controlador = new ControladorAlimentos();
            ConfigurarTabla();
            CargarProductos();
            dgvCatalogo.CellClick += dgvCatalogo_CellClick;
        }

        private void ConfigurarTabla()
        {
            dgvCatalogo.Columns.Clear();
            dgvCatalogo.AutoGenerateColumns = false;

            dgvCatalogo.Columns.Add(new DataGridViewTextBoxColumn { Name = "colNombre", HeaderText = "Alimento", DataPropertyName = "Nombre", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvCatalogo.Columns.Add(new DataGridViewTextBoxColumn { Name = "colUnidad", HeaderText = "Medida", DataPropertyName = "UnidadMedida", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvCatalogo.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCalorias", HeaderText = "kcal", DataPropertyName = "Calorias", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvCatalogo.Columns.Add(new DataGridViewTextBoxColumn { Name = "colProteinas", HeaderText = "Proteínas (g)", DataPropertyName = "Proteinas", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvCatalogo.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCarbos", HeaderText = "Carbos (g)", DataPropertyName = "Carbohidratos", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvCatalogo.Columns.Add(new DataGridViewTextBoxColumn { Name = "colGrasas", HeaderText = "Grasas (g)", DataPropertyName = "Grasas", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvCatalogo.Columns.Add(new DataGridViewButtonColumn { Name = "colEditar", HeaderText = "Editar", Text = "✏️ Editar", UseColumnTextForButtonValue = true, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvCatalogo.Columns.Add(new DataGridViewButtonColumn { Name = "colEliminar", HeaderText = "Eliminar", Text = "🗑️ Eliminar", UseColumnTextForButtonValue = true, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
        }

        private void CargarProductos()
        {
            try
            {
                _todosLosProductos = _controlador.ObtenerTodos();
                MostrarEnTabla(_todosLosProductos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarEnTabla(List<Producto> productos)
        {
            dgvCatalogo.DataSource = null;
            dgvCatalogo.DataSource = productos;
        }

        private void dgvCatalogo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string nombreAlimento = dgvCatalogo.Rows[e.RowIndex].Cells["colNombre"].Value?.ToString();
            if (string.IsNullOrEmpty(nombreAlimento)) return;

            var producto = _todosLosProductos.FirstOrDefault(p => p.Nombre == nombreAlimento);
            if (producto == null) return;

            if (e.ColumnIndex == dgvCatalogo.Columns["colEliminar"].Index)
            {
                var confirmar = MessageBox.Show($"¿Eliminar {nombreAlimento}?",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmar == DialogResult.Yes)
                {
                    _controlador.EliminarProducto(nombreAlimento);
                    CargarProductos();
                }
            }
            else if (e.ColumnIndex == dgvCatalogo.Columns["colEditar"].Index)
            {
                Form frmEditar = new Form
                {
                    Text = "Editar alimento",
                    Size = new System.Drawing.Size(400, 400),
                    StartPosition = FormStartPosition.CenterParent,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    MaximizeBox = false
                };

                var lblNombre = new Label { Text = "Nombre:", Location = new System.Drawing.Point(20, 20), AutoSize = true };
                var txtNombre = new TextBox { Location = new System.Drawing.Point(20, 45), Size = new System.Drawing.Size(340, 30), Text = producto.Nombre, ReadOnly = true };
                var lblUnidad = new Label { Text = "Unidad:", Location = new System.Drawing.Point(20, 85), AutoSize = true };
                var txtUnidad = new TextBox { Location = new System.Drawing.Point(20, 110), Size = new System.Drawing.Size(340, 30), Text = producto.UnidadMedida };
                var lblCal = new Label { Text = "Calorías:", Location = new System.Drawing.Point(20, 150), AutoSize = true };
                var numCal = new NumericUpDown { Location = new System.Drawing.Point(20, 175), Size = new System.Drawing.Size(150, 30), Maximum = 9999, DecimalPlaces = 1, Value = (decimal)producto.Calorias };
                var lblProt = new Label { Text = "Proteínas (g):", Location = new System.Drawing.Point(200, 150), AutoSize = true };
                var numProt = new NumericUpDown { Location = new System.Drawing.Point(200, 175), Size = new System.Drawing.Size(150, 30), Maximum = 999, DecimalPlaces = 1, Value = (decimal)producto.Proteinas };
                var lblCarb = new Label { Text = "Carbohidratos (g):", Location = new System.Drawing.Point(20, 215), AutoSize = true };
                var numCarb = new NumericUpDown { Location = new System.Drawing.Point(20, 240), Size = new System.Drawing.Size(150, 30), Maximum = 999, DecimalPlaces = 1, Value = (decimal)producto.Carbohidratos };
                var lblGrasa = new Label { Text = "Grasas (g):", Location = new System.Drawing.Point(200, 215), AutoSize = true };
                var numGrasa = new NumericUpDown { Location = new System.Drawing.Point(200, 240), Size = new System.Drawing.Size(150, 30), Maximum = 999, DecimalPlaces = 1, Value = (decimal)producto.Grasas };
                var btnGuardar = new Button { Text = "GUARDAR", Location = new System.Drawing.Point(120, 300), Size = new System.Drawing.Size(150, 40) };

                btnGuardar.Click += (s, ev) =>
                {
                    producto.UnidadMedida = txtUnidad.Text.Trim();
                    producto.Calorias = (double)numCal.Value;
                    producto.Proteinas = (double)numProt.Value;
                    producto.Carbohidratos = (double)numCarb.Value;
                    producto.Grasas = (double)numGrasa.Value;

                    _controlador.ActualizarProducto(producto);
                    MessageBox.Show("Alimento actualizado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmEditar.Close();
                    CargarProductos();
                };

                frmEditar.Controls.AddRange(new System.Windows.Forms.Control[]
                {
                    lblNombre, txtNombre, lblUnidad, txtUnidad,
                    lblCal, numCal, lblProt, numProt,
                    lblCarb, numCarb, lblGrasa, numGrasa, btnGuardar
                });

                frmEditar.ShowDialog();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtBuscarNombre.Text.Trim();
                var resultados = _controlador.Buscar(nombre);
                MostrarEnTabla(resultados);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void btnAgregarRapido_Click(object sender, EventArgs e)
        {
            MostrarFormularioAgregarAlimento();
        }

        private void MostrarFormularioAgregarAlimento()
        {
            Form formulario = new Form
            {
                Text = "Agregar nuevo alimento",
                Size = new System.Drawing.Size(400, 400),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false
            };

            var lblNombre = new Label { Text = "Nombre:", Location = new System.Drawing.Point(20, 20), AutoSize = true };
            var txtNombre = new TextBox { Location = new System.Drawing.Point(20, 45), Size = new System.Drawing.Size(340, 30) };
            var lblUnidad = new Label { Text = "Unidad (ej: 100g):", Location = new System.Drawing.Point(20, 85), AutoSize = true };
            var txtUnidad = new TextBox { Location = new System.Drawing.Point(20, 110), Size = new System.Drawing.Size(340, 30) };
            var lblCal = new Label { Text = "Calorías:", Location = new System.Drawing.Point(20, 150), AutoSize = true };
            var numCal = new NumericUpDown { Location = new System.Drawing.Point(20, 175), Size = new System.Drawing.Size(150, 30), Maximum = 9999, DecimalPlaces = 1 };
            var lblProt = new Label { Text = "Proteínas (g):", Location = new System.Drawing.Point(200, 150), AutoSize = true };
            var numProt = new NumericUpDown { Location = new System.Drawing.Point(200, 175), Size = new System.Drawing.Size(150, 30), Maximum = 999, DecimalPlaces = 1 };
            var lblCarb = new Label { Text = "Carbohidratos (g):", Location = new System.Drawing.Point(20, 215), AutoSize = true };
            var numCarb = new NumericUpDown { Location = new System.Drawing.Point(20, 240), Size = new System.Drawing.Size(150, 30), Maximum = 999, DecimalPlaces = 1 };
            var lblGrasa = new Label { Text = "Grasas (g):", Location = new System.Drawing.Point(200, 215), AutoSize = true };
            var numGrasa = new NumericUpDown { Location = new System.Drawing.Point(200, 240), Size = new System.Drawing.Size(150, 30), Maximum = 999, DecimalPlaces = 1 };
            var btnGuardar = new Button { Text = "GUARDAR", Location = new System.Drawing.Point(120, 300), Size = new System.Drawing.Size(150, 40) };

            btnGuardar.Click += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("El nombre es obligatorio.", "Campo requerido",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var nuevo = new Producto(
                    txtNombre.Text.Trim(),
                    txtUnidad.Text.Trim(),
                    (double)numCal.Value,
                    (double)numProt.Value,
                    (double)numCarb.Value,
                    (double)numGrasa.Value
                );

                _controlador.AgregarProducto(nuevo);
                MessageBox.Show("Alimento agregado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                formulario.Close();
                CargarProductos();
            };

            formulario.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                lblNombre, txtNombre, lblUnidad, txtUnidad,
                lblCal, numCal, lblProt, numProt,
                lblCarb, numCarb, lblGrasa, numGrasa, btnGuardar
            });

            formulario.ShowDialog();
        }

        private void btnVolverLista_Click(object sender, EventArgs e) => this.Close();
    }
}