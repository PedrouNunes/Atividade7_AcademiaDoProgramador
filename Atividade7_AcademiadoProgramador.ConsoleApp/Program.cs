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

            //static void menorTestagem(out int menor, out int[] numeros)
            //{
            //    menor = 9999999;
            //    for (int i = 0; i < 10; i++)
            //    {
            //        if (numeros[i] < menor)
            //        {
            //            menor = numeros[i];
            //        }
            //    }
            //}

            static int media(int[] numeros)
            {
                //int soma = 0;
                int cont = 0;
                int media;
                for (int i = 0; i < numeros.Length; i++)
                {
                    cont = cont + numeros[i];
                }

                media = cont / numeros.Length;
                return media;
            }

            int[] numeros = new int[10];
            int maior = 0;
            int menor;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite o numero " + i + ": ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            maiorTestagem(ref maior, ref numeros);
            Console.WriteLine();
            Console.Write("O maior numero é o: " + maior);

            //menorTestagem(out menor, out numeros);
            //Console.WriteLine();
            //Console.Write("O maior numero é o: " + menor);

            
            Console.WriteLine();
            Console.Write("A média aritmética é: " + media(numeros));
            

        }
    }
}
