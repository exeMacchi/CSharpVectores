using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20___Dias_de_la_semana_2
{
    internal class Ejercicio20
    {
        static void Main(string[] args)
        {
            /* 
                20. Tome en cuenta el ejercicio anterior y agregue lo siguiente: 
                    Mostrar las veces que aparecieron por cada día de la semana. 
                    Usar un vector contador. 
            */

            Random random = new Random();
            int[] vNumeros = new int[30];
            char[] vSemana = new char[30];
            int[] vFrecuencia = new int[] { 0, 0, 0, 0, 0, 0, 0 };

            for (int i = 0; i < 30; i++)
            {
                vNumeros[i] = random.Next(1, 8);

                switch (vNumeros[i])
                {
                    case 1: vSemana[i] = 'D'; vFrecuencia[0]++; break;
                    case 2: vSemana[i] = 'L'; vFrecuencia[1]++; break;
                    case 3: vSemana[i] = 'M'; vFrecuencia[2]++; break;
                    case 4: vSemana[i] = 'I'; vFrecuencia[3]++; break;
                    case 5: vSemana[i] = 'J'; vFrecuencia[4]++; break;
                    case 6: vSemana[i] = 'V'; vFrecuencia[5]++; break;
                    case 7: vSemana[i] = 'S'; vFrecuencia[6]++; break;
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

            Console.WriteLine();
            Console.WriteLine($"Cantidad de domingos  (D): {vFrecuencia[0]}");
            Console.WriteLine($"Cantidad de lunes     (L): {vFrecuencia[1]}");
            Console.WriteLine($"Cantidad de martes    (M): {vFrecuencia[2]}");
            Console.WriteLine($"Cantidad de miércoles (I): {vFrecuencia[3]}");
            Console.WriteLine($"Cantidad de jueves    (J): {vFrecuencia[4]}");
            Console.WriteLine($"Cantidad de viernes   (V): {vFrecuencia[5]}");
            Console.WriteLine($"Cantidad de sábados   (S): {vFrecuencia[6]}");
        }
    }
}
