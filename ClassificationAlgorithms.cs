using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1Algoritmos
{
    public class ClassificationAlgorithms
    {
        public static int[] OrdenaciónInserción(int[] array)
        {
            //Considerando que el primer elemento se encuentra "ordenado", se comienza a recorrer desde el segundo elemento.
            for (int i = 1; i < array.Length; i++)
            {
                //Almacena los elementos ordenados del arreglo.
                int arrayOrder = array[i], j;
                //Evalúa si el array no ordenado es mayor que arrayOrder.
                for (j = i - 1; j >= 0 && array[j] > arrayOrder; j--)
                {
                    //Desplaza el elemento no ordenado hacia la derecha para hacer espacio al que sí lo está.
                    array[j + 1] = array[j];
                }
                //Inserta el valor del arreglo ordenado en la posición correcta.
                array[j + 1] = arrayOrder;
            }
            return array;
        }
        public static int[] OrdenaciónSeleción(int[] array)
        {
            //38, 27, 43, 3, 9, 82, 10, 15, 90, 29
            int sArray = array.Length; //Guarda el tamaño del arreglo.
            int fArray = array.Length - 1;
 
            //Evaluar cada una de las posibilidades.
            for (int i = 0; i < fArray; i++)
            {
                int iLargest = 0; //Almacena el índice más grande.
                for (int j = 0; j < sArray - i; j++)
                {
                    if (array[j] > array[iLargest])
                    {
                        iLargest = j; //El valor más grande es asignado a la variable iBigger y lo repite hasta el mayor de todos.
                    }
                }

                int tArray = array[fArray - i]; //Almacena en el valor del último arreglo seleccionado.
                array[fArray - i] = array[iLargest]; //El valor final del arreglo se le asigna el valor más grande.
                array[iLargest] = tArray; //El valor más grande se le asigna el valor del último elemento del arreglo.
            }
            return array;

        }
        public static int[] OrdenaciónBurbujaOptimizada(int[] array)
        {
            //Inicializar que todavía no existe ningún intercambio entre elementos.
            bool exchange; 
            //Evaluar cada uno de los índices.
            int arrayNumbers = array.Length - 1;
            for (int i = 0; i < arrayNumbers; i++)
            {
                //Se reinica el valor de intercambio cada que termina una iteración.
                exchange = false;
                for (int j = 0; j < arrayNumbers - i; j++)
                {
                    
                    if (array[j] > array[j + 1])
                    {
                        // Intercambiar elementos
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        //Surge un intercambio y vuelve a subir, dejará de hacerlo cuando haya probado con todo.
                        exchange = true; 
                    }
                }
                //Si no hay intercambio, termina proceso.
                if (exchange == false)
                {
                    break;
                }
            }
           
            return array;
        }

        //OrdenaciónFusión
        public static int[] MergeSort(int[] array)
        {
            if (array.Length <= 1)
                return array;

            int mid = array.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[array.Length - mid];

            Array.Copy(array, 0, left, 0, mid);
            Array.Copy(array, mid, right, 0, array.Length - mid);

            MergeSort(left);
            MergeSort(right);
            Merge(array, left, right);
            return array;
        }

        private static void Merge(int[] array, int[] left, int[] right)
        {   
            int i = 0, j = 0, k = 0;
            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    array[k++] = left[i++];
                }
                else
                {
                    array[k++] = right[j++];
                }
            }

            while (i < left.Length)
            {
                array[k++] = left[i++];
            }

            while (j < right.Length)
            {
                array[k++] = right[j++];
            }
        }
    }
}
