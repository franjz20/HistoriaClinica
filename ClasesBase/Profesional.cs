using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Profesional
    {
        private int profesional_Id;
        private string profesional_Nombre;
        private string profesional_Apellido;
        private string profesional_Especialidad;
        private string profesiona_Matricula;

        public Profesional()
        {
        }

        public int Profesional_Id { get => profesional_Id; set => profesional_Id = value; }
        public string Profesional_Nombre { get => profesional_Nombre; set => profesional_Nombre = value; }
        public string Profesional_Apellido { get => profesional_Apellido; set => profesional_Apellido = value; }
        public string Profesional_Especialidad { get => profesional_Especialidad; set => profesional_Especialidad = value; }
        public string Profesiona_Matricula { get => profesiona_Matricula; set => profesiona_Matricula = value; }
    }
}