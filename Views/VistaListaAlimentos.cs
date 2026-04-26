using System;
using System.Collections.Generic;
using System.IO;
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
        }

        /// <summary>
        /// Configura las columnas del DataGridView como texto normal
        /// </summary>
        private void ConfigurarTabla()
        {
            dgvCatalogo.Columns.Clear();
            dgvCatalogo.AutoGenerateColumns = false;

            dgvCatalogo.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNombre",
                HeaderText = "Alimento",
                DataPropertyName = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvCatalogo.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colUnidad",
                HeaderText = "Medida",
                DataPropertyName = "UnidadMedida",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvCatalogo.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCalorias",
                HeaderText = "kcal",
                DataPropertyName = "Calorias",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvCatalogo.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colProteinas",
                HeaderText = "Proteínas (g)",
                DataPropertyName = "Proteinas",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvCatalogo.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCarbos",
                HeaderText = "Carbos (g)",
                DataPropertyName = "Carbohidratos",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvCatalogo.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colGrasas",
                HeaderText = "Grasas (g)",
                DataPropertyName = "Grasas",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }

        /// <summary>
        /// Carga todos los productos del repositorio en la tabla
        /// </summary>
        private void CargarProductos()
        {
            try
            {
                _todosLosProductos = _controlador.ObtenerTodos();
                MostrarEnTabla(_todosLosProductos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Muestra una lista de productos en el DataGridView
        /// </summary>
        private void MostrarEnTabla(List<Producto> productos)
        {
            dgvCatalogo.DataSource = null;
            dgvCatalogo.DataSource = productos;
        }

        // --- EVENTOS ---
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

        private void btnAgregarCatalogo_Click(object sender, EventArgs e)
        {
            MostrarFormularioAgregarAlimento();
        }

        private void MostrarFormularioAgregarAlimento()
        {
            // Formulario simple para agregar un nuevo alimento
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

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dialogo = new SaveFileDialog
                {
                    Filter = "CSV|*.csv",
                    FileName = "catalogo_alimentos.csv"
                };

                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    var lineas = new List<string>
                    {
                        "Nombre,Unidad,Calorias,Proteinas,Carbohidratos,Grasas"
                    };

                    foreach (var p in _todosLosProductos)
                    {
                        lineas.Add($"{p.Nombre},{p.UnidadMedida},{p.Calorias},{p.Proteinas},{p.Carbohidratos},{p.Grasas}");
                    }

                    File.WriteAllLines(dialogo.FileName, lineas);
                    MessageBox.Show("Lista exportada correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar: " + ex.Message);
            }
        }

        private void btnVolverLista_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}