using static System.Console;
using System.IO;

WriteLine("Digite o nome do arquivo: ");
var nome = ReadLine();
nome = LimparNome(nome);
var path = Path.Combine(Environment.CurrentDirectory, $"{nome}.txt");

CriarArquivo(path);
WriteLine("Aperte ENTER para finalizar.");
ReadLine();

static string LimparNome(string nome)
{
    foreach(var @char in Path.GetInvalidFileNameChars())
        {
            nome = nome.Replace(@char, '-');
        }
        return nome;
}

static void CriarArquivo(string path)
{
    try
    {
        using var sw = File.CreateText(path);
        sw.WriteLine("Esta é a linha 1 do arquivo");
        sw.WriteLine("Esta é a linha 1 do arquivo");
        sw.WriteLine("Esta é a linha 1 do arquivo");
    }
    catch 
    {
        WriteLine("O nome do arquivo é inválido.");
    }
    
}



// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// var path = Path.Combine(Environment.CurrentDirectory, "teste.txt");

// //File.Create(path);

// //cria um texto dentro do arquivo
// using (var sw = File.CreateText(path))
// {
//     sw.WriteLine("Esta é a linha 1 do arquivo.");
//     sw.WriteLine("Esta é a linha 2 do arquivo.");
//     sw.WriteLine("Esta é a linha 3 do arquivo.");
// }

//sw.Flush();

