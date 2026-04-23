namespace NutricionEnTusManos_1.Views
{
    partial class VistaNutricion
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
            lblResultado = new Label();
            btnCalcular = new Button();
            cmbObjetivo = new ComboBox();
            txtEdad = new TextBox();
            txtPeso = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // lblResultado
            // 
            lblResultado.BorderStyle = BorderStyle.FixedSingle;
            lblResultado.Location = new Point(152, 541);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(206, 34);
            lblResultado.TabIndex = 0;
            lblResultado.Text = "Aqui aparece su plan...";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(169, 451);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(149, 39);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular mi plan";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // cmbObjetivo
            // 
            cmbObjetivo.FormattingEnabled = true;
            cmbObjetivo.Items.AddRange(new object[] { "Mantener", "Perder Grasa", "Ganar Masa" });
            cmbObjetivo.Location = new Point(128, 357);
            cmbObjetivo.Name = "cmbObjetivo";
            cmbObjetivo.Size = new Size(211, 33);
            cmbObjetivo.TabIndex = 2;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(169, 268);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(149, 31);
            txtEdad.TabIndex = 3;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(169, 157);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(149, 31);
            txtPeso.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(222, 129);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 5;
            label1.Text = "Peso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 223);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 6;
            label2.Text = "Edad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(152, 329);
            label3.Name = "label3";
            label3.Size = new Size(187, 25);
            label3.TabIndex = 7;
            label3.Text = "Seleccione su objetivo";
            
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(183, 46);
            label4.Name = "label4";
            label4.Size = new Size(135, 25);
            label4.TabIndex = 8;
            label4.Text = "Plan Nutricional";
            // 
            // VistaNutricion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 622);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPeso);
            Controls.Add(txtEdad);
            Controls.Add(cmbObjetivo);
            Controls.Add(btnCalcular);
            Controls.Add(lblResultado);
            Name = "VistaNutricion";
            Text = "VistaNutricion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResultado;
        private Button btnCalcular;
        private ComboBox cmbObjetivo;
        private TextBox txtEdad;
        private TextBox txtPeso;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}