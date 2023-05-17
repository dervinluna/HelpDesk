using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHelpDesk.Back
{
    internal class Tecnico : Usuario
    {
        public int idTecnico { get; set; }
        public int ticketAsig { get; set; }
        public Tecnico() { }

        public Tecnico(int idTecnico, string nombre, string usuario,
            string contraseña, string tipo)
        {
            this.idTecnico = idTecnico;
            this.nombre = nombre;
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.tipo = tipo;
        }
      
        private SqlConnection GetSqlConnection()
        {
            string connectionString = @"Data Source=LAPTOP_SERVER;Initial Catalog=helpdesk;Integrated Security=True"; // Actualiza la conexión 
            return new SqlConnection(connectionString);
        }
        public String Asignar(int ticket, int idTecnico, int estado = 12)
        {
            string sqlSelect = "SELECT COUNT(*) FROM Solicitud WHERE ticket = @ticket";
            string sql = "UPDATE Solicitud SET estado = @estado, idTecnico = @idTecnico    WHERE ticket = @ticket";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            cmd.Parameters.AddWithValue("@ticket", ticket);
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            if (count > 0)
            {
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@ticket", ticket);
                cmd.Parameters.AddWithValue("@idTecnico", idTecnico);
                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    return (ex.ToString() + "Error no se pudo Grabar update");
                }
            }
            else
            {
                return "Solicitud no existe, Verificar....";
            }
            conn.Close();
            return "Solicitud Asignada, exitosamente ";
        }
        public String Terminar(int ticket, int estado = 13)
        {
            string sqlSelect = "SELECT COUNT(*) FROM Solicitud WHERE ticket = @ticket";
            string sql = "UPDATE Solicitud SET estado = @estado WHERE ticket = @ticket";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            cmd.Parameters.AddWithValue("@ticket", ticket);
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            if (count > 0)
            {
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@ticket", ticket);
                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    return (ex.ToString() + "Error no se pudo Grabar update");
                }
            }
            else
            {
                return "Solicitud no existe, Verificar....";
            }
            conn.Close();
            return "Solicitud Terminada, Espere que se la aprueven.... ";
        }

    }
}