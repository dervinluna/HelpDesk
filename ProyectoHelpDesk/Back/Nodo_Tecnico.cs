using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHelpDesk.Back
{
    internal class Nodo
    {
        public Tecnico Informacion { get; set; }
        public Nodo Liga { get; set; }

        public Nodo()
        {
            Informacion = null;
            Liga = null;
        }

        public Nodo(Tecnico informacion)
        {
            Informacion = informacion;
            Liga = null;
        }

        public override string ToString()
        {
            return $"{Informacion.nombre} ({Informacion.idTecnico})";
        }
    }
}
