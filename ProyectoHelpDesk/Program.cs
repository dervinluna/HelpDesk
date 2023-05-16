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
            Console.WriteLine(cliente.Generar(11, "No me deja ingresar al sistema", 2));
            Console.WriteLine(cliente.Cancelar(111));
            Console.WriteLine(cliente.Calificar(111,"Buen servicio"));
        }
    }
}
