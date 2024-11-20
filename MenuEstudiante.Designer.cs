namespace TestLogin
{
    partial class MenuEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuEstudiante));
            btnHorario = new Button();
            groupBox1 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            btnCambiarContraseña = new Button();
            label2 = new Label();
            btnCursos = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnHorario
            // 
            btnHorario.BackColor = SystemColors.ControlDarkDark;
            btnHorario.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHorario.ForeColor = Color.White;
            btnHorario.Image = (Image)resources.GetObject("btnHorario.Image");
            btnHorario.Location = new Point(220, 62);
            btnHorario.Name = "btnHorario";
            btnHorario.Size = new Size(140, 109);
            btnHorario.TabIndex = 0;
            btnHorario.Text = "Horario";
            btnHorario.TextImageRelation = TextImageRelation.ImageAboveText;
            btnHorario.UseVisualStyleBackColor = false;
            btnHorario.Click += btnHorario_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnCambiarContraseña);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnCursos);
            groupBox1.Controls.Add(btnHorario);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(577, 192);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Bahnschrift Condensed", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(270, -3);
            label8.Name = "label8";
            label8.Size = new Size(120, 41);
            label8.TabIndex = 18;
            label8.Text = "Principal";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ControlDarkDark;
            label7.Font = new Font("Bahnschrift Condensed", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(197, -3);
            label7.Name = "label7";
            label7.Size = new Size(78, 41);
            label7.TabIndex = 17;
            label7.Text = "Menú";
            // 
            // btnCambiarContraseña
            // 
            btnCambiarContraseña.BackColor = SystemColors.ControlDarkDark;
            btnCambiarContraseña.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCambiarContraseña.ForeColor = Color.White;
            btnCambiarContraseña.Image = (Image)resources.GetObject("btnCambiarContraseña.Image");
            btnCambiarContraseña.Location = new Point(416, 63);
            btnCambiarContraseña.Name = "btnCambiarContraseña";
            btnCambiarContraseña.Size = new Size(140, 109);
            btnCambiarContraseña.TabIndex = 7;
            btnCambiarContraseña.Text = "Cambiar Contraseña";
            btnCambiarContraseña.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCambiarContraseña.UseVisualStyleBackColor = false;
            btnCambiarContraseña.Click += btnCambiarContraseña_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(453, 0);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 6;
            label2.Text = "Cerrar sesión";
            label2.Click += label2_Click;
            // 
            // btnCursos
            // 
            btnCursos.BackColor = SystemColors.ControlDarkDark;
            btnCursos.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCursos.ForeColor = Color.White;
            btnCursos.Image = (Image)resources.GetObject("btnCursos.Image");
            btnCursos.Location = new Point(26, 62);
            btnCursos.Name = "btnCursos";
            btnCursos.Size = new Size(137, 109);
            btnCursos.TabIndex = 1;
            btnCursos.Text = "Cursos";
            btnCursos.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCursos.UseVisualStyleBackColor = false;
            btnCursos.Click += btnCursos_Click;
            // 
            // MenuEstudiante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(601, 219);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuEstudiante";
            StartPosition = FormStartPosition.CenterScreen;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnHorario;
        private GroupBox groupBox1;
        private Button btnCursos;
        private Label label2;
        private Button btnCambiarContraseña;
        private Label label7;
        private Label label8;
    }
}