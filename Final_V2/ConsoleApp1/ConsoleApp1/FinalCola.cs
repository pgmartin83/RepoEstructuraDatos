using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Text.RegularExpressions;


namespace conStack
{
    class FinalCola
    {
        static void Main()
        {
            Queue Cola = new Queue();
            int menu; 
            do
            {
                //Console.Clear();//se limpia consola

                menu = opcionMenu();
                switch (menu)
                {
                    case 1:                                             //OPCION 1 crear Cola
                        Cola = new Queue();
                        Console.WriteLine("Se creo una nueva Cola: ");
                        Console.WriteLine();
                        break;

                    case 2:
                        borrarCola(ref Cola);
                        Console.WriteLine("Se borro la Cola: ");
                        Console.WriteLine();
                        break;

                    case 3:
                        agregarPedido(ref Cola);
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.Write("Número de pedido a borrar: ");
                        int pedido = Convert.ToInt32(Console.ReadLine());
                        borrarPedido(ref Cola, pedido);
                        Console.WriteLine();
                        break;

                    case 5:
                        listarPedidos(Cola);
                        Console.WriteLine();
                        break;

                    case 6:
                        ultimoPedido(Cola);
                        Console.WriteLine();
                        break;

                    case 7:
                        primerPedido(Cola);
                        Console.WriteLine();
                        break;

                    case 8:
                        cantidadPedidos(Cola);
                        Console.WriteLine();
                        break;

                    case 9:
                        Console.Write("Pedido a consultar: ");
                        int consulta = Convert.ToInt32(Console.Read());
                        verificarPedido(ref Cola, consulta);
                        Console.WriteLine();
                        break;

                    case 0: break;                                      //OPCION 0 salir
                    default:
                        Console.WriteLine("Opcion incorrecta...");
                        break;
                }
            }
            while (menu != 0);
            Console.WriteLine("Saliendo del programa...");
        }

       //opciones del menu
        static int opcionMenu()
        {
            Console.WriteLine("1- Crear Cola");
            Console.WriteLine("2- Borrar Cola");
            Console.WriteLine("3- Agregar Pedido");
            Console.WriteLine("4- Borrar Pedido");
            Console.WriteLine("5- Listar todas los Pedidos");
            Console.WriteLine("6- Listar último Pedido");
            Console.WriteLine("7- Listar primer Pedido");
            Console.WriteLine("8- Cantidad de Pedido");
            Console.WriteLine("9- Verificar Pedido");

            Console.WriteLine("0- Salir");
            
            Console.Write("Ingresa tu opción: ");
            
            try
            {
                int valor = Convert.ToInt32(Console.ReadLine());
                return valor;
            }
            catch
            {
                Console.WriteLine("ERROR: la opción no es valida. Intente de nuevo.");
                return opcionMenu();

            }
        }

        //Borra la cola completa OPCION 2
        static void borrarCola(ref Queue cola)
        {
            cola.Clear();
            //listarPedidos(cola);
            Console.WriteLine("Presione cualquier tecla para continuar ...");
            Console.ReadKey();
        }

        //Agregar pedido del 1 al 999 OPCION 3
        static void agregarPedido(ref Queue cola)
        {
            Console.Write("Ingrese el pedidido (1 a 999): ");
            int pedido = Convert.ToInt32(Console.ReadLine());
            if (pedido > 0 & pedido <= 999)
            {
                Console.WriteLine("Pedido ingresado");
                cola.Enqueue(pedido);
            }
            else
            {
                Console.WriteLine("Pedido incorrecto");
            }
            
        }

        //Borrar pedido OPCION 4
        static void borrarPedido(ref Queue cola, int pedido)
        {
                        
            if (cola.Count > 0)
            {

                int p = (int)cola.Dequeue();
                if (cola.Count > 0)
                {
                    borrarPedido(ref cola, pedido);

                }
                if (p != pedido)
                {
                    cola.Enqueue(p);
                }
                else
                {
                    Console.WriteLine("El pedido {0} fue eliminado", pedido);
                    Console.WriteLine("Presione cualquier tecla para continuar ...");
                    Console.ReadKey();
                }
            }
        }
                        
        
        //Listar todos los pedidos OPCION 5
        static void listarPedidos(Queue cola)
        {
            foreach (int cola2 in cola)
            {
                Console.WriteLine(cola2);
            }

            Console.WriteLine("Presione cualquier tecla para continuar ...");
            Console.ReadKey();

        }

        //Ultimo Pedido OPCION 6
        static void ultimoPedido(Queue cola)
        {
            Queue cola2 = new Queue(cola);
                  
            if (cola2.Count > 1)
            {
                       
                int p = (int)cola2.Dequeue();
                ultimoPedido(cola2);
                cola2.Enqueue(p);
                
            }
            else
            {
                Console.WriteLine(cola2.Peek());
                                
                Console.WriteLine("Presione cualquier tecla para continuar ...");
                Console.ReadKey();
                
            }
                       
        }

        //Primer Pedido OPCION 7
        static void primerPedido(Queue cola)
        {
            Console.WriteLine("Primer pedido: {0}",cola.Peek());
            Console.WriteLine("Presione cualquier tecla para continuar ...");
            Console.ReadKey();
            
        }


        //Cantidad de pedidos OPCION 8
        static void cantidadPedidos(Queue cola)
        {
            if (cola.Count > 0)
            {
                int p = cola.Count;
                Console.WriteLine("Cantidad de pedidos: {0}", p);
                Console.WriteLine("Presione cualquier tecla para continuar ...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No hay pedidos");
                Console.WriteLine("Presione cualquier tecla para continuar ...");
                Console.ReadKey();
            }
        }

        //Verificar Pedido OPCION 9
        static void verificarPedido(ref Queue cola, int consulta)
        {
            Console.WriteLine("Encontrado: {0}", cola.Contains(consulta));
            Console.WriteLine("Presione cualquier tecla para continuar ...");
            Console.ReadKey();
        }

    }
}