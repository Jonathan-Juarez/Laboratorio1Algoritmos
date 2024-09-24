using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1Algoritmos
{
    public class ExercicesAgorithms
    {
        public static void Ejecución()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Laboratorio: Algoritmos de Búsqueda, Ordenación y Programación Eficiente.\n");
            Console.WriteLine("1.Algoritmo de búsqueda.");
            Console.WriteLine("2.Algoritmo de ordenamiento.");
            Console.WriteLine("3.Algoritmo de programación exhautiva y vuelta atrás.\n");

            Console.Write("¿Qué algoritmo deseas usar? ");
            int aSelection = Convert.ToInt32(Console.ReadLine());

            ExecirseSelection(aSelection);
        }
        public static void ExecirseSelection(int aSelection)
        {
            Console.Clear();
            string answer = "SI";
            switch (aSelection)
            {
                case 1:
                    int[] sNumbers = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
                    Console.WriteLine("ALGORITMOS DE BÚSQUEDA\n");
                    Console.WriteLine("1.Búsqueda Binaria en un Array Ordenado");
                    Console.WriteLine("2.Búsqueda Secuencial con Condición");
                    Console.WriteLine("3.Búsqueda de un Elemento Mayor que un Dado");
                    Console.WriteLine("4.Búsqueda de Elementos Duplicados\n");
                    Console.WriteLine("Ingresa cualquier número para ir al menú.\n");

                    Console.Write("¿Qué algoritmo de búsqueda desea usar? ");
                    int aSearch = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Lista: 1, 3, 5, 7, 9, 11, 13, 15, 17, 19\n");
                    switch (aSearch)
                    {
                        case 1:
                            while (answer.ToUpper() == "SI")
                            {
                                if (answer.ToUpper() == "SI")
                                {
                                    Console.WriteLine("Lista: 1, 3, 5, 7, 9, 11, 13, 15, 17, 19\n");

                                    Console.Write("¿Qué número desea encontrar? ");
                                    int selectedNumber = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine($"El número {selectedNumber} se encuentra en el índice {SearchAlgorithms.BúsquedaBinaria(sNumbers, selectedNumber)}\n");
                                    Console.Write("¿Desea intentar con otro número? (SI / NO): ");
                                    answer = Console.ReadLine();
                                    Console.Clear();
                                }
                            }
                            Ejecución();
                            break;
                        case 2:
                            Console.WriteLine($"El primer índice que se puede dividir entre 3 es {SearchAlgorithms.BúsquedaSecuencial(sNumbers)}");
                            Console.Write("\nColoca SI para ir al menú o cualquier letra para salir. ");
                            answer = Console.ReadLine();
                            if (answer.ToUpper() == "SI")
                            {
                                Ejecución();
                            }
                            System.Environment.Exit(0);
                            break;
                        case 3:
                            while (answer.ToUpper() == "SI")
                            {
                                if (answer.ToUpper() == "SI")
                                {
                                    Console.WriteLine("Lista: 1, 3, 5, 7, 9, 11, 13, 15, 17, 19\n");
                                    Console.Write("¿Qué número desea encontrar? ");
                                    int givenNumber = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine($"El número mayor al {givenNumber} se encuentra en el índice {SearchAlgorithms.BúsquedaMayorValorDado(sNumbers, givenNumber)}");
                                    Console.Write("¿Desea intentar con otro número? (SI / NO): ");
                                    answer = Console.ReadLine();
                                    Console.Clear();
                                }
                            }
                            Ejecución();
                            break;
                        case 4:
                            Console.WriteLine($"¿Hay valores repetidos? {SearchAlgorithms.BúsquedaNúmerosRepetidos(sNumbers)}");
                            Console.Write("\nColoca SI para ir al menú o cualquier letra para salir. ");
                            answer = Console.ReadLine();
                            if (answer.ToUpper() == "SI")
                            {
                                Ejecución();
                            }
                            System.Environment.Exit(0);

                            break;
                        default:
                            Ejecución();
                            Console.ReadKey();
                            break;
                    }
                    break;
                case 2:
                    int[] oNumbers = { 38, 27, 43, 3, 9, 82, 10, 15, 90, 29 };
                    Console.WriteLine("ALGORITMOS DE ORDENAMIENTO\n");
                    Console.WriteLine("1.Ordenación por inserción");
                    Console.WriteLine("2.Ordenación por selección");
                    Console.WriteLine("3.Ordenación por burbuja optimizada");
                    Console.WriteLine("4.Ordenación por fusión\n");

                    Console.Write("¿Qué algoritmo de ordenación desea usar? ");
                    int aOrder = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Datos no ordenados: 38, 27, 43, 3, 9, 82, 10, 15, 90, 29\n");
                    switch (aOrder)
                    {
                        case 1:
                            int[] oInsertion = ClassificationAlgorithms.OrdenaciónInserción(oNumbers);
                            Console.WriteLine($"Datos ordenados: {string.Join(", ", oInsertion)}");
                            break;
                        case 2:
                            int[] oSelection = ClassificationAlgorithms.OrdenaciónSeleción(oNumbers);
                            Console.WriteLine($"Datos ordenaods: {string.Join(", ", oSelection)}");
                            break;
                        case 3:
                            int[] oBubble = ClassificationAlgorithms.OrdenaciónBurbujaOptimizada(oNumbers);
                            Console.WriteLine($"Datos ordenados: {string.Join(", ", oBubble)}");
                            break;
                        case 4:
                            int[] oMerge = ClassificationAlgorithms.MergeSort(oNumbers);
                            Console.WriteLine($"Datos ordenados: {string.Join(", ", oMerge)}");
                            break;
                    }
                    break;
                case 3:
                    char[] eChar = { 'A', 'B', 'C', 'D', 'E' };
                    Console.Write("¿Qué algoritmo de programación exhaustiva desea usar? ");
                    int aExahustiveBackTracking = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Datos no ordenados: 38, 27, 43, 3, 9, 82, 10, 15, 90, 29\n");
                    switch (aExahustiveBackTracking)
                    {
                        case 1:

                            break;
                        case 2:
                            Console.WriteLine("¿Cuántas combinaciones desea? ");
                            int kCombination = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 3:
                           
                            break;
                        case 4:
                            
                            break;
                    }
                    break;
                default:
                    Console.Write("Ingresa uno de los números dados. Presiona cualquier tecla para volver al menú.");
                    break;

            }
        }
    }
}
