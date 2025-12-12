using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Rol
    {
        private int rol_Id;
        private string rol_Descripcion;


        // Constructor
        public Rol()
        {
        }

        // Getters and Setters / Propiedades
        public int Rol_Id { get => rol_Id; set => rol_Id = value; }
        public string Rol_Descripcion { get => rol_Descripcion; set => rol_Descripcion = value; }
    }
}