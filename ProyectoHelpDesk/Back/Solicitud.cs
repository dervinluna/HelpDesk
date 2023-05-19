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
        public int estado { get; set; }//11,12,13,14,15,16
        public string descripcion { get; set; }
        public int idCliente { get; set; }
        public int? idTecnico { get; set; }
        public string calificacion { get; set; }
        public Solicitud() { }

        public Solicitud(int ticket, int estado, string descripcion, int idCliente, string calificacion, int? idTecnico)
        {
            this.ticket = ticket;
            this.estado = estado;
            this.descripcion = descripcion;
            this.idCliente = idCliente;
            this.idTecnico = idTecnico;
            this.calificacion= calificacion;
            

        }
       
    }
}
