namespace NutricionEnTusManos_1.Views
{
    partial class VistaDashboard
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
            panel1 = new Panel();
            label3 = new Label();
            lblDieta = new Label();
            lblObjetivo = new Label();
            lblPeso = new Label();
            lblNombre = new Label();
            panelCalorias = new Panel();
            label2 = new Label();
            label1 = new Label();
            bna = new Label();
            name = new Label();
            mki = new Label();
            pbGrasas = new ProgressBar();
            pbCarbohidratos = new ProgressBar();
            pbProteinas = new ProgressBar();
            lblCaloriasCirculo = new Label();
            panelGestion = new Panel();
            btnAgregar = new Button();
            dgvMenuHoy = new DataGridView();
            lstAlimentos = new ListBox();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            panel1.SuspendLayout();
            panelCalorias.SuspendLayout();
            panelGestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMenuHoy).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblDieta);
            panel1.Controls.Add(lblObjetivo);
            panel1.Controls.Add(lblPeso);
            panel1.Controls.Add(lblNombre);
            panel1.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(214, 193);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 21);
            label3.Name = "label3";
            label3.Size = new Size(144, 23);
            label3.TabIndex = 3;
            label3.Text = "PERFIL Y HABITOS";
            // 
            // lblDieta
            // 
            lblDieta.AutoSize = true;
            lblDieta.Location = new Point(12, 162);
            lblDieta.Name = "lblDieta";
            lblDieta.Size = new Size(55, 21);
            lblDieta.TabIndex = 3;
            lblDieta.Text = "Dieta:";
            // 
            // lblObjetivo
            // 
            lblObjetivo.AutoSize = true;
            lblObjetivo.Location = new Point(12, 132);
            lblObjetivo.Name = "lblObjetivo";
            lblObjetivo.Size = new Size(80, 21);
            lblObjetivo.TabIndex = 2;
            lblObjetivo.Text = "Objetivo:";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(12, 101);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(86, 21);
            lblPeso.TabIndex = 1;
            lblPeso.Text = "Peso: 0 kg";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 64);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(73, 21);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Usuario:";
            // 
            // panelCalorias
            // 
            panelCalorias.BackColor = Color.White;
            panelCalorias.Controls.Add(label2);
            panelCalorias.Controls.Add(label1);
            panelCalorias.Controls.Add(bna);
            panelCalorias.Controls.Add(name);
            panelCalorias.Controls.Add(mki);
            panelCalorias.Controls.Add(pbGrasas);
            panelCalorias.Controls.Add(pbCarbohidratos);
            panelCalorias.Controls.Add(pbProteinas);
            panelCalorias.Controls.Add(lblCaloriasCirculo);
            panelCalorias.Location = new Point(220, 0);
            panelCalorias.Name = "panelCalorias";
            panelCalorias.Size = new Size(266, 642);
            panelCalorias.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(87, 477);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 8;
            label2.Text = "MACROS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 284);
            label1.Name = "label1";
            label1.Size = new Size(153, 21);
            label1.TabIndex = 7;
            label1.Text = "CALORIAS DIARIAS";
            // 
            // bna
            // 
            bna.AutoSize = true;
            bna.Location = new Point(3, 592);
            bna.Name = "bna";
            bna.Size = new Size(56, 25);
            bna.TabIndex = 6;
            bna.Text = "Grasa";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(3, 561);
            name.Name = "name";
            name.Size = new Size(125, 25);
            name.TabIndex = 5;
            name.Text = "Carbohidratos";
            // 
            // mki
            // 
            mki.AutoSize = true;
            mki.Location = new Point(3, 525);
            mki.Name = "mki";
            mki.Size = new Size(85, 25);
            mki.TabIndex = 4;
            mki.Text = "Proteínas";
            // 
            // pbGrasas
            // 
            pbGrasas.Location = new Point(136, 592);
            pbGrasas.Name = "pbGrasas";
            pbGrasas.Size = new Size(127, 30);
            pbGrasas.TabIndex = 3;
            // 
            // pbCarbohidratos
            // 
            pbCarbohidratos.Location = new Point(136, 556);
            pbCarbohidratos.Name = "pbCarbohidratos";
            pbCarbohidratos.Size = new Size(127, 30);
            pbCarbohidratos.TabIndex = 2;
            // 
            // pbProteinas
            // 
            pbProteinas.Location = new Point(136, 520);
            pbProteinas.Name = "pbProteinas";
            pbProteinas.Size = new Size(127, 30);
            pbProteinas.TabIndex = 1;
            // 
            // lblCaloriasCirculo
            // 
            lblCaloriasCirculo.AutoSize = true;
            lblCaloriasCirculo.BorderStyle = BorderStyle.FixedSingle;
            lblCaloriasCirculo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCaloriasCirculo.Location = new Point(34, 323);
            lblCaloriasCirculo.Name = "lblCaloriasCirculo";
            lblCaloriasCirculo.Size = new Size(94, 92);
            lblCaloriasCirculo.TabIndex = 0;
            lblCaloriasCirculo.Text = "1500\r\n kcal";
            lblCaloriasCirculo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelGestion
            // 
            panelGestion.BackColor = Color.White;
            panelGestion.BorderStyle = BorderStyle.FixedSingle;
            panelGestion.Controls.Add(btnAgregar);
            panelGestion.Controls.Add(dgvMenuHoy);
            panelGestion.Controls.Add(lstAlimentos);
            panelGestion.Controls.Add(btnBuscar);
            panelGestion.Controls.Add(txtBuscar);
            panelGestion.Location = new Point(510, 0);
            panelGestion.Name = "panelGestion";
            panelGestion.Size = new Size(699, 465);
            panelGestion.TabIndex = 2;
            panelGestion.Paint += panelGestion_Paint;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.MediumSeaGreen;
            btnAgregar.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(22, 390);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(146, 40);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Añadir al Menú";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvMenuHoy
            // 
            dgvMenuHoy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMenuHoy.BackgroundColor = Color.White;
            dgvMenuHoy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMenuHoy.Location = new Point(197, 67);
            dgvMenuHoy.Name = "dgvMenuHoy";
            dgvMenuHoy.RowHeadersVisible = false;
            dgvMenuHoy.RowHeadersWidth = 62;
            dgvMenuHoy.Size = new Size(497, 317);
            dgvMenuHoy.TabIndex = 3;
            // 
            // lstAlimentos
            // 
            lstAlimentos.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstAlimentos.FormattingEnabled = true;
            lstAlimentos.Location = new Point(3, 100);
            lstAlimentos.Name = "lstAlimentos";
            lstAlimentos.Size = new Size(188, 284);
            lstAlimentos.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(151, 63);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.RightToLeft = RightToLeft.Yes;
            btnBuscar.Size = new Size(40, 31);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "🔍 ";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(3, 63);
            txtBuscar.Multiline = true;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(142, 31);
            txtBuscar.TabIndex = 0;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // VistaDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1321, 645);
            Controls.Add(panelGestion);
            Controls.Add(panelCalorias);
            Controls.Add(panel1);
            Name = "VistaDashboard";
            Text = "VistaDashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelCalorias.ResumeLayout(false);
            panelCalorias.PerformLayout();
            panelGestion.ResumeLayout(false);
            panelGestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMenuHoy).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblNombre;
        private Label lblDieta;
        private Label lblObjetivo;
        private Label lblPeso;
        private Panel panelCalorias;
        private ProgressBar pbGrasas;
        private ProgressBar pbCarbohidratos;
        private ProgressBar pbProteinas;
        private Label lblCaloriasCirculo;
        private Label bna;
        private Label name;
        private Label mki;
        private Panel panelGestion;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private ListBox lstAlimentos;
        private DataGridView dgvMenuHoy;
        private Button btnAgregar;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}