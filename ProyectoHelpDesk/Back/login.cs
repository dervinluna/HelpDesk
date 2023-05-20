using System.Data.SqlClient;

namespace ProyectoHelpDesk.Back
{

    internal class login : Usuario
    {
        public static SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP_SERVER;Initial Catalog=helpdesk;Integrated Security=True");
        public int exist;
        //---------------------Clase que representa la lista doblemente enlazada-------------

        public Usuario Guardando(string pass, string user)
        {
            Usuario newUsu = new Usuario();
            using (conn)
            {
                conn.Open();

                string query = "SELECT idUsuario, nombre, tipo FROM Usuario WHERE usuario = @user AND password = @pass";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@pass", pass);
                    command.Parameters.AddWithValue("@user", user);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            newUsu.id = (int)reader["idUsuario"];
                            newUsu.nombre = (string)reader["nombre"];
                            newUsu.tipo = (int)reader["tipo"];
                            // Asigna aquí los valores correspondientes a las demás propiedades de "solicitud"


                        }
                    }
                }
            }
            return newUsu;

        }
        //-----------------imprimimos las solicitudes pendientes de asignacion--------------


    }

}
