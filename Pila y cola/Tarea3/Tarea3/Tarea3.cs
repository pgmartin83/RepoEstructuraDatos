using System;
using System.Collections;

namespace Tarea3
{
    class Tarea3
    {
        static void Main()
        {
            //Stack pila = new Stack();
            Queue Cola = new Queue();
            string frases;
            int x = 0;

            //Cola
            do
            {
                Console.Write("ingrese una frase: ");
                frases = Convert.ToString(Console.ReadLine());

                Cola.Enqueue(frases);
                x++;

            } while (frases != "");

            for (int i = 0; i < x; i++)
            {
                frases = (string)Cola.Dequeue();
                Console.WriteLine(frases);
            }

            //Pila
            /*do
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

            }*/
        }
    }
}
