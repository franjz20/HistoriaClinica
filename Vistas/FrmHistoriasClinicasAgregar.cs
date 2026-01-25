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

using ClasesBase;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Vistas
{
    public partial class FrmHistoriasClinicasAgregar : Form
    {
        int idPaciente;
        public FrmHistoriasClinicasAgregar(int pacienteId)
        {
            InitializeComponent();
            this.idPaciente = pacienteId;

            cargar_datos_paciente();
        }

        private void cargar_datos_paciente()
        {
            Paciente paciente = TrabajarPaciente.obtener_paciente_id(idPaciente);

            if(paciente != null)
            {
                labelNombre.Text = "Nombre: " + paciente.Paciente_Nombre + " " + paciente.Paciente_Apellido;
                labelDNI.Text = "DNI: " + paciente.Paciente_Dni.ToString();
                lblEdad.Text = "Edad: " + calcular_edad(paciente.Paciente_FechaNacimiento).ToString();
            }
        }

        private void btnGuardarPaciente_Click(object sender, EventArgs e)
        {
            if (!validaciones()) return;

            HistoriaClinica nuevaHC = new HistoriaClinica();

            nuevaHC.Paciente_Id = idPaciente;
            nuevaHC.Hc_motivoConsulta = txtMotivoConsulta.Text;
            nuevaHC.Hc_antecedentes = txtAntecedentes.Text;
            nuevaHC.Hc_signosVitalesFC = Convert.ToInt32(txtSigVitFC.Text);
            nuevaHC.Hc_signosVitalesPA = txtSigVitPA.Text;
            nuevaHC.Hc_signosVitalesTemp = float.Parse(txtSigVitTemp.Text);
            nuevaHC.Hc_signosVitalesSat = Convert.ToInt32(txtSigVitSat.Text);
            nuevaHC.Hc_exploracionFisica = txtExploracionFisica.Text;
            nuevaHC.Hc_diagnosticoPresuntivo = Convert.ToInt32(txtDiagPresuntivo.Text);
            nuevaHC.Hc_estudiosSolicitados = txtEstudiosSolicitados.Text;
            nuevaHC.Hc_tratamiento = txtTratamiento.Text;
            nuevaHC.Hc_observaciones = txtObservaciones.Text;
            nuevaHC.Hc_fechaConsulta = dtpFechaConsulta.Value;

            TrabajarHistoriasClinicas.insertar_Historia_Clinica(nuevaHC);

            MessageBox.Show("Historia clínica guardada correctamente");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private bool validaciones()
        {
            if (
                string.IsNullOrWhiteSpace(txtMotivoConsulta.Text) ||
                string.IsNullOrWhiteSpace(txtAntecedentes.Text) ||
                string.IsNullOrWhiteSpace(txtSigVitFC.Text) ||
                string.IsNullOrWhiteSpace(txtSigVitPA.Text) ||
                string.IsNullOrWhiteSpace(txtSigVitTemp.Text) ||
                string.IsNullOrWhiteSpace(txtSigVitSat.Text) ||
                string.IsNullOrWhiteSpace(txtExploracionFisica.Text) ||
                string.IsNullOrWhiteSpace(txtDiagPresuntivo.Text) ||
                string.IsNullOrWhiteSpace(txtEstudiosSolicitados.Text) ||
                string.IsNullOrWhiteSpace(txtTratamiento.Text) ||
                string.IsNullOrWhiteSpace(txtObservaciones.Text)
               )
            {
                MessageBox.Show("Debe completar todos los campos obligatorios.");
                return false;
            }

            // MOTIVO CONSULTA
            if (string.IsNullOrWhiteSpace(txtMotivoConsulta.Text) || !texto_medico_valido(txtMotivoConsulta.Text))
            {
                MessageBox.Show("Motivo de consulta inválido.");
                return false;
            }

            // ANTECEDENTES
            if (string.IsNullOrWhiteSpace(txtAntecedentes.Text) || !texto_medico_valido(txtAntecedentes.Text))
            {
                MessageBox.Show("Antecedentes inválidos.");
                return false;
            }

            // FRECUENCIA CARDÍACA (solo números)
            if (!int.TryParse(txtSigVitFC.Text, out int fc) || fc <= 0 || fc > 250)
            {
                MessageBox.Show("Frecuencia cardíaca inválida.");
                return false;
            }

            // PRESIÓN ARTERIAL formato 120/80
            if (!Regex.IsMatch(txtSigVitPA.Text, @"^\d{2,3}/\d{2,3}$"))
            {
                MessageBox.Show("Presión arterial inválida. Ej: 120/80");
                return false;
            }

            // TEMPERATURA (decimal con punto o coma)
            string tempTexto = txtSigVitTemp.Text.Replace(',', '.');

            if (!float.TryParse(tempTexto, NumberStyles.Any, CultureInfo.InvariantCulture, out float temp) || temp < 30 || temp > 45)
            {
                MessageBox.Show("Temperatura inválida.");
                return false;
            }

            // SATURACIÓN (0–100)
            if (!int.TryParse(txtSigVitSat.Text, out int sat) || sat < 0 || sat > 100)
            {
                MessageBox.Show("Saturación de oxígeno inválida (0-100).");
                return false;
            }

            // EXPLORACIÓN FÍSICA
            if (string.IsNullOrWhiteSpace(txtExploracionFisica.Text) || !texto_medico_valido(txtExploracionFisica.Text))
            {
                MessageBox.Show("Exploración física inválida.");
                return false;
            }

            // DIAGNÓSTICO
            if (string.IsNullOrWhiteSpace(txtDiagPresuntivo.Text) || !texto_medico_valido(txtDiagPresuntivo.Text))
            {
                MessageBox.Show("Diagnóstico inválido.");
                return false;
            }

            // ESTUDIOS
            if (string.IsNullOrWhiteSpace(txtEstudiosSolicitados.Text) || !texto_medico_valido(txtEstudiosSolicitados.Text))
            {
                MessageBox.Show("Estudios solicitados inválidos.");
                return false;
            }

            // TRATAMIENTO
            if (string.IsNullOrWhiteSpace(txtTratamiento.Text) || !texto_medico_valido(txtTratamiento.Text))
            {
                MessageBox.Show("Tratamiento inválido.");
                return false;
            }

            // OBSERVACIONES
            if (string.IsNullOrWhiteSpace(txtObservaciones.Text) || !texto_medico_valido(txtObservaciones.Text))
            {
                MessageBox.Show("Observaciones inválidas.");
                return false;
            }

            return true;
        }

        private bool texto_medico_valido(string texto)
        {
            return Regex.IsMatch(texto, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ0-9\s.,:;()%°+\-/""]+$");
        }

        private int calcular_edad(DateTime fechaNacimiento)
        {
            int edad = DateTime.Now.Year - fechaNacimiento.Year;
            if (fechaNacimiento.Date > DateTime.Today.AddYears(-edad)) edad--;
            return edad;
        }
    }
}
