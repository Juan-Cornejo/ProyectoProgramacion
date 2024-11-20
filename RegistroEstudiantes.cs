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
    public partial class RegistroEstudiantes : Form
    {
        private int filaSeleccionada = -1;
        public RegistroEstudiantes()
        {
            InitializeComponent();

            this.Load += new EventHandler(Form1_Load);
            DataGridViewEstudiantes.CellClick += DataGridViewEstudiantes_CellClick;

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
            DataGridViewEstudiantes.ColumnCount = 5;
            DataGridViewEstudiantes.Columns[0].Name = "Rut";
            DataGridViewEstudiantes.Columns[1].Name = "Correo";
            DataGridViewEstudiantes.Columns[2].Name = "Nombre";
            DataGridViewEstudiantes.Columns[3].Name = "Apellido";
            DataGridViewEstudiantes.Columns[4].Name = "Ramo";
        }
        private void DataGridViewEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                filaSeleccionada = e.RowIndex;

                txtbRut.Text = DataGridViewEstudiantes.Rows[filaSeleccionada].Cells["Rut"].Value.ToString();
                txtbCorreo.Text = DataGridViewEstudiantes.Rows[filaSeleccionada].Cells["Correo"].Value.ToString();
                txtbName.Text = DataGridViewEstudiantes.Rows[filaSeleccionada].Cells["Nombre"].Value.ToString();
                txtbApellido.Text = DataGridViewEstudiantes.Rows[filaSeleccionada].Cells["Apellido"].Value.ToString();
                cmbRamo.SelectedItem = DataGridViewEstudiantes.Rows[filaSeleccionada].Cells["Ramo"].Value.ToString();
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

            if (DataGridViewEstudiantes.Columns.Count == 0)
            {
                DataGridViewEstudiantes.ColumnCount = 5;
                DataGridViewEstudiantes.Columns[0].Name = "Rut";
                DataGridViewEstudiantes.Columns[1].Name = "Correo";
                DataGridViewEstudiantes.Columns[2].Name = "Nombre";
                DataGridViewEstudiantes.Columns[3].Name = "Apellido";
                DataGridViewEstudiantes.Columns[4].Name = "Ramo";
            }

            DataGridViewEstudiantes.Rows.Add(txtbRut.Text, txtbCorreo.Text, txtbName.Text,
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
            if (DataGridViewEstudiantes.IsCurrentCellDirty)
            {
                DataGridViewEstudiantes.EndEdit();
            }

            DataGridViewEstudiantes.ClearSelection();

            string filtro = txtbNombreFiltro.Text.Trim();

            if (string.IsNullOrWhiteSpace(filtro))
            {
                foreach (DataGridViewRow fila in DataGridViewEstudiantes.Rows)
                {
                    if (fila.IsNewRow)
                    {
                        continue;
                    }
                    fila.Visible = true;
                }
                return;
            }
            foreach (DataGridViewRow fila in DataGridViewEstudiantes.Rows)
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

            DataGridViewEstudiantes.Rows[filaSeleccionada].Cells["Rut"].Value = txtbRut.Text;
            DataGridViewEstudiantes.Rows[filaSeleccionada].Cells["Correo"].Value = txtbCorreo.Text;
            DataGridViewEstudiantes.Rows[filaSeleccionada].Cells["Nombre"].Value = txtbName.Text;
            DataGridViewEstudiantes.Rows[filaSeleccionada].Cells["Apellido"].Value = txtbApellido.Text;
            DataGridViewEstudiantes.Rows[filaSeleccionada].Cells["Ramo"].Value = cmbRamo.SelectedItem.ToString();

            MessageBox.Show("Datos actualizados correctamente.",
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtbRut.Clear();
            txtbCorreo.Clear();
            txtbName.Clear();
            txtbApellido.Clear();
            cmbRamo.SelectedIndex = 0;
            filaSeleccionada = -1;
            DataGridViewEstudiantes.ClearSelection();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada != -1)
            {
                DialogResult confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar esta fila?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    DataGridViewEstudiantes.Rows.RemoveAt(filaSeleccionada);
                    filaSeleccionada = -1;
                    MessageBox.Show("Fila eliminada correctamente.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtbRut.Clear();
                    txtbCorreo.Clear();
                    txtbName.Clear();
                    txtbApellido.Clear();
                    cmbRamo.SelectedIndex = 0;
                    filaSeleccionada = -1;
                    DataGridViewEstudiantes.ClearSelection();
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna fila para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}