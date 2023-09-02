using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("YO SOY UN PROGRAMADOR Y EXPERTO EN REDES RECONOCIDO");
            Console.WriteLine("#JAJAJA_FENOMENALLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL");
            //Variables
            int opcion;
            string nombre;
                long numero;

            //Instanciamos a la coleccion
            Dictionary<string, long> contactos = new Dictionary<string, long>();

            do
            {
                Console.Clear();  //limpiamos la consola

                //Menu
                Console.WriteLine("1. Agregar contacto");
                Console.WriteLine("2. Buscar contacto");
                Console.WriteLine("3. Eliminar contacto");
                Console.WriteLine("Mostrar contactos");

                Console.Write("\nEscoge una opcion:  ");
                opcion = Convert.ToInt32(Console.ReadLine());

                Console.Clear();  //limpiamos la consola

                switch (opcion)
                {
                    case 1:
                        Console.Write(" Nombre:  ");
                        nombre = Console.ReadLine();

                        Console.WriteLine("Numero:  ");
                        numero = Convert.ToInt64(Console.ReadLine());

                        contactos.Add(nombre, numero);
                        Console.WriteLine("\n({0}) se ha agregado con exito",nombre);

                        Console.WriteLine("\nPresiona cualquier tecla para regresar al menu...");
                        Console.ReadKey();

                        break;

                        case 2:
                        Console.WriteLine("buscar contacto por nombre:  ");
                        nombre = Console.ReadLine();

                        if (contactos.ContainsKey(nombre))
                        {

                            Console.WriteLine("\nContacto encontrado!");

                            Console.WriteLine("{0}: {1}", nombre, contactos[nombre]);
                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menu...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("El contacto no existe!");
                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menu...");
                            Console.ReadKey();

                        }

                        break;

                    case 3:
                        Console.WriteLine(" Contacto a eliminar");
                        nombre = Console.ReadLine();

                        if (contactos.ContainsKey(nombre))
                        {

                           contactos.Remove(nombre);

                            Console.WriteLine("\n({0} ha sido eliminado con exito" , nombre);
                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menu...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("El contacto no existe!");
                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menu...");
                            Console.ReadKey();

                        }

                        break;

                    case 4:
                        Console.WriteLine("Contactos en tu agenda: \n");

                        foreach(KeyValuePair<string, long> elemento in contactos)
                        {
                            Console.WriteLine("{0}: {1}", elemento.Key, elemento.Value);
                        }
                        Console.WriteLine("\nPresiona cualquier tecla para regresar al menu...");
                        Console.ReadKey();

                        break;




                }

            } while (opcion >= 1 && opcion <= 4);



          
        }
    }
}
