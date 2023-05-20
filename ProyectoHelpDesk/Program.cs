using ProyectoHelpDesk.Back;
using ProyectoHelpDesk.Front;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProyectoHelpDesk.Back.Tecnico;
using ProyectoHelpDesk.Front;

namespace ProyectoHelpDesk
{
    internal static class Program
    {
        public static SqlConnection conn = new SqlConnection(@"Data Source=LAIN;Initial Catalog=helpdesk;Integrated Security=True");

        static void Main(string[] args)
        {

            Cliente cliente = new Cliente();
            JefeIt jefeit = new JefeIt();
            Tecnico tecnico = new Tecnico();
            //Console.WriteLine(cliente.Generar("No puedo ingresar al sistema1", 1));
            //Console.WriteLine(cliente.Cancelar(102));
            //Console.WriteLine(cliente.Calificar(101,"Buen servicio"));
            //Console.WriteLine(jefeIt.Aprobar(103));
            //Console.WriteLine(jefeIt.Reasignar(104));
            //Console.WriteLine(tecnico.Asignar(102, 2));
            //Console.WriteLine(tecnico.Terminar(102));
            // Crear instancia de la lista doblemente enlazada
            // Tecnico.ListaDobleEnlazada lista = new Tecnico.ListaDobleEnlazada();   
            //lista.ImprimirSolicitudes();
            //JefeIt.ListaDobleEnlazada lista = new JefeIt.ListaDobleEnlazada();
            //lista.ImprimirSolicitudes();
            //Tecnico.ListaDobleEnlazada2 lista = new Tecnico.ListaDobleEnlazada2();
            //lista.ImprimirSolicitudes(4);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Crea una instancia del formulario principal que contendrá el UserControl Login
            Form formularioPrincipal = new Form();

            // Crea una instancia del UserControl Login
            Login clienteForm = new Login();
            jefeit jefeitForm = new jefeit();
            tecnico TecnicoForm = new tecnico();

            // Agrega el UserControl Login al formulario principal
           // formularioPrincipal.Controls.Add(clienteForm);

            // Inicia la aplicación mostrando el formulario principal
            //Application.Run(jefeitForm);
            Application.Run(clienteForm);




        }
    }
    }

