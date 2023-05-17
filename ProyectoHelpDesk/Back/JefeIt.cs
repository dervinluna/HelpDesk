using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHelpDesk.Back
{
    internal class JefeIt : Usuario
    {
        public int idJefe { get; set; }
        public JefeIt() { }

        public JefeIt(int idJefe, string nombre, string usuario,
            string contraseña, string tipo)
        {
            this.idJefe = idJefe;
            this.nombre = nombre;
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.tipo = tipo;
        }
        public String Aprobar(int ticket, int estado = 14, int? idTecnico=null)
        {
            string sqlSelect = "SELECT COUNT(*) FROM Solicitud WHERE ticket = @ticket";
            string sql = "UPDATE Solicitud SET estado = @estado, idTecnico = @idTecnico   WHERE ticket = @ticket";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            cmd.Parameters.AddWithValue("@ticket", ticket);
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            if (count > 0)
            {
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@ticket", ticket);
                if (idTecnico == null)
                {
                    cmd.Parameters.AddWithValue("@idTecnico", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@idTecnico", idTecnico);
                }
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
            return "Servicio aprobado exitosamente. ";
        }
        public String Reasignar(int ticket, int estado = 12)
        {
            string sqlSelect = "SELECT COUNT(*) FROM Solicitud WHERE ticket = @ticket";
            string sql = "UPDATE Solicitud SET estado = @estado   WHERE ticket = @ticket";
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
                    return (ex.ToString() + "Error no se pudo grabar update.");
                }
            }
            else
            {
                return "Solicitud no existe, verificar....";
            }
            conn.Close();
            return "Solicitud reasignada, exitosamente. ";
        }

    }
}
