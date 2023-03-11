using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11___Vocales_3
{
    internal class Ejercicio11
    {
        static void Main(string[] args)
        {
            /* 
                11. Cree dos vectores paralelos de 30 elementos. Uno debe contener vocales 
                    y el otro números del 1 al 10. Ambos generados al azar. Luego mostrar 
                    solo las vocales donde su vector paralelo tenga números impares. 
            */

            Random random = new Random();
            int[] vNumeros = new int[30];
            char[] vVocales = new char[30];
            char[] vocales = new char[] { 'a', 'e', 'i', 'o', 'u' };

            // Proceso
            for (int i = 0; i < 30; i++)
            {
                vNumeros[i] = random.Next(1, 11);
                int vocal = random.Next(0, 5);
                vVocales[i] = vocales[vocal];
            }

            // Resultados
            Console.Write("Números: ");
            for (int i = 0; i < 30; i++)
            {
                Console.Write(vNumeros[i] + " ");
            }
            Console.WriteLine();

            Console.Write("Vocales: ");
            for (int i = 0; i < 30; i++)
            {
                Console.Write(vVocales[i] + " ");
            }
            Console.WriteLine();

            Console.Write("\nVocales con sus números impares paralelos: ");
            for (int i = 0; i < 30; i++)
            {
                if (vNumeros[i] % 2 != 0)
                {
                    Console.Write(vVocales[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
