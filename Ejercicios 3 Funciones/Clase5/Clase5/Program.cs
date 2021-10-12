using System;
using System.Collections;

namespace Clase5
{
    public class Program
    {
        public static void Main()
        {
            string palabra;

            Stack miPila = new Stack();
            miPila.Push("Hola, ");
            miPila.Push("soy ");
            miPila.Push("yo");

            for (byte i=0; i<3; i++)
            {
                palabra = (string)miPila.Pop();
                Console.WriteLine(palabra);
            }
        }
    }
}
