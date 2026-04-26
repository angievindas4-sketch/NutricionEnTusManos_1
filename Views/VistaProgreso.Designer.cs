namespace NutricionEnTusManos_1.Views
{
    partial class VistaProgreso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnVolver = new Button();
            lblTitulo = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            gbEvolucion = new GroupBox();
            panelPesoActual = new GroupBox();
            panelMeta = new GroupBox();
            panelCambio = new GroupBox();
            lblTitActual = new Label();
            lblPesoActual = new Label();
            lblLogroSemana = new Label();
            lblTitMeta = new Label();
            lblPesoMeta = new Label();
            lblFaltan = new Label();
            lblTitCambio = new Label();
            lblKilosTotales = new Label();
            lblDesdeInicio = new Label();
            lblTextoProgreso = new Label();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            gbContenedorMetas = new GroupBox();
            pbProgresoMeta = new ProgressBar();
            backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            btnActualizarDatos = new Button();
            backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            gbCardEjercicio = new GroupBox();
            gbCardAgua = new GroupBox();
            gbCardNutricion = new GroupBox();
            lblTitEjercicio = new Label();
            lblDetalleEjercicio = new Label();
            lblTitAgua = new Label();
            lblDetalleAgua = new Label();
            lblTitNutricion = new Label();
            lblDetalleNutricion = new Label();
            gbEvolucion.SuspendLayout();
            panelPesoActual.SuspendLayout();
            panelMeta.SuspendLayout();
            panelCambio.SuspendLayout();
            gbContenedorMetas.SuspendLayout();
            gbCardEjercicio.SuspendLayout();
            gbCardAgua.SuspendLayout();
            gbCardNutricion.SuspendLayout();
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
            panelPesoActual.Text = "Sub-Panel 1";
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
            panelMeta.Text = "Sub-Panel 2";
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
            panelCambio.Text = "Sub-Panel 3";
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
            // lblPesoActual
            // 
            lblPesoActual.AutoSize = true;
            lblPesoActual.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPesoActual.Location = new Point(211, 39);
            lblPesoActual.Name = "lblPesoActual";
            lblPesoActual.Size = new Size(98, 32);
            lblPesoActual.TabIndex = 1;
            lblPesoActual.Text = "75.5 kg";
            // 
            // lblLogroSemana
            // 
            lblLogroSemana.AutoSize = true;
            lblLogroSemana.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogroSemana.ForeColor = Color.ForestGreen;
            lblLogroSemana.Location = new Point(80, 76);
            lblLogroSemana.Name = "lblLogroSemana";
            lblLogroSemana.Size = new Size(170, 21);
            lblLogroSemana.TabIndex = 2;
            lblLogroSemana.Text = "Logro Semanal: -1.2 kg";
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
            // lblPesoMeta
            // 
            lblPesoMeta.AutoSize = true;
            lblPesoMeta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPesoMeta.Location = new Point(180, 39);
            lblPesoMeta.Name = "lblPesoMeta";
            lblPesoMeta.Size = new Size(98, 32);
            lblPesoMeta.TabIndex = 1;
            lblPesoMeta.Text = "70.0 kg";
            // 
            // lblFaltan
            // 
            lblFaltan.AutoSize = true;
            lblFaltan.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFaltan.ForeColor = Color.DodgerBlue;
            lblFaltan.Location = new Point(133, 76);
            lblFaltan.Name = "lblFaltan";
            lblFaltan.Size = new Size(100, 21);
            lblFaltan.TabIndex = 2;
            lblFaltan.Text = "Faltan: 5.5 kg";
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
            // lblKilosTotales
            // 
            lblKilosTotales.AutoSize = true;
            lblKilosTotales.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKilosTotales.ForeColor = Color.DarkGreen;
            lblKilosTotales.Location = new Point(239, 39);
            lblKilosTotales.Name = "lblKilosTotales";
            lblKilosTotales.Size = new Size(94, 32);
            lblKilosTotales.TabIndex = 1;
            lblKilosTotales.Text = "-4.5 kg";
            // 
            // lblDesdeInicio
            // 
            lblDesdeInicio.AutoSize = true;
            lblDesdeInicio.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDesdeInicio.Location = new Point(73, 73);
            lblDesdeInicio.Name = "lblDesdeInicio";
            lblDesdeInicio.Size = new Size(199, 21);
            lblDesdeInicio.TabIndex = 2;
            lblDesdeInicio.Text = "(desde Peso Inicial: 80.0 kg)";
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
            // btnActualizarDatos
            // 
            btnActualizarDatos.BackColor = SystemColors.ControlLight;
            btnActualizarDatos.Location = new Point(890, 308);
            btnActualizarDatos.Name = "btnActualizarDatos";
            btnActualizarDatos.Size = new Size(185, 40);
            btnActualizarDatos.TabIndex = 6;
            btnActualizarDatos.Text = "ACTUALIZAR DATOS";
            btnActualizarDatos.UseVisualStyleBackColor = false;
            // 
            // gbCardEjercicio
            // 
            gbCardEjercicio.Controls.Add(lblDetalleEjercicio);
            gbCardEjercicio.Controls.Add(lblTitEjercicio);
            gbCardEjercicio.Location = new Point(37, 456);
            gbCardEjercicio.Name = "gbCardEjercicio";
            gbCardEjercicio.Size = new Size(355, 190);
            gbCardEjercicio.TabIndex = 3;
            gbCardEjercicio.TabStop = false;
            gbCardEjercicio.Text = "Actividad Física";
            // 
            // gbCardAgua
            // 
            gbCardAgua.Controls.Add(lblDetalleAgua);
            gbCardAgua.Controls.Add(lblTitAgua);
            gbCardAgua.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbCardAgua.Location = new Point(421, 456);
            gbCardAgua.Name = "gbCardAgua";
            gbCardAgua.Size = new Size(329, 190);
            gbCardAgua.TabIndex = 4;
            gbCardAgua.TabStop = false;
            gbCardAgua.Text = "Consumo de Agua";
            // 
            // gbCardNutricion
            // 
            gbCardNutricion.Controls.Add(lblDetalleNutricion);
            gbCardNutricion.Controls.Add(lblTitNutricion);
            gbCardNutricion.Location = new Point(774, 456);
            gbCardNutricion.Name = "gbCardNutricion";
            gbCardNutricion.Size = new Size(351, 190);
            gbCardNutricion.TabIndex = 5;
            gbCardNutricion.TabStop = false;
            gbCardNutricion.Text = "Dato Curioso";
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
            // lblDetalleEjercicio
            // 
            lblDetalleEjercicio.AutoSize = true;
            lblDetalleEjercicio.Location = new Point(20, 82);
            lblDetalleEjercicio.Name = "lblDetalleEjercicio";
            lblDetalleEjercicio.Size = new Size(301, 75);
            lblDetalleEjercicio.TabIndex = 1;
            lblDetalleEjercicio.Text = "Pasos promedio: 10,200 (¡Excelente!)\r\nCalorías quemadas: 210 kcal/día\r\nNivel: Moderado.";
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
            // lblDetalleAgua
            // 
            lblDetalleAgua.AutoSize = true;
            lblDetalleAgua.Location = new Point(32, 82);
            lblDetalleAgua.Name = "lblDetalleAgua";
            lblDetalleAgua.Size = new Size(256, 75);
            lblDetalleAgua.TabIndex = 1;
            lblDetalleAgua.Text = "Vasos registrados: 4\r\nMeta: 8 vasos\r\nEstado: Al 50% de Hidratación.";
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
            // lblDetalleNutricion
            // 
            lblDetalleNutricion.AutoSize = true;
            lblDetalleNutricion.Location = new Point(35, 72);
            lblDetalleNutricion.Name = "lblDetalleNutricion";
            lblDetalleNutricion.Size = new Size(293, 100);
            lblDetalleNutricion.TabIndex = 1;
            lblDetalleNutricion.Text = "Carbohidratos: 180g\r\nProteínas: 95g\r\nTip: Prioriza la proteína para mayor \r\nsaciedad.";
            // 
            // VistaProgreso
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 649);
            Controls.Add(gbCardNutricion);
            Controls.Add(gbCardAgua);
            Controls.Add(gbCardEjercicio);
            Controls.Add(gbEvolucion);
            Controls.Add(lblTitulo);
            Controls.Add(btnVolver);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "VistaProgreso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Progreso - Nutrición en tus manos";
            gbEvolucion.ResumeLayout(false);
            gbEvolucion.PerformLayout();
            panelPesoActual.ResumeLayout(false);
            panelPesoActual.PerformLayout();
            panelMeta.ResumeLayout(false);
            panelMeta.PerformLayout();
            panelCambio.ResumeLayout(false);
            panelCambio.PerformLayout();
            gbContenedorMetas.ResumeLayout(false);
            gbCardEjercicio.ResumeLayout(false);
            gbCardEjercicio.PerformLayout();
            gbCardAgua.ResumeLayout(false);
            gbCardAgua.PerformLayout();
            gbCardNutricion.ResumeLayout(false);
            gbCardNutricion.PerformLayout();
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
    }
}