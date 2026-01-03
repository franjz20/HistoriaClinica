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
            HistoriaClinica nuevaHC = new HistoriaClinica();

            nuevaHC.Paciente_Id = idPaciente;
            nuevaHC.Hc_MotivoConsulta = txtMotivoConsulta.Text;
            nuevaHC.Hc_Antecedentes = txtAntecedentes.Text;
            nuevaHC.Hc_Sigvit_fc = Convert.ToInt32(txtSigVitFC.Text);
            nuevaHC.Hc_Sigvit_pa = txtSigVitPA.Text;
            nuevaHC.Hc_Sigvit_temp = float.Parse(txtSigVitTemp.Text);
            nuevaHC.Hc_Sigvit_sat = Convert.ToInt32(txtSigVitSat.Text);
            nuevaHC.Hc_ExploracionFisica = txtExploracionFisica.Text;
            nuevaHC.Hc_DiagnosticoPresuntivo = txtDiagPresuntivo.Text;
            nuevaHC.Hc_EstudiosSolicitados = txtEstudiosSolicitados.Text;
            nuevaHC.Hc_Tratamiento = txtTratamiento.Text;
            nuevaHC.Hc_Observaciones = txtObservaciones.Text;
            nuevaHC.Hc_FechaConsulta = dtpFechaConsulta.Value;

            validaciones();

            TrabajarHistoriaClinica.insertarHistoriaClinica(nuevaHC);

            MessageBox.Show("Historia clínica guardada correctamente");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void validaciones()
        {
            if (string.IsNullOrWhiteSpace(txtMotivoConsulta.Text))
            {
                MessageBox.Show("Ingrese el motivo de la consulta.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAntecedentes.Text))
            {
                MessageBox.Show("Ingrese el antecendente.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSigVitFC.Text))
            {
                MessageBox.Show("Ingrese Signos Vitales FC.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSigVitPA.Text))
            {
                MessageBox.Show("Ingrese Signos Vitales PA.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSigVitTemp.Text))
            {
                MessageBox.Show("Ingrese Signos Vitales Temp.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSigVitSat.Text))
            {
                MessageBox.Show("Ingrese Signos Vitales Sat.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtExploracionFisica.Text))
            {
                MessageBox.Show("Ingrese Exploracion fisica.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDiagPresuntivo.Text))
            {
                MessageBox.Show("Ingrese Diagnostico presuntivo.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEstudiosSolicitados.Text))
            {
                MessageBox.Show("Ingrese Estudios Solicitados.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTratamiento.Text))
            {
                MessageBox.Show("Ingrese Tratamiento.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtObservaciones.Text))
            {
                MessageBox.Show("Ingrese Observaciones.");
                return;
            }
            //if (string.IsNullOrWhiteSpace(txtSigVitFC.Text)) ---> esta parte es para validar fecha.
            //{
            //MessageBox.Show("Ingrese Signos Vitales FC.");
            //return;
            //}
        }
    }
}
