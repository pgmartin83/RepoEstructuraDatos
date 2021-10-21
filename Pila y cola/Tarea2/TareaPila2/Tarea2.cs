using System;
using System.Collections;

namespace Tarea2
{
    public class Tarea2
    {
        public static void Main()
        {
            double  numero;
            Queue Cola = new Queue();

            for (byte i = 0; i < 6; i++)
            {
                Console.Write("Ingrese un número entero: ");
                numero = Convert.ToDouble(Console.ReadLine());
                Cola.Enqueue(numero);
            }

            for (byte x = 0; x < 6; x++)
            {
                numero = (double)Cola.Dequeue();
                Console.WriteLine(numero);
            }
        }
    }
}
