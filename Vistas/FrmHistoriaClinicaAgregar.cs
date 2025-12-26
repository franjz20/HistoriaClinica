using ClasesBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmHistoriaClinicaAgregar : Form
    {
        public FrmHistoriaClinicaAgregar()
        {
            InitializeComponent();
            getPacienteInit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Paciente pacienteRecuperado = TrabajarPaciente.ObtenerPacientePorId(1);
            MessageBox.Show("Paciente recuperado: " + pacienteRecuperado.Paciente_Nombre + pacienteRecuperado.Paciente_Apellido);
        }

        private void getPacienteInit ()
        {
            Paciente pacienteBuscado = TrabajarPaciente.ObtenerPacientePorId(1);
            lblNombre.Text = pacienteBuscado.Paciente_Nombre + ' '+ pacienteBuscado.Paciente_Apellido;
            lblDomicilio.Text = "Domicilio: " + pacienteBuscado.Paciente_Direccion;
            lblFechaNac.Text = "Fecha de Nacimiento :" + pacienteBuscado.Paciente_FechaNacimiento.ToShortDateString();
            lblnroTel.Text = "Nro. de Teléfono :" + pacienteBuscado.Paciente_Telefono.ToString();
            lblEdad.Text = "Edad :" + CalculateAge(pacienteBuscado.Paciente_FechaNacimiento).ToString() + " años";
            lblObraSocial.Text = "Obra Social :" + pacienteBuscado.Paciente_ObraSocial.ToString();
            lblAfiliado.Text = "Nro. de Afiliado :" + pacienteBuscado.Paciente_NumeroAfiliado.ToString();
        }

        private int CalculateAge(DateTime dateP)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dateP.Year;
            if (dateP.Date > today.AddYears(-age)) age--;
            return age;
        }

   
    }
}
