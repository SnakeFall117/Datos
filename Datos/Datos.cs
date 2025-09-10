using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    internal class Datos
    {
        string nombre;
        int edad;
        float peso = 0f;
        public void pedir()
        {
            Console.WriteLine("Ingresa tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingresa tu edad");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa tu peso");
            peso = float.Parse(Console.ReadLine());

        }
        public void devolver()
        {
            Console.WriteLine("Tu nombre es: " + nombre);
            Console.WriteLine("Tu edad es: " + edad);
            Console.WriteLine("Tu peso es: " + peso);
        }
    }
}
