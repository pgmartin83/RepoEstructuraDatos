using System;

namespace Tarea7
{
    class Tarea7
    {
        static void Main()
        {
            Console.Write("Ingrese una letra: ");
            string l = Console.ReadLine();
            
            Console.Write("Ingrese una numero: ");
            int a = Convert.ToInt32(Console.ReadLine());
            
            for (int i = a; i >= 0; i--)
            {
                for (int b = 0; b < i; b++)
                {
                    Console.Write("{0}", l);
                }
                Console.WriteLine();
            }
        }
    }
}