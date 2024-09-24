using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1Algoritmos
{
    public class SearchAlgorithms
    {
        public static int BúsquedaBinaria(int[] arrayNumbers, int selectedNumber)
        {
            //Inicializar indice inicio y fin del arreglo.
            int iArray = 0;
            int fArray = arrayNumbers.Length - 1; //- 1 porque se comienza a contar desde el 0.

            //Evaluar si el array de inicio es menor al array de fin.
            while (iArray <= fArray)
            {
                //Buscar valor medio del arreglo.
                int mArray = (iArray + fArray) / 2; //Ejemplo: m = (0 + 9) / 2 = 4, por ser entero.
                                                    //m = (5 + 5) / 2 = 5; continua hasta que dé el número buscado.

                if (arrayNumbers[mArray] < selectedNumber) //Ejemplo: Buscar el 7, entonces, 4 < 7, sí.
                {
                    iArray = mArray + 1; //Deja te tomar en cuenta la primera mitad, asignando que el valor de inicio es el valor medio de array + 1.
                                         //Ejemplo: iArray = 4 + 1; ... 
                }
                else if (arrayNumbers[mArray] > selectedNumber)
                {
                    fArray = mArray - 1; //Se enfonca en la primera mitad, asignando que el valor final es el valor medio de array - 1.
                }
                else
                {
                    return mArray; //Si no es mayor ni menor, m es el valor buscado.
                }
            }
            return -1; //No se encontró el número.
        }

        //Tiene que tomar en cuenta uno por uno hasta llegar a encontrar el valor que se puede dividir entre 3.
        public static int BúsquedaSecuencial(int[] arrayNumbers)
        {
            int iArray = 0;
            int fArray = arrayNumbers.Length - 1;

            while (iArray <= fArray)
            {
                if (arrayNumbers[iArray] % 3 == 0) //0 % 3; 1 % 3; ... 
                {
                    return iArray; //Es el primer número del arreglo que se divide entre 3

                }
                else
                {
                    iArray++; //0 + 1; 1 + 1; ... Irá sumando hasta que llegue al que cumpla con la condición.
                }
            }
            return -1; //No hay ningún número divisible entre 3.
        }
        public static int BúsquedaMayorValorDado(int[] arrayNumbers, int givenNumber)
        {
            int iArray = 0;
            int fArray = arrayNumbers.Length - 1;

            while (iArray <= fArray)
            {
                if (givenNumber < arrayNumbers[iArray]) //4 < 1; ... 4 < 5, sí.
                {
                    return iArray;
                }
                else
                {
                    iArray++; //1 + 1; ... 4 + 1 ; 
                }
            }
            return -1;
        }
        public static bool BúsquedaNúmerosRepetidos(int[] arrayNumbers)
        {
            int iArray = 0;
            int fArray = arrayNumbers.Length - 1;
            //Evaluar el arreglo de inicio (i) con cada de los elementos de la lista. 
            for (int i = 0; i <= fArray; i++)
            {
                for (int f = i + 1; f <= fArray; f++)
                {
                    if (arrayNumbers[i] == arrayNumbers[f])
                    {
                        return true;
                    }
                    else
                    {
                        iArray++;
                    }
                }
            }
            return false; //No encontró un número igual en el arreglo.          
        }
    }
}


