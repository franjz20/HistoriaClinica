using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarPaciente
    {
        //private static string connectionString =
                                //"Server=(localdb)\\MSSQLLocalDB;Database=HistoriaClinicaDB;Trusted_Connection=True;";
        
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
                                    AttachDbFilename=|DataDirectory|\BD\HistoriaClinicaDB.mdf;
                                    Integrated Security=True;
                                    Connect Timeout=30;";

        public static DataTable listar_pacientes()
        {

            SqlConnection cnn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Pacientes";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void insertar_paciente(Paciente paciente)
        {
            SqlConnection cnn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Pacientes (Nombre, Apellido, DNI, FechaNacimiento, Direccion, Telefono, Email, ObraSocial, NumeroAfiliado, Observaciones) " +
                              "VALUES (@nombre, @apellido, @dni, @fechaNacimiento, @direccion, @telefono, @email, @obraSocial, @numeroAfiliado, @observaciones)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@nombre", paciente.Paciente_Nombre);
            cmd.Parameters.AddWithValue("@apellido", paciente.Paciente_Apellido);
            cmd.Parameters.AddWithValue("@dni", paciente.Paciente_Dni);
            cmd.Parameters.AddWithValue("@fechaNacimiento", paciente.Paciente_FechaNacimiento);
            cmd.Parameters.AddWithValue("@direccion", paciente.Paciente_Direccion);
            cmd.Parameters.AddWithValue("@telefono", paciente.Paciente_Telefono);
            cmd.Parameters.AddWithValue("@email", paciente.Paciente_Email);
            cmd.Parameters.AddWithValue("@obraSocial", paciente.Paciente_ObraSocial);
            cmd.Parameters.AddWithValue("@numeroAfiliado", paciente.Paciente_NumeroAfiliado);
            cmd.Parameters.AddWithValue("@observaciones", paciente.Paciente_Observaciones);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void modificar_paciente(Paciente paciente)
        {
            SqlConnection cnn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Pacientes SET Nombre=@nombre, Apellido=@apellido, DNI=@dni, FechaNacimiento=@fechaNacimiento, " +
                              "Direccion=@direccion, Telefono=@telefono, Email=@email, ObraSocial=@obraSocial, NumeroAfiliado=@numeroAfiliado, Observaciones=@observaciones " +
                              "WHERE PacienteId=@pacienteId";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@nombre", paciente.Paciente_Nombre);
            cmd.Parameters.AddWithValue("@apellido", paciente.Paciente_Apellido);
            cmd.Parameters.AddWithValue("@dni", paciente.Paciente_Dni);
            cmd.Parameters.AddWithValue("@fechaNacimiento", paciente.Paciente_FechaNacimiento);
            cmd.Parameters.AddWithValue("@direccion", paciente.Paciente_Direccion);
            cmd.Parameters.AddWithValue("@telefono", paciente.Paciente_Telefono);
            cmd.Parameters.AddWithValue("@email", paciente.Paciente_Email);
            cmd.Parameters.AddWithValue("@obraSocial", paciente.Paciente_ObraSocial);
            cmd.Parameters.AddWithValue("@numeroAfiliado", paciente.Paciente_NumeroAfiliado);
            cmd.Parameters.AddWithValue("@observaciones", paciente.Paciente_Observaciones);

            cmd.Parameters.AddWithValue("@pacienteId", paciente.Paciente_Id);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void eliminar_paciente(Paciente paciente)
        {
            SqlConnection cnn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            
            cmd.CommandText = "DELETE FROM Pacientes WHERE Paciente_Id=@pacienteId";
            
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pacienteId", paciente.Paciente_Id);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

    }
}
