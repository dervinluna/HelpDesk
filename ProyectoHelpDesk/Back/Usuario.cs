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
        public static SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP_SERVER;Initial Catalog=helpdesk;Integrated Security=True");

        //Creamos los Atributos de la Superclase
        public int id { get; set; }
        public string nombre { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public int tipo { get; set; } //(JefeIt,Cliente,Tipo)
        public int? cantSolicitudes { get; set; }
        //constructor sin parametros 
        public Usuario() { }
        //constructor con parametros
        public Usuario(string nombre, string usuario, string contraseña, int tipo)
        {
          
            this.nombre = nombre;
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.tipo = tipo;
        }
    }
}
