namespace NutricionEnTusManos_1.Views
{
    partial class VistaRegistro
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
            label1 = new Label();
            txtNombre = new TextBox();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            numPeso = new NumericUpDown();
            nunEdad = new NumericUpDown();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPeso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nunEdad).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1278, 678);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 66);
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
            // txtUsuario
            // 
            txtUsuario.Location = new Point(209, 130);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(297, 31);
            txtUsuario.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(209, 193);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(297, 31);
            txtPassword.TabIndex = 3;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 196);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 5;
            label3.Text = "Contraseña:";
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
            groupBox1.Location = new Point(12, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(521, 287);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de la Cuenta";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(nunEdad);
            groupBox2.Controls.Add(numPeso);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(554, 59);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(338, 287);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información Física";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 58);
            label4.Name = "label4";
            label4.Size = new Size(103, 28);
            label4.TabIndex = 0;
            label4.Text = "Peso (kg):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 113);
            label5.Name = "label5";
            label5.Size = new Size(67, 28);
            label5.TabIndex = 1;
            label5.Text = "Edad: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 168);
            label6.Name = "label6";
            label6.Size = new Size(84, 28);
            label6.TabIndex = 2;
            label6.Text = "Género:";
            // 
            // numPeso
            // 
            numPeso.Location = new Point(156, 56);
            numPeso.Name = "numPeso";
            numPeso.Size = new Size(154, 34);
            numPeso.TabIndex = 3;
            // 
            // nunEdad
            // 
            nunEdad.Location = new Point(156, 111);
            nunEdad.Name = "nunEdad";
            nunEdad.Size = new Size(154, 34);
            nunEdad.TabIndex = 4;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(157, 164);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(129, 32);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Masculino";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(157, 202);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(128, 32);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "Femenino";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(157, 240);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(78, 32);
            radioButton3.TabIndex = 7;
            radioButton3.TabStop = true;
            radioButton3.Text = "Otro";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // VistaRegistro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 678);
            Controls.Add(panel1);
            Name = "VistaRegistro";
            Text = "VistaRegistro";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPeso).EndInit();
            ((System.ComponentModel.ISupportInitialize)nunEdad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
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
    }
}