using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15___Maximo_y_minimo_2
{
    internal class Ejercicio15
    {
        static void Main(string[] args)
        {
            /* 
                15. Cree dos vectores paralelos de 30 elementos cada uno. Uno debe 
                    contener vocales y el otro números del -10 al 10. Ambos generados al 
                    azar. Hallar el mínimo y máximo en el vector de números, pero 
                    mostrando además las vocales correspondiente al vector paralelo. 
    */

            Random random = new Random();
            int[] vNumeros = new int[30];
            char[] vVocales = new char[30];
            char[] vocales = new char[] { 'a', 'e', 'i', 'o', 'u' };
            int maxNum = 0, indiceMax = 0, minNum = 0, indiceMin = 0;

            // Inicializar
            for (int i = 0; i < 30; i++)
            {
                vNumeros[i] = random.Next(-10, 11);

                int vocal = random.Next(0, 5);
                vVocales[i] = vocales[vocal];
            }

            // Proceso
            for (int i = 0; i < 30; i++)
            {
                if (i == 0)
                {
                    maxNum = vNumeros[i];
                    indiceMax = i;
                }
                else if (vNumeros[i] > maxNum)
                {
                    maxNum = vNumeros[i];
                    indiceMax = i;
                }

                if (i == 0)
                {
                    minNum = vNumeros[i];
                    indiceMin = i;
                }
                else if (vNumeros[i] < minNum)
                {
                    minNum = vNumeros[i];
                    indiceMin = i;
                }
            }

            // Resultados
            //Console.Write("Números: ");
            //for (int i = 0; i < 30; i++)
            //{
            //    Console.Write(vNumeros[i] + " ");
            //}
            //Console.WriteLine();

            //Console.Write("Vocales: ");
            //for (int i = 0; i < 30; i++)
            //{
            //    Console.Write(vVocales[i] + "  ");
            //}
            //Console.WriteLine();
            Console.WriteLine("Números y Vocales: ");
            for (int i = 0; i < 30; i++)
            {
                Console.Write(vNumeros[i] + " ");
                Console.Write(vVocales[i] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine($"Valor máximo: {maxNum} ---> " +
                              $"Vocal: {vVocales[indiceMax]}");

            Console.WriteLine($"Valor mínimo: {minNum} ---> " +
                              $"Vocal: {vVocales[indiceMin]}");
        }
    }
}
