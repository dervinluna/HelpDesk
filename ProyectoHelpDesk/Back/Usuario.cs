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
<<<<<<< HEAD
       public SqlConnection conn = new SqlConnection(@"Data Source=LAIN;Initial Catalog=helpdesk;Integrated Security=True");
=======
       public SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP_SERVER;Initial Catalog=helpdesk;Integrated Security=True");
>>>>>>> f9a017f3238c510e5494daea48cb1f1874920198

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
        #region validacion del login
        public Boolean Acceso(string user, string pass) {
            string sql = "SELECT idUsuario, nombre, tipo FROM Usuario WHERE usuario = @user AND password = @pass";
            
            conn.Open();         
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@pass", pass);
            try
            {
                int rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString() + "Error no se pudo grabar update.");
                return false;
            }
           
            conn.Close();
            return true;
        }

        #endregion

    }
}
