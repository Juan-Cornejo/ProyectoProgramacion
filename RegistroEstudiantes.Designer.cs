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
            DataGridViewEstudiantes = new DataGridView();
            btnActualizar = new Button();
            btnEliminar = new Button();
            groupBox1 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            btnAgregar = new Button();
            label4 = new Label();
            txtbCorreo = new TextBox();
            btnAtras = new Button();
            cmbRamo = new ComboBox();
            txtbApellido = new TextBox();
            txtbName = new TextBox();
            txtbRut = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnFiltrar = new Button();
            txtbNombreFiltro = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridViewEstudiantes).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // DataGridViewEstudiantes
            // 
            DataGridViewEstudiantes.AllowUserToAddRows = false;
            DataGridViewEstudiantes.AllowUserToDeleteRows = false;
            DataGridViewEstudiantes.AllowUserToResizeRows = false;
            DataGridViewEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewEstudiantes.Location = new Point(291, 105);
            DataGridViewEstudiantes.Name = "DataGridViewEstudiantes";
            DataGridViewEstudiantes.ReadOnly = true;
            DataGridViewEstudiantes.RowHeadersWidth = 51;
            DataGridViewEstudiantes.Size = new Size(928, 622);
            DataGridViewEstudiantes.TabIndex = 8;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ControlDarkDark;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(956, 58);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(132, 41);
            btnActualizar.TabIndex = 14;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ControlDarkDark;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(1107, 58);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 41);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtbCorreo);
            groupBox1.Controls.Add(btnAtras);
            groupBox1.Controls.Add(cmbRamo);
            groupBox1.Controls.Add(txtbApellido);
            groupBox1.Controls.Add(txtbName);
            groupBox1.Controls.Add(txtbRut);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(273, 721);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Bahnschrift Condensed", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(34, 99);
            label8.Name = "label8";
            label8.Size = new Size(205, 57);
            label8.TabIndex = 17;
            label8.Text = "Estudiantes";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ControlDarkDark;
            label7.Font = new Font("Bahnschrift Condensed", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(61, 42);
            label7.Name = "label7";
            label7.Size = new Size(153, 57);
            label7.TabIndex = 16;
            label7.Text = "Registro";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ControlDarkDark;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(81, 651);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(103, 41);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(8, 259);
            label4.Name = "label4";
            label4.Size = new Size(73, 24);
            label4.TabIndex = 11;
            label4.Text = "Correo";
            // 
            // txtbCorreo
            // 
            txtbCorreo.BackColor = SystemColors.ControlLight;
            txtbCorreo.Font = new Font("Bahnschrift", 12F);
            txtbCorreo.ForeColor = SystemColors.ControlDarkDark;
            txtbCorreo.Location = new Point(8, 286);
            txtbCorreo.Name = "txtbCorreo";
            txtbCorreo.Size = new Size(262, 32);
            txtbCorreo.TabIndex = 10;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = SystemColors.ControlDarkDark;
            btnAtras.FlatAppearance.BorderSize = 0;
            btnAtras.FlatStyle = FlatStyle.Flat;
            btnAtras.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtras.ForeColor = Color.White;
            btnAtras.Location = new Point(0, 0);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(103, 41);
            btnAtras.TabIndex = 6;
            btnAtras.Text = "Atrás";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click_1;
            // 
            // cmbRamo
            // 
            cmbRamo.BackColor = SystemColors.ControlLight;
            cmbRamo.Font = new Font("Bahnschrift", 12F);
            cmbRamo.ForeColor = SystemColors.ControlDarkDark;
            cmbRamo.FormattingEnabled = true;
            cmbRamo.Location = new Point(8, 536);
            cmbRamo.Name = "cmbRamo";
            cmbRamo.Size = new Size(263, 32);
            cmbRamo.TabIndex = 9;
            // 
            // txtbApellido
            // 
            txtbApellido.BackColor = SystemColors.ControlLight;
            txtbApellido.Font = new Font("Bahnschrift", 12F);
            txtbApellido.ForeColor = SystemColors.ControlDarkDark;
            txtbApellido.Location = new Point(8, 455);
            txtbApellido.Name = "txtbApellido";
            txtbApellido.Size = new Size(262, 32);
            txtbApellido.TabIndex = 7;
            // 
            // txtbName
            // 
            txtbName.BackColor = SystemColors.ControlLight;
            txtbName.Font = new Font("Bahnschrift", 12F);
            txtbName.ForeColor = SystemColors.ControlDarkDark;
            txtbName.Location = new Point(8, 369);
            txtbName.Name = "txtbName";
            txtbName.Size = new Size(262, 32);
            txtbName.TabIndex = 6;
            // 
            // txtbRut
            // 
            txtbRut.BackColor = SystemColors.ControlLight;
            txtbRut.Font = new Font("Bahnschrift", 12F);
            txtbRut.ForeColor = SystemColors.ControlDarkDark;
            txtbRut.Location = new Point(8, 203);
            txtbRut.Name = "txtbRut";
            txtbRut.Size = new Size(262, 32);
            txtbRut.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(8, 509);
            label5.Name = "label5";
            label5.Size = new Size(62, 24);
            label5.TabIndex = 4;
            label5.Text = "Ramo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 428);
            label3.Name = "label3";
            label3.Size = new Size(84, 24);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 342);
            label2.Name = "label2";
            label2.Size = new Size(83, 24);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(8, 176);
            label1.Name = "label1";
            label1.Size = new Size(41, 24);
            label1.TabIndex = 0;
            label1.Text = "Rut";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlLight;
            groupBox2.Controls.Add(btnFiltrar);
            groupBox2.Controls.Add(txtbNombreFiltro);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(291, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(485, 93);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = SystemColors.ControlDarkDark;
            btnFiltrar.FlatAppearance.BorderSize = 0;
            btnFiltrar.FlatStyle = FlatStyle.Flat;
            btnFiltrar.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiltrar.ForeColor = Color.White;
            btnFiltrar.Location = new Point(377, 40);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(89, 41);
            btnFiltrar.TabIndex = 19;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // txtbNombreFiltro
            // 
            txtbNombreFiltro.BackColor = SystemColors.ControlLight;
            txtbNombreFiltro.Font = new Font("Bahnschrift", 12F);
            txtbNombreFiltro.ForeColor = SystemColors.ControlDarkDark;
            txtbNombreFiltro.Location = new Point(6, 46);
            txtbNombreFiltro.Name = "txtbNombreFiltro";
            txtbNombreFiltro.Size = new Size(262, 32);
            txtbNombreFiltro.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(0, 15);
            label6.Name = "label6";
            label6.Size = new Size(96, 28);
            label6.TabIndex = 18;
            label6.Text = "Nombre";
            // 
            // RegistroEstudiantes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1226, 739);
            Controls.Add(groupBox2);
            Controls.Add(btnActualizar);
            Controls.Add(groupBox1);
            Controls.Add(DataGridViewEstudiantes);
            Controls.Add(btnEliminar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistroEstudiantes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro Estudiantes";
            ((System.ComponentModel.ISupportInitialize)DataGridViewEstudiantes).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView DataGridViewEstudiantes;
        private Button btnActualizar;
        private Button btnEliminar;
        private GroupBox groupBox1;
        private Button btnAgregar;
        private Label label4;
        private TextBox txtbCorreo;
        private Button btnAtras;
        private ComboBox cmbRamo;
        private TextBox txtbApellido;
        private TextBox txtbName;
        private TextBox txtbRut;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private Label label7;
        private GroupBox groupBox2;
        private TextBox txtbNombreFiltro;
        private Label label6;
        private Button btnFiltrar;
    }
}