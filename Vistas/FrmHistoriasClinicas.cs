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
    public partial class FrmHistoriasClinicas : Form
    {
        private readonly int _pacienteId;

        public FrmHistoriasClinicas(int pacienteId = -1)
        {
            InitializeComponent();
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill; //esto permite que el formulario se pegue dentro del panel principal
            _pacienteId = pacienteId;
        }

        private void FrmHistoriasClinicas_Load(object sender, EventArgs e)
        {
            load_historias_clinicas();
        }

        private void load_historias_clinicas()
        {
            if (_pacienteId < 0)
            {
                dgvHistoriasClinicas.DataSource = null;
                return;
            }

            DataTable tablaDatos = TrabajarHistoriasClinicas.listar_HC_porPaciente(_pacienteId);

            dgvHistoriasClinicas.DataSource = tablaDatos;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FrmGestionHistoriaClinica frm = new FrmGestionHistoriaClinica();
            //frm.Show();
            FrmHistoriasClinicasAgregar frmAgregarHC = new FrmHistoriasClinicasAgregar(_pacienteId);
            frmAgregarHC.Show();
        }
    }
}
