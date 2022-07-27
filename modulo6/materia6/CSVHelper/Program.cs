using System.IO;
using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper;

//LerCsvComClasse();
//LerCsvComOutroDelimitador();
EscreverCsv();

Console.WriteLine("Digite ENTER para finalizar");
Console.ReadLine();

static void EscreverCsv()
{
    var path = Path.Combine(Environment.CurrentDirectory, "Saída");
    var di = new DirectoryInfo(path);

    if(!di.Exists)
        di.Create();
    
    path = Path.Combine(path, "usuarios.csv");

    var pessoas = new List<Pessoa>()
    {
        new Pessoa()
        {
            Nome = "José da Silva",
            Email = "js@email.com",
            Telefone = 21255855,
        },
        new Pessoa()
        {
            Nome = "Pedro Paiva",
            Email = "pp@email.com",
            Telefone = 36659874,
        },
        new Pessoa()
        {
            Nome = "Maria Gomes",
            Email = "mg@email.com",
            Telefone = 28547932,
        },
        new Pessoa()
        {
            Nome = "Carla de Moraes",
            Email = "cm@email.com",
            Telefone = 36058097,
        }
    };

    using var sr = new StreamWriter(path);
    using var csvWriter = new CsvWriter(sr, CultureInfo.InstalledUICulture)
    {
        Delimiter = " "
    };
    csvWriter.WriteRecords(pessoas);
}

static void LerCsvComOutroDelimitador()
{
    var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "Livros-precos-com-virgula.csv");
    var fi = new FileInfo(path);

    if(!fi.Exists)
        throw new FileNotFoundException($"O arquivo {path} não existe.");

    using var sr = new StreamReader(fi.FullName);
    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
    {
        Delimiter = ";"
    };
    using var csvReader = new CsvReader(sr, csvConfig);
    csvReader.Context.RegisterClassMap<Livro>();

    var registros = csvReader.GetRecords<Livro>().ToList();

    foreach (var registro in registros)
    {
        Console.WriteLine($"Título: {registro.Titulo}.");
        Console.WriteLine($"Preço: {registro.Preco}.");
        Console.WriteLine($"Autor: {registro.Autor}.");
        Console.WriteLine($"Lançamento: {registro.Lancamento}.");
        Console.WriteLine("-----------");
    }
}

// static void LerCsvComClasse()
// {
//     var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "novos-usuarios.csv");
//     var  fi = new FileInfo(path);

//     if(!fi.Exists)
//         throw new FileNotFoundException($"O arquivo {path} não existe.");
// }

// static void LerCsvComDynamic()
// {
//     var path = Path.Combine(Environment.CurrentDirectory, )
// }


// var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "Produtos.csv");

// var fi = new FileInfo(path);

// if(!fi.Exists)
//     throw new FileNotFoundException($"O arquivo {path} não existe.");

// using var sr = new StreamReader(fi.FullName);
// var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);
// var csvReader = new CsvReader(sr, csvConfig);

// var registros = csvReader.GetRecords<dynamic>();

// foreach(var registro in registros)
// {
//     Console.WriteLine($"nome:{registro.Produto}");
//     Console.WriteLine($"marca:{registro.Marca}");
//     Console.WriteLine($"preço:{registro.Preco}");
// }