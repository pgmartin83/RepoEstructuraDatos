using System;

namespace Tarea4
{
    public class Tarea4
    {
        public static void Main(string[] args)
        {
            for (int fila=1; fila <= 7; fila++)
            {
                for (int espacios = 7 - fila; espacios > 0; espacios--)
                {
                    Console.Write(" ");
                }
                for (int conta = 1; conta < (2*fila); conta++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
