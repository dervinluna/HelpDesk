using ProyectoHelpDesk.Back;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoHelpDesk
{
    internal static class Program
    {
     
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            JefeIt jefeIt = new JefeIt();
            Tecnico tecnico = new Tecnico();
            //Console.WriteLine(cliente.Generar("No puedo ingresar al sistema", 1,5 ,"fs" ,4));
            //Console.WriteLine(cliente.Cancelar(102));
            //Console.WriteLine(cliente.Calificar(101,"Buen servicio"));
            //Console.WriteLine(jefeIt.Aprobar(103));
            //Console.WriteLine(jefeIt.Reasignar(104));
            //Console.WriteLine(tecnico.Asignar(102, 2));
            Console.WriteLine(tecnico.Terminar(102));


        }
    }
}
