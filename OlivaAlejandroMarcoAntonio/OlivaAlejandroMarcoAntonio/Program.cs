using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlivaAlejandroMarcoAntonio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LikedList lista = new LikedList();
            int op = 0;

            do
            {
                Console.WriteLine("\t**** Registro de números ****");
                Console.WriteLine("");
                Console.WriteLine("1. Insertar nodos al inicio");
                Console.WriteLine("2. Insertar nodos al final");
                Console.WriteLine("3. Mostrar nodos");
                Console.WriteLine("4. Eliminar");
                Console.WriteLine("5. Encontrar el nodo del medio");
                Console.WriteLine("6. Invertir lista");
                Console.WriteLine("7. Salir");
                Console.WriteLine("");
                Console.Write("Seleccione una opción: ");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Write("Digite la cantidad de números a insertar al inicio: ");
                        int cantidadInicio = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < cantidadInicio; i++)
                        {
                            Console.Write($"Ingrese el valor {i + 1}: ");
                            int valorInicio = Convert.ToInt32(Console.ReadLine());
                            lista.InsertarInicio(valorInicio);
                        }
                        break;

                    case 2:
                        Console.Write("Digite la cantidad de números a insertar al final: ");
                        int cantidadFinal = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < cantidadFinal; i++)
                        {
                            Console.Write($"Ingrese el valor {i + 1}: ");
                            int valorFinal = Convert.ToInt32(Console.ReadLine());
                            lista.InsertarFinal(valorFinal);
                        }
                        break;

                    case 3:
                        lista.PrintList();
                        break;

                    case 4:
                        Console.Write("Ingrese el valor a eliminar: ");
                        int valorEliminar = Convert.ToInt32(Console.ReadLine());
                        lista.EliminarNodo(valorEliminar);
                        break;

                    case 5:
                        lista.EncontrarNodoMedio();
                        break;

                    case 6:
                        lista.InvertirLista();
                        break;

                    case 7:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.WriteLine();

            } while (op != 7);
        }
    }
}
