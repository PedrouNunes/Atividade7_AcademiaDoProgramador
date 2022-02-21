using System;

namespace Atividade7_AcademiadoProgramador.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void maiorTestagem(ref int maior, ref int[] numeros)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (numeros[i] > maior)
                   {
                       maior = numeros[i];
                   }
                }
            }


            int[] numeros = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite o numero " + i + ": ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            int maior = 0;
            maiorTestagem(ref maior, ref numeros);
            Console.Write("O maior numero é o: " + maior);

        }
    }
}
