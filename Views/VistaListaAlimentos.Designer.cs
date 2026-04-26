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
            btnBuscar = new Button();
            txtBuscarNombre = new TextBox();
            label1 = new Label();
            gbCatalogo = new GroupBox();
            dgvCatalogo = new DataGridView();
            colNombre = new DataGridViewButtonColumn();
            colCalorias = new DataGridViewButtonColumn();
            colProteinas = new DataGridViewButtonColumn();
            colCarbos = new DataGridViewButtonColumn();
            colGrasas = new DataGridViewButtonColumn();
            gbOpcionesRapidas = new GroupBox();
            btnAgregarRapido = new Button();
            gbFiltros.SuspendLayout();
            gbCatalogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCatalogo).BeginInit();
            gbOpcionesRapidas.SuspendLayout();
            SuspendLayout();
            // 
            // btnVolverLista
            // 
            btnVolverLista.Font = new Font("Segoe UI", 8F);
            btnVolverLista.Location = new Point(13, 497);
            btnVolverLista.Name = "btnVolverLista";
            btnVolverLista.Size = new Size(141, 52);
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
            gbFiltros.Controls.Add(txtBuscarNombre);
            gbFiltros.Controls.Add(label1);
            gbFiltros.Location = new Point(13, 90);
            gbFiltros.Name = "gbFiltros";
            gbFiltros.Size = new Size(435, 193);
            gbFiltros.TabIndex = 2;
            gbFiltros.TabStop = false;
            gbFiltros.Text = "Búsqueda y Filtrado";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(147, 121);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(116, 49);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscarNombre
            // 
            txtBuscarNombre.Location = new Point(20, 66);
            txtBuscarNombre.Name = "txtBuscarNombre";
            txtBuscarNombre.Size = new Size(387, 31);
            txtBuscarNombre.TabIndex = 1;
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
            // gbCatalogo
            // 
            gbCatalogo.Controls.Add(dgvCatalogo);
            gbCatalogo.Location = new Point(455, 90);
            gbCatalogo.Name = "gbCatalogo";
            gbCatalogo.Size = new Size(815, 467);
            gbCatalogo.TabIndex = 3;
            gbCatalogo.TabStop = false;
            gbCatalogo.Text = "Valores Nutricionales";
            // 
            // dgvCatalogo
            // 
            dgvCatalogo.AllowUserToAddRows = false;
            dgvCatalogo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCatalogo.BackgroundColor = Color.White;
            dgvCatalogo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCatalogo.Location = new Point(6, 37);
            dgvCatalogo.Name = "dgvCatalogo";
            dgvCatalogo.RowHeadersVisible = false;
            dgvCatalogo.RowHeadersWidth = 62;
            dgvCatalogo.Size = new Size(803, 422);
            dgvCatalogo.TabIndex = 0;
            // 
            // colNombre
            // 
            colNombre.MinimumWidth = 8;
            colNombre.Name = "colNombre";
            colNombre.Width = 150;
            // 
            // colCalorias
            // 
            colCalorias.MinimumWidth = 8;
            colCalorias.Name = "colCalorias";
            colCalorias.Width = 150;
            // 
            // colProteinas
            // 
            colProteinas.MinimumWidth = 8;
            colProteinas.Name = "colProteinas";
            colProteinas.Width = 150;
            // 
            // colCarbos
            // 
            colCarbos.MinimumWidth = 8;
            colCarbos.Name = "colCarbos";
            colCarbos.Width = 150;
            // 
            // colGrasas
            // 
            colGrasas.MinimumWidth = 8;
            colGrasas.Name = "colGrasas";
            colGrasas.Width = 150;
            // 
            // gbOpcionesRapidas
            // 
            gbOpcionesRapidas.Controls.Add(btnAgregarRapido);
            gbOpcionesRapidas.Location = new Point(12, 298);
            gbOpcionesRapidas.Name = "gbOpcionesRapidas";
            gbOpcionesRapidas.Size = new Size(435, 184);
            gbOpcionesRapidas.TabIndex = 4;
            gbOpcionesRapidas.TabStop = false;
            gbOpcionesRapidas.Text = "Opciones Rápidas";
            // 
            // btnAgregarRapido
            // 
            btnAgregarRapido.Location = new Point(20, 46);
            btnAgregarRapido.Name = "btnAgregarRapido";
            btnAgregarRapido.Size = new Size(389, 103);
            btnAgregarRapido.TabIndex = 0;
            btnAgregarRapido.Text = "AGREGAR NUEVO ALIMENTO";
            btnAgregarRapido.UseVisualStyleBackColor = true;
            btnAgregarRapido.Click += btnAgregarRapido_Click;
            // 
            // VistaListaAlimentos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1282, 569);
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
        private Button btnBuscar;
        private GroupBox gbCatalogo;
        private DataGridView dgvCatalogo;
        private DataGridViewButtonColumn colNombre;
        private DataGridViewButtonColumn colCalorias;
        private DataGridViewButtonColumn colProteinas;
        private DataGridViewButtonColumn colCarbos;
        private DataGridViewButtonColumn colGrasas;
        private GroupBox gbOpcionesRapidas;
        private Button btnAgregarRapido;
    }
}