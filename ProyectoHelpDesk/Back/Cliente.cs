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
        //------------Crear Cliente-------------------
        public String NewCliente(string nombre, string usuario,
            string contraseña, string tipo)
        {
            this.nombre = nombre;
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.tipo = tipo;
            return "Cliente creado Exitosamente";
        }
        //------------Eliminar Cliente-------------------
        public String DeleteCliente(int idCliente)
        {
            this.idCliente = idCliente;
            //consulta de eliminacion
            return "Cliente creado Exitosamente";
        }
        //------------------Generamos la solicitud------------------
        public String Generar(int estado, string descripcion, int idCliente, int? idTecnico=null)
        {
            Solicitud solicitud = new Solicitud();
            solicitud.estado = estado;
            solicitud.descripcion = descripcion;
            solicitud.idCliente = idCliente;
            solicitud.idTecnico = idTecnico;
            //consulta
            string sql = "INSERT INTO Solicitud (estado, descripcion, idCliente, idTecnico) " +
             "VALUES (@estado, @descripcion, @idCliente, @idTecnico)";
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
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString() + "Error no se pudo Grabar insert");
            }
            conn.Close();
            return "Se ha creado la solicitud, mantente en espera por favor";
        }
        //-----------------------Cancelar Solicitud-------------------------
        public String Cancelar(int ticket,  int estado=16)
        {
            string sql = "UPDATE Solicitud SET estado = @estado WHERE ticket = @ticket";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@estado", estado);
            cmd.Parameters.AddWithValue("@ticket", ticket);
            conn.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            return "Solicitud cancelada exitosamente";
        }
        //-----------------------Calificar servicio-------------------------
        public String Calificar(int ticket, string calificacion, int estado=15)
        {
            string sql = "UPDATE Solicitud SET estado = @estado, descripcion = @calificacion   WHERE ticket = @ticket";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@calificacion", calificacion);
            cmd.Parameters.AddWithValue("@estado", estado);
            cmd.Parameters.AddWithValue("@ticket", ticket);
            conn.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            return "Servicio calificado exitosamente";
        }
    }
}
