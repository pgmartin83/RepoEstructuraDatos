using System;

namespace Tarea6
{
    class Tarea6
    {
        static void Main()
        {
            string numeros;

            Console.Write("Escribe un número: ");
            numeros = Console.ReadLine();

            Console.WriteLine("\nLa suma total de sus cifras es {0}.", SumaCifras(numeros));
        }

        public static int SumaCifras(string n)
        {
            int suma = 0;
            for (int i = 0; i <= (n.Length - 1); i++)
            {
                suma += Convert.ToInt32(n[i].ToString());
            }
            return suma;
        }
    }
}
