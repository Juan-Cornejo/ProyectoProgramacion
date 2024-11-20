namespace TestLogin
{
    partial class MenuPrincipal
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
            groupBox1 = new GroupBox();
            btnProfesores = new Button();
            label2 = new Label();
            btnEstudiantes = new Button();
            label8 = new Label();
            label7 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnProfesores);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnEstudiantes);
            groupBox1.Location = new Point(11, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(396, 245);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // btnProfesores
            // 
            btnProfesores.BackColor = SystemColors.ControlDarkDark;
            btnProfesores.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfesores.ForeColor = Color.White;
            btnProfesores.Image = Properties.Resources.profesor;
            btnProfesores.ImageAlign = ContentAlignment.BottomCenter;
            btnProfesores.Location = new Point(215, 61);
            btnProfesores.Margin = new Padding(3, 4, 3, 4);
            btnProfesores.Name = "btnProfesores";
            btnProfesores.RightToLeft = RightToLeft.No;
            btnProfesores.Size = new Size(150, 144);
            btnProfesores.TabIndex = 3;
            btnProfesores.Text = "Profesores";
            btnProfesores.TextImageRelation = TextImageRelation.ImageAboveText;
            btnProfesores.UseVisualStyleBackColor = false;
            btnProfesores.Click += btnProfesores_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(137, 222);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 6;
            label2.Text = "Cerrar sesión";
            label2.Click += label2_Click;
            // 
            // btnEstudiantes
            // 
            btnEstudiantes.BackColor = SystemColors.ControlDarkDark;
            btnEstudiantes.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEstudiantes.ForeColor = Color.White;
            btnEstudiantes.Image = Properties.Resources.gorro_de_graduacion__2_;
            btnEstudiantes.ImageAlign = ContentAlignment.BottomCenter;
            btnEstudiantes.Location = new Point(25, 61);
            btnEstudiantes.Margin = new Padding(3, 4, 3, 4);
            btnEstudiantes.Name = "btnEstudiantes";
            btnEstudiantes.Size = new Size(150, 144);
            btnEstudiantes.TabIndex = 2;
            btnEstudiantes.Text = "Estudiantes";
            btnEstudiantes.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEstudiantes.UseVisualStyleBackColor = false;
            btnEstudiantes.Click += btnEstudiantes_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Bahnschrift Condensed", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(153, 0);
            label8.Name = "label8";
            label8.Size = new Size(184, 41);
            label8.TabIndex = 19;
            label8.Text = "Administrativo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ControlDarkDark;
            label7.Font = new Font("Bahnschrift Condensed", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(78, 0);
            label7.Name = "label7";
            label7.Size = new Size(78, 41);
            label7.TabIndex = 20;
            label7.Text = "Menú";
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(419, 266);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Label label2;
        private Button btnEstudiantes;
        private Button btnProfesores;
        private Label label8;
        private Label label7;
    }
}