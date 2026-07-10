using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosMetodos
{
    class Program
    {
        static string[,] producto = new string[10, 3];
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("===== MENU =====");
                Console.WriteLine("1. Registrar Producto");
                Console.WriteLine("2. Mostrar Productos");
                Console.WriteLine("3. Actualizar Productos");
                Console.WriteLine("4. Eliminar Productos");
                Console.WriteLine("5. Salir");
                Console.Write("Ingrese una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine(" === REGISTRAR PRODUCTO ===");
                        Registrar();
                        Pausa();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(" === MOSTRAR PRODUCTOS ===");
                        MostrarE();
                        Pausa();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine(" === ACTUALIZAR PRODUCTO ===");
                        Actualizar();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine(" === ELIMINAR PRODUCTO ===");
                        Eliminar();
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
            while (opcion != 5);
        }

        static void Registrar()
        {
            bool registardo = false;

            for (int i = 0; i < 10; i++)
            {
                if (string.IsNullOrEmpty(producto[i, 0]))
                {
                    Console.Write("Codigo: ");
                    producto[i, 0] = Console.ReadLine();
                    Console.Write("Nombre del Producto: ");
                    producto[i, 1] = Console.ReadLine();
                    Console.Write("Cantidad: ");
                    producto[i, 2] = Console.ReadLine();
                    Console.WriteLine("\nProducto registrado.");
                    registardo = true;
                    break;
                }
            }
            if (!registardo)
            {
                Console.WriteLine("\nLa matriz esta llena.");
            }
        }
        static void MostrarE()
        {
            Console.WriteLine("\nCODIGO\tNOMBRE DEL PRODUCTO\tCANTIDAD");
            Console.WriteLine("==========================");
            for (int i = 0; i < 10; i++)
            {
                if (!string.IsNullOrEmpty(producto[i, 0]))
                {
                    Console.WriteLine(
                        producto[i, 0] + "\t" +
                        producto[i, 1] + "\t" +
                        producto[i, 2]);
                }
            }
        }
        static void Actualizar()
        {
            string codigo;
            bool encontrado = false;
            Console.Write("Codigo a buscar: ");
            codigo = Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                if (producto[i, 0] == codigo)
                {
                    Console.Write("Nuevo nombre: ");
                    producto[i, 1] = Console.ReadLine();
                    Console.Write("Nueva cantidad: ");
                    producto[i, 2] = Console.ReadLine();
                    Console.WriteLine("\nRegistro actualizado.");
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("\nCodigo no encontrado.");
            }
        }
        static void Eliminar()
        {
            string codigo;
            bool encontrado = false;
            Console.Write("Codigo a eliminar: ");
            codigo = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                if (producto[i, 0] == codigo)
                {
                    producto[i, 0] = "";
                    producto[i, 1] = "";
                    producto[i, 2] = "";
                    Console.WriteLine("\nRegistro eliminado.");
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("\nCodigo no encontrado.");
            }

        }
        static void Pausa()
        {
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}