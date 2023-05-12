using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHelpDesk.Back
{
    internal class Usuario
    {

        //Creamos los Atributos de la Superclase
        public int? id { get; set; }
        public string nombre { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public string tipo { get; set; } //(JefeIt,Cliente,Tipo)
        //constructor sin parametros 
        public Usuario() { }
        //constructor con parametros
        public Usuario(int? id, string nombre, string usuario, string contraseña, string tipo)
        {
            this.id = id;
            this.nombre = nombre;
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.tipo = tipo;
        }
    }
}
