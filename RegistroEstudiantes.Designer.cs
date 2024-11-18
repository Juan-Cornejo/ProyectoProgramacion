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
            DataGridView = new DataGridView();
            groupBox2 = new GroupBox();
            btnActualizar = new Button();
            label6 = new Label();
            btnFiltrar = new Button();
            btnEliminar = new Button();
            groupBox1 = new GroupBox();
            btnAgregar = new Button();
            label4 = new Label();
            txtbCorreo = new TextBox();
            cmbRamo = new ComboBox();
            txtbApellido = new TextBox();
            txtbName = new TextBox();
            txtbRut = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAtras
            // 
            btnAtras.BackColor = SystemColors.ControlDarkDark;
            btnAtras.FlatAppearance.BorderSize = 0;
            btnAtras.FlatStyle = FlatStyle.Flat;
            btnAtras.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtras.ForeColor = Color.White;
            btnAtras.Location = new Point(23, 0);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(103, 41);
            btnAtras.TabIndex = 5;
            btnAtras.Text = "Atrás";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // DataGridView
            // 
            DataGridView.AllowUserToOrderColumns = true;
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(291, 171);
            DataGridView.Name = "DataGridView";
            DataGridView.RowHeadersWidth = 51;
            DataGridView.Size = new Size(928, 476);
            DataGridView.TabIndex = 8;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(234, 234, 234);
            groupBox2.Controls.Add(btnActualizar);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(btnFiltrar);
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Location = new Point(291, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(928, 159);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ControlDarkDark;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(6, 99);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(132, 41);
            btnActualizar.TabIndex = 14;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift Condensed", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(410, -3);
            label6.Name = "label6";
            label6.Size = new Size(108, 57);
            label6.TabIndex = 15;
            label6.Text = "Filtro";
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = SystemColors.ControlDarkDark;
            btnFiltrar.FlatAppearance.BorderSize = 0;
            btnFiltrar.FlatStyle = FlatStyle.Flat;
            btnFiltrar.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiltrar.ForeColor = Color.White;
            btnFiltrar.Location = new Point(833, 99);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(89, 41);
            btnFiltrar.TabIndex = 14;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ControlDarkDark;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(162, 99);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 41);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
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
            groupBox1.Location = new Point(-19, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(304, 649);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ControlDarkDark;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(98, 576);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(103, 41);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 134);
            label4.Name = "label4";
            label4.Size = new Size(76, 28);
            label4.TabIndex = 11;
            label4.Text = "Correo:";
            // 
            // txtbCorreo
            // 
            txtbCorreo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbCorreo.Location = new Point(23, 165);
            txtbCorreo.Name = "txtbCorreo";
            txtbCorreo.Size = new Size(262, 34);
            txtbCorreo.TabIndex = 10;
            // 
            // cmbRamo
            // 
            cmbRamo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRamo.FormattingEnabled = true;
            cmbRamo.Location = new Point(22, 457);
            cmbRamo.Name = "cmbRamo";
            cmbRamo.Size = new Size(263, 36);
            cmbRamo.TabIndex = 9;
            // 
            // txtbApellido
            // 
            txtbApellido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbApellido.Location = new Point(23, 355);
            txtbApellido.Name = "txtbApellido";
            txtbApellido.Size = new Size(262, 34);
            txtbApellido.TabIndex = 7;
            // 
            // txtbName
            // 
            txtbName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbName.Location = new Point(23, 257);
            txtbName.Name = "txtbName";
            txtbName.Size = new Size(262, 34);
            txtbName.TabIndex = 6;
            // 
            // txtbRut
            // 
            txtbRut.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbRut.Location = new Point(23, 75);
            txtbRut.Name = "txtbRut";
            txtbRut.Size = new Size(262, 34);
            txtbRut.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 426);
            label5.Name = "label5";
            label5.Size = new Size(67, 28);
            label5.TabIndex = 4;
            label5.Text = "Ramo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 324);
            label3.Name = "label3";
            label3.Size = new Size(90, 28);
            label3.TabIndex = 2;
            label3.Text = "Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 226);
            label2.Name = "label2";
            label2.Size = new Size(89, 28);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 44);
            label1.Name = "label1";
            label1.Size = new Size(46, 28);
            label1.TabIndex = 0;
            label1.Text = "Rut:";
            // 
            // RegistroEstudiantes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1240, 659);
            Controls.Add(DataGridView);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistroEstudiantes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro Estudiantes";
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAtras;
        private DataGridView DataGridView;
        private GroupBox groupBox2;
        private Button btnActualizar;
        private Label label6;
        private Button btnFiltrar;
        private Button btnEliminar;
        private GroupBox groupBox1;
        private Button btnAgregar;
        private Label label4;
        private TextBox txtbCorreo;
        private ComboBox cmbRamo;
        private TextBox txtbApellido;
        private TextBox txtbName;
        private TextBox txtbRut;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}