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
            btnEstudiantes = new Button();
            label2 = new Label();
            btnProfesores = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEstudiantes);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnProfesores);
            groupBox1.Location = new Point(10, 6);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(426, 201);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // btnEstudiantes
            // 
            btnEstudiantes.BackColor = SystemColors.ControlDarkDark;
            btnEstudiantes.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEstudiantes.ForeColor = Color.White;
            btnEstudiantes.Image = Properties.Resources.profesor;
            btnEstudiantes.Location = new Point(252, 46);
            btnEstudiantes.Name = "btnEstudiantes";
            btnEstudiantes.RightToLeft = RightToLeft.No;
            btnEstudiantes.Size = new Size(131, 108);
            btnEstudiantes.TabIndex = 3;
            btnEstudiantes.Text = "Profesores";
            btnEstudiantes.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEstudiantes.UseVisualStyleBackColor = false;
            btnEstudiantes.Click += btnEstudiantes_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(320, 3);
            label2.Name = "label2";
            label2.Size = new Size(106, 17);
            label2.TabIndex = 6;
            label2.Text = "Cerrar sesión";
            label2.Click += label2_Click;
            // 
            // btnProfesores
            // 
            btnProfesores.BackColor = SystemColors.ControlDarkDark;
            btnProfesores.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfesores.ForeColor = Color.White;
            btnProfesores.Image = Properties.Resources.gorro_de_graduacion__2_;
            btnProfesores.ImageAlign = ContentAlignment.BottomCenter;
            btnProfesores.Location = new Point(39, 46);
            btnProfesores.Name = "btnProfesores";
            btnProfesores.Size = new Size(131, 108);
            btnProfesores.TabIndex = 2;
            btnProfesores.Text = "Estudiantes";
            btnProfesores.TextImageRelation = TextImageRelation.ImageAboveText;
            btnProfesores.UseVisualStyleBackColor = false;
            btnProfesores.Click += btnProfesores_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(446, 216);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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
        private Button btnProfesores;
        private Button btnEstudiantes;
    }
}