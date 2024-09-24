using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1Algoritmos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    ExercicesAgorithms.Ejecución();
                    Console.ReadKey();
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nError: {e.Message}");
                    Console.ReadKey();
                }

            } while (true);
        }        
    }
}
