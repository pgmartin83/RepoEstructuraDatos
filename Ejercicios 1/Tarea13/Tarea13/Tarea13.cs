using System;

namespace Tarea13
{
    public class Tarea13
    {
        public static void Main()
        {
            int numero;

            Console.Write("Ingrese un número del 1 al 5: ");
            numero = Convert.ToChar(Console.ReadLine());
            
            switch (numero)
            {
                case '1': Console.Write("Uno");
                        break;
                case '2': Console.Write("Dos");
                        break;
                case '3': Console.Write("Tres");
                    break;
                case '4': Console.Write("Cuatro");
                    break;
                case '5': Console.Write("Cinco");
                    break;
                
                default: Console.Write("Número incorrecto");
                        break;
            }
        }
    }
}
