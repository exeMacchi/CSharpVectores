using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12___Maximo_y_minimo_1
{
    internal class Ejercicio12
    {
        static void Main(string[] args)
        {
            /* 
               12. Escriba un programa que genere un vector de 30 enteros al azar 
                   (del -10 al 10). Calcule e imprima su mínimo y máximo. 
           */

            Random random = new Random();
            int[] vNumeros = new int[30];
            int maxNum = 0, minNum = 0;

            // Proceso
            for (int i = 0; i < 30; i++)
            {
                vNumeros[i] = random.Next(-10, 11);

                if (i == 0)
                {
                    maxNum = vNumeros[i];
                }
                else if (vNumeros[i] > maxNum)
                {
                    maxNum = vNumeros[i];
                }

                if (i == 0)
                {
                    minNum = vNumeros[i];
                }
                else if (vNumeros[i] < minNum)
                {
                    minNum = vNumeros[i];
                }
            }

            // Resultados
            Console.Write("Números: ");
            for (int i = 0; i < 30; i++)
            {
                Console.Write(vNumeros[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine($"Valor máximo: {maxNum}");
            Console.WriteLine($"Valor mínimo: {minNum}");
        }
    }
}
