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
            linkLabelEstudiantes = new LinkLabel();
            groupBox1 = new GroupBox();
            linkLabelProfesores = new LinkLabel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // linkLabelEstudiantes
            // 
            linkLabelEstudiantes.AutoSize = true;
            linkLabelEstudiantes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabelEstudiantes.LinkColor = Color.Black;
            linkLabelEstudiantes.Location = new Point(21, 110);
            linkLabelEstudiantes.Name = "linkLabelEstudiantes";
            linkLabelEstudiantes.Size = new Size(200, 28);
            linkLabelEstudiantes.TabIndex = 0;
            linkLabelEstudiantes.TabStop = true;
            linkLabelEstudiantes.Text = "Gestionar Estudiantes";
            linkLabelEstudiantes.LinkClicked += linkLabelEstudiantes_LinkClicked;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linkLabelProfesores);
            groupBox1.Controls.Add(linkLabelEstudiantes);
            groupBox1.Location = new Point(12, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(487, 268);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // linkLabelProfesores
            // 
            linkLabelProfesores.AutoSize = true;
            linkLabelProfesores.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabelProfesores.LinkColor = Color.Black;
            linkLabelProfesores.Location = new Point(257, 110);
            linkLabelProfesores.Name = "linkLabelProfesores";
            linkLabelProfesores.Size = new Size(192, 28);
            linkLabelProfesores.TabIndex = 1;
            linkLabelProfesores.TabStop = true;
            linkLabelProfesores.Text = "Gestionar Profesores";
            linkLabelProfesores.LinkClicked += linkLabelProfesores_LinkClicked;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(511, 288);
            Controls.Add(groupBox1);
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private LinkLabel linkLabelEstudiantes;
        private GroupBox groupBox1;
        private LinkLabel linkLabelProfesores;
    }
}