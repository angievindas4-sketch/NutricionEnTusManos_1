namespace NutricionEnTusManos_1.Views
{
    partial class VistaRegistro
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
            labelNivelActividad = new Label();
            comboNivelActividad = new ComboBox();
            groupBox3 = new GroupBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            groupBox2 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            nunEdad = new NumericUpDown();
            numPeso = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            txtPassword = new TextBox();
            label3 = new Label();
            txtUsuario = new TextBox();
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            groupBox4 = new GroupBox();
            panel1 = new Panel();
            panel2 = new Panel();
            btnFinalizarRegistro = new Button();
            label9 = new Label();
            numAltura = new NumericUpDown();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nunEdad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPeso).BeginInit();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAltura).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBox2);
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(labelNivelActividad);
            groupBox3.Controls.Add(comboNivelActividad);
            groupBox3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(894, 63);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(354, 420);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tus Objetivos";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Estándar", "Vegetariana", "Keto" });
            comboBox2.Location = new Point(162, 172);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(179, 33);
            comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ganar Masa", "Perder Peso", "Mantener" });
            comboBox1.Location = new Point(162, 58);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(179, 33);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 180);
            label8.Name = "label8";
            label8.Size = new Size(126, 25);
            label8.TabIndex = 1;
            label8.Text = "Tipo de dieta:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 66);
            label7.Name = "label7";
            label7.Size = new Size(93, 25);
            label7.TabIndex = 0;
            label7.Text = "Objetivo:";
            // 
            // labelNivelActividad
            // 
            labelNivelActividad.AutoSize = true;
            labelNivelActividad.Location = new Point(16, 280);
            labelNivelActividad.Name = "labelNivelActividad";
            labelNivelActividad.Size = new Size(140, 25);
            labelNivelActividad.TabIndex = 4;
            labelNivelActividad.Text = "Nivel de actividad:";
            // 
            // comboNivelActividad
            // 
            comboNivelActividad.FormattingEnabled = true;
            comboNivelActividad.Items.AddRange(new object[] {
                "Sedentario",
                "Ligero (1-3 días/semana)",
                "Moderado (3-5 días/semana)",
                "Activo (6-7 días/semana)",
                "Muy activo (atleta)"
            });
            comboNivelActividad.Location = new Point(16, 310);
            comboNivelActividad.Name = "comboNivelActividad";
            comboNivelActividad.Size = new Size(325, 33);
            comboNivelActividad.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numAltura);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(nunEdad);
            groupBox2.Controls.Add(numPeso);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(544, 63);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(337, 321);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información Física";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(156, 286);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(76, 29);
            radioButton3.TabIndex = 7;
            radioButton3.TabStop = true;
            radioButton3.Text = "Otro";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(156, 251);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(120, 29);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "Femenino";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(156, 216);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(122, 29);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Masculino";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // nunEdad
            // 
            nunEdad.Location = new Point(156, 170);
            nunEdad.Minimum = 1;
            nunEdad.Maximum = 120;
            nunEdad.Value = 25;
            nunEdad.Name = "nunEdad";
            nunEdad.Size = new Size(154, 31);
            nunEdad.TabIndex = 4;
            // 
            // numPeso
            // 
            numPeso.Location = new Point(156, 113);
            numPeso.Minimum = 30;
            numPeso.Maximum = 300;
            numPeso.DecimalPlaces = 1;
            numPeso.Value = 70;
            numPeso.Name = "numPeso";
            numPeso.Size = new Size(154, 31);
            numPeso.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 216);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 2;
            label6.Text = "Género:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 172);
            label5.Name = "label5";
            label5.Size = new Size(61, 25);
            label5.TabIndex = 1;
            label5.Text = "Edad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 115);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 0;
            label4.Text = "Peso (kg):";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(6, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(521, 321);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de la Cuenta";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(209, 193);
            txtPassword.PasswordChar = '*';
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(297, 31);
            txtPassword.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 196);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 5;
            label3.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(209, 130);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(297, 31);
            txtUsuario.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 82);
            label1.Name = "label1";
            label1.Size = new Size(172, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre Completo:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(209, 63);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(297, 31);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 133);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 4;
            label2.Text = "Usuario:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(panel1);
            groupBox4.Controls.Add(groupBox3);
            groupBox4.Controls.Add(groupBox1);
            groupBox4.Controls.Add(groupBox2);
            groupBox4.Location = new Point(12, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1254, 590);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "CREAR CUENTA DE USUARIO";
            groupBox4.Enter += groupBox4_Enter;
            // 
            // panel1
            // 
            panel1.Location = new Point(470, 501);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 139);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnFinalizarRegistro);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 516);
            panel2.Name = "panel2";
            panel2.Size = new Size(1278, 162);
            panel2.TabIndex = 2;
            // 
            // btnFinalizarRegistro
            // 
            btnFinalizarRegistro.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinalizarRegistro.Location = new Point(428, 14);
            btnFinalizarRegistro.Name = "btnFinalizarRegistro";
            btnFinalizarRegistro.Size = new Size(389, 122);
            btnFinalizarRegistro.TabIndex = 0;
            btnFinalizarRegistro.Text = "FINALIZAR Y GUARDAR REGISTRO";
            btnFinalizarRegistro.UseVisualStyleBackColor = true;
            btnFinalizarRegistro.Click += btnFinalizarRegistro_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(41, 66);
            label9.Name = "label9";
            label9.Size = new Size(72, 25);
            label9.TabIndex = 8;
            label9.Text = "Altura (cm):";
            // 
            // numAltura
            // 
            numAltura.Location = new Point(156, 60);
            numAltura.Minimum = 100;
            numAltura.Maximum = 250;
            numAltura.DecimalPlaces = 0;
            numAltura.Value = 170;
            numAltura.Name = "numAltura";
            numAltura.Size = new Size(154, 31);
            numAltura.TabIndex = 9;
            // 
            // VistaRegistro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 678);
            Controls.Add(panel2);
            Controls.Add(groupBox4);
            Name = "VistaRegistro";
            Text = "VistaRegistro";
            Load += VistaRegistro_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nunEdad).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPeso).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numAltura).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private TextBox txtUsuario;
        private TextBox txtNombre;
        private GroupBox groupBox1;
        private TextBox txtPassword;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private NumericUpDown numPeso;
        private Label label6;
        private Label label5;
        private Label label4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private NumericUpDown nunEdad;
        private GroupBox groupBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label8;
        private Label label7;
        private GroupBox groupBox4;
        private Panel panel1;
        private Panel panel2;
        private Button btnFinalizarRegistro;
        private Label label9;
        private NumericUpDown numAltura;
        private Label labelNivelActividad;
        private ComboBox comboNivelActividad;
    }
}