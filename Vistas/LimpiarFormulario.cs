using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public class LimpiarFormulario : Form
    {
        public LimpiarFormulario()
        {

        }

        protected void LimpiarForm(Control control)
        {
            foreach(Control c in control.Controls)
            {
                if(c is TextBox)
                {
                    ((TextBox)c).Clear();
                } 
                else if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                }
                else if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }
                else if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
                else if (c.HasChildren)
                {
                    LimpiarForm(c);
                }
            }
        }

        protected void ResetDataGridView(DataGridView dataGridView, object dataSource)
        {
            dataGridView.DataSource = dataSource;
        }

    }
}
