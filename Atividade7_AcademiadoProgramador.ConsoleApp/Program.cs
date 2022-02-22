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
            static void maior2Testagem(ref int maior2, ref int[] numeros, ref int maior)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (numeros[i] < maior && numeros[i] > maior2)
                    {
                        maior2 = numeros[i];
                    }
                }
            }

            static void maior3Testagem(ref int maior3, ref int[] numeros, ref int maior2)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (numeros[i] < maior2 && numeros[i] > maior3)
                    {
                        maior3 = numeros[i];
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

            static double media(int[] numeros)
            {
                //int soma = 0;
                int cont = 0;
                double media;
                for (int i = 0; i < numeros.Length; i++)
                {
                    cont = cont + numeros[i];
                }

                media = cont / numeros.Length;
                return media;
            }

            int[] numeros = new int[10];
            int maior = 0;
            //int menor;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite o numero " + i + ": ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            maiorTestagem(ref maior, ref numeros);
            Console.WriteLine();
            Console.Write("O maior numero é o: " + maior);

            Console.WriteLine();

            int maior2 = 0;
            maior2Testagem(ref maior2, ref numeros, ref maior);
            Console.WriteLine();
            Console.Write("O segundo maior numero é o: " + maior2);

            Console.WriteLine();

            int maior3 = 0;
            maior3Testagem(ref maior3, ref numeros, ref maior2);
            Console.WriteLine();
            Console.Write("O terceiro maior numero é o: " + maior3);
            //menorTestagem(out menor, out numeros);
            //Console.WriteLine();
            //Console.Write("O maior numero é o: " + menor);


            Console.WriteLine();
            Console.WriteLine();
            Console.Write("A média aritmética é: " + media(numeros));
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Sequencia de numeros: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(numeros[i] + " ");
            }

        }
    }
}
