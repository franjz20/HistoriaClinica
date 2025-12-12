using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Paciente
    {
        private int paciente_Id;
        private string paciente_Nombre;
        private string paciente_Apellido;
        private int paciente_Dni;
        private DateTime paciente_FechaNacimiento;
        private string paciente_Direccion;
        private int paciente_Telefono;
        private string paciente_Email;
        private string paciente_ObraSocial;
        private int paciente_NumeroAfiliado;
        private string paciente_Genero;
        private string paciente_Observaciones;

        // Constructor
        public Paciente()
        {
        }

        // Getters and Setters / Propiedades
        public int Paciente_Id { get => paciente_Id; set => paciente_Id = value; }
        public string Paciente_Nombre { get => paciente_Nombre; set => paciente_Nombre = value; }
        public string Paciente_Apellido { get => paciente_Apellido; set => paciente_Apellido = value; }
        public int Paciente_Dni { get => paciente_Dni; set => paciente_Dni = value; }
        public DateTime Paciente_FechaNacimiento { get => paciente_FechaNacimiento; set => paciente_FechaNacimiento = value; }
        public string Paciente_Direccion { get => paciente_Direccion; set => paciente_Direccion = value; }
        public int Paciente_Telefono { get => paciente_Telefono; set => paciente_Telefono = value; }
        public string Paciente_Email { get => paciente_Email; set => paciente_Email = value; }
        public string Paciente_ObraSocial { get => paciente_ObraSocial; set => paciente_ObraSocial = value; }
        public int Paciente_NumeroAfiliado { get => paciente_NumeroAfiliado; set => paciente_NumeroAfiliado = value; }
        public string Paciente_Genero { get => paciente_Genero; set => paciente_Genero = value; }
        public string Paciente_Observaciones { get => paciente_Observaciones; set => paciente_Observaciones = value; }
    }
}