using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Usuario
    {
        private int usuario_Id;
        //private int rol_Id;
        private string usuario_Apellido;
        private string usuario_Nombre;
        private string usuario_Email;
        private string usuario_Contraseña;
        private string usuario_NombreUsuario;

        // Constructor
        public Usuario()
        {
            // Constructor por defecto
        }
        public Usuario(string usuario_NombreUsuario, string usuario_Contraseña)
        {
            this.usuario_NombreUsuario = usuario_NombreUsuario;
            this.usuario_Contraseña = usuario_Contraseña;
        }

        // Getters and Setters / Propiedades
        public int Usuario_Id { get => usuario_Id; set => usuario_Id = value; }
        //public int Rol_Id { get => rol_Id; set => rol_Id = value; }
        public string Usuario_Apellido { get => usuario_Apellido; set => usuario_Apellido = value; }
        public string Usuario_Nombre { get => usuario_Nombre; set => usuario_Nombre = value; }
        public string Usuario_Email { get => usuario_Email; set => usuario_Email = value; }
        public string Usuario_Contraseña { get => usuario_Contraseña; set => usuario_Contraseña = value; }
        public string Usuario_NombreUsuario { get => usuario_NombreUsuario; set => usuario_NombreUsuario = value; }
    }
}