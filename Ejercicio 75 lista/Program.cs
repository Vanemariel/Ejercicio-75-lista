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

            string palabra;
            int numero;

            List<string> Lista = new List<string>();
            palabra = Console.ReadLine();   

            while (palabra != "")
            {
                Lista.Add(palabra);
                Console.ReadLine();
               
            }
            Console.WriteLine("ingrese la pocision de la palabra que quiere");

            numero = Convert.ToInt32(Console.ReadLine());

            while (numero != 0)
            {
                if (numero <= Lista.Count && numero > 0)
                {
                    numero--;
                    Console.WriteLine((string)Lista[numero]);
                    Console.WriteLine("ingresa la ñpocicsion de la palabra que desea");
                    numero = Convert.ToInt32(Console.ReadLine());

                }
                else
                {
                    Console.WriteLine("execede la cantidad de elementos");
                    numero = Convert.ToInt32(Console.ReadLine());
                }
            }


            /*Console.WriteLine("¿hola cual es tu nombre");
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
            }*/
        }
    }
}
