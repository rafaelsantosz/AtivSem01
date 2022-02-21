using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivSem01.Classes
{
    public class Funcoes
    {
        //Método responsável por criar uma Matriz
        public static int[,] CriarMatriz()
        {
            try
            {
                Console.Write("Quantas linhas terá a Matriz? ");
                int linhasMatriz = int.Parse(Console.ReadLine()); //recebe o número de linhas da Matriz
                Console.Write("E quantas colunas? ");
                int colunasMatriz = int.Parse(Console.ReadLine()); //recebe o número de colunas da Matriz

                //cria uma Matriz com o número de linhas e colunas informado
                int[,] matrizNumeros = new int[linhasMatriz, colunasMatriz];

                //loop para solicitar os números da Matriz
                for (int i = 0; i < linhasMatriz; i++)
                {
                    Console.WriteLine($"-------------------------------------");

                    for (int j = 0; j < colunasMatriz; j++)
                    {
                        Console.Write($"Informe o número da posição ({i},{j}): ");
                        matrizNumeros[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                return matrizNumeros;
            }
            //caso ocorra um erro, é retornado uma matriz vazia
            catch (Exception)
            {
                int[,] matrizVazia = new int[0, 0];

                return matrizVazia;
            }
        }

        //Método recebe uma matriz de inteiros e faz a soma total dos números
        public static int Somar(int[,] matriz)
        {
            int resultado = 0;

            try
            {
                //loop para fazer a soma total
                foreach (int numeros in matriz)
                {
                    resultado += numeros;
                }

                return resultado;
            }
            //caso ocorra um erro, é retornado 0 como resultado
            catch (Exception)
            {
                return 0;
            }
        }

        //Método responsável por criar um array
        public static int[] CriarArray()
        {
            Console.WriteLine("INFORME 4 NÚMEROS!");
            try
            {
                int[] numeros = new int[4];

                //loop para solicitar os números
                for (int i = 0; i < 4; i++)
                {
                    Console.Write("Digite o " + (i + 1) + "°: ");
                    numeros[i] = int.Parse(Console.ReadLine());
                }
                    
                return numeros;
            }
            //caso ocorra um erro, é retornado um array
            catch (Exception)
            {
                int[] array = new int[4];
                return array;
            }
        }

        //Método recebe 4 números e retorna o maior deles
        public static int MaiorNumero(int num1, int num2, int num3, int num4)
        {
            try
            {
                int[] arrayNumeros = new int[4];

                //adiciona os números no array
                arrayNumeros[0] = num1;
                arrayNumeros[1] = num2;
                arrayNumeros[2] = num3;
                arrayNumeros[3] = num4;

                return arrayNumeros.Max(); //retorna o maior número
            }
            //caso ocorra um erro, é retornado 0 como resultado
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
