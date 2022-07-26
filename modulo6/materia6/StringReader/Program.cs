using System.Text;
using System.IO;
using System;

var sb = new StringBuilder();

sb.AppendLine("Caracteres na primeira linha para ler,");
sb.AppendLine("e a segunda linha,");
sb.AppendLine("e o fim.");

using var sr = new StringReader(sb.ToString());
//var buffer = new char[10];
//var tamanho = 0;

do
{
    Console.WriteLine(sr.ReadLine());
} while (sr.Peek() >= 0);

// do
// {
//     tamanho = sr.Read(buffer);
//     Console.WriteLine(string.Join(" ", buffer));
// } while  (tamanho >= buffer.Length);

// Console.WriteLine("Digite ENTER para finalizar");
// Console.ReadLine();

//var pos = sr.Read(buffer);
//Console.WriteLine($"{string.Join(" ", buffer)}");
//Console.Read();

//var texto = sr.ReadLine();
