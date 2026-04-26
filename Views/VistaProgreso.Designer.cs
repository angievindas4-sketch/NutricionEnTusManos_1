namespace NutricionEnTusManos_1.Views
{
    partial class VistaProgreso
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
            btnVolver = new Button();
            lblTitulo = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            gbEvolucion = new GroupBox();
            btnActualizarDatos = new Button();
            gbContenedorMetas = new GroupBox();
            pbProgresoMeta = new ProgressBar();
            lblTextoProgreso = new Label();
            panelPesoActual = new GroupBox();
            lblLogroSemana = new Label();
            lblPesoActual = new Label();
            lblTitActual = new Label();
            panelCambio = new GroupBox();
            lblDesdeInicio = new Label();
            lblKilosTotales = new Label();
            lblTitCambio = new Label();
            panelMeta = new GroupBox();
            lblFaltan = new Label();
            lblPesoMeta = new Label();
            lblTitMeta = new Label();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            gbCardEjercicio = new GroupBox();
            lblDetalleEjercicio = new Label();
            lblTitEjercicio = new Label();
            gbCardAgua = new GroupBox();
            lblDetalleAgua = new Label();
            lblTitAgua = new Label();
            gbCardNutricion = new GroupBox();
            lblDetalleNutricion = new Label();
            lblTitNutricion = new Label();
            gbHistorial = new GroupBox();
            lblDesde = new Label();
            dtpDesde = new DateTimePicker();
            lblHasta = new Label();
            dtpHasta = new DateTimePicker();
            btnFiltrar = new Button();
            dgvHistorial = new DataGridView();
            lblResumenHistorial = new Label();
            gbEvolucion.SuspendLayout();
            gbContenedorMetas.SuspendLayout();
            panelPesoActual.SuspendLayout();
            panelCambio.SuspendLayout();
            panelMeta.SuspendLayout();
            gbCardEjercicio.SuspendLayout();
            gbCardAgua.SuspendLayout();
            gbCardNutricion.SuspendLayout();
            gbHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 8F);
            btnVolver.Location = new Point(19, 13);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(95, 31);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "← VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(19, 47);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(368, 28);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "MI PROGRESO Y RECOMENDACIONES";
            // 
            // gbEvolucion
            // 
            gbEvolucion.Controls.Add(btnActualizarDatos);
            gbEvolucion.Controls.Add(gbContenedorMetas);
            gbEvolucion.Controls.Add(lblTextoProgreso);
            gbEvolucion.Controls.Add(panelPesoActual);
            gbEvolucion.Controls.Add(panelCambio);
            gbEvolucion.Controls.Add(panelMeta);
            gbEvolucion.Location = new Point(27, 83);
            gbEvolucion.Name = "gbEvolucion";
            gbEvolucion.Size = new Size(1098, 361);
            gbEvolucion.TabIndex = 2;
            gbEvolucion.TabStop = false;
            gbEvolucion.Text = "Evolución de mi Peso";
            gbEvolucion.Enter += gbEvolucion_Enter;
            // 
            // btnActualizarDatos
            // 
            btnActualizarDatos.BackColor = SystemColors.ControlLight;
            btnActualizarDatos.Location = new Point(890, 308);
            btnActualizarDatos.Name = "btnActualizarDatos";
            btnActualizarDatos.Size = new Size(185, 40);
            btnActualizarDatos.TabIndex = 6;
            btnActualizarDatos.Text = "ACTUALIZAR DATOS";
            btnActualizarDatos.UseVisualStyleBackColor = false;
            btnActualizarDatos.Click += btnActualizarDatos_Click;
            // 
            // gbContenedorMetas
            // 
            gbContenedorMetas.Controls.Add(pbProgresoMeta);
            gbContenedorMetas.Location = new Point(30, 193);
            gbContenedorMetas.Name = "gbContenedorMetas";
            gbContenedorMetas.Size = new Size(1045, 89);
            gbContenedorMetas.TabIndex = 5;
            gbContenedorMetas.TabStop = false;
            gbContenedorMetas.Text = "Barra de Progreso";
            // 
            // pbProgresoMeta
            // 
            pbProgresoMeta.Location = new Point(0, 39);
            pbProgresoMeta.Name = "pbProgresoMeta";
            pbProgresoMeta.Size = new Size(1045, 50);
            pbProgresoMeta.TabIndex = 0;
            pbProgresoMeta.Value = 50;
            // 
            // lblTextoProgreso
            // 
            lblTextoProgreso.AutoSize = true;
            lblTextoProgreso.Location = new Point(10, 165);
            lblTextoProgreso.Name = "lblTextoProgreso";
            lblTextoProgreso.Size = new Size(196, 25);
            lblTextoProgreso.TabIndex = 4;
            lblTextoProgreso.Text = "Progreso hacia la meta:";
            // 
            // panelPesoActual
            // 
            panelPesoActual.Controls.Add(lblLogroSemana);
            panelPesoActual.Controls.Add(lblPesoActual);
            panelPesoActual.Controls.Add(lblTitActual);
            panelPesoActual.Location = new Point(10, 35);
            panelPesoActual.Name = "panelPesoActual";
            panelPesoActual.Size = new Size(350, 118);
            panelPesoActual.TabIndex = 0;
            panelPesoActual.TabStop = false;
            panelPesoActual.Text = "Actual";
            // 
            // lblLogroSemana
            // 
            lblLogroSemana.AutoSize = true;
            lblLogroSemana.Font = new Font("Segoe UI", 8F);
            lblLogroSemana.ForeColor = Color.ForestGreen;
            lblLogroSemana.Location = new Point(80, 76);
            lblLogroSemana.Name = "lblLogroSemana";
            lblLogroSemana.Size = new Size(170, 21);
            lblLogroSemana.TabIndex = 2;
            lblLogroSemana.Text = "Logro: 0.0 kg";
            // 
            // lblPesoActual
            // 
            lblPesoActual.AutoSize = true;
            lblPesoActual.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPesoActual.Location = new Point(211, 39);
            lblPesoActual.Name = "lblPesoActual";
            lblPesoActual.Size = new Size(98, 32);
            lblPesoActual.TabIndex = 1;
            lblPesoActual.Text = "0 kg";
            // 
            // lblTitActual
            // 
            lblTitActual.AutoSize = true;
            lblTitActual.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitActual.Location = new Point(20, 39);
            lblTitActual.Name = "lblTitActual";
            lblTitActual.Size = new Size(185, 32);
            lblTitActual.TabIndex = 0;
            lblTitActual.Text = "PESO ACTUAL :";
            // 
            // panelCambio
            // 
            panelCambio.Controls.Add(lblDesdeInicio);
            panelCambio.Controls.Add(lblKilosTotales);
            panelCambio.Controls.Add(lblTitCambio);
            panelCambio.Location = new Point(742, 35);
            panelCambio.Name = "panelCambio";
            panelCambio.Size = new Size(350, 118);
            panelCambio.TabIndex = 2;
            panelCambio.TabStop = false;
            panelCambio.Text = "Cambio";
            // 
            // lblDesdeInicio
            // 
            lblDesdeInicio.AutoSize = true;
            lblDesdeInicio.Font = new Font("Segoe UI", 8F);
            lblDesdeInicio.Location = new Point(73, 73);
            lblDesdeInicio.Name = "lblDesdeInicio";
            lblDesdeInicio.Size = new Size(199, 21);
            lblDesdeInicio.TabIndex = 2;
            lblDesdeInicio.Text = "(desde Peso Inicial: 0.0 kg)";
            // 
            // lblKilosTotales
            // 
            lblKilosTotales.AutoSize = true;
            lblKilosTotales.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKilosTotales.ForeColor = Color.DarkGreen;
            lblKilosTotales.Location = new Point(239, 39);
            lblKilosTotales.Name = "lblKilosTotales";
            lblKilosTotales.Size = new Size(94, 32);
            lblKilosTotales.TabIndex = 1;
            lblKilosTotales.Text = "0.0 kg";
            // 
            // lblTitCambio
            // 
            lblTitCambio.AutoSize = true;
            lblTitCambio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitCambio.ForeColor = Color.DarkGreen;
            lblTitCambio.Location = new Point(40, 39);
            lblTitCambio.Name = "lblTitCambio";
            lblTitCambio.Size = new Size(202, 32);
            lblTitCambio.TabIndex = 0;
            lblTitCambio.Text = "CAMBIO TOTAL :";
            // 
            // panelMeta
            // 
            panelMeta.Controls.Add(lblFaltan);
            panelMeta.Controls.Add(lblPesoMeta);
            panelMeta.Controls.Add(lblTitMeta);
            panelMeta.Location = new Point(373, 35);
            panelMeta.Name = "panelMeta";
            panelMeta.Size = new Size(350, 118);
            panelMeta.TabIndex = 1;
            panelMeta.TabStop = false;
            panelMeta.Text = "Meta";
            // 
            // lblFaltan
            // 
            lblFaltan.AutoSize = true;
            lblFaltan.Font = new Font("Segoe UI", 8F);
            lblFaltan.ForeColor = Color.DodgerBlue;
            lblFaltan.Location = new Point(133, 76);
            lblFaltan.Name = "lblFaltan";
            lblFaltan.Size = new Size(100, 21);
            lblFaltan.TabIndex = 2;
            lblFaltan.Text = "Faltan: 0.0 kg";
            // 
            // lblPesoMeta
            // 
            lblPesoMeta.AutoSize = true;
            lblPesoMeta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPesoMeta.Location = new Point(180, 39);
            lblPesoMeta.Name = "lblPesoMeta";
            lblPesoMeta.Size = new Size(98, 32);
            lblPesoMeta.TabIndex = 1;
            lblPesoMeta.Text = "0.0 kg";
            // 
            // lblTitMeta
            // 
            lblTitMeta.AutoSize = true;
            lblTitMeta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitMeta.Location = new Point(84, 39);
            lblTitMeta.Name = "lblTitMeta";
            lblTitMeta.Size = new Size(100, 32);
            lblTitMeta.TabIndex = 0;
            lblTitMeta.Text = "META : ";
            // 
            // gbCardEjercicio
            // 
            gbCardEjercicio.Controls.Add(lblDetalleEjercicio);
            gbCardEjercicio.Controls.Add(lblTitEjercicio);
            gbCardEjercicio.Location = new Point(37, 456);
            gbCardEjercicio.Name = "gbCardEjercicio";
            gbCardEjercicio.Size = new Size(355, 270);
            gbCardEjercicio.TabIndex = 3;
            gbCardEjercicio.TabStop = false;
            gbCardEjercicio.Text = "Actividad Física";
            // 
            // lblDetalleEjercicio
            // 
            lblDetalleEjercicio.AutoSize = true;
            lblDetalleEjercicio.Location = new Point(20, 82);
            lblDetalleEjercicio.Name = "lblDetalleEjercicio";
            lblDetalleEjercicio.Size = new Size(301, 75);
            lblDetalleEjercicio.TabIndex = 1;
            lblDetalleEjercicio.Text = "";
            // 
            // lblTitEjercicio
            // 
            lblTitEjercicio.AutoSize = true;
            lblTitEjercicio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitEjercicio.Location = new Point(20, 47);
            lblTitEjercicio.Name = "lblTitEjercicio";
            lblTitEjercicio.Size = new Size(172, 25);
            lblTitEjercicio.TabIndex = 0;
            lblTitEjercicio.Text = "Resumen Semanal:";
            // 
            // gbCardAgua
            // 
            gbCardAgua.Controls.Add(lblDetalleAgua);
            gbCardAgua.Controls.Add(lblTitAgua);
            gbCardAgua.Font = new Font("Segoe UI", 9F);
            gbCardAgua.Location = new Point(421, 456);
            gbCardAgua.Name = "gbCardAgua";
            gbCardAgua.Size = new Size(329, 270);
            gbCardAgua.TabIndex = 4;
            gbCardAgua.TabStop = false;
            gbCardAgua.Text = "Consumo de Agua";
            // 
            // lblDetalleAgua
            // 
            lblDetalleAgua.AutoSize = true;
            lblDetalleAgua.Location = new Point(32, 82);
            lblDetalleAgua.Name = "lblDetalleAgua";
            lblDetalleAgua.Size = new Size(256, 75);
            lblDetalleAgua.TabIndex = 1;
            lblDetalleAgua.Text = "";
            // 
            // lblTitAgua
            // 
            lblTitAgua.AutoSize = true;
            lblTitAgua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitAgua.Location = new Point(32, 47);
            lblTitAgua.Name = "lblTitAgua";
            lblTitAgua.Size = new Size(166, 25);
            lblTitAgua.TabIndex = 0;
            lblTitAgua.Text = "Resumen de Hoy :";
            // 
            // gbCardNutricion
            // 
            gbCardNutricion.Controls.Add(lblDetalleNutricion);
            gbCardNutricion.Controls.Add(lblTitNutricion);
            gbCardNutricion.Location = new Point(774, 456);
            gbCardNutricion.Name = "gbCardNutricion";
            gbCardNutricion.Size = new Size(351, 270);
            gbCardNutricion.TabIndex = 5;
            gbCardNutricion.TabStop = false;
            gbCardNutricion.Text = "Resumen Nutricional";
            // 
            // lblDetalleNutricion
            // 
            lblDetalleNutricion.AutoSize = true;
            lblDetalleNutricion.Location = new Point(35, 72);
            lblDetalleNutricion.Name = "lblDetalleNutricion";
            lblDetalleNutricion.Size = new Size(293, 100);
            lblDetalleNutricion.TabIndex = 1;
            lblDetalleNutricion.Text = "";
            // 
            // lblTitNutricion
            // 
            lblTitNutricion.AutoSize = true;
            lblTitNutricion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitNutricion.Location = new Point(35, 47);
            lblTitNutricion.Name = "lblTitNutricion";
            lblTitNutricion.Size = new Size(200, 25);
            lblTitNutricion.TabIndex = 0;
            lblTitNutricion.Text = "Resumen Nutricional :";
            // 
            // gbHistorial
            // 
            gbHistorial.Controls.Add(lblResumenHistorial);
            gbHistorial.Controls.Add(dgvHistorial);
            gbHistorial.Controls.Add(btnFiltrar);
            gbHistorial.Controls.Add(dtpHasta);
            gbHistorial.Controls.Add(lblHasta);
            gbHistorial.Controls.Add(dtpDesde);
            gbHistorial.Controls.Add(lblDesde);
            gbHistorial.Location = new Point(27, 740);
            gbHistorial.Name = "gbHistorial";
            gbHistorial.Size = new Size(1098, 420);
            gbHistorial.TabIndex = 6;
            gbHistorial.TabStop = false;
            gbHistorial.Text = "Historial de Alimentación por Fecha";
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Location = new Point(20, 35);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(60, 25);
            lblDesde.TabIndex = 0;
            lblDesde.Text = "Desde:";
            // 
            // dtpDesde
            // 
            dtpDesde.CustomFormat = "dd/MM/yyyy";
            dtpDesde.Format = DateTimePickerFormat.Custom;
            dtpDesde.Location = new Point(90, 30);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(160, 31);
            dtpDesde.TabIndex = 1;
            dtpDesde.Value = DateTime.Today.AddDays(-15);
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Location = new Point(270, 35);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(57, 25);
            lblHasta.TabIndex = 2;
            lblHasta.Text = "Hasta:";
            // 
            // dtpHasta
            // 
            dtpHasta.CustomFormat = "dd/MM/yyyy";
            dtpHasta.Format = DateTimePickerFormat.Custom;
            dtpHasta.Location = new Point(340, 30);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(160, 31);
            dtpHasta.TabIndex = 3;
            dtpHasta.Value = DateTime.Today;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(520, 28);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(120, 35);
            btnFiltrar.TabIndex = 4;
            btnFiltrar.Text = "VER HISTORIAL";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // dgvHistorial
            // 
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorial.BackgroundColor = Color.White;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Location = new Point(10, 75);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.RowHeadersVisible = false;
            dgvHistorial.Size = new Size(1075, 280);
            dgvHistorial.TabIndex = 5;
            // 
            // lblResumenHistorial
            // 
            lblResumenHistorial.AutoSize = true;
            lblResumenHistorial.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResumenHistorial.Location = new Point(10, 365);
            lblResumenHistorial.Name = "lblResumenHistorial";
            lblResumenHistorial.Size = new Size(200, 25);
            lblResumenHistorial.TabIndex = 6;
            lblResumenHistorial.Text = "";
            // 
            // VistaProgreso
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 850);
            Controls.Add(gbHistorial);
            Controls.Add(gbCardNutricion);
            Controls.Add(gbCardAgua);
            Controls.Add(gbCardEjercicio);
            Controls.Add(gbEvolucion);
            Controls.Add(lblTitulo);
            Controls.Add(btnVolver);
            FormBorderStyle = FormBorderStyle.Sizable;
            AutoScroll = true;
            MaximizeBox = false;
            Name = "VistaProgreso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Progreso - Nutrición en tus manos";
            gbEvolucion.ResumeLayout(false);
            gbEvolucion.PerformLayout();
            gbContenedorMetas.ResumeLayout(false);
            panelPesoActual.ResumeLayout(false);
            panelPesoActual.PerformLayout();
            panelCambio.ResumeLayout(false);
            panelCambio.PerformLayout();
            panelMeta.ResumeLayout(false);
            panelMeta.PerformLayout();
            gbCardEjercicio.ResumeLayout(false);
            gbCardEjercicio.PerformLayout();
            gbCardAgua.ResumeLayout(false);
            gbCardAgua.PerformLayout();
            gbCardNutricion.ResumeLayout(false);
            gbCardNutricion.PerformLayout();
            gbHistorial.ResumeLayout(false);
            gbHistorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Label lblTitulo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox gbEvolucion;
        private GroupBox panelCambio;
        private GroupBox panelMeta;
        private GroupBox panelPesoActual;
        private Label lblTitActual;
        private Label lblPesoActual;
        private Label lblLogroSemana;
        private Label lblFaltan;
        private Label lblPesoMeta;
        private Label lblTitMeta;
        private Label lblDesdeInicio;
        private Label lblKilosTotales;
        private Label lblTitCambio;
        private Label lblTextoProgreso;
        private GroupBox gbContenedorMetas;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private ProgressBar pbProgresoMeta;
        private Button btnActualizarDatos;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private GroupBox gbCardEjercicio;
        private GroupBox gbCardAgua;
        private GroupBox gbCardNutricion;
        private Label lblDetalleEjercicio;
        private Label lblTitEjercicio;
        private Label lblDetalleAgua;
        private Label lblTitAgua;
        private Label lblDetalleNutricion;
        private Label lblTitNutricion;
        private GroupBox gbHistorial;
        private Label lblDesde;
        private DateTimePicker dtpDesde;
        private Label lblHasta;
        private DateTimePicker dtpHasta;
        private Button btnFiltrar;
        private DataGridView dgvHistorial;
        private Label lblResumenHistorial;
    }
}