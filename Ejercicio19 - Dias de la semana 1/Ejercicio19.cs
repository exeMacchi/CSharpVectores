using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19___Dias_de_la_semana_1
{
    internal class Ejercicio19
    {
        static void Main(string[] args)
        {
            /* 
                19. Escriba un programa que genere números al azar del 1 al 7 en un vector 
                    de 30 elementos. Éstos representan los números de la semana, en la 
                    medida en que van apareciendo los números, deberá agregar a otro 
                    vector de tipo char las letras correspondientes al día de semana.
                    Por ejemplo: 1 es D, 2 es L, 3 es M, 4 es I, 5 es J, 6 es V y 7 es S. 
                    Mostrar ambos vectores. 
            */

            Random random = new Random();
            int[] vNumeros = new int[30];
            char[] vSemana = new char[30];

            // Proceso
            for (int i = 0; i < 30; i++)
            {
                vNumeros[i] = random.Next(1, 8);

                switch (vNumeros[i])
                {
                    case 1: vSemana[i] = 'D'; break;
                    case 2: vSemana[i] = 'L'; break;
                    case 3: vSemana[i] = 'M'; break;
                    case 4: vSemana[i] = 'I'; break;
                    case 5: vSemana[i] = 'J'; break;
                    case 6: vSemana[i] = 'V'; break;
                    case 7: vSemana[i] = 'S'; break;
                }
            }

            // Resultados
            Console.WriteLine("Resultados:");
            for (int i = 0; i < 30; i++)
            {
                if (i % 10 == 0 && i != 0)
                {
                    Console.WriteLine();
                    Console.Write($"{vNumeros[i]}-{vSemana[i]} ");
                } 
                else
                {
                    Console.Write($"{vNumeros[i]}-{vSemana[i]} ");
                }
            }
            Console.WriteLine();
        }
    }
}
