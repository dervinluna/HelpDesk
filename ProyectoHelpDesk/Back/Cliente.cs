using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHelpDesk.Back
{
    internal class Cliente : Usuario
    {
<<<<<<< HEAD

=======
>>>>>>> f9a017f3238c510e5494daea48cb1f1874920198
        public int idCliente { get; set; }
        public int ticketGene { get; set; }
        public Cliente()
        {
        }
        //constructor
        public Cliente(int idCliente, string nombre, string usuario,
            string contraseña, string tipo)
        {
            this.idCliente = idCliente;
            this.nombre = nombre;
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.tipo = tipo;
        }
        //------------------Generamos la solicitud------------------
        public String Generar( string descripcion, int idCliente, int  estado= 11, string calificacion=null, int? idTecnico=null)
        {
            Solicitud solicitud = new Solicitud();
            solicitud.estado = estado;
            solicitud.descripcion = descripcion;
            solicitud.idCliente = idCliente;
            solicitud.idTecnico = idTecnico;
            solicitud.calificacion = calificacion;           //consulta
            string sql = "INSERT INTO Solicitud (estado, descripcion, idCliente, idTecnico, calificacion) " +
             "VALUES (@estado, @descripcion, @idCliente, @idTecnico,@calificacion)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@estado", solicitud.estado);
            cmd.Parameters.AddWithValue("@descripcion", solicitud.descripcion);
            cmd.Parameters.AddWithValue("@idCliente", solicitud.idCliente);
            if (solicitud.idTecnico == null)
            {
                cmd.Parameters.AddWithValue("@idTecnico", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@idTecnico", solicitud.idTecnico);
            }
            if (solicitud.calificacion == null)
            {
                cmd.Parameters.AddWithValue("@calificacion", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@calificacion", solicitud.calificacion);
            }
            
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString() + "Error no se pudo Grabar insert");
                return "Creacion Fallida";
            }
            conn.Close();
            return "Solicitud creada, mantente en espera por favor...";
        }
        //-----------------------Cancelar Solicitud-------------------------
        public String Cancelar(int ticket,  int estado=16)
        {
            string sqlSelect = "SELECT COUNT(*) FROM Solicitud WHERE ticket = @ticket";
            string sql = "UPDATE Solicitud SET estado = @estado WHERE ticket = @ticket";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            cmd.Parameters.AddWithValue("@ticket", ticket);
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            
            if (count > 0) {
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@ticket", ticket);
                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    return (ex.ToString() + "Error no se pudo grabar el update.");
                }

            }
            else {
                return "Solicitud no existe, Verificar....";
            }
            
            conn.Close();
            return "Solicitud cancelada exitosamente.";
        }
        //-----------------------Calificar servicio-------------------------
        public String Calificar(int ticket, string calificacion, int estado=15)
        {
            string sqlSelect = "SELECT COUNT(*) FROM Solicitud WHERE ticket = @ticket";
            string sql = "UPDATE Solicitud SET estado = @estado, calificacion = @calificacion   WHERE ticket = @ticket";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            cmd.Parameters.AddWithValue("@ticket", ticket);
            conn.Open();
            
            int count = (int)cmd.ExecuteScalar();

            if (count > 0)
            {
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@calificacion", calificacion);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@ticket", ticket);
                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    return (ex.ToString() + "Error no se pudo Grabar update.");
                }
            }
            else
            {
                return "Solicitud no existe, Verificar....";
            }
            conn.Close();
            return "Solicitud calificada exitosamente.";
        }
    }
}
