using System.IO;
//criando diretorio
CriarDiretoriosGlobo();

//criando arquivos
//CriarArquivo();

var origem = Path.Combine(Environment.CurrentDirectory, "brasil.txt");
var destino = Path.Combine(Environment.CurrentDirectory, "globo", "América do Sul", "Brasil", "brasil.txt");
CopiarArquivo(origem, destino);

static void CopiarArquivo(string pathOrigem, string pathDestino)
{
    if(!File.Exists(pathOrigem))
    {
        Console.WriteLine("Arquivo de origem não existe.");
    }
    if (File.Exists(pathDestino))
    {
        Console.WriteLine("O arquivo já existe no destino");
    }
    File.Copy(pathOrigem, pathDestino);
}

//MoverArquivo(origem, destino);
static void MoverArquivo(string pathOrigem, string pathDestino)
{
    if(!File.Exists(pathOrigem))
    {
        Console.WriteLine("Arquivo de origem não existe.");
        return;
    }

    if(File.Exists(pathDestino))
    {
        Console.WriteLine("Arquivo já existe na pasta destino");
        return;
    }

    File.Move(pathOrigem, pathDestino);
}


static void CriarArquivo()
{
    var path = Path.Combine(Environment.CurrentDirectory, "brasil.txt");
    if(!File.Exists(path))
    {
        using var sw = File.CreateText(path);
        sw.WriteLine("População: 210 milhões");
        sw.WriteLine("IDH: 0,901");
        sw.WriteLine("Dados atualizados em: 20/04/2018");
    } 
}

static void CriarDiretoriosGlobo()
{
    var path = Path.Combine(Environment.CurrentDirectory, "globo"); 
    if(!Directory.Exists(path))
    {
        var dirGlobo = Directory.CreateDirectory(path);
        //criando subdiretórios
        var dirAmNorte = dirGlobo.CreateSubdirectory("América do Norte");
        var dirAmCentral = dirGlobo.CreateSubdirectory("América Central");
        var dirAmSul = dirGlobo.CreateSubdirectory("América do Sul");

        dirAmNorte.CreateSubdirectory("USA");
        dirAmNorte.CreateSubdirectory("México");
        dirAmNorte.CreateSubdirectory("Canada");

        dirAmCentral.CreateSubdirectory("Costa Rica");
        dirAmCentral.CreateSubdirectory("Panamá");
        dirAmCentral.CreateSubdirectory("El Salvador");

        dirAmSul.CreateSubdirectory("Brasil");
        dirAmSul.CreateSubdirectory("Argentina");
        dirAmSul.CreateSubdirectory("Paraguai");
    }
    else
    {
        System.Console.WriteLine("Pasta já existe.");
    }
}
