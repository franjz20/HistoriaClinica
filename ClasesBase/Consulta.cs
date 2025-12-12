using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Consulta
    {
        private int consulta_Id;
        private int historia_Id;
        private DateTime consulta_Fecha;
        private string consulta_Motivo;
        private string consulta_Diagnostico;
        private int conuslta_Tratamiento;
        private string consulta_ProfesionalAtiende;

        public Consulta()
        {
        }

        public int Consulta_Id { get => consulta_Id; set => consulta_Id = value; }
        public int Historia_Id { get => historia_Id; set => historia_Id = value; }
        public DateTime Consulta_fecha { get => consulta_Fecha; set => consulta_Fecha = value; }
        public string Consulta_motivo { get => consulta_Motivo; set => consulta_Motivo = value; }
        public string Consulta_diagnostico { get => consulta_Diagnostico; set => consulta_Diagnostico = value; }
        public int Conuslta_tratamiento { get => conuslta_Tratamiento; set => conuslta_Tratamiento = value; }
        public string Consulta_profesionalAtiende { get => consulta_ProfesionalAtiende; set => consulta_ProfesionalAtiende = value; }
    }
}