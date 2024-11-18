namespace TestLogin
{
    partial class RegistroEstudiantes
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
            btnAtras = new Button();
            SuspendLayout();
            // 
            // btnAtras
            // 
            btnAtras.BackColor = SystemColors.ControlDarkDark;
            btnAtras.FlatAppearance.BorderSize = 0;
            btnAtras.FlatStyle = FlatStyle.Flat;
            btnAtras.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtras.ForeColor = Color.White;
            btnAtras.Location = new Point(21, 31);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(103, 41);
            btnAtras.TabIndex = 5;
            btnAtras.Text = "Atrás";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // RegistroEstudiantes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAtras);
            Name = "RegistroEstudiantes";
            Text = "Registro Estudiantes";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAtras;
    }
}