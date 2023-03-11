using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13___Ordenamiento_burbuja
{
    internal class Ejercicio13
    {
        static void Main(string[] args)
        {
            // 13. Ídem al ejercicio anterior, pero utilizando el método
            //     burbuja de ordenamiento.

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

            // Ordenamiento burbuja
            for (int i = 0; i < 30; i++)
            {
                for (int x = 0; x < 29; x++)
                {
                    if (vNumeros[x] > vNumeros[x + 1])
                    {
                        int aux = vNumeros[x];
                        vNumeros[x] = vNumeros[x + 1];
                        vNumeros[x + 1] = aux;
                    }
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
