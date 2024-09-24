using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1Algoritmos
{
    public class ExhaustiveBacktrackingAlgorithms
    {
        public static void Laberinto()
        {

        }
        public static void GeneraciónCombinaciones(char[] arrayChar, char[]CombinationChar, int kNumbers)
        {
            int iArray = 0;
            int fArray = arrayChar.Length - 1;
            if (iArray == kNumbers) 
            {
                Console.WriteLine(CombinationChar);
                return;
            }
            //INCOMPLETO
            for (int i = 0; i < arrayChar.Length; i++)
            {
                CombinationChar[iArray] = arrayChar[i];
            }
        }
        public static void ResoluciónRompecabezas()
        {
        }
        public static void SudokuSolver()
        {

        }
    }
}
