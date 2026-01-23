using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarHistoriasClinicas
    {
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
                                    AttachDbFilename=|DataDirectory|\BD\HistoriaClinicaDB.mdf;
                                    Integrated Security=True;
                                    Connect Timeout=30;";

        public static DataTable listar_historias_clinicas()
        {
            SqlConnection cnn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT hc.Fecha_Consulta, hc.Motivo_Consulta, hc.Diagnostico_Presuntivo, " +
                              "p.Nombre + ' ' + p.Apellido as Nombre_Completo, p.DNI, DATEDIFF(YEAR, p.FechaNacimiento, GETDATE()) as Edad " +
                              "FROM Historias_Clinicas hc " +
                              "INNER JOIN Pacientes p ON hc.Paciente_Id = p.PacienteId " +
                              "ORDER BY hc.Fecha_Consulta DESC";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public static DataTable listar_HC_porPaciente(int pacienteId)
        {
            SqlConnection cnn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "SELECT hc.Fecha_Consulta, hc.Motivo_Consulta, hc.Diagnostico_Presuntivo, " +
            //                  "p.Nombre + ' ' + p.Apellido as Nombre_Completo, p.DNI, DATEDIFF(YEAR, p.FechaNacimiento, GETDATE()) as Edad " +
            //                  "FROM Historias_Clinicas hc " +
            //                  "INNER JOIN Pacientes p ON hc.Paciente_Id = p.PacienteId " +
            //                  "ORDER BY hc.Fecha_Consulta DESC";

            cmd.CommandText = "SELECT HC_Id, Fecha_Consulta, Motivo_Consulta, Diagnostico_Presuntivo, Observaciones " +
                              "FROM Historias_Clinicas " +
                              "Where Paciente_Id = @pacienteId "+
                              "ORDER BY Fecha_Consulta DESC";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pacienteId", pacienteId);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void insertar_Historia_Clinica(HistoriaClinica historiaClinica)
        {
            SqlConnection cnn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Historias_Clinicas (Paciente_Id, Antecedentes, Motivo_Consulta, Signos_Vitales_FC, " +
                              "Signos_Vitales_PA, Signos_Vitales_Temp, Signos_Vitales_Sat, Exploracion_Fisica, Diagnostico_Presuntivo, " +
                              "Estudios_Solicitados, Tratamiento, Observaciones, Fecha_Consulta) " +
                              "VALUES (@Paciente_Id, @Antecedentes, @Motivo_Consulta, @Signos_Vitales_FC, " +
                              "@Signos_Vitales_PA, @Signos_Vitales_Temp, @Signos_Vitales_Sat, @Exploracion_Fisica, @Diagnostico_Presuntivo, " +
                              "@Estudios_Solicitados, @Tratamiento, @Observaciones, @Fecha_Consulta)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Paciente_Id", historiaClinica.Paciente_Id);
            cmd.Parameters.AddWithValue("@Antecedentes", historiaClinica.Hc_antecedentes);
            cmd.Parameters.AddWithValue("@Motivo_Consulta", historiaClinica.Hc_motivoConsulta);
            cmd.Parameters.AddWithValue("@Signos_Vitales_FC", historiaClinica.Hc_signosVitalesFC);
            cmd.Parameters.AddWithValue("@Signos_Vitales_PA", historiaClinica.Hc_signosVitalesPA);
            cmd.Parameters.AddWithValue("@Signos_Vitales_Temp", historiaClinica.Hc_signosVitalesTemp);
            cmd.Parameters.AddWithValue("@Signos_Vitales_Sat", historiaClinica.Hc_signosVitalesSat);
            cmd.Parameters.AddWithValue("@Exploracion_Fisica", historiaClinica.Hc_exploracionFisica);
            cmd.Parameters.AddWithValue("@Diagnostico_Presuntivo", historiaClinica.Hc_diagnosticoPresuntivo);
            cmd.Parameters.AddWithValue("@Estudios_Solicitados", historiaClinica.Hc_estudiosSolicitados);
            cmd.Parameters.AddWithValue("@Tratamiento", historiaClinica.Hc_tratamiento);
            cmd.Parameters.AddWithValue("@Observaciones", historiaClinica.Hc_observaciones);
            cmd.Parameters.AddWithValue("@Fecha_Consulta", historiaClinica.Hc_fechaConsulta);
            
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
