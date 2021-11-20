using System;
using System.Collections;
using System.IO;


namespace TPN2
{
    public class TPN2
    { 
        
        struct tipoPersona
        {
            public string nombre, email;
            public DateTime turno;
            public string nacimiento, dni, telefono;
            //public string fecha = DateTime.Now.ToString("");
                        
        }

        static int capacidad = 100;
        static tipoPersona[] gente = new tipoPersona[capacidad];
        static int cantidad = 0;
        static bool terminado = false;
        static string nombreArchivo = "agenda.txt";


        public static void Main() //Función principal
        {
            LeerDeArchivo();
            
            do
            {
                MostrarMenu();
                switch (LeerOpcion())
                {
                    case "1": NuevoDato(); break;
                    case "2": MostrarDatos(); break;
                    case "3": BuscarNombre(); break;
                    case "4": BuscarDNI(); break;
                    case "5": AgendarTurno(); break;
                    case "6": MostrarTurno(); break;

                    case "0": // Salir de la aplicación
                        Console.WriteLine();
                        Console.WriteLine("Saliendo...");
                        Console.WriteLine();
                        terminado = true;
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Opción incorrecta!");
                        Console.WriteLine();
                        break;
                }
            } while (!terminado);
        }

        public static void MostrarMenu() //Menú principal
        {
            DateTime hoy = DateTime.Now;
            Console.WriteLine("Agenda {0}", hoy);
            Console.WriteLine();
            Console.WriteLine("1- Añadir una nueva persona");
            Console.WriteLine("2- Ver todos los nombres agendados");
            Console.WriteLine("3- Buscar por Nombre");
            Console.WriteLine("4- Buscar por DNI");
            Console.WriteLine("5- Ingresar Turno");
            Console.WriteLine("6- Listar Turnos");
            Console.WriteLine("0- Salir");
        }

        public static void NuevoDato() //Cargar datos, opción 1 del menú principal
        {
            if (cantidad < capacidad - 1)
            {
                Console.WriteLine("Introduciendo la persona {0}", cantidad + 1);

                Console.Write("Introduzca el nombre: ");
                gente[cantidad].nombre = Console.ReadLine();

                Console.Write("Introduzca el correo electrónico: ");
                gente[cantidad].email = Console.ReadLine();

                Console.Write("Introduzca el año de nacimiento: ");
                gente[cantidad].nacimiento = Console.ReadLine();//Convert.ToInt32(Console.ReadLine());

                Console.Write("Introduzca el DNI: ");
                gente[cantidad].dni = Console.ReadLine();//Convert.ToInt32(Console.ReadLine());

                Console.Write("Introduzca el número de teléfono: ");
                gente[cantidad].telefono = Console.ReadLine(); //Convert.ToInt32(Console.ReadLine());

                //gente[cantidad].turno = DateTime.Now;

                cantidad++;
                Console.WriteLine();
                GuardarEnArchivo();
            }
            else
                Console.WriteLine("Base de datos llena");
        }

        public static void MostrarDatos() //Muestra todos los nombres, opción 2 del menú principal
        {
            if (cantidad == 0)
                Console.WriteLine("No hay datos");
            else
                for (int i = 0; i < cantidad; i++)
                    Console.WriteLine("{0}: {1}, DNI: {2}", i + 1, gente[i].nombre, gente[i].dni);
            Console.WriteLine();
        }

        public static void BuscarNombre() //Busca por nombre completo(mayúscula o minúscula), opción 3 del menú principal
        {
            Console.Write("Escriba el nombre a buscar:  ");
            string buscar = Console.ReadLine();

            bool encontrado = false;
            for (int i = 0; i < cantidad; i++)
                if (buscar.ToUpper() == gente[i].nombre.ToUpper())
                {
                    encontrado = true;
                    Console.WriteLine("{0}: Nombre: {1}, Email: {2}, Nacido en: {3}, DNI: {4}, Telefono: {5}", i + 1, gente[i].nombre, gente[i].email, gente[i].nacimiento, gente[i].dni, gente[i].telefono);
                }

            if (!encontrado)
            {
                Console.WriteLine("No se ha encontrado.");
                Console.WriteLine();
            }
            Console.WriteLine();
        }


        public static void BuscarDNI() //Busca por número de DNI, opción 4 del menú principal
        {
            Console.Write("Escriba el DNI:  ");
            /*int*/string buscar = Console.ReadLine();//Convert.ToInt32(Console.ReadLine());

            bool encontrado = false;
            for (int i = 0; i < cantidad; i++)
                if (buscar == gente[i].dni)
                {
                    encontrado = true;
                    Console.WriteLine("{0}: Nombre: {1}, Email: {2}, Nacido en: {3}, DNI: {4}, Telefono: {5}", i + 1, gente[i].nombre, gente[i].email, gente[i].nacimiento, gente[i].dni, gente[i].telefono);
                }

            if (!encontrado)
            {
                Console.WriteLine("No se ha encontrado.");
                Console.WriteLine();
            }
            Console.WriteLine();
        }


        public static string LeerOpcion() //ingreso de opción del menú principal
        {
            Console.Write("Escoja una opción: ");
            string opcion = Console.ReadLine();
            Console.WriteLine();
            return opcion;
        }

        public static void LeerDeArchivo() //Lee en archivo txt
        {
            if (File.Exists(nombreArchivo))
            {
                Console.WriteLine("Abriendo Archivo...");
                StreamReader fichero = File.OpenText(nombreArchivo);
                string linea1, linea2, linea3, linea4, linea5;
                DateTime linea6 = new DateTime();
                // Error al leer lineas que no son del tipo fecha
                do
                {
                    linea1 = fichero.ReadLine();
                    if (linea1 == null) // archivo txt vacío o fin de archivo txt
                        break;
                    linea2 = fichero.ReadLine();
                    linea3 = fichero.ReadLine();
                    linea4 = fichero.ReadLine();
                    linea5 = fichero.ReadLine();
                    linea6 = DateTime.Parse(fichero.ReadLine());                    

                    if (cantidad < capacidad - 1)
                    {
                        gente[cantidad].nombre = linea1;
                        gente[cantidad].email = linea2;
                        gente[cantidad].nacimiento = linea3;
                        gente[cantidad].dni = linea4;
                        gente[cantidad].telefono = linea5;
                        gente[cantidad].turno = linea6;

                        //gente[cantidad].nacimiento = Convert.ToInt32(linea3);
                        //gente[cantidad].dni = Convert.ToInt32(linea4);
                        //gente[cantidad].telefono = Convert.ToInt32(linea5);
                        //gente[cantidad].turno = linea6;
                        cantidad++;
                    }
                }
                while ((linea1 != null) && (linea2 != null) && (linea3 != null) && (linea4 != null) && (linea5 != null));// && (linea6 != null));
                fichero.Close();
            }
        }

        public static void GuardarEnArchivo() //Escribe en archivo txt
        {
            StreamWriter fichero = File.CreateText(nombreArchivo);
            for (int i = 0; i < cantidad; i++)
            {
                fichero.WriteLine(gente[i].nombre);
                fichero.WriteLine(gente[i].email);
                fichero.WriteLine(gente[i].nacimiento);
                fichero.WriteLine(gente[i].dni);
                fichero.WriteLine(gente[i].telefono);
                fichero.WriteLine(gente[i].turno);
            }
            fichero.Close();
        }

        public static void AgendarTurno() //Agenda turnos con DNI 
        {
            Console.Write("Escriba el DNI:  ");
            /*int*/string buscar = Console.ReadLine();//Convert.ToInt32(Console.ReadLine());
            bool encontrado = false;
            for (int i = 0; i < cantidad; i++)
                if (buscar == gente[i].dni)
                {
                    encontrado = true;
                    Console.WriteLine("DNI: {2}, Nombre: {1}", i + 1, gente[i].nombre, gente[i].dni);

                    Console.WriteLine("Ingrese la fecha y la hora del turno (dd/MM/yyyy HH:mm)");
                    //DateTime fecha = DateTime.ParseExact(Console.ReadLine(), formato, null);
                    
                    DateTime fecha = DateTime.Parse(Console.ReadLine());
                    /*
                    Console.Write("Ingrese el día: ");
                    var dia = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingrese el mes: ");
                    var mes = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingrese el año: ");
                    var año = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingrese la hora: ");
                    var hora = Convert.ToInt32(Console.ReadLine());

                    DateTime fecha = new DateTime();

                    
                    fecha = fecha.AddDays(dia-1);
                    fecha = fecha.AddMonths(mes-1);
                    fecha = fecha.AddYears(año-1);
                    fecha = fecha.AddHours(hora);

                    */

                    Console.Write("El turno con fecha {0} se asigno a {1} ",fecha, gente[i].nombre);
                    gente[i].turno = fecha;
                                        
                }

            if (!encontrado)
            {
                Console.WriteLine("No se ha encontrado.");
                Console.WriteLine();
            }
            Console.WriteLine();

        }

        public static void MostrarTurno() //Muestra todos los turnos con fecha, nombre y DNI, opción 6 del menú principal
        {
            if (cantidad == 0)
                Console.WriteLine("No hay datos");
            else
                for (int i = 0; i < cantidad; i++)
                    Console.WriteLine("{0}: Fecha:{1}, {2}, DNI: {3}", i + 1, gente[i].turno ,gente[i].nombre, gente[i].dni);
            Console.WriteLine();
        }

    }

        


}