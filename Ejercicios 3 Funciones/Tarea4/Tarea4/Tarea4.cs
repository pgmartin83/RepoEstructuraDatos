using System;

namespace Tarea4
{
    public class Tarea4
    {
        public static void Main(string[] args)
        {
            for (int fila=1; fila <= 7; fila++) //dibujo de cada linea (bucle externo)
            {
                for (int espacios = 7 - fila; espacios > 0; espacios--) //díbuja espacios en blanco (ler bucle interno)
                {
                    Console.Write(" ");
                }
                for (int conta = 1; conta < (2*fila); conta++) // dibuja asteriscos (2* bucle interno)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
