using System;

namespace Tarea3
{
    public class Tarea3
    {
        public static void Main()
        {
            int n;
            Console.WriteLine("Escriba un número: ");
            n = Convert.ToInt32(Console.ReadLine());
            EsPrimo(n);
            
        }

        static bool EsPrimo(int numero)
        {
            int a = 0;
            for (int i = 2; i < numero; i++)
            {
                if ((numero % i) == 0)
                {
                    a++;
                }

            }
            if (a != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
    }
}
