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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void AbrirFormularioPanel(Form formHijo)
        {
            //Si hay algun formulario cargado, se lo borra de pantalla
            if (panelContenido.Controls.Count > 0)
                panelContenido.Controls.Clear();

            //Configurar el formulario hijo
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            panelContenido.Controls.Add(formHijo);
            panelContenido.Tag = formHijo;
            formHijo.Show();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            AbrirFormularioPanel(new FrmPacientes());
        }

        private void btnHistoriaClinica_Click(object sender, EventArgs e)
        {
            AbrirFormularioPanel(new FrmHistoriaClinicaAgregar());
        }

        private void btnTurnos_Click(object sender, EventArgs e)
        {
            AbrirFormularioPanel(new FrmTurnos());
        }

        private void btnProfesional_Click(object sender, EventArgs e)
        {
            AbrirFormularioPanel(new FrmProfesionales());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
