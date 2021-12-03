using System;
using System.Collections;

namespace Final_Cola
{
    public class Final_Cola
    { 
        static void Main()
        {
            Queue Cola = new Queue();
            int menu;

            do
            {
                menu = opcionesMenu();
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Creando Cola nuyeva");
                        Cola = new Queue();
                        break;
                    case 2:
                        break;
                }
            }
            while (opcion != 9);
            Console.WriteLine("El programa a finalizado.");

        }


        static int opcionesMenu()
        {
            Console.WriteLine("1. Crear Cola");
            Console.WriteLine("2. Borrar Cola");
            Console.WriteLine("3. Agregar Pedido");
            Console.WriteLine("4. Borrar Pedido");
            Console.WriteLine("5. Listar todos los Pedidos.");
            Console.WriteLine("6. Listar último Pedido.");
            Console.WriteLine("7. Listar primer Pedido.");
            Console.WriteLine("8. Cantidad de Pedido.");
            Console.WriteLine("9. Salir");

            Console.Write("Escoja una opción: ");
        }



    }


    

            
}
