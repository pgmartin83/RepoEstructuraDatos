using System;

namespace Tarea9
{
    public class Tarea9
    {
        public static void Main()
        {
            int numero1;
            int numero2;
            int producto;

            Console.Write("Ingrese el primero número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            producto = numero1 * numero2;

            Console.WriteLine("El producto entre {0} y {1} es {2}", numero1, numero2, producto);
        }
    }
}
