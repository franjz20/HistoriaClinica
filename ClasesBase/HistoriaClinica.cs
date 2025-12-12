using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class HistoriaClinica
    {
        private int historia_Id;
        private int paciente_Id;
        private DateTime historia_FechaApertura;
        private string historia_Observaciones;

        public HistoriaClinica()
        {
        }

        public int Historia_Id { get => historia_Id; set => historia_Id = value; }
        public int Paciente_Id { get => paciente_Id; set => paciente_Id = value; }
        public DateTime Historia_fechaApertura { get => historia_FechaApertura; set => historia_FechaApertura = value; }
        public string Historia_Observaciones { get => historia_Observaciones; set => historia_Observaciones = value; }
    }
}