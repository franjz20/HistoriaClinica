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
        private string hc_antecedentes;
        private string hc_motivoConsulta;
        private int hc_signosVitalesFC;
        private string hc_signosVitalesPA;
        private float hc_signosVitalesTemp;
        private int hc_signosVitalesSat;
        private string hc_exploracionFisica;
        private int hc_diagnosticoPresuntivo;
        private string hc_estudiosSolicitados;
        private string hc_tratamiento;
        private string hc_observaciones;
        private DateTime hc_fechaConsulta;

        public HistoriaClinica()
        {
        }

        public int Historia_Id { get => historia_Id; set => historia_Id = value; }
        public int Paciente_Id { get => paciente_Id; set => paciente_Id = value; }
        public string Hc_antecedentes { get => hc_antecedentes; set => hc_antecedentes = value; }
        public string Hc_motivoConsulta { get => hc_motivoConsulta; set => hc_motivoConsulta = value; }
        public int Hc_signosVitalesFC { get => hc_signosVitalesFC; set => hc_signosVitalesFC = value; }
        public string Hc_signosVitalesPA { get => hc_signosVitalesPA; set => hc_signosVitalesPA = value; }
        public float Hc_signosVitalesTemp { get => hc_signosVitalesTemp; set => hc_signosVitalesTemp = value; }
        public int Hc_signosVitalesSat { get => hc_signosVitalesSat; set => hc_signosVitalesSat = value; }
        public string Hc_exploracionFisica { get => hc_exploracionFisica; set => hc_exploracionFisica = value; }
        public int Hc_diagnosticoPresuntivo { get => hc_diagnosticoPresuntivo; set => hc_diagnosticoPresuntivo = value; }
        public string Hc_estudiosSolicitados { get => hc_estudiosSolicitados; set => hc_estudiosSolicitados = value; }
        public string Hc_tratamiento { get => hc_tratamiento; set => hc_tratamiento = value; }
        public string Hc_observaciones { get => hc_observaciones; set => hc_observaciones = value; }
        public DateTime Hc_fechaConsulta { get => hc_fechaConsulta; set => hc_fechaConsulta = value; }
    }
}