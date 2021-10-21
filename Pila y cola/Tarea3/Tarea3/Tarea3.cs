using System;
using System.Collections;

namespace Tarea3
{
    class Tarea3
    {
        static void Main()
        {
            Stack pila = new Stack();
            string frases;
            int x = 0;

            do
            {
                Console.Write("ingrese una frase: ");
                frases = Convert.ToString(Console.ReadLine());

                pila.Push(frases);
                x++;

            } while (frases != "");

            for (int i = 0; i < x; i++)
            {
                frases = (string)pila.Pop();
                Console.WriteLine(frases);

            }
        }
    }
}
