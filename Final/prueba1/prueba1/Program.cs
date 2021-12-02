using System;
using System.Collections;


namespace prueba1
{
    public class Program
    {
        public static void Main()
        {           

            Queue Cola = new Queue();
            
            Cola.Enqueue("hola");
            Cola.Enqueue("hola2");
            Cola.Enqueue("hola3");
                                    
            Console.WriteLine( "{0}", Cola.Dequeue());
            
            Console.WriteLine("{0}", Cola.Peek());

            Console.WriteLine("{0}", Cola.Dequeue());

            Cola = new Queue();

            Cola.Enqueue("chau");
            Cola.Enqueue("chau2");
            Cola.Enqueue("chau3");

            Console.WriteLine("{0}", Cola.Dequeue());

            Console.WriteLine("{0}", Cola.Peek());

            Console.WriteLine("{0}", Cola.Dequeue());

            
        }
    }
}
