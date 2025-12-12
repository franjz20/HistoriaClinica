using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class ObraSocial
    {
        private int obraSocial_Id;
        private string obraSocial_Nombre;
        private string obraSocial_Plan;

        public ObraSocial()
        {
        }

        public int ObraSocial_Id { get => obraSocial_Id; set => obraSocial_Id = value; }
        public string ObraSocial_Nombre { get => obraSocial_Nombre; set => obraSocial_Nombre = value; }
        public string ObraSocial_Plan { get => obraSocial_Plan; set => obraSocial_Plan = value; }
    }
}