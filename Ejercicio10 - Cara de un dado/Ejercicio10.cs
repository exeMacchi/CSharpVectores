using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10___Cara_de_un_dado
{
    internal class Ejercicio10
    {
        static void Main(string[] args)
        {
            // 10. Ídem al ejercicio anterior, pero contando los números de la
            //     cara de un dado.

            Random random = new Random();
            int[] vTiradas = new int[30];
            int[] vCantidadNumeros = new int[] { 0, 0, 0, 0, 0, 0 };

            // Proceso
            Console.Write("Tiradas: ");
            for (int i = 0; i < 30; i++)
            {
                vTiradas[i] = random.Next(1, 7);

                switch (vTiradas[i])
                {
                    case 1: vCantidadNumeros[0]++; break;
                    case 2: vCantidadNumeros[1]++; break;
                    case 3: vCantidadNumeros[2]++; break;
                    case 4: vCantidadNumeros[3]++; break;
                    case 5: vCantidadNumeros[4]++; break;
                    case 6: vCantidadNumeros[5]++; break;
                }

                // Mostrar tiradas
                Console.Write(vTiradas[i] + " ");
            }
            Console.WriteLine();

            // Ordenar 
            for (int i = 0; i < 30; i++)
            {
                for (int x = 0; x < 29; x++)
                {
                    if (vTiradas[x] > vTiradas[x + 1])
                    {
                        int aux = vTiradas[x];
                        vTiradas[x] = vTiradas[x + 1];
                        vTiradas[x + 1] = aux;
                    }
                }
            }

            // Tiradas ordenadas
            Console.Write("Tiradas ordenadas: ");
            for (int i = 0; i < 30; i++)
            {
                Console.Write(vTiradas[i] + " ");
            }
            Console.WriteLine();

            // Resultados
            Console.WriteLine();
            Console.WriteLine($"Cantidad de veces que el 1 aparece: " +
                              $"{vCantidadNumeros[0]}");
            Console.WriteLine($"Cantidad de veces que el 2 aparece: " +
                              $"{vCantidadNumeros[1]}");
            Console.WriteLine($"Cantidad de veces que el 3 aparece: " +
                              $"{vCantidadNumeros[2]}");
            Console.WriteLine($"Cantidad de veces que el 4 aparece: " +
                              $"{vCantidadNumeros[3]}");
            Console.WriteLine($"Cantidad de veces que el 5 aparece: " +
                              $"{vCantidadNumeros[4]}");
            Console.WriteLine($"Cantidad de veces que el 6 aparece: " +
                              $"{vCantidadNumeros[5]}");
        }
    }
}
