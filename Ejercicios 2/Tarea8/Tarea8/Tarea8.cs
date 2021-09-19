using System;

namespace Tarea8
{
    public class Tarea8
    {
        public static void Main()
        {
            char letra;
            Console.WriteLine("Ingrese una letra: ");
            letra = Convert.ToChar(Console.ReadLine());

            switch (letra)
            {
                case 'a': 
                    Console.WriteLine("La letra {0} es una vocal", letra);
                    break;
                case 'e': 
                    Console.WriteLine("La letra {0} es una vocal", letra);
                    break;
                case 'i':
                    Console.WriteLine("La letra {0} es una vocal", letra);
                    break;
                case 'o':
                    Console.WriteLine("La letra {0} es una vocal", letra);
                    break;
                case 'u':
                    Console.WriteLine("La letra {0} es una vocal", letra);
                    break;
                default: Console.WriteLine("La letra {0} es una consonante", letra);
                    break;
            }
        }
    }
}
