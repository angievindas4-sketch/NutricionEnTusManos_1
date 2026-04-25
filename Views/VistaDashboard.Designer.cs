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
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 645);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(250, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1052, 642);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel1);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(220, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1101, 645);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(button1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1101, 150);
            panel4.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(833, 40);
            button1.Name = "button1";
            button1.Size = new Size(190, 82);
            button1.TabIndex = 0;
            button1.Text = "Actualizar Perfil";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 36);
            label1.Name = "label1";
            label1.Size = new Size(181, 25);
            label1.TabIndex = 1;
            label1.Text = "Nombre del Usuario: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 97);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 2;
            label2.Text = "ID Usuario:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel5, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 150);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1101, 300);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(544, 294);
            panel5.TabIndex = 0;
            // 
            // VistaDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1321, 645);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "VistaDashboard";
            Text = "VistaDashboard";
            Load += VistaDashboard_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label2;
        private Label label1;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel5;
    }
}