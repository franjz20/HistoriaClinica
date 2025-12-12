using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Turno
    {
        private int turno_Id;
        private int paciente_Id;
        private int profesional_Id;
        private DateTime turno_FechaHora;
        private string turno_Estado;

        public Turno()
        {
        }

        public int Turno_Id { get => turno_Id; set => turno_Id = value; }
        public int Paciente_Id { get => paciente_Id; set => paciente_Id = value; }
        public int Profesional_Id { get => profesional_Id; set => profesional_Id = value; }
        public DateTime Turno_FechaHora { get => turno_FechaHora; set => turno_FechaHora = value; }
        public string Turno_Estado { get => turno_Estado; set => turno_Estado = value; }
    }
}