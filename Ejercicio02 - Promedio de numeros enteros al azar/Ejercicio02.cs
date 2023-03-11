using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02___Promedio_de_numeros_enteros_al_azar
{
    internal class Ejercicio02
    {
        static void Main(string[] args)
        {
            /* 
                2. Escriba un programa que genere un vector de 20 enteros al azar, lo 
                   muestre y calcule e imprima promedio. Los números deben oscilar entre
                   el 5 y el 10. 
            */

            Random random = new Random();
            int[] vNumeros = new int[20];
            int acumulador = 0;

            for (int i = 0; i < 20; i++)
            {
                vNumeros[i] = random.Next(5, 11);
                acumulador += vNumeros[i];
            }

            float promedio = acumulador / 20.0f;

            for (int i = 0; i < 20; i++)
            {
                Console.Write(vNumeros[i] + " ");
            }
            Console.WriteLine($"\nEl promedio es: {Math.Round(promedio, 2)}");
        }
    }
}
