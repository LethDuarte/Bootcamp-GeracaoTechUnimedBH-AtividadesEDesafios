using System;
using ExemploPOO.Models;
using ExemploPOO.Interfaces;
using ExemploPOO.Helper;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "C:\\DIO - TrabalhandoComArquivos";
            var caminhoPathCombine = Path.Combine(caminho, "PastaTeste 3");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-test-stream.txt");
            var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-bkp.txt");
            var novoCaminhoArquivo = Path.Combine(caminho, "PastaTeste 2", "arquivo-teste-stream.tx");

            var listaString = new List<string>{"Linha 1", "Linha 2", "Linha 3"};
            var listaStringContinuacao = new List<string>{"Linha 4", "Linha 5", "Linha 6"};

            FileHelper helper = new FileHelper();
            helper.DeletarArquivo(caminhoArquivoTesteCopia);

            //helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);

            //helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo);
            //helper.LerArquivosStream(caminhoArquivo);

            //helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            //helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);
            
            
            //helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            
            //helper.CriarArquivoTexto(caminhoArquivo, "Olá! Teste de escrita de arquivo.");

            //helper.ApagarDiretorio(caminhoPathCombine, true);

            // System.Console.WriteLine("Criando diretório: " + caminhoPathCombine);
            // helper.CriarDiretorio(caminhoPathCombine);

            //helper.ListarArquivosDiretorios(caminho);
            //helper.ListarDiretorios(caminho);
            
            // ICalculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.Somar(10, 20));
            
            
            // Corrente c = new Corrente();
            // c.Creditar(100);
            // c.ExibirSaldo();

            // Calculadora calc = new Calculadora();
            // System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10,10));
            // System.Console.WriteLine("Resultado da segunda soma: " + calc.Somar(10,10,10));

            // Aluno a1 = new Aluno();
            // a1.Nome = "Roberto";
            // a1.Idade = 18;
            // a1.Documento = "123456";
            // a1.Nota = 10;
            // a1.Apresentar();

            // Professor p1 = new Professor();
            // p1.Nome = "Carlos";
            // p1.Idade = 45;
            // p1.Documento = "789654";
            // p1.Salario = 2000;
            // p1.Apresentar();
            
            
            // //Valores válidos
            // Retangulos r = new Retangulos();
            // r.DefinirMedidas(30, 40);

            // System.Console.WriteLine($"Área: {r.ObterArea()}");

            // //Valores inválidos
            // Retangulos r2 = new Retangulos();
            // r2.DefinirMedidas(0,0);

            // System.Console.WriteLine($"Área: {r2.ObterArea()}");


            // Pessoa p1 = new Pessoa();

            // p1.Nome = "Bob";
            // p1.Idade = 20;

            // p1.Apresentar();
        }
    }
}
