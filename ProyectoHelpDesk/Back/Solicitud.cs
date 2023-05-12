using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHelpDesk.Back
{
    internal class Solicitud : Usuario
    {
        public int ticket { get; set; }
        public string estado { get; set; }
        public string descripcion { get; set; }
        public Solicitud() { }

        public Solicitud(int ticket, string estado, string descripcion, int idCliente, int? idTecnico)
        {
            this.ticket = ticket;
            this.estado = estado;
            this.descripcion = descripcion;
            this.id = idCliente;
            //validamos debido a que en la generacion de la solicitud no vendra ese parametro
            if (idCliente != null)
            {
                this.id = idTecnico;
            }

        }
        public bool Generar(int ticket, string estado, string descripcion, int idCliente, int? idTecnico)
        {
            Solicitud solicitud = new Solicitud();
            return true;
        }
    }
}
