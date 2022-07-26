string textReaderText = "TextReader é a classe base abstrata " + 
                "de StreamReader e StringReader, que lê caracteres " +
                "de streams e strings, respectivamente. \n\n" + 

                "Crie uma instância de TextReader para abrir um arquivo de texto " + 
                "para ler um intervalo especificado de caracteres " + 
                "ou para criar um leito baseado em um fluxo existente. \n\n";

string linha, paragrafo = null;
var sr = new StringReader(textReaderText);

while (true)
{
    linha = sr.ReadLine();
    if (linha != null)
    {
        paragrafo += linha + " ";
    }
    else
    {
        paragrafo += '\n';
    }
}

Console.WriteLine($"Texto modificado: {paragrafo}");

int caractereLido;
char caractereConvertido;

var sw = new StringWriter();
sr = new StringReader(paragrafo);

while(true)
{
    caractereLido = sr.ReadLine();
    if(caractereLido == -1) break;

    caractereConvertido = Convert.ToChar(caractereLido);

    if(caractereLido == '-')
    {
        sw.Write("\n\n");

        sr.Read();
        sr.Read();
    }
    else
    {
        sw.Write(caractereConvertido);
    }

    COnsole.WriteLine($"Texto armazenado no StringWriter: {sw.ToString()}");
}
