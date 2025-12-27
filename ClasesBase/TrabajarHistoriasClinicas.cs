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
    }
}
