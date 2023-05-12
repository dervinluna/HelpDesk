using System;
using System.Collections.Generic;
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
    }
}
