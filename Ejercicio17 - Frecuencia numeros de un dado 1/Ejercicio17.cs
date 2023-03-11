using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17___Frecuencia_numeros_de_un_dado_1
{
    internal class Ejercicio17
    {
        static void Main(string[] args)
        {
            /* 
                17. Escriba un programa que inicialice un vector de 100 elementos con los 
                    números de un dado (al azar) e indique la frecuencia de cada número. 
                    Se recomienda usar un vector contador cantdado[6]={0}, donde la 
                    posición 0 esté relacionada con la cantidad de unos del dado, la 
                    posición 1, con las caras «dos», etcétera. 
            */

            Random random = new Random();
            int[] vTiradas = new int[100];
            int[] vFrecuencia = new int[] { 0, 0, 0, 0, 0, 0 };

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

            // Resultados
            Console.WriteLine();
            Console.WriteLine($"Cantidad de veces que el 1 apareció: {vFrecuencia[0]}");
            Console.WriteLine($"Cantidad de veces que el 2 apareció: {vFrecuencia[1]}");
            Console.WriteLine($"Cantidad de veces que el 3 apareció: {vFrecuencia[2]}");
            Console.WriteLine($"Cantidad de veces que el 4 apareció: {vFrecuencia[3]}");
            Console.WriteLine($"Cantidad de veces que el 5 apareció: {vFrecuencia[4]}");
            Console.WriteLine($"Cantidad de veces que el 6 apareció: {vFrecuencia[5]}");
        }
    }
}
