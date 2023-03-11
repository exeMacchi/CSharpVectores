using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03___Promedio_de_numeros_decimales_al_azar
{
    internal class Ejercicio03
    {
        static void Main(string[] args)
        {
            /* 
                3. Escriba un programa que genere un vector de 20 números decimales al 
                   azar y lo muestre. Además, debe calcular e imprimir su promedio (solo 
                   los números que se ubican en subíndices impares). Los números deben 
                   oscilar entre el -5.0 y el 5.0 
            */

            Random random = new Random();
            float[] vNumeros = new float[20];
            int contadorImpares = 0;
            float acumulador = 0;

            for (int i = 0; i < 20; i++)
            {
                vNumeros[i] = (float)random.Next(-5, 6);
                if (i % 2 != 0)
                {
                    acumulador += vNumeros[i];
                    contadorImpares++;
                }
            }

            float promedio = acumulador / contadorImpares;

            for (int i = 0; i < 20; i++)
            {
                Console.Write(vNumeros[i] + " ");
            }
            Console.WriteLine($"\nEl promedio es: {Math.Round(promedio, 2)}");
        }
    }
}
