using System;

namespace Tarea11
{
    public class Program
    {
        public static void Main()
        {
            int entero1, entero2;

            Console.Write("Ingrese un número entero: ");
            entero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese otro número entero: ");
            entero2 = Convert.ToInt32(Console.ReadLine());

            if (entero1 > entero2)
            {
                Console.Write("El número {0} es mayor que {1}", entero1, entero2);
            }
            else
            {
                Console.Write("El número {0} es menor que {1}", entero1, entero2);
            }
        }
    }
}
