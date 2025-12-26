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
            cmd.CommandText = "INSERT INTO Pacientes (Nombre, Apellido, DNI, FechaNacimiento, Genero, Direccion, Telefono, Email, ObraSocial, NumeroAfiliado, Observaciones) " +
                              "VALUES (@nombre, @apellido, @dni, @fechaNacimiento, @genero, @direccion, @telefono, @email, @obraSocial, @numeroAfiliado, @observaciones)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@nombre", paciente.Paciente_Nombre);
            cmd.Parameters.AddWithValue("@apellido", paciente.Paciente_Apellido);
            cmd.Parameters.AddWithValue("@dni", paciente.Paciente_Dni);
            cmd.Parameters.AddWithValue("@fechaNacimiento", paciente.Paciente_FechaNacimiento);
            cmd.Parameters.AddWithValue("@genero", paciente.Paciente_Genero);
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
            cmd.CommandText = "UPDATE Pacientes SET Nombre=@nombre, Apellido=@apellido, DNI=@dni, FechaNacimiento=@fechaNacimiento, Genero=@genero" +
                              "Direccion=@direccion, Telefono=@telefono, Email=@email, ObraSocial=@obraSocial, NumeroAfiliado=@numeroAfiliado, Observaciones=@observaciones " +
                              "WHERE PacienteId=@pacienteId";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@nombre", paciente.Paciente_Nombre);
            cmd.Parameters.AddWithValue("@apellido", paciente.Paciente_Apellido);
            cmd.Parameters.AddWithValue("@dni", paciente.Paciente_Dni);
            cmd.Parameters.AddWithValue("@fechaNacimiento", paciente.Paciente_FechaNacimiento);
            cmd.Parameters.AddWithValue("@genero", paciente.Paciente_Genero);
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
            Console.WriteLine("Paciente modificado correctamente.");
        }

        public static void eliminar_paciente(Paciente paciente)
        {
            SqlConnection cnn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "DELETE FROM Pacientes WHERE PacienteId=@pacienteId";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pacienteId", paciente.Paciente_Id);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable buscar_pacientes(string busqueda)
        {
            SqlConnection cnn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT PacienteId, DNI, Apellido, Nombre, Email, ObraSocial, Observaciones " +
                              "FROM Pacientes " +
                              "WHERE Apellido LIKE @filtro OR Nombre LIKE @filtro OR CAST(DNI AS VARCHAR) LIKE @filtro";

            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@filtro", "%" + busqueda + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        } 

        public static Paciente ObtenerPacientePorId(int pacienteId)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Pacientes WHERE PacienteId=@pacienteId";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@pacienteId", pacienteId);
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
               Paciente paciente = new Paciente();
                {
                    paciente.Paciente_Nombre = reader["Nombre"].ToString();
                    paciente.Paciente_Apellido = reader["Apellido"].ToString();
                    paciente.Paciente_FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]);
                    paciente.Paciente_Dni = Convert.ToInt32(reader["DNI"]);
                    paciente.Paciente_Genero = reader["Genero"].ToString();
                    paciente.Paciente_Direccion = reader["Direccion"].ToString();
                    paciente.Paciente_Telefono = Convert.ToInt32(reader["Telefono"]);
                    paciente.Paciente_Email = reader["Email"].ToString();
                    paciente.Paciente_ObraSocial = reader["ObraSocial"].ToString();
                    paciente.Paciente_NumeroAfiliado = Convert.ToInt32(reader["NumeroAfiliado"]);
                    cnn.Close();

                }
                return paciente;

            }
            else
            {
                return null;
            }

        }

    }
}
