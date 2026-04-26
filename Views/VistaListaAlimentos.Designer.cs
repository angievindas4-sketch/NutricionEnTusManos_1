namespace NutricionEnTusManos_1.Views
{
    partial class VistaListaAlimentos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnVolverLista = new Button();
            lblTituloLista = new Label();
            gbFiltros = new GroupBox();
            label1 = new Label();
            txtBuscarNombre = new TextBox();
            label2 = new Label();
            cmbCategoria = new ComboBox();
            btnBuscar = new Button();
            gbCatalogo = new GroupBox();
            dgvCatalogo = new DataGridView();
            colNombre = new DataGridViewButtonColumn();
            colCalorias = new DataGridViewButtonColumn();
            colProteinas = new DataGridViewButtonColumn();
            colCarbos = new DataGridViewButtonColumn();
            colGrasas = new DataGridViewButtonColumn();
            gbOpcionesRapidas = new GroupBox();
            btnAgregarRapido = new Button();
            btnExportar = new Button();
            btnAgregarCatalogo = new Button();
            gbFiltros.SuspendLayout();
            gbCatalogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCatalogo).BeginInit();
            gbOpcionesRapidas.SuspendLayout();
            SuspendLayout();
            // 
            // btnVolverLista
            // 
            btnVolverLista.Font = new Font("Segoe UI", 8F);
            btnVolverLista.Location = new Point(12, 591);
            btnVolverLista.Name = "btnVolverLista";
            btnVolverLista.Size = new Size(106, 30);
            btnVolverLista.TabIndex = 0;
            btnVolverLista.Text = "← VOLVER";
            btnVolverLista.UseVisualStyleBackColor = true;
            btnVolverLista.Click += btnVolverLista_Click;
            // 
            // lblTituloLista
            // 
            lblTituloLista.AutoSize = true;
            lblTituloLista.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloLista.Location = new Point(12, 20);
            lblTituloLista.Name = "lblTituloLista";
            lblTituloLista.Size = new Size(372, 38);
            lblTituloLista.TabIndex = 1;
            lblTituloLista.Text = "CATÁLOGO DE ALIMENTOS";
            // 
            // gbFiltros
            // 
            gbFiltros.Controls.Add(btnBuscar);
            gbFiltros.Controls.Add(cmbCategoria);
            gbFiltros.Controls.Add(label2);
            gbFiltros.Controls.Add(txtBuscarNombre);
            gbFiltros.Controls.Add(label1);
            gbFiltros.Location = new Point(13, 90);
            gbFiltros.Name = "gbFiltros";
            gbFiltros.Size = new Size(435, 283);
            gbFiltros.TabIndex = 2;
            gbFiltros.TabStop = false;
            gbFiltros.Text = "Búsqueda y Filtrado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 38);
            label1.Name = "label1";
            label1.Size = new Size(185, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre del alimento:";
            // 
            // txtBuscarNombre
            // 
            txtBuscarNombre.Location = new Point(20, 66);
            txtBuscarNombre.Name = "txtBuscarNombre";
            txtBuscarNombre.Size = new Size(387, 31);
            txtBuscarNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 118);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 2;
            label2.Text = "Categoría:";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Todas", "Frutas", "Verduras", "Carnes", "Lácteos", "Granos", "Otro" });
            cmbCategoria.Location = new Point(20, 146);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(278, 33);
            cmbCategoria.TabIndex = 3;
            cmbCategoria.SelectedIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(311, 146);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(90, 33);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // gbCatalogo
            // 
            gbCatalogo.Controls.Add(dgvCatalogo);
            gbCatalogo.Location = new Point(455, 90);
            gbCatalogo.Name = "gbCatalogo";
            gbCatalogo.Size = new Size(663, 473);
            gbCatalogo.TabIndex = 3;
            gbCatalogo.TabStop = false;
            gbCatalogo.Text = "Valores Nutricionales";
            // 
            // dgvCatalogo
            // 
            dgvCatalogo.AllowUserToAddRows = false;
            dgvCatalogo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCatalogo.BackgroundColor = System.Drawing.Color.White;
            dgvCatalogo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCatalogo.Location = new Point(18, 37);
            dgvCatalogo.Name = "dgvCatalogo";
            dgvCatalogo.RowHeadersVisible = false;
            dgvCatalogo.RowHeadersWidth = 62;
            dgvCatalogo.Size = new Size(639, 429);
            dgvCatalogo.TabIndex = 0;
            // 
            // gbOpcionesRapidas
            // 
            gbOpcionesRapidas.Controls.Add(btnExportar);
            gbOpcionesRapidas.Controls.Add(btnAgregarRapido);
            gbOpcionesRapidas.Location = new Point(13, 379);
            gbOpcionesRapidas.Name = "gbOpcionesRapidas";
            gbOpcionesRapidas.Size = new Size(435, 184);
            gbOpcionesRapidas.TabIndex = 4;
            gbOpcionesRapidas.TabStop = false;
            gbOpcionesRapidas.Text = "Opciones Rápidas";
            // 
            // btnAgregarRapido
            // 
            btnAgregarRapido.Location = new Point(24, 39);
            btnAgregarRapido.Name = "btnAgregarRapido";
            btnAgregarRapido.Size = new Size(389, 52);
            btnAgregarRapido.TabIndex = 0;
            btnAgregarRapido.Text = "AGREGAR NUEVO ALIMENTO";
            btnAgregarRapido.UseVisualStyleBackColor = true;
            btnAgregarRapido.Click += btnAgregarRapido_Click;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(24, 110);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(389, 52);
            btnExportar.TabIndex = 1;
            btnExportar.Text = "EXPORTAR LISTA";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnAgregarCatalogo
            // 
            btnAgregarCatalogo.FlatStyle = FlatStyle.Flat;
            btnAgregarCatalogo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarCatalogo.Location = new Point(306, 573);
            btnAgregarCatalogo.Name = "btnAgregarCatalogo";
            btnAgregarCatalogo.Size = new Size(543, 52);
            btnAgregarCatalogo.TabIndex = 5;
            btnAgregarCatalogo.Text = "AGREGAR NUEVO ALIMENTO AL CATÁLOGO";
            btnAgregarCatalogo.UseVisualStyleBackColor = true;
            btnAgregarCatalogo.Click += btnAgregarCatalogo_Click;
            // 
            // VistaListaAlimentos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new Size(1130, 633);
            Controls.Add(btnAgregarCatalogo);
            Controls.Add(gbOpcionesRapidas);
            Controls.Add(gbCatalogo);
            Controls.Add(gbFiltros);
            Controls.Add(lblTituloLista);
            Controls.Add(btnVolverLista);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "VistaListaAlimentos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Alimentos - Nutrición en tus manos";
            gbFiltros.ResumeLayout(false);
            gbFiltros.PerformLayout();
            gbCatalogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCatalogo).EndInit();
            gbOpcionesRapidas.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolverLista;
        private Label lblTituloLista;
        private GroupBox gbFiltros;
        private Label label1;
        private TextBox txtBuscarNombre;
        private Label label2;
        private ComboBox cmbCategoria;
        private Button btnBuscar;
        private GroupBox gbCatalogo;
        private DataGridView dgvCatalogo;
        private DataGridViewButtonColumn colNombre;
        private DataGridViewButtonColumn colCalorias;
        private DataGridViewButtonColumn colProteinas;
        private DataGridViewButtonColumn colCarbos;
        private DataGridViewButtonColumn colGrasas;
        private GroupBox gbOpcionesRapidas;
        private Button btnExportar;
        private Button btnAgregarRapido;
        private Button btnAgregarCatalogo;
    }
}