using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18___Frecuencia_numeros_de_un_dado_2
{
    internal class Ejercicio18
    {
        static void Main(string[] args)
        {
            /*
                18. Repita el ejercicio anterior, pero ahora informe el número que salió 
                    más veces y el número que salió menos veces. 
            */

            Random random = new Random();
            int[] vTiradas = new int[100];
            int[] vFrecuencia = new int[] { 0, 0, 0, 0, 0, 0 };
            int maxNumTirada = 0, minNumTirada = 0, indiceMax = 0, indiceMin = 0;

            // Proceso de inicialización y visualización
            Console.WriteLine("Tiradas:");
            for (int i = 0; i < 100; i++)
            {
                vTiradas[i] = random.Next(1, 7);

                switch (vTiradas[i])
                {
                    case 1: vFrecuencia[0]++; break;
                    case 2: vFrecuencia[1]++; break;
                    case 3: vFrecuencia[2]++; break;
                    case 4: vFrecuencia[3]++; break;
                    case 5: vFrecuencia[4]++; break;
                    case 6: vFrecuencia[5]++; break;

                }

                if (i % 10 == 0 && i != 0)
                {
                    Console.WriteLine();
                    Console.Write(vTiradas[i] + " ");
                }
                else
                {
                    Console.Write(vTiradas[i] + " ");
                }
            }
            Console.WriteLine();

            // Proceso de búsqueda de máxima y mínima tirada
            for (int i = 0; i < 6; i++)
            {
                if (i == 0)
                {
                    maxNumTirada = vFrecuencia[i];
                    indiceMax = i;
                }
                else if (vFrecuencia[i] > maxNumTirada)
                {
                    maxNumTirada = vFrecuencia[i];
                    indiceMax = i;
                }

                if (i == 0)
                {
                    minNumTirada = vFrecuencia[i];
                    indiceMin = i;
                }
                else if (vFrecuencia[i] < minNumTirada)
                {
                    minNumTirada = vFrecuencia[i];
                    indiceMin = i;
                }
            }
           
            // Resultados
            Console.WriteLine();
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Frecuencia número {i + 1}: {vFrecuencia[i]}");
            }
            Console.WriteLine();

            Console.WriteLine($"El número con mayor frecuencia: {indiceMax + 1}");
            Console.WriteLine($"El número con menor frecuencia: {indiceMin + 1}");
        }
    }
}
