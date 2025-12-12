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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            bool usuarioEncontrado = false;

            //Usuario usuario1 = new Usuario("franco", "1234");
            //Usuario usuario2 = new Usuario("daniel", "5678");

            string nombreUsuario = txtNombreUsuario.Text;
            string contraseñaUsuario = txtContraseñaUsuario.Text;

            Usuario autenticadorUsuario = TrabajarUsuario.autenticar_usuario(nombreUsuario, contraseñaUsuario);

            
            if(autenticadorUsuario != null)
            {
                FrmMain oFrmMain = new FrmMain();
                oFrmMain.Show();
                usuarioEncontrado = true;
                
                if(usuarioEncontrado)
                {
                    MessageBox.Show("Bienvenido/a: " + txtNombreUsuario.Text);
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Incorrectos.");
                }
            }
            else
            {
                MessageBox.Show("No figura en el sistema.");
            }
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            FrmUsuario oFrmUsuario = new FrmUsuario();
            oFrmUsuario.Show();
        }
    }
}
