using System;

namespace Tarea2
{
    public class Tarea2
    {
        public static void Main()
        {
            int numero, contador = 0, res;

            Console.WriteLine("ingrese un número positivo: ");
            numero = Convert.ToInt32(Console.ReadLine());

            while (numero > 0)
            {
                //res = numero % 10;
                contador++;
                numero = numero / 10;

            }
            Console.Write("El numero ingresado tiene {0} digitos", contador);
        }
    }
}
