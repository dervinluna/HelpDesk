using ProyectoHelpDesk.Back;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProyectoHelpDesk.Back.Tecnico;

namespace ProyectoHelpDesk
{
    internal static class Program
    {
        public static SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP_SERVER;Initial Catalog=helpdesk;Integrated Security=True");

        static void Main(string[] args)
        {

            Cliente cliente = new Cliente();
            JefeIt jefeIt = new JefeIt();
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
        }


    }
    }

