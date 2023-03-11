using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01___Suma_de_numeros_al_azar
{
    internal class Ejercicio01
    {
        static void Main(string[] args)
        {
            /* 
                1. Escriba un programa que genere un vector de 50 números enteros al azar 
                   y lo muestre. Calcule e imprima su suma. Los números deben oscilar 
                   entre el 0 y el 9. 
            */

            int[] vNumeros = new int[50];
            Random random = new Random();

            for (int i = 0; i < 50; i++)
            {
                vNumeros[i] = random.Next(0, 10);
            }

            for (int i = 0; i < 50; i++)
            {
                Console.Write(vNumeros[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
