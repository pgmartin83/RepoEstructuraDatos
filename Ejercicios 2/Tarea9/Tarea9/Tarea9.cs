using System;

namespace Tarea9
{
    public class Tarea9
    {
        public static void Main()
        {
            string contraseña, contraseña2;
            string nombre;
            

            do
            {
                Console.Write("Ingrese su nombre de usuario: ");
                nombre = Console.ReadLine();
                Console.Write("Ingrese su contraseña: ");
                contraseña = Console.ReadLine();
                Console.Write("Ingrese su contraseña nuevamente: ");
                contraseña2 = Console.ReadLine();

                if (contraseña != contraseña2)
                    Console.WriteLine("Sus contraseñas no coinciden");
            }
            while (contraseña != contraseña2);

            Console.WriteLine("Contraseña correcta");
        }
    }
}
