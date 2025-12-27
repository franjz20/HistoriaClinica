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
        public FrmHistoriasClinicas()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill; //esto permite que el formulario se pegue dentro del panel principal
        }

        private void FrmHistoriasClinicas_Load(object sender, EventArgs e)
        {
            load_historias_clinicas();
        }

        private void load_historias_clinicas()
        {
            DataTable tablaDatos = TrabajarHistoriasClinicas.listar_historias_clinicas();

            dgvHistoriasClinicas.DataSource = tablaDatos;

            if(dgvHistoriasClinicas.Rows.Count == 0)
            {
                //FrmHistoriaClinicaNueva oFrmHCNueva = new FrmHistoriaClinicaNueva();
                //oFrmHCNueva.ShowDialog();

                tablaDatos = TrabajarHistoriasClinicas.listar_historias_clinicas();
                dgvHistoriasClinicas.DataSource = tablaDatos;
            }

        }
    }
}
