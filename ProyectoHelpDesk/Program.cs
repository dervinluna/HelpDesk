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
<<<<<<< HEAD
        public static SqlConnection conn = new SqlConnection(@"Data Source=LAIN;Initial Catalog=helpdesk;Integrated Security=True");
=======
        public static SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP_SERVER;Initial Catalog=helpdesk;Integrated Security=True");
>>>>>>> f9a017f3238c510e5494daea48cb1f1874920198

        static void Main(string[] args)
        {

            Cliente cliente = new Cliente();
<<<<<<< HEAD
            JefeIt jefeit = new JefeIt();
=======
            JefeIt jefeIt = new JefeIt();
>>>>>>> f9a017f3238c510e5494daea48cb1f1874920198
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
            cliente clienteForm = new cliente();
<<<<<<< HEAD
            jefeit jefeitForm = new jefeit();
            tecnico TecnicoForm = new tecnico();
=======
>>>>>>> f9a017f3238c510e5494daea48cb1f1874920198

            // Agrega el UserControl Login al formulario principal
           // formularioPrincipal.Controls.Add(clienteForm);

            // Inicia la aplicación mostrando el formulario principal
<<<<<<< HEAD
            Application.Run(jefeitForm);
=======
            Application.Run(clienteForm);
>>>>>>> f9a017f3238c510e5494daea48cb1f1874920198
            //Application.Run();




        }
    }
    }

