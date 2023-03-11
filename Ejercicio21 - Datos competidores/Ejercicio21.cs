using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio21___Datos_competidores
{
    internal class Ejercicio21
    {
        static void Main(string[] args)
        {
            /* 
                21. En una competencia de maratón se necesita registrar tres datos de 200 
                    competidores (número de corredor, peso y ubicación). Ingresar los 
                    datos en tres vectores paralelos (vn, vp y vu, respectivamente). 
                    Luego se pide lo siguiente:
	                    a. Ordene de modo ascendente por ubicación.
	                    b. Muestre ubicación y número de competidor (solo los 10 primeros 
                           ordenados).
	                    c. Halle y muestre el promedio de peso de todos. 
            */
            Random random = new Random();
            int[] vNumeroCorredor = new int[200];
            float[] vPesoCorredor = new float[200];
            int[] vUbicacionCorredor = new int[200];
            int numeroCompetidores = 10;
            float pesoAcumulado = 0;

            // Pedida de datos
            for (int i = 0; i < numeroCompetidores; i++)
            {
                Console.WriteLine($"----------- Competidor {i + 1} -----------");
                Console.Write("Número: "); 
                vNumeroCorredor[i] = int.Parse(Console.ReadLine());

                Console.Write("Peso (kg): ");
                vPesoCorredor[i] = float.Parse(Console.ReadLine());
                pesoAcumulado += vPesoCorredor[i];

                Console.Write("Ubicación: ");
                vUbicacionCorredor[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            //Orden
            for (int i = 0; i < numeroCompetidores; i++)
            {
                for (int x = 0; x < (numeroCompetidores - 1); x++)
                {
                    if (vUbicacionCorredor[x] > vUbicacionCorredor[x + 1])
                    {
                        float aux = vUbicacionCorredor[x];
                        vUbicacionCorredor[x] = vUbicacionCorredor[x + 1];
                        vUbicacionCorredor[x + 1] = (int)aux;

                        aux = vNumeroCorredor[x];
                        vNumeroCorredor[x] = vNumeroCorredor[x + 1];
                        vNumeroCorredor[x + 1] = (int)aux;

                        aux = vPesoCorredor[x];
                        vPesoCorredor[x] = vPesoCorredor[x + 1];
                        vPesoCorredor[x + 1] = aux;
                    }
                }
            }

            //Promedio
            float promedioPeso = pesoAcumulado / numeroCompetidores;

            //Resultados
            Console.WriteLine("\n---------------- Resultados ----------------");
            Console.WriteLine("Ubicación y numeración de los 10 primeros competidores:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i + 1}. Competidor número {vNumeroCorredor[i]} " +
                                  $"----> Ubicación: {vUbicacionCorredor[i]}");
            }
            Console.WriteLine($"\nPromedio de peso de todos los competidores: " +
                              $"{Math.Round(promedioPeso, 2)}");
        }
    }
}
