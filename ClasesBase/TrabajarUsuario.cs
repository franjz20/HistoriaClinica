using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarUsuario
    {
        //private static string connectionString =
                                //"Server=(localdb)\\MSSQLLocalDB;Database=HistoriaClinicaDB;Trusted_Connection=True;";
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
                                    AttachDbFilename=|DataDirectory|\BD\HistoriaClinicaDB.mdf;
                                    Integrated Security=True;
                                    Connect Timeout=30;";
        
        
        //ConexionDB conexionDB = new ConexionDB();

        public static void insertar_usuario(Usuario nuevoUsuario)
        {
            SqlConnection cnn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Usuarios(Usu_NombreUsuario, ContraseñaHash, Usu_Apellido, Usu_Nombre, Usu_Email)" +
                                            "values(@nombreUsuario, @contraseñaUsuario, @nombreCuenta, @apellidoCuenta, @emailCuenta)";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@nombreUsuario", nuevoUsuario.Usuario_NombreUsuario);
            cmd.Parameters.AddWithValue("@contraseñaUsuario", nuevoUsuario.Usuario_Contraseña);
            cmd.Parameters.AddWithValue("@nombreCuenta", nuevoUsuario.Usuario_Nombre);
            cmd.Parameters.AddWithValue("@apellidoCuenta", nuevoUsuario.Usuario_Apellido);
            cmd.Parameters.AddWithValue("@emailCuenta", nuevoUsuario.Usuario_Email);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static Usuario autenticar_usuario(string nombreUsuario, string contraseñaUsuario)
        {
            Usuario autenticarUsuario = null;

            SqlConnection cnn = new SqlConnection(connectionString);

            string consulta = "SELECT * FROM Usuarios WHERE Usu_NombreUsuario = @nombreUsuario AND ContraseñaHash = @contraseñaUsuario";

            SqlCommand cmd = new SqlCommand(consulta, cnn);

            cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
            cmd.Parameters.AddWithValue("@contraseñaUsuario", contraseñaUsuario);

            cnn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                autenticarUsuario = new Usuario();//Solo si existe el usuario
                //Si encuentra el objeto Usuario, asignar sus propiedades
                autenticarUsuario.Usuario_Id = Convert.ToInt32(reader["Usuario_Id"]);
                autenticarUsuario.Usuario_Apellido = reader["Usu_Apellido"].ToString();
                autenticarUsuario.Usuario_Nombre = reader["Usu_Nombre"].ToString();
                autenticarUsuario.Usuario_NombreUsuario = reader["Usu_NombreUsuario"].ToString();
                autenticarUsuario.Usuario_Email = reader["Usu_Email"].ToString();
            }

            reader.Close();

            cmd.ExecuteNonQuery();
            cnn.Close();

            return autenticarUsuario;
        }
    }
}
