using System;

namespace Tarea10
{
    public class Tarea10
    {
        public static void Main()
        {
            string nombre, dato = "Martín";


            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
                
            if (nombre != dato)
            {
                Console.WriteLine("No te conozco!");
            }
            else
            {
                Console.WriteLine("Hola Martín");
            } 
                
        }
    }
}
