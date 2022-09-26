using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico75
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listastring = new List<string>();


            Console.WriteLine("¿hola cual es tu nombre");
            string nombre = Console.ReadLine();//puedo usar mucho texto
            Console.WriteLine("¿" + nombre + "ingresa tu apellido?");
            string cadena = Console.ReadLine();
            Console.WriteLine("¿ cual es tu calle de donde vivis");
            string direccion = Console.ReadLine();

            listastring.Add(nombre);
            listastring.Add(cadena);
            listastring.Add(direccion);

            for (int i = 0; i < listastring.Count; i++)
            {
                string dato = listastring[i];
                Console.WriteLine(dato);
            }
        }
    }
}
