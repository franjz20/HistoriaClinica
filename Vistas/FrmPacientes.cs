using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ClasesBase;

namespace Vistas
{
    public partial class FrmPacientes : Form
    {
        public FrmPacientes()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill; //esto permite que el formulario se pegue dentro del panel principal
        }

        private void FrmPacientes_Load(Object sender, EventArgs e)
        {
            load_pacientes();
        }
        private void load_pacientes()
        {

            var tablaDatos = TrabajarPaciente.listar_pacientes();

            var vistaTabla = tablaDatos.AsEnumerable()
                .Select(row => new
                {
                    Id = Convert.ToInt32(row["PacienteId"]),
                    DNI = row["DNI"] == DBNull.Value ? "" : row["DNI"].ToString(),
                    Apellido = row["Apellido"]?.ToString(),
                    Nombre = row["Nombre"]?.ToString(),
                    Email = row["Email"] == DBNull.Value ? "" : row["Email"].ToString(),
                    ObraSocial = row["ObraSocial"] == DBNull.Value ? "" : row["ObraSocial"].ToString(),
                    Observaciones = row["Observaciones"] == DBNull.Value ? "" : row["Observaciones"].ToString()
                })
                .ToList();

            //dgvPacientes.DataSource = TrabajarPaciente.listar_pacientes();
            //dgvPacientes.DataSource = null;
            BindingSource bs = new BindingSource();
            bs.DataSource = vistaTabla;

            dgvPacientes.AutoGenerateColumns = true;
            //dgvPacientes.ColumnHeadersVisible = true;
            //dgvPacientes.DataSource = vistaTabla;
            dgvPacientes.DataSource = bs;

            dgvPacientes.Columns["Id"].HeaderText = "ID";
            //dgvPacientes.Columns["PacienteId"].Visible = false;
            dgvPacientes.Columns["DNI"].HeaderText = "DNI";
            dgvPacientes.Columns["Apellido"].HeaderText = "Apellido";
            dgvPacientes.Columns["Nombre"].HeaderText = "Nombre";
            dgvPacientes.Columns["Email"].HeaderText = "Correo Electronico";
            dgvPacientes.Columns["ObraSocial"].HeaderText = "Obra Social";
            dgvPacientes.Columns["Observaciones"].HeaderText = "Observaciones";
        }
        private void FrmPacientes_Shown(object sender, EventArgs e)
        {
            load_pacientes();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmPacienteAgregar oFrmPacienteAgregar = new FrmPacienteAgregar();
            oFrmPacienteAgregar.ShowDialog();
            load_pacientes();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un paciente para modificar.");
                return;
            }

            //Obtener el ID del paciente a modificar
            int idPaciente = obtener_PacienteId_Seleccionado();

            FrmPacienteAgregar oFrmPacienteAgregar = new FrmPacienteAgregar(idPaciente);
            oFrmPacienteAgregar.ShowDialog();
            load_pacientes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Paciente eliminar_paciente = new Paciente();

            eliminar_paciente.Paciente_Id = obtener_PacienteId_Seleccionado();//Asignar el ID del paciente seleccionado

            TrabajarPaciente.eliminar_paciente(eliminar_paciente);
            load_pacientes();
            //LimpiarForm(this);
        }

        //Funciones de ayuda para el manejo del DataGridView
        private int obtener_PacienteId_Seleccionado()
        {
            if (dgvPacientes.CurrentRow != null)
            {
                //Obtener el valor de la celda que contiene el ID del Paciente
                return Convert.ToInt32(dgvPacientes.CurrentRow.Cells["Id"].Value);
            }
            else
            {
                throw new Exception("No se ha seleccionado ningún paciente.");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.ToLower();

            foreach (DataGridView fila in dgvPacientes.Rows)
            {
                //if (fila.DataBoundItem == null) continue;

                //string dni = fila.Cells["DNI"].Value.ToString().ToLower();
                //string apellido = fila.Cells["Apellido"].Value.ToString().ToLower();

                //fila.Visible = dni.Contains(filtro) || apellido.Contains(filtro);
            }

        }

    }
}
