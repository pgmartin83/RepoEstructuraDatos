using System;

namespace Tarea2
{
    public class Tarea2
    {
        public static void Main()
        {
            int n1, n2;
            Console.Write("Ingrese un número entero: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese otro número entero: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Menor(n1, n2);
        }

        public static void Menor(int m1, int m2)
        {
            if (m1 < m2)
                Console.Write("El menor es {0}", m1);
            else
                Console.Write("El menor es {0}", m2);

        }
    }
}
