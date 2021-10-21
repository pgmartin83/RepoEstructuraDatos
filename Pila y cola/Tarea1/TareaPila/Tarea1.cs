using System;
using System.Collections;

namespace Tarea1
{
    public class Tarea1
    {
        public static void Main()
        {
            int numero;
            Stack miPila = new Stack();
            
            for (byte i = 0; i < 6; i++)
            {
                Console.Write("Ingrese un número entero: ");
                numero = Convert.ToInt32(Console.ReadLine());
                miPila.Push(numero);
            }

            for (byte x = 0; x < 6; x++)
            {
                numero = (int)miPila.Pop();
                Console.WriteLine(numero);
            }
        }
    }
}
