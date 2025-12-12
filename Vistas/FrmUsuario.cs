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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            bool usuarioCreado = false;
            Usuario nuevoUsuario = new Usuario ();
            
            nuevoUsuario.Usuario_NombreUsuario = txtNombreUsuarioCuenta.Text;
            nuevoUsuario.Usuario_Nombre = txtNombreCuenta.Text;
            nuevoUsuario.Usuario_Apellido = txtApellidoCuenta.Text;
            nuevoUsuario.Usuario_Email = txtEmailCuenta.Text;
            nuevoUsuario.Usuario_Contraseña = txtContraseñaCuenta.Text;

            TrabajarUsuario.insertar_usuario(nuevoUsuario);
            usuarioCreado = true;

            if (usuarioCreado)
            {
                MessageBox.Show("Usuario creado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            //LimpiarForm(this);
        }
    }
}
