using System;

namespace Tarea10
{
    public class Tarea10
    {
        public static void Main()

        {
            int entero;

            Console.Write("Ingrese un número entero: ");
            entero = Convert.ToInt32(Console.ReadLine());

            if (entero % 2 == 0)
            {
                Console.WriteLine("El número {0} es par.", entero);
            }
            else
            {
                Console.WriteLine("El número {0} es impar.", entero);
            }
        }
    }
}
