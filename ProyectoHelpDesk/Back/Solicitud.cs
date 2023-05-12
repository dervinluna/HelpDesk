using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProyectoHelpDesk.Back
{
    internal class Solicitud:Usuario
    {
        public int ticket { get; set; }
        public int estado { get; set; }
        public string descripcion { get; set; }
        public int idCliente { get; set; }
        public int? idTecnico { get; set; } 
        public Solicitud() { }

        public Solicitud(int ticket, int estado, string descripcion, int idCliente, int? idTecnico)
        {
            this.ticket = ticket;
            this.estado = estado;
            this.descripcion = descripcion;
            this.idCliente = idCliente;
            this.idTecnico = idTecnico;
            

        }
        //---------------Generar solicitud--------------------
        public String Generar(int estado, string descripcion, int idCliente, int? idTecnico)
        {
            Solicitud solicitud = new Solicitud();
            solicitud.estado = estado;
            solicitud.descripcion = descripcion;
            solicitud.idCliente  = idCliente;
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
           }catch(Exception ex) {
                Console.WriteLine(ex.ToString()+"Error no se pudo Grabar insert"); 
            }
            conn.Close();
            return "Se ha creado la solicitud, mantente en espera por favor";
        }
    }
}
