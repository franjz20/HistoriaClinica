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
    public partial class FrmPacienteAgregar : Form
    {
        int idPaciente = 0;

        public FrmPacienteAgregar()
        {
            InitializeComponent();
        }

        public FrmPacienteAgregar(int id)
        {
            InitializeComponent();
            idPaciente = id;

            if(idPaciente != 0)
            {
                lblTitulo.Text = "Modificar Paciente";
            }

            cargar_datos();
        }

        private void cargar_datos()
        {
            if (idPaciente != 0)
            {
                this.Text = "Modificar Paciente";
                Paciente paciente = TrabajarPaciente.listar_pacientes().AsEnumerable()
                    .Where(row => row.Field<int>("PacienteId") == idPaciente)
                    .Select(row => new Paciente
                    {
                        Paciente_Id = Convert.ToInt32(row["PacienteId"]),
                        Paciente_Dni = Convert.ToInt32(row["DNI"]),
                        Paciente_Apellido = row["Apellido"].ToString(),
                        Paciente_Nombre = row["Nombre"].ToString(),
                        Paciente_FechaNacimiento = Convert.ToDateTime(row["FechaNacimiento"]),
                        Paciente_Genero = row["Genero"].ToString(),
                        Paciente_Telefono = Convert.ToInt32(row["Telefono"]),
                        Paciente_Direccion = row["Direccion"].ToString(),
                        Paciente_Email = row["Email"].ToString(),
                        Paciente_ObraSocial = row["ObraSocial"].ToString(),
                        Paciente_NumeroAfiliado = Convert.ToInt32(row["NumeroAfiliado"]),
                        Paciente_Observaciones = row["Observaciones"].ToString()
                    })
                    .FirstOrDefault();
                if (paciente != null)
                {
                    txtDni.Text = paciente.Paciente_Dni.ToString();
                    txtApellido.Text = paciente.Paciente_Apellido;
                    txtNombre.Text = paciente.Paciente_Nombre;
                    dtpFechaNacimiento.Value = paciente.Paciente_FechaNacimiento;
                    cmbGenero.SelectedItem = paciente.Paciente_Genero;
                    txtTelefono.Text = paciente.Paciente_Telefono.ToString();
                    txtDireccion.Text = paciente.Paciente_Direccion;
                    txtEmail.Text = paciente.Paciente_Email;
                    txtObraSocial.Text = paciente.Paciente_ObraSocial;
                    txtNumeroAfiliado.Text = paciente.Paciente_NumeroAfiliado.ToString();
                    txtObservaciones.Text = paciente.Paciente_Observaciones;
                }
            }
        }

        private void btnGuardarPaciente_Click(object sender, EventArgs e)
        {

            if(idPaciente == 0)
            {
                agregar_paciente();
                MessageBox.Show("Paciente agregado");
            }
            else
            {
                modificar_paciente();
                MessageBox.Show("Paciente modificado");
            }

            this.Close();
        }

        private void agregar_paciente()
        {
            Paciente nuevo_paciente = new Paciente();

            int dni, telefono, numeroAfiliado;

            if (!int.TryParse(txtDni.Text, out dni))
            {
                MessageBox.Show("DNI inválido");
                return;
            }

            if (!int.TryParse(txtTelefono.Text, out telefono))
            {
                MessageBox.Show("Teléfono inválido");
                return;
            }

            if (!int.TryParse(txtNumeroAfiliado.Text, out numeroAfiliado))
            {
                MessageBox.Show("Número de afiliado inválido");
                return;
            }

            nuevo_paciente.Paciente_Dni = dni;
            nuevo_paciente.Paciente_Apellido = txtApellido.Text;
            nuevo_paciente.Paciente_Nombre = txtNombre.Text;
            nuevo_paciente.Paciente_FechaNacimiento = dtpFechaNacimiento.Value;

            if (cmbGenero.SelectedItem != null)
                nuevo_paciente.Paciente_Genero = cmbGenero.SelectedItem.ToString();
            
            nuevo_paciente.Paciente_Telefono = telefono;
            nuevo_paciente.Paciente_Direccion = txtDireccion.Text;
            nuevo_paciente.Paciente_Email = txtEmail.Text;
            nuevo_paciente.Paciente_ObraSocial = txtObraSocial.Text;
            nuevo_paciente.Paciente_NumeroAfiliado = numeroAfiliado;
            nuevo_paciente.Paciente_Observaciones = txtObservaciones.Text;

            TrabajarPaciente.insertar_paciente(nuevo_paciente);
        }

        private void modificar_paciente()
        {
            Paciente mod_paciente = new Paciente();

            int dni, telefono, numeroAfiliado;

            if (!int.TryParse(txtDni.Text, out dni))
            {
                MessageBox.Show("DNI inválido");
                return;
            }

            if (!int.TryParse(txtTelefono.Text, out telefono))
            {
                MessageBox.Show("Teléfono inválido");
                return;
            }

            if (!int.TryParse(txtNumeroAfiliado.Text, out numeroAfiliado))
            {
                MessageBox.Show("Número de afiliado inválido");
                return;
            }

            mod_paciente.Paciente_Id = idPaciente;
            mod_paciente.Paciente_Dni = dni;
            mod_paciente.Paciente_Apellido = txtApellido.Text;
            mod_paciente.Paciente_Nombre = txtNombre.Text;
            mod_paciente.Paciente_FechaNacimiento = dtpFechaNacimiento.Value;

            if (cmbGenero.SelectedItem != null)
                mod_paciente.Paciente_Genero = cmbGenero.SelectedItem.ToString();

            mod_paciente.Paciente_Telefono = telefono;
            mod_paciente.Paciente_Direccion = txtDireccion.Text;
            mod_paciente.Paciente_Email = txtEmail.Text;
            mod_paciente.Paciente_ObraSocial = txtObraSocial.Text;
            mod_paciente.Paciente_NumeroAfiliado = numeroAfiliado;
            mod_paciente.Paciente_Observaciones = txtObservaciones.Text;

            TrabajarPaciente.modificar_paciente(mod_paciente);
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
