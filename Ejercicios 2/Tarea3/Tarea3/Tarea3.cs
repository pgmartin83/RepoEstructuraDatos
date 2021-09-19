using System;

namespace Tarea3
{
    public class Tarea3
    {
        public static void Main()
        {
            int contador = 1;

            do
            {
                Console.WriteLine("9 x {0} = {1}", contador, 9 * contador);
                contador++;
            }
            while (contador <= 10);
            
        }
    }
}
