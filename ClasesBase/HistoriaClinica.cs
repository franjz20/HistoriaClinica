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
        private string hc_MotivoConsulta;
        private string hc_Antecedentes;
        private int hc_Sigvit_fc;
        private string hc_Sigvit_pa;
        private float hc_Sigvit_temp;
        private int hc_Sigvit_sat;
        private string hc_ExploracionFisica;
        private string hc_DiagnosticoPresuntivo;
        private string hc_EstudiosSolicitados;
        private string hc_Tratamiento;
        private string hc_Observaciones;
        private DateTime hc_FechaConsulta;

        public HistoriaClinica()
        {
        }

        public int Historia_Id { get => historia_Id; set => historia_Id = value; }
        public int Paciente_Id { get => paciente_Id; set => paciente_Id = value; }
        public string Hc_MotivoConsulta { get => hc_MotivoConsulta; set => hc_MotivoConsulta = value; }
        public string Hc_Antecedentes { get => hc_Antecedentes; set => hc_Antecedentes = value; }
        public int Hc_Sigvit_fc { get => hc_Sigvit_fc; set => hc_Sigvit_fc = value; }
        public string Hc_Sigvit_pa { get => hc_Sigvit_pa; set => hc_Sigvit_pa = value; }
        public float Hc_Sigvit_temp { get => hc_Sigvit_temp; set => hc_Sigvit_temp = value; }
        public int Hc_Sigvit_sat { get => hc_Sigvit_sat; set => hc_Sigvit_sat = value; }
        public string Hc_ExploracionFisica { get => hc_ExploracionFisica; set => hc_ExploracionFisica = value; }
        public string Hc_DiagnosticoPresuntivo { get => hc_DiagnosticoPresuntivo; set => hc_DiagnosticoPresuntivo = value; }
        public string Hc_EstudiosSolicitados { get => hc_EstudiosSolicitados; set => hc_EstudiosSolicitados = value; }
        public string Hc_Tratamiento { get => hc_Tratamiento; set => hc_Tratamiento = value; }
        public string Hc_Observaciones { get => hc_Observaciones; set => hc_Observaciones = value; }
        public DateTime Hc_FechaConsulta { get => hc_FechaConsulta; set => hc_FechaConsulta = value; }
    }
}