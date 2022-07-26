using System.IO;

var path = Path.Combine(Environment.CurrentDirectory, "globo");
//criando diretorio
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
