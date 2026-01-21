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

namespace Vistas
{
    public partial class FrmHistoriasClinicasAgregar : Form
    {
        int idPaciente;
        public FrmHistoriasClinicasAgregar(int pacienteId)
        {
            InitializeComponent();
            this.idPaciente = pacienteId;
        }

        private void btnGuardarPaciente_Click(object sender, EventArgs e)
        {
            //HistoriaClinica nuevaHC = new HistoriaClinica();

            //nuevaHC.Paciente_Id = idPaciente;
            //nuevaHC.Hc_MotivoConsulta = txtMotivoConsulta.Text;
            //nuevaHC.Hc_Antecedentes = txtAntecedentes.Text;
            //nuevaHC.Hc_Sigvit_fc = Convert.ToInt32(txtSigVitFC.Text);
            //nuevaHC.Hc_Sigvit_pa = txtSigVitPA.Text;
            //nuevaHC.Hc_Sigvit_temp = float.Parse(txtSigVitTemp.Text);
            //nuevaHC.Hc_Sigvit_sat = Convert.ToInt32(txtSigVitSat.Text);
            //nuevaHC.Hc_ExploracionFisica = txtExploracionFisica.Text;
            //nuevaHC.Hc_DiagnosticoPresuntivo = txtDiagPresuntivo.Text;
            //nuevaHC.Hc_EstudiosSolicitados = txtEstudiosSolicitados.Text;
            //nuevaHC.Hc_Tratamiento = txtTratamiento.Text;
            //nuevaHC.Hc_Observaciones = txtObservaciones.Text;
            //nuevaHC.Hc_FechaConsulta = dtpFechaConsulta.Value;

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

            if (!validaciones()) return;

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
            if (string.IsNullOrWhiteSpace(txtMotivoConsulta.Text))
            {
                MessageBox.Show("Ingrese el motivo de la consulta.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAntecedentes.Text))
            {
                MessageBox.Show("Ingrese el antecendente.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSigVitFC.Text))
            {
                MessageBox.Show("Ingrese Signos Vitales FC.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSigVitPA.Text))
            {
                MessageBox.Show("Ingrese Signos Vitales PA.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSigVitTemp.Text))
            {
                MessageBox.Show("Ingrese Signos Vitales Temp.");
                return false;
            } 
            if (string.IsNullOrWhiteSpace(txtSigVitSat.Text))
            {
                MessageBox.Show("Ingrese Signos Vitales Sat.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtExploracionFisica.Text))
            {
                MessageBox.Show("Ingrese Exploracion fisica.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDiagPresuntivo.Text))
            {
                MessageBox.Show("Ingrese Diagnostico presuntivo.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEstudiosSolicitados.Text))
            {
                MessageBox.Show("Ingrese Estudios Solicitados.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTratamiento.Text))
            {
                MessageBox.Show("Ingrese Tratamiento.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtObservaciones.Text))
            {
                MessageBox.Show("Ingrese Observaciones.");
                return false;
            }
            //if (string.IsNullOrWhiteSpace(txtSigVitFC.Text)) ---> esta parte es para validar fecha.
            //{
            //MessageBox.Show("Ingrese Signos Vitales FC.");
            //return;
            //}
            return true;
        }
    }
}
