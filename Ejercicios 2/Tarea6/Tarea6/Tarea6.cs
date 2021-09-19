using System;

namespace Tarea6
{
    public class Tarea6
    {
        public static void Main()
        {
            int a = 5, b, c;

            Console.WriteLine("a = 5: {0}", a);
            Console.WriteLine("b = ++a: {0}", b = ++a);
            Console.WriteLine("c = a++: {0}", c = a++);
            Console.WriteLine("b = b * 5: {0}", b = b * 5);
            Console.WriteLine("a = a * 2: {0}", a = a * 2);
        }
    }
}
