using System;

namespace Tarea1
{
    public class Program
    {
        public static void Main()
        {
            int identificador = 1234, contraseña = 1111;
            int numero1, numero2;

            do
            {
                Console.Write("Ingrese su identificador numérico: ");
                numero1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese su contraseña numérica: ");
                numero2 = Convert.ToInt32(Console.ReadLine());

                if ((numero1 != identificador) || (numero2 != contraseña))
                    Console.WriteLine("Identificador o contraseña no válida.");
            }
            while ((numero1 != identificador) || (numero2 != contraseña));

            Console.Write("Identificador y contraseña aceptada");
        }
    }
}
