using System;

namespace Tarea3
{
    public class Tarea3
    {
        public static void Main()
        {
            int n;
            bool resultado;

            Console.Write("Escriba un número: ");
            n = Convert.ToInt32(Console.ReadLine());

            

            if (EsPrimo(n))
            {
                Console.WriteLine("El numero es primo");
            }
            else
            {
                Console.WriteLine("El numero no es primo");
            }
        }

        static bool EsPrimo(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if ((numero % i) == 0)
                {
                    // No es primo :(
                    return false;
                }
            }

            // Es primo :)
            return true;
        }
    }
}