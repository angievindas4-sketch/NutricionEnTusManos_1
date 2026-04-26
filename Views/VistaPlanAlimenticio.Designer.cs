namespace NutricionEnTusManos_1.Views
{
    partial class VistaPlanAlimenticio
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
            lblTituloPlan = new Label();
            gbBusqueda = new GroupBox();
            btnBuscar = new Button();
            txtBuscarAlimento = new TextBox();
            gbTiempos = new GroupBox();
            btnCena = new Button();
            btnMeriendas = new Button();
            btnAlmuerzo = new Button();
            btnDesayuno = new Button();
            gbDetalle = new GroupBox();
            dgvPlan = new DataGridView();
            colAlimento = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colCalorias = new DataGridViewTextBoxColumn();
            colAccion = new DataGridViewButtonColumn();
            lblTotalCalorias = new Label();
            btnVolver = new Button();
            dtpFechaPlan = new DateTimePicker();
            label1 = new Label();
            gbBusqueda.SuspendLayout();
            gbTiempos.SuspendLayout();
            gbDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPlan).BeginInit();
            SuspendLayout();
            // 
            // lblTituloPlan
            // 
            lblTituloPlan.AutoSize = true;
            lblTituloPlan.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloPlan.Location = new Point(31, 22);
            lblTituloPlan.Name = "lblTituloPlan";
            lblTituloPlan.Size = new Size(428, 38);
            lblTituloPlan.TabIndex = 0;
            lblTituloPlan.Text = "MI PLAN ALIMENTICIO DIARIO";
            // 
            // gbBusqueda
            // 
            gbBusqueda.Controls.Add(btnBuscar);
            gbBusqueda.Controls.Add(txtBuscarAlimento);
            gbBusqueda.Location = new Point(32, 95);
            gbBusqueda.Name = "gbBusqueda";
            gbBusqueda.Size = new Size(1196, 86);
            gbBusqueda.TabIndex = 1;
            gbBusqueda.TabStop = false;
            gbBusqueda.Text = "Búsqueda de Alimentos";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(1074, 24);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(97, 42);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscarAlimento
            // 
            txtBuscarAlimento.Location = new Point(21, 30);
            txtBuscarAlimento.Name = "txtBuscarAlimento";
            txtBuscarAlimento.Size = new Size(1047, 31);
            txtBuscarAlimento.TabIndex = 0;
            // 
            // gbTiempos
            // 
            gbTiempos.Controls.Add(btnCena);
            gbTiempos.Controls.Add(btnMeriendas);
            gbTiempos.Controls.Add(btnAlmuerzo);
            gbTiempos.Controls.Add(btnDesayuno);
            gbTiempos.Location = new Point(34, 198);
            gbTiempos.Name = "gbTiempos";
            gbTiempos.Size = new Size(1197, 96);
            gbTiempos.TabIndex = 2;
            gbTiempos.TabStop = false;
            gbTiempos.Text = "Seleccionar Tiempo de Comida";
            // 
            // btnCena
            // 
            btnCena.Location = new Point(641, 30);
            btnCena.Name = "btnCena";
            btnCena.Size = new Size(257, 57);
            btnCena.TabIndex = 3;
            btnCena.Text = "CENA";
            btnCena.UseVisualStyleBackColor = true;
            // 
            // btnMeriendas
            // 
            btnMeriendas.Location = new Point(925, 30);
            btnMeriendas.Name = "btnMeriendas";
            btnMeriendas.Size = new Size(257, 57);
            btnMeriendas.TabIndex = 2;
            btnMeriendas.Text = "MERIENDAS";
            btnMeriendas.UseVisualStyleBackColor = true;
            // 
            // btnAlmuerzo
            // 
            btnAlmuerzo.Location = new Point(342, 32);
            btnAlmuerzo.Name = "btnAlmuerzo";
            btnAlmuerzo.Size = new Size(257, 55);
            btnAlmuerzo.TabIndex = 1;
            btnAlmuerzo.Text = "ALMUERZO";
            btnAlmuerzo.UseVisualStyleBackColor = true;
            // 
            // btnDesayuno
            // 
            btnDesayuno.Location = new Point(33, 30);
            btnDesayuno.Name = "btnDesayuno";
            btnDesayuno.Size = new Size(257, 57);
            btnDesayuno.TabIndex = 0;
            btnDesayuno.Text = "DESAYUNO";
            btnDesayuno.UseVisualStyleBackColor = true;
            // 
            // gbDetalle
            // 
            gbDetalle.Controls.Add(dgvPlan);
            gbDetalle.Location = new Point(36, 302);
            gbDetalle.Name = "gbDetalle";
            gbDetalle.Size = new Size(1193, 280);
            gbDetalle.TabIndex = 3;
            gbDetalle.TabStop = false;
            gbDetalle.Text = "Alimentos en el Plan";
            // 
            // dgvPlan
            // 
            dgvPlan.AllowUserToAddRows = false;
            dgvPlan.BackgroundColor = Color.White;
            dgvPlan.BorderStyle = BorderStyle.None;
            dgvPlan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlan.Columns.AddRange(new DataGridViewColumn[] { colAlimento, colCantidad, colCalorias, colAccion });
            dgvPlan.Location = new Point(11, 31);
            dgvPlan.Name = "dgvPlan";
            dgvPlan.RowHeadersVisible = false;
            dgvPlan.RowHeadersWidth = 62;
            dgvPlan.Size = new Size(1169, 243);
            dgvPlan.TabIndex = 0;
            // 
            // colAlimento
            // 
            colAlimento.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colAlimento.HeaderText = "Alimento";
            colAlimento.MinimumWidth = 8;
            colAlimento.Name = "colAlimento";
            // 
            // colCantidad
            // 
            colCantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCantidad.HeaderText = "Cantidad";
            colCantidad.MinimumWidth = 8;
            colCantidad.Name = "colCantidad";
            // 
            // colCalorias
            // 
            colCalorias.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCalorias.HeaderText = "Calorías";
            colCalorias.MinimumWidth = 8;
            colCalorias.Name = "colCalorias";
            // 
            // colAccion
            // 
            colAccion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colAccion.HeaderText = "Acción";
            colAccion.MinimumWidth = 8;
            colAccion.Name = "colAccion";
            colAccion.Resizable = DataGridViewTriState.True;
            colAccion.SortMode = DataGridViewColumnSortMode.Automatic;
            colAccion.Text = "📝 Editar  🗑️ Borrar";
            colAccion.UseColumnTextForButtonValue = true;
            // 
            // lblTotalCalorias
            // 
            lblTotalCalorias.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotalCalorias.AutoSize = true;
            lblTotalCalorias.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCalorias.Location = new Point(801, 602);
            lblTotalCalorias.Name = "lblTotalCalorias";
            lblTotalCalorias.Size = new Size(376, 28);
            lblTotalCalorias.TabIndex = 4;
            lblTotalCalorias.Text = "TOTAL CALORÍAS DESAYUNO: 260 kcal";
            // 
            // btnVolver
            // 
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(21, 598);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(97, 43);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "← VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // dtpFechaPlan
            // 
            dtpFechaPlan.CustomFormat = "dd/MM/yyyy";
            dtpFechaPlan.Format = DateTimePickerFormat.Custom;
            dtpFechaPlan.Location = new Point(1052, 44);
            dtpFechaPlan.Name = "dtpFechaPlan";
            dtpFechaPlan.Size = new Size(151, 31);
            dtpFechaPlan.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(974, 44);
            label1.Name = "label1";
            label1.Size = new Size(72, 28);
            label1.TabIndex = 7;
            label1.Text = "Fecha ";
            label1.Click += label1_Click;
            // 
            // VistaPlanAlimenticio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1281, 653);
            Controls.Add(label1);
            Controls.Add(dtpFechaPlan);
            Controls.Add(btnVolver);
            Controls.Add(lblTotalCalorias);
            Controls.Add(gbDetalle);
            Controls.Add(gbTiempos);
            Controls.Add(gbBusqueda);
            Controls.Add(lblTituloPlan);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "VistaPlanAlimenticio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Plan Alimenticio - Nutrición en tus manos";
            gbBusqueda.ResumeLayout(false);
            gbBusqueda.PerformLayout();
            gbTiempos.ResumeLayout(false);
            gbDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPlan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloPlan;
        private GroupBox gbBusqueda;
        private Button btnBuscar;
        private TextBox txtBuscarAlimento;
        private GroupBox gbTiempos;
        private Button btnCena;
        private Button btnMeriendas;
        private Button btnAlmuerzo;
        private Button btnDesayuno;
        private GroupBox gbDetalle;
        private DataGridView dgvPlan;
        private DataGridViewTextBoxColumn colAlimento;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colCalorias;
        private DataGridViewButtonColumn colAccion;
        private Label lblTotalCalorias;
        private Button btnVolver;
        private DateTimePicker dtpFechaPlan;
        private Label label1;
    }
}