using System;
using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacoesArray op = new OperacoesArray();
            int[] array = new int[5] {6, 3, 8, 1, 9};
            int [] arrayCopia = new int[10];
            string[] arrayString = op.ConverterParaArrayString(array);

            //int valorProcurado = 9;

            System.Console.WriteLine($"Capacidade atual do array: {array.Length}");

            op.RedimensionarArray(ref array, array.Length*2);

            System.Console.WriteLine($"Capacidade atual do array após redimensionar: {array.Length}");

            // int indice = op.ObterIndice(array, valorProcurado);

            // if(indice > -1){
            //     System.Console.WriteLine("O indice do elemento {0} é: {1}", valorProcurado, indice);
            // }
            // else
            // {
            //     System.Console.WriteLine("Valor não existente no array.");
            // }

            // int valorAchado = op.ObterValor(array, valorProcurado);

            // if (valorAchado > 0) //qd o valor não é encontrado, .find retorna o valor padrão do array (no caso 0)
            // {
            //     System.Console.WriteLine("Encontrei o valor");
            // }
            // else{
            //     System.Console.WriteLine("Não encontrei o valor");
            // }

            // bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);

            // if(todosMaiorQue){
            //     System.Console.WriteLine("Todos os valores são maiores que {0}", valorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Existem valores que não são maiores que {0}", valorProcurado);
            // }
            //{0} é substituido pela variavel passada em seguida


            // bool existe = op.Existe(array, valorProcurado);

            // if(existe)
            // {
            //     System.Console.WriteLine("Encontrei o valor {0}", valorProcurado);
            // } 
            // else
            // {
            //     System.Console.WriteLine("Não encontei o valor {0}", valorProcurado);
            // }

            // System.Console.WriteLine("Array original:");
            // op.ImprimirArray(array);
            
            //op.OrdenarBubbleSort(ref array);
            //op.Ordernar(ref array);

            // System.Console.WriteLine("Array ordenado:");
            // op.ImprimirArray(array);

            // System.Console.WriteLine("Array antes da copia");
            // op.ImprimirArray(arrayCopia);

            // op.Copiar(ref array, ref arrayCopia);
            // System.Console.WriteLine("Array depois da copia:");
            // op.ImprimirArray(arrayCopia);


            //declarando um array multidimensional com 4 lns e 2 cols
            // int[,] matriz = new int[4,2]
            // {
            //     {8, 8}, //linha 0 - colunas 0 e 1
            //     {10, 20},  //linha 1 - colunas 0 e 1
            //     {50, 100},  //linha 2 - colunas 0 e 1
            //     {90, 200}   //linha 3 - colunas 0 e 1
            // };

            // for (int i = 0; i < matriz.GetLength(0); i++) //GetLength pega a dimensão do array - vai percorrer as linhas
            // {
            //     for (int j = 0; j < matriz.GetLength(1); j++) //vai percorrer as colunas
            //     {
            //         Console.WriteLine(matriz[i, j]);
            //     }
            // }

            // int[] arrayInteiros = new int[3]; //declarei um array com capacidade máxima de 3posicoes

            // //inserindo valor em cada uma das posições
            // arrayInteiros[0] = 10;
            // arrayInteiros[1] = 20;
            // arrayInteiros[2] = 30;

            // System.Console.WriteLine("Percorrendo o array pelo for:");
            // for (int i = 0; i < arrayInteiros.Length; i++) //boa pratica usar sempre o .Length, que pega a capacidade total do array
            // {
            //     Console.WriteLine(arrayInteiros[i]);
            // }

            // System.Console.WriteLine("Percorrendo o array pelo foreach:");
            // foreach (int item in arrayInteiros)
            // {
            //     System.Console.WriteLine(item);
            // }
        }
    }
}

