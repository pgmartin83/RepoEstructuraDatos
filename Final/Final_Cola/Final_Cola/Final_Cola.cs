using System;
using System.Collections;

namespace Final_Cola
{
    public class Final_Cola
    {

        //public string nombreCola;

        public static void Main()
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
            
            switch (Console.ReadLine())
            {
                
                case "1": CrearCola(); break;
                case "2": BorrarCola(); break;
                case "3": AgregarPedido(); break;
                case "4": BorrarPedido(); break;
                case "5": Listar(); break;
                case "6": ListarUltimo(); break;
                case "7": ListarPrimero(); break;
                case "8": CantidadPedido(); break;

                case "9": // Salir de la aplicación
                    Console.WriteLine();
                    Console.WriteLine("Saliendo...");
                    Console.WriteLine();
                    bool terminado = true;
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Opción incorrecta!");
                    Console.WriteLine();
                    break;
            }

        }
        
        public static void CrearCola() 
        {
            Console.Write("Ingrese el nombre de la nueva cola: ");
            Queue nombreCola = new Queue();

            Main();
        }

        public static void BorrarCola() { }

        public static int AgregarPedido() 
        {
            Console.Write("Agregar un Pedido: ");
            int pedidos = Convert.ToInt32(Console.ReadLine());
            nombreCola.Enqueue(pedidos);

        }

        public static void BorrarPedido() { }

        public static void Listar() { }

        public static void ListarUltimo() { }

        public static void ListarPrimero() { }

        public static void CantidadPedido() { }


    }
}
