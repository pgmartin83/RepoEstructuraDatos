using System;

namespace Tarea5
{
    public class Tarea5
    {
        public static void Main()
        {
            int o, n1, n2;
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");

            Console.Write("Elija una opción: ");
            o = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el primer número: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Calcula(o, n1, n2);
        }
        
        public static float Calcula(int x, float a, float b)
        {
            switch (x)
            {
                case 1: Console.WriteLine("calcula {0} + {1} = {2}", a, b, a + b); return 0;

                case 2: Console.WriteLine("calcula {0} - {1} = {2}", a, b, a - b); return 0;

                case 3: Console.WriteLine("calcula {0} * {1} = {2}", a, b, a * b); return 0;

                case 4: Console.WriteLine("calcula {0} / {1} = {2}", a, b, a / b); return 0;

                default:
                    return 0;
                    break;
            }
        }
        
    }
}
   
