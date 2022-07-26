using System;
using System.IO;

var path = @"c:\temp\globo";
using var fsw = new FileSystemWatcher(path);
fsw.Create += OnCreated;
fsw.Rename += OnRenamed;
fsw.Deleted += OnDeleted;

fsw.EnableRaisingEvents = true;
fsw.IncludeSubdirectories = true;

Console.WriteLine($"Monitorando eventos na pasta {path}");
Console.WriteLine("Presione ENTER para finalizar...");
Console.ReadLine();

Console.ReadLine();

void OnCreated (object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"Foi criado o arquivo {e.Name}.");
}

void OnDeleted (object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"Foi excluído o arquivo {e.Name}.");
}

void OnRenamed(object sender, RenamedEventArgs e)
{
    Console.WriteLine($"O arquivo {e.OldName} foi renomeado.");
}
