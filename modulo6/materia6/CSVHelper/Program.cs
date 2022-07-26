using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper;

LerCsvComClasse();

Console.WriteLine("Digite ENTER para finalizar");
Console.ReadLine();

static void LerCsvComClasse()
{
    var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "novos-usuarios.csv");
    var  fi = new FileInfo(path);

    if(!fi.Exists)
        throw new FileNotFoundException($"O arquivo {path} não existe.");
}

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