using System;

namespace Tarea1
{
    public class Tarea1
    {
        public static void Main()
        {
            float real;
            Console.WriteLine("Ingrese un número real: ");
            real = Convert.ToSingle(Console.ReadLine());
            Signo(real);
        }

        public static void Signo(float n)
        {
            if (n < 0)
                Console.Write("-1");
            else if (n > 0)
                Console.Write("1");
            else 
                Console.Write("0");
        }      
    }

}
