using System.IO;
using System;

//var path = Path.Combine(Environment.CurrentDirectory, "globo");
var path = @"c:\temp\globo";
Console.WriteLine("Digite [ENTER] para finalizar");
Console.ReadLine();

static void LerArquivos(string path)
{
    var arquivos = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
    foreach (var arquivo in arquivos)
    {
        var fileInfo = new FileInfo(arquivo);
        Console.WriteLine($"[Nome]: {fileInfo.Name}");
        Console.WriteLine($"[Tamanho]: {fileInfo.Length}");
        Console.WriteLine($"[Último acesso]: {fileInfo.LastAccessTime}");
        Console.WriteLine($"[Pasta]: {fileInfo.DirectoryName}");
        Console.WriteLine("------------------");
    }
}


//LerDiretorios(path);
static void LerDiretorios(string path)
{
    if(Directory.Exists(path))
    {
        var diretorios = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
        //AllDirectories procura em todos diretorios e subdiretorios
        foreach(var dir in diretorios)
        {
            var dirInfo = new DirectoryInfo(dir);
            Console.WriteLine($"[Nome]: {dirInfo.Name}");
            Console.WriteLine($"[Raiz]: {dirInfo.Root}");
            if(dirInfo.Parent != null)
                Console.WriteLine($"[Pai]: {dirInfo.Parent}");

            Console.WriteLine("-----------------------");
        }
    }
    else
    {
        Console.WriteLine($"{path} não existe");
    }
}
