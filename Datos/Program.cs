using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Datos objdatos = new Datos();
            string universidad;
            Console.WriteLine("Ingresa tu universidad: ");
            universidad = Console.ReadLine();
            objdatos.pedir();
            objdatos.devolver();
            Console.WriteLine("Tu universidad es: " + universidad);
        }
    }
}
