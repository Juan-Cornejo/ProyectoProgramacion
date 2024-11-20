using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestLogin
{
    public partial class RegistroProfesores : Form
    {
        private int filaSeleccionada = -1;
        public RegistroProfesores()
        {
            InitializeComponent();

            this.Load += new EventHandler(Form1_Load);
            DataGridViewProfesores.CellClick += DataGridViewProfesores_CellClick;

            cmbRamo.Items.Add("Seleccione...");
            cmbRamo.Items.Add("Programación II");
            cmbRamo.Items.Add("Base de Datos II");
            cmbRamo.Items.Add("Inglés Técnico I");
            cmbRamo.Items.Add("Taller de Creatividad e Innovación");
            cmbRamo.Items.Add("Persona, Comunión y Servicio");
            cmbRamo.Items.Add("Diseño de Software");
            cmbRamo.SelectedIndex = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewProfesores.ColumnCount = 5;
            DataGridViewProfesores.Columns[0].Name = "Rut";
            DataGridViewProfesores.Columns[1].Name = "Correo";
            DataGridViewProfesores.Columns[2].Name = "Nombre";
            DataGridViewProfesores.Columns[3].Name = "Apellido";
            DataGridViewProfesores.Columns[4].Name = "Ramo";
        }
        private void DataGridViewProfesores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                filaSeleccionada = e.RowIndex;

                txtbRut.Text = DataGridViewProfesores.Rows[filaSeleccionada].Cells["Rut"].Value.ToString();
                txtbCorreo.Text = DataGridViewProfesores.Rows[filaSeleccionada].Cells["Correo"].Value.ToString();
                txtbName.Text = DataGridViewProfesores.Rows[filaSeleccionada].Cells["Nombre"].Value.ToString();
                txtbApellido.Text = DataGridViewProfesores.Rows[filaSeleccionada].Cells["Apellido"].Value.ToString();
                cmbRamo.SelectedItem = DataGridViewProfesores.Rows[filaSeleccionada].Cells["Ramo"].Value.ToString();
            }
        }
        private void btnAtras_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new MenuPrincipal().Show();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbRut.Text) || string.IsNullOrWhiteSpace(txtbCorreo.Text) ||
        string.IsNullOrWhiteSpace(txtbName.Text) || string.IsNullOrWhiteSpace(txtbApellido.Text) ||
        cmbRamo.SelectedIndex == 0)
            {
                MessageBox.Show("Todos los campos son obligatorios.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show("¿Confirmar proceso de guardar?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.No)
                return;

            if (DataGridViewProfesores.Columns.Count == 0)
            {
                DataGridViewProfesores.ColumnCount = 5;
                DataGridViewProfesores.Columns[0].Name = "Rut";
                DataGridViewProfesores.Columns[1].Name = "Correo";
                DataGridViewProfesores.Columns[2].Name = "Nombre";
                DataGridViewProfesores.Columns[3].Name = "Apellido";
                DataGridViewProfesores.Columns[4].Name = "Ramo";
            }

            DataGridViewProfesores.Rows.Add(txtbRut.Text, txtbCorreo.Text, txtbName.Text,
                txtbApellido.Text, cmbRamo.SelectedItem.ToString());

            MessageBox.Show("Datos guardados correctamente.",
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtbRut.Clear();
            txtbCorreo.Clear();
            txtbName.Clear();
            txtbApellido.Clear();
            cmbRamo.SelectedIndex = 0;
            txtbRut.Focus();
        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (DataGridViewProfesores.IsCurrentCellDirty)
            {
                DataGridViewProfesores.EndEdit();
            }

            DataGridViewProfesores.ClearSelection();

            string filtro = txtbNombreFiltro.Text.Trim();

            if (string.IsNullOrWhiteSpace(filtro))
            {
                foreach (DataGridViewRow fila in DataGridViewProfesores.Rows)
                {
                    if (fila.IsNewRow)
                    {
                        continue;
                    }
                    fila.Visible = true;
                }
                return;
            }
            foreach (DataGridViewRow fila in DataGridViewProfesores.Rows)
            {
                if (fila.IsNewRow)
                {
                    continue;
                }
                if (fila.Cells["Nombre"].Value != null &&
                    fila.Cells["Nombre"].Value.ToString().IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    fila.Visible = true;
                }
                else
                {
                    fila.Visible = false;
                }
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada == -1)
            {
                MessageBox.Show("No se ha seleccionado ninguna fila para actualizar.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtbRut.Text) || string.IsNullOrWhiteSpace(txtbCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtbName.Text) || string.IsNullOrWhiteSpace(txtbApellido.Text) ||
                cmbRamo.SelectedIndex == 0)
            {
                MessageBox.Show("Todos los campos son obligatorios.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show("¿Desea actualizar los datos?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.No)
                return;

            DataGridViewProfesores.Rows[filaSeleccionada].Cells["Rut"].Value = txtbRut.Text;
            DataGridViewProfesores.Rows[filaSeleccionada].Cells["Correo"].Value = txtbCorreo.Text;
            DataGridViewProfesores.Rows[filaSeleccionada].Cells["Nombre"].Value = txtbName.Text;
            DataGridViewProfesores.Rows[filaSeleccionada].Cells["Apellido"].Value = txtbApellido.Text;
            DataGridViewProfesores.Rows[filaSeleccionada].Cells["Ramo"].Value = cmbRamo.SelectedItem.ToString();

            MessageBox.Show("Datos actualizados correctamente.",
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtbRut.Clear();
            txtbCorreo.Clear();
            txtbName.Clear();
            txtbApellido.Clear();
            cmbRamo.SelectedIndex = 0;
            filaSeleccionada = -1;
            DataGridViewProfesores.ClearSelection();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada != -1)
            {
                DialogResult confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar esta fila?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    DataGridViewProfesores.Rows.RemoveAt(filaSeleccionada);
                    filaSeleccionada = -1;
                    MessageBox.Show("Fila eliminada correctamente.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtbRut.Clear();
                    txtbCorreo.Clear();
                    txtbName.Clear();
                    txtbApellido.Clear();
                    cmbRamo.SelectedIndex = 0;
                    filaSeleccionada = -1;
                    DataGridViewProfesores.ClearSelection();
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna fila para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}