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
        //-------------------Asignar solicitud------------------
        public string Asignar(int ticket, int estado = 12)
        {
            using (SqlConnection conn = GetSqlConnection())
            {
                string sql = "UPDATE Solicitud SET estado = @estado WHERE ticket = @ticket";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@ticket", ticket);
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0 ? "Solicitud asignada correctamente" : "No se encontró el ticket especificado";
            }
        }
        //-------------------Terminar ejecucion------------------
        public string Ejecutado(int ticket, int estado = 13)
        {
            using (SqlConnection conn = GetSqlConnection())
            {
                string sql = "UPDATE Solicitud SET estado = @estado WHERE ticket = @ticket";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@ticket", ticket);
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0 ? "Solicitud ejecutada correctamente" : "No se encontró el ticket especificado";
            }
        }
        private SqlConnection GetSqlConnection()
        {
            string connectionString = @"Data Source=LAPTOP_SERVER;Initial Catalog=helpdesk;Integrated Security=True"; // Actualiza la conexión 
            return new SqlConnection(connectionString);
        }

    }
}
