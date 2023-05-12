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
        public String Asignar(int ticket, int estado = 12)
        {
            string sql = "UPDATE Solicitud SET estado = @estado WHERE ticket = @ticket";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@estado", estado);
            cmd.Parameters.AddWithValue("@ticket", ticket);
            conn.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            return "Solicitud en proceso";
        }
        //-------------------Terminar ejecucion------------------
        public String Ejecutado(int ticket, int estado = 13)
        {
            string sql = "UPDATE Solicitud SET estado = @estado WHERE ticket = @ticket";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@estado", estado);
            cmd.Parameters.AddWithValue("@ticket", ticket);
            conn.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            return "Solicitud en proceso";
        }

    }
}
