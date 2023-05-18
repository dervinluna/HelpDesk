using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHelpDesk.Back
{
    internal class Usuario
    {
        //conecion a base de datos 
       public SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP_SERVER;Initial Catalog=helpdesk;Integrated Security=True");

        //Creamos los Atributos de la Superclase
        public string nombre { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public string tipo { get; set; } //(JefeIt,Cliente,Tipo)
        public int? cantSolicitudes { get; set; }
        //constructor sin parametros 
        public Usuario() { }
        //constructor con parametros
        public Usuario(string nombre, string usuario, string contraseña, string tipo)
        {
          
            this.nombre = nombre;
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.tipo = tipo;
        }
    }
}
