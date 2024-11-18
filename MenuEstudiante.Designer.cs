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
            btnCursos = new Button();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnHorario
            // 
            btnHorario.BackColor = SystemColors.ControlDarkDark;
            btnHorario.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHorario.ForeColor = Color.White;
            btnHorario.Image = (Image)resources.GetObject("btnHorario.Image");
            btnHorario.Location = new Point(51, 42);
            btnHorario.Name = "btnHorario";
            btnHorario.Size = new Size(140, 109);
            btnHorario.TabIndex = 0;
            btnHorario.Text = "Horario";
            btnHorario.TextImageRelation = TextImageRelation.ImageAboveText;
            btnHorario.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnCursos);
            groupBox1.Controls.Add(btnHorario);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(422, 192);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // btnCursos
            // 
            btnCursos.BackColor = SystemColors.ControlDarkDark;
            btnCursos.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCursos.ForeColor = Color.White;
            btnCursos.Image = (Image)resources.GetObject("btnCursos.Image");
            btnCursos.Location = new Point(228, 42);
            btnCursos.Name = "btnCursos";
            btnCursos.Size = new Size(137, 109);
            btnCursos.TabIndex = 1;
            btnCursos.Text = "Cursos";
            btnCursos.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCursos.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(298, -3);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 6;
            label2.Text = "Cerrar sesión";
            label2.Click += label2_Click;
            // 
            // MenuEstudiante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(446, 216);
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
    }
}