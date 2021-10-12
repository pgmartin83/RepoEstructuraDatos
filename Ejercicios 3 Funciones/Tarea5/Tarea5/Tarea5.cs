using System;

namespace Tarea5
{
    public class Tarea5
    {
        public static void Main()
        {
            int o, n1, n2;
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Suma");
            Console.WriteLine("3. Suma");
            Console.WriteLine("4. Suma");

            Console.Write("Elija una opción: ");
            o = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el primer número: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Calcula(o, n1, n2);
        }
        
        public static int Calcula(int x, int a, int b)
        {
            switch (x)
            {
                case 1: Sumar(a, b); break;
            }
        }
        
        public static int Sumar(int s1,int s2)
        {
            Console.WriteLine("calcula {0} + {1} = {2}", s1, s2, s1 + s2);
        }
    }
}
   
