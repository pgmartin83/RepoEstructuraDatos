using System;

namespace Tarea12
{
    public class Tarea12
    {
        public static void Main(string[] args)
        {

            float numero1, numero2;
            Console.Write("Introduzca el primer numero: ");
            numero1 = float.Parse(Console.ReadLine());
            Console.Write("Introduzca el segundo numero: ");
            numero2 = float.Parse(Console.ReadLine());

            if (numero2 != 0)
            {
                Console.WriteLine("El resultado de la division de n1 {0} y n2 {1} es: {2}", numero1, numero2, (numero1 / numero2));
            }
            else
            {
                Console.WriteLine("Error no se puede dividir por 0");
            }
        }
    }
}
