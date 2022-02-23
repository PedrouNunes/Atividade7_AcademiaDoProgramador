using System;
using System.Linq;

namespace Atividade7_AcademiadoProgramador.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void maiorTestagem(ref double maior, ref double[] numeros)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (numeros[i] > maior)
                   {
                       maior = numeros[i];
                   }
                }
            }
            static void maior2Testagem(ref double maior2, ref double[] numeros, ref double maior)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (numeros[i] < maior && numeros[i] > maior2)
                    {
                        maior2 = numeros[i];
                    }
                }
            }
            static void maior3Testagem(ref double maior3, ref double[] numeros, ref double maior2)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (numeros[i] < maior2 && numeros[i] > maior3)
                    {
                        maior3 = numeros[i];
                    }
                }
            }
            static void menorTestagem(double[] numeros, out double menor)
            {
                menor = 9999999;
                for (int i = 0; i < 10; i++)
                {
                    if (numeros[i] < menor)
                    {
                        menor = numeros[i];
                    }
                }
            }
            static double media(double[] numeros)
            {
                double soma = 0;
                for (int i = 0; i < numeros.Length; i++)
                {
                    soma = soma + numeros[i];
                }
                return soma / numeros.Length;
            }
            static void negativo(double[] numeros)
            {
                String negativos = "";
                for (int i = 0; i < numeros.Length; i++)
                {
                    if (numeros[i] < 0)
                    {
                        negativos = negativos + numeros[i];
                    }
                }
                char[] numerosNegativos = negativos.ToCharArray();

                for (int i = 0; i < numerosNegativos.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(numerosNegativos[i]);
                    }
                    else
                    {
                        if(i % 2 != 0 && i < numerosNegativos.Length - 1){
                            Console.Write(numerosNegativos[i] + ", ");
                        }
                        else
                        {
                            Console.Write(numerosNegativos[i]);
                        }
                    }
                }

            }
            static void removerItem(ref double[] numeros, ref double excluir)
            {
                int numeroParaRemover = 0, j = 0;

                for (int i = 0; i < numeros.Length; i++)
                {
                    if (numeros[i] == excluir)
                    {
                        numeroParaRemover = numeroParaRemover + 1;
                    }
                }

                double[] listaComORemovido = new double[numeros.Length - numeroParaRemover];

                for (int i = 0; i < numeros.Length; i++)
                {
                    if(numeros[i] != excluir){
                        listaComORemovido[j] = numeros[i];
                        j = j + 1;
            }
                }
                numeros = listaComORemovido;

            }
            static void exibir(double[] numeros)
            {
                for (int i = 0; i < numeros.Length; i++)
                {
                    if (i < numeros.Length - 1)
                    {
                        Console.Write(numeros[i] + ", ");
                    }
                    else
                    {
                        Console.Write(numeros[i]);
                    }
                }
            }

            double[] numeros = new double[10];
            double maior = 0;
            double menor;         
          
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite o numero " + i + ": ");
                numeros[i] = Convert.ToDouble(Console.ReadLine());
            }
            
            maiorTestagem(ref maior, ref numeros);
            Console.WriteLine();
            Console.Write("O maior numero é o: " + maior);

            Console.WriteLine();

            double maior2 = 0;
            maior2Testagem(ref maior2, ref numeros, ref maior);
            Console.WriteLine();
            Console.Write("O segundo maior numero é o: " + maior2);

            Console.WriteLine();

            double maior3 = 0;
            maior3Testagem(ref maior3, ref numeros, ref maior2);
            Console.WriteLine();
            Console.Write("O terceiro maior numero é o: " + maior3);

            Console.WriteLine();
            Console.WriteLine();

            menorTestagem(numeros, out menor);
            Console.Write("O menor numero é o: " + menor);

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("A média aritmética é: " + media(numeros));

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Numeros negativos: ");
            negativo(numeros);

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Sequencia de numeros: ");
            exibir(numeros);

            Console.WriteLine();
            Console.WriteLine();
           
            Console.Write("Digite um valor para ser removido: ");
            double remover = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            removerItem(ref numeros, ref remover);

            Console.Write("Valor com o número removido: ");
            exibir(numeros);

            Console.WriteLine();
        }
    }
}
