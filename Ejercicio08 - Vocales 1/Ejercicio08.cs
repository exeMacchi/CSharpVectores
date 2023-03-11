using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08___Vocales_1
{
    internal class Ejercicio08
    {
        static void Main(string[] args)
        {
            /* 
                8. Escriba un programa que genere un vector de 30 vocales al azar, lo 
                   muestre y cuente la cantidad de vocales «a» y «o». Mostrar resultado.
            */

            Random random = new Random();
            char[] vSecuencia = new char[30];
            char[] vVocales = new char[] { 'a', 'e', 'i', 'o', 'u' };
            int contVocalA = 0, contVocalO = 0;

            // Proceso
            for (int i = 0; i < 30; i++)
            {
                int vocal = random.Next(0, 5);
                vSecuencia[i] = vVocales[vocal];

                if (vSecuencia[i] == 'a')
                {
                    contVocalA++;
                }
                if (vSecuencia[i] == 'o')
                {
                    contVocalO++;
                }
            }

            // Resultados
            Console.Write("Secuencia de vocales: ");
            for (int i = 0; i < 30; i++)
            {
                Console.Write(vSecuencia[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine($"Cantidad de vocales a: {contVocalA}");
            Console.WriteLine($"Cantidad de vocales o: {contVocalO}");
        }
    }
}
